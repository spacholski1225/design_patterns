using Strategy.Interfaces;

namespace Strategy.Files
{
    public class CsvFileStrategy : IStrategy
    {
        public void CreateFile()
        {
            Console.WriteLine("Created CSV file.");
        }
    }
}
