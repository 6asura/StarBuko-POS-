using System;

namespace Starbuko
{
    public class Transaction
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public decimal TotalAmount { get; set; }
    }
}