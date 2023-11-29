using System.Diagnostics.Metrics;

namespace ManagingANewspaper
{
    public enum TypeEditor { CONTENT,LITERARY,TORANY,GENERAL}
    public class Editor:Worker
    {

        static int num = 0;
        public int Id { get; set; }

        public TypeEditor TEditor {  get; set; }   
        public Editor()
        {
            Id = num++;
        }
        public Editor(TypeEditor tEditor,string name, string phone, string ad, float salary=0, int priority = 0) : base(name, phone, ad, salary, priority)
        {
            Id = num++;
            TEditor= tEditor;
        }
    }
}
