using Strategy.Interfaces;

namespace Strategy.Files
{
    public class JsonFileStrategy : IStrategy
    {
        public void CreateFile()
        {
            Console.WriteLine("Created new JSON file.");
        }
    }
}
