﻿using Strategy.Interfaces;

namespace Strategy.Files
{
    public class JsonFile : IFileFactory
    {
        public void ReadFile()
        {
            Console.WriteLine("JSON file readed");
        }

        public void SaveFile()
        {
            Console.WriteLine("JSON file saved");
        }
    }
}
