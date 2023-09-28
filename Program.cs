using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите путь к папке:");
            string Folder = Console.ReadLine();

            Console.WriteLine("Введите ключевое слово для поиска:");
            string WordSearch = Console.ReadLine();

            string[] files = Directory.GetFiles(Folder);

            Console.WriteLine("Результаты поиска:");

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);

                if (fileName.IndexOf(WordSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(fileName);
                }
            }

            Console.ReadLine();
        }
    }
}
