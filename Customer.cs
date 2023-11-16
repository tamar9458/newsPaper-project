namespace Shop
{
    public class Customer
    {
        static int num = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pon { get; set; }
        public string Adress { get; set; }
        public Customer()
        {
            Id = num++;
        }
        public Customer(string name,string pon ,string ad)
        {
            Id = num++;
            Name = name;
            Pon = pon;
            Adress = ad;
        }
    }
}
