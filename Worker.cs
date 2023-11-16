using System;

namespace Shop
{
    public class Worker
    {
        static int num = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pon{ get; set; }
        public string Adress { get; set; }
        public float Salary { get; set; } = 0;
        public Worker()
        {
            Id = num++;
        }
        public Worker(string name, string pon, string ad)
        {
            Id = num++;
            Name = name;
            Pon = pon;
            Adress = ad;
        }
    }
}
