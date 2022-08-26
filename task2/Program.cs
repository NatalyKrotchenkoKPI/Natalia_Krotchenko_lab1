using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(1, "One");
            dict1.Add(2, "Two");
            dict1.Add(3, "Three");
            Console.WriteLine("Перший словник ");
            foreach (var person in dict1)
            {
                Console.WriteLine($"key: {person.Key}  value: {person.Value}");
            }
          
            Console.WriteLine("-----------------------------------");
            List<string> list = new List<string>() { "Tom", "Bob", "Sam" };
            Console.WriteLine("Список");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            Dictionary<string, string> dict2 = list.ToDictionary(x => x, x => x);
            dict2["Tom"] = dict1[1];
            dict2["Bob"] = dict1[2];
            dict2["Sam"] = dict1[3];

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Результат ");
            foreach (var person in dict2)
            {
                Console.WriteLine($"key: {person.Key}  value: {person.Value}");
            }
            //Console.WriteLine(String.Join(Environment.NewLine, dict2));
            Console.WriteLine();
            string jsonString = JsonSerializer.Serialize(dict2);

            Console.WriteLine(jsonString);

        }
    }

}
