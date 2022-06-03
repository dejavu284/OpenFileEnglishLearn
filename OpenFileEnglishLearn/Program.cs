using System;
using System.IO;

namespace OpenFileEnglishLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Them: Databases\n\n");
                string FilePath = "C:/Users/Я/Desktop/текст по английскому учить.txt";
                StreamReader streamReader = new StreamReader(FilePath);
                string AllFile = streamReader.ReadToEnd();
                string[] EachLine = AllFile.Split("..");
                int IndexLine = 0;
                while (IndexLine < EachLine.Length-1)
                {
                    Console.WriteLine(EachLine[IndexLine]);
                    Console.WriteLine("\n{0} - Строк осталось", EachLine.Length - IndexLine - 2);
                    Console.ReadKey(true);
                    IndexLine++;
                }
                Console.WriteLine("\n\n\n\n");
                Console.ReadKey(true);
            }
        }
    }
}
