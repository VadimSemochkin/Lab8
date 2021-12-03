using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "G:/books";
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine("Список каталогов: ");
            foreach (var thing in dir.GetDirectories())
            {
                Console.WriteLine(thing.Name);
                Console.WriteLine("Список подкаталогов: ");
                foreach (var item in thing.GetDirectories())
               
                    Console.WriteLine(item.Name);
                Console.WriteLine();
               
            }
            Console.WriteLine("Список файлов: ");
            foreach (var item in dir.GetFiles())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }
    }
}
