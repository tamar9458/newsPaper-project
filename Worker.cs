namespace ManagingANewspaper
{
    public class Worker
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public float Salary { get; set; } = 0;
        public int Priority { get; set; }
        public Worker()
        {
            
        }
        public Worker(string name, string phone, string address, float salary,int priority)
        {
           
            Name = name;
            Phone = pon;
            Adress = address;
            Salary = salary;
            Priority=priority;
        }
    }
}
