using System;
using System.IO;
using System.Text;


namespace Readling_Writing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desktopPath =Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath,"output.text");
            File.WriteAllText(filePath,"\n Привет этот текст добавится в файле\n")
            string[] lines = File.ReadAllLines("output.text");
            Console.WriteLine("Содержимое файла:\n");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}