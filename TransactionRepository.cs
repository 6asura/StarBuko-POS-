using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace Starbuko
{
    public class TransactionRepository
    {
        public int SaveTransaction(int userId, decimal totalAmount, decimal amountTendered, decimal changeAmount, List<LineItem> items)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                using (var dbTransaction = conn.BeginTransaction())
                {
                    try
                    {
                        string transactionQuery = @"
                            INSERT INTO transactions (user_id, total_amount, amount_tendered, change_amount)
                            VALUES (@userId, @totalAmount, @amountTendered, @changeAmount);
                            SELECT LAST_INSERT_ID();";

                        int transactionId;

                        using (var cmd = new MySqlCommand(transactionQuery, conn, dbTransaction))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                            cmd.Parameters.AddWithValue("@amountTendered", amountTendered);
                            cmd.Parameters.AddWithValue("@changeAmount", changeAmount);

                            transactionId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string itemQuery = @"
                            INSERT INTO transaction_items
                            (transaction_id, product_id, product_name, cup_size, quantity, unit_price, total_price)
                            VALUES
                            (@transactionId, @productId, @productName, @cupSize, @quantity, @unitPrice, @totalPrice)";

                        foreach (var item in items)
                        {
                            using (var cmd = new MySqlCommand(itemQuery, conn, dbTransaction))
                            {
                                cmd.Parameters.AddWithValue("@transactionId", transactionId);
                                cmd.Parameters.AddWithValue("@productId", item.ProductId);
                                cmd.Parameters.AddWithValue("@productName", item.ProductName);
                                cmd.Parameters.AddWithValue("@cupSize", item.CupSize);
                                cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                                cmd.Parameters.AddWithValue("@unitPrice", item.UnitPrice);
                                cmd.Parameters.AddWithValue("@totalPrice", item.TotalPrice);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        dbTransaction.Commit();
                        return transactionId;
                    }
                    catch
                    {
                        dbTransaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public List<Transaction> GetAllTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT id, created_at, total_amount
                    FROM transactions
                    ORDER BY id DESC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(new Transaction
                        {
                            Id = reader.GetInt32("id"),
                            CreatedAt = reader.GetDateTime("created_at"),
                            TotalAmount = reader.GetDecimal("total_amount")
                        });
                    }
                }
            }

            return transactions;
        }
    }
}