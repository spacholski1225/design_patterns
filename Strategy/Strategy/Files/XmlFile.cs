using Strategy.Interfaces;

namespace Strategy.Files
{
    public class XmlFile : IFileStrategy
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
