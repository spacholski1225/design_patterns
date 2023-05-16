using Strategy.Interfaces;

namespace Strategy.Files
{
    public class XmlFileStrategy : IStrategy
    {
        public void CreateFile()
        {
            Console.WriteLine("Created new XML file.");
        }
    }
}
