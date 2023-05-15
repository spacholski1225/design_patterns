using Strategy.Interfaces;

namespace Strategy.Files
{
    public class CsvFile : IFileFactory
    {
        public void ReadFile()
        {
            Console.WriteLine("CSV file readed");
        }

        public void SaveFile()
        {
            Console.WriteLine("CSV file opened");
        }
    }
}
