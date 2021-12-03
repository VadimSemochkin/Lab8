using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs/Log.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            StreamWriter a = new StreamWriter(path);
            double[] array = new double[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0,100);
                
                a.Write(array[i] + " ");
            }
            a.Close();
            using (StreamReader sr = new StreamReader(path))
            {
                Console.Write(sr.ReadLine());
            }
            Console.WriteLine();
            double sum=0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Сумма равна {0}", sum);

            Console.ReadKey();
        }
    }
}
