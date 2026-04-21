using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Starbuko
{
    public class ProductRepository
    {
        public List<Product> GetAllActiveProducts()
        {
            List<Product> products = new List<Product>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT id, name, price, image_path, is_active FROM products WHERE is_active = 1";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Price = reader.GetDecimal("price"),
                            ImagePath = reader.IsDBNull(reader.GetOrdinal("image_path"))
                                ? ""
                                : reader.GetString("image_path"),
                            IsActive = reader.GetBoolean("is_active")
                        });
                    }
                }
            }

            return products;
        }

        //get ALL products (for admin/manage screen)
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT id, name, price, image_path, is_active FROM products ORDER BY id DESC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Price = reader.GetDecimal("price"),
                            ImagePath = reader.IsDBNull(reader.GetOrdinal("image_path"))
                                ? ""
                                : reader.GetString("image_path"),
                            IsActive = reader.GetBoolean("is_active")
                        });
                    }
                }
            }

            return products;
        }

        public void AddProduct(Product product)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO products (name, price, image_path, is_active)
                    VALUES (@name, @price, @imagePath, @isActive)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", product.Name);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@imagePath", product.ImagePath);
                    cmd.Parameters.AddWithValue("@isActive", product.IsActive);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE products
                    SET name = @name,
                        price = @price,
                        image_path = @imagePath,
                        is_active = @isActive
                    WHERE id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", product.Id);
                    cmd.Parameters.AddWithValue("@name", product.Name);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@imagePath", product.ImagePath);
                    cmd.Parameters.AddWithValue("@isActive", product.IsActive);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}