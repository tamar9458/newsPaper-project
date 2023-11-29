namespace ManagingANewspaper
{
    public class DataWriter
    {
        public readonly List<Writer> _Writers;
        public DataDesigner()
        {
            _Writers = new List<Writer>();
            using (var reader = StreamReader("D:\\אחיותי היקרות\\תמי\\תכנות תמי\\.NET\\NewsPaper\\writers.csv"))
            using (var csv = new CsvReader(reader, CultureInFo.InvariantCulture))
            {
                _Writers = csv.GetRecords<Writer>().ToList();
            }
        }
    }
}
