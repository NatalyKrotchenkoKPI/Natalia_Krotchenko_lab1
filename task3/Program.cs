using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var output = input.Select((x, i) => ((i + 1) * x));
            var output1 = output.Where(x => x >= 10 && x <= 99);
            var output2 = output1.Reverse();
            Console.WriteLine("До виконання");

            foreach (int i in input)
                Console.WriteLine(i);

            Console.WriteLine("Добуток"); 

            foreach (int i in output)
                Console.WriteLine(i);

            Console.WriteLine("Видалення не двозначних елементів");
            foreach (int i in output1)
                Console.WriteLine(i);

            Console.WriteLine("Зворотній порядок");
            foreach (int i in output2)
                Console.WriteLine(i);

        }
    }
    
    }
    
