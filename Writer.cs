using System;

namespace ManagingANewspaper
{
    public enum TypeWriter { CHILDREN=1,TEEN,ADULT};
    public class Writer:Worker
    {

        static int num = 0;
        public int Id { get; set; }
        public TypeWriter TWriter { get; set; } = TypeWriter.child;
        public Writer()
        {
            Id = num++;
        }
    
        public Writer(TypeWriter typeWriter,string name, string phone, string ad, float salary=0, int vetek = 0 ) :base(name, phone, ad,salary, vetek)
        {
            Id = num++;
            TWriter = typeWriter;
        }
    }
}
