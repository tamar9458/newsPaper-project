namespace Shop
{
    public class Product
    {
        static int num = 0;
        public int Id { get; set; } = num++;
        public string Name { get; set; }
        public float Price { get; set; }
        public Product()
        {
        }
        public Product(string name,float price)
        {
            Name = name;
            Price = price;

        }
    }
}
