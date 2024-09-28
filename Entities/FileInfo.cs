

namespace DictionaryFix.Entities
{
    internal class CSVinfo
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public int Votes { get; set; }

        public CSVinfo() { }

        public CSVinfo(string path) 
        {
            Path = path;
        }        
    }
}
