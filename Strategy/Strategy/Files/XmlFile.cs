using Strategy.Interfaces;

namespace Strategy.Files
{
    public class XmlFile : IFileFactory
    {
        public void ReadFile()
        {
            Console.WriteLine("XML file readed");
        }

        public void SaveFile()
        {
            Console.WriteLine("XML file saved");
        }
    }
}
