namespace ManagingANewspaper
{
    public class DataEditors
    {
        public readonly List<Designer> _Editors;
        public DataDesigner()
        {
            _Editors = new List<Editor>();
            using (var reader = StreamReader("D:\\אחיותי היקרות\\תמי\\תכנות תמי\\.NET\\NewsPaper\\editors.csv"))
            using (var csv = new CsvReader(reader, CultureInFo.InvariantCulture))
            {
                _Editors = csv.GetRecords<Editor>().ToList();
            }
        }
    }
}
