namespace Starbuko
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public bool IsActive { get; set; }

        public Product() { }

        public Product(int id, string name, decimal price, string imagePath, bool isActive)
        {
            Id = id;
            Name = name;
            Price = price;
            ImagePath = imagePath;
            IsActive = isActive;
        }

        public Product(string name, decimal price, string imagePath)
        {
            Name = name;
            Price = price;
            ImagePath = imagePath;
            IsActive = true;
        }
    }
}