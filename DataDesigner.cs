using CsvHelper;

namespace ManagingANewspaper
{
    public class DataDesigner
    {
        public readonly List<Designer> _Designers;
        public DataDesigner()
        {
            _Designers = new List<Designer>();
            using (var reader = StreamReader("D:\\אחיותי היקרות\\תמי\\תכנות תמי\\.NET\\NewsPaper\\designers.csv")) 
            using (var csv=new CsvReader(reader, CultureInFo.InvariantCulture))
            {
                _Designers=csv.GetRecords<Designer>().ToList();
            }
        }
    }
}
