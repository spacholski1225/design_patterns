using Strategy.Interfaces;

namespace Strategy
{
    public class CustomFile
    {
        public CustomFile(IStrategy fileStrategy)
        {
            fileStrategy.CreateFile();
        }
    }
}
