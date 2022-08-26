using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Galaxy> theGalaxies = new List<Galaxy>()
        {
        new Galaxy() {Name1 = "Krotchenko", Name2 = "Natalia", Name3 = "Vadimivna", Year = 2004, Kyrs = 1, Group = "IK-12", Metodu = 1, Proga = 2, English = 2, Ukr = 3, Hist = 3 },
        new Galaxy() {Name1 = "Smith", Name2 = "Olivia", Name3 = "Ihorivna", Year = 2003, Kyrs = 2, Group = "IK-13", Metodu = 2, Proga = 4, English = 4, Ukr = 3, Hist = 3 },
        new Galaxy() {Name1 = "Brown", Name2 = "Amelia", Name3 = "Serhiivna", Year = 2005, Kyrs = 1, Group = "IK-12", Metodu = 3, Proga = 3, English = 3, Ukr = 5, Hist = 5 },
        new Galaxy() {Name1 = "King", Name2 = "Lily", Name3 = "Stepanivna", Year = 2004, Kyrs = 2, Group = "IK-13", Metodu = 4, Proga = 2, English = 4, Ukr = 3, Hist = 2 },
        new Galaxy() {Name1 = "Evans", Name2 = "Joseph", Name3 = "Aleksandrovich", Year = 2003, Kyrs = 3, Group = "IK-12", Metodu = 1, Proga = 1, English = 2, Ukr = 3, Hist = 5 },
        new Galaxy() {Name1 = "Johnson", Name2 = "Boris", Name3 = "Aleksandrovich", Year = 2005, Kyrs = 1, Group = "IK-13", Metodu = 2, Proga = 2, English = 2, Ukr = 1, Hist = 1 },
        new Galaxy() {Name1 = "Makron", Name2 = "Emanuel", Name3 = "Frederick", Year = 2004, Kyrs = 2, Group = "IK-12", Metodu = 5, Proga = 4, English = 5, Ukr = 5, Hist = 5 },
        new Galaxy() {Name1 = "Scholz", Name2 = "Olaf", Name3 = "Mercelevich", Year = 2004, Kyrs = 3, Group = "IK-13", Metodu = 4, Proga = 5, English = 5, Ukr = 5, Hist = 5 },
        new Galaxy() {Name1 = "Duda", Name2 = "Andrzej", Name3 = "Sebastianovich", Year = 2003, Kyrs = 3, Group = "IK-12", Metodu = 5, Proga = 5, English = 4, Ukr = 5, Hist = 5 }
            };
            Console.WriteLine("\nBefore sort:");
            Console.WriteLine();
            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine("Прiзвище: " + theGalaxy.Name1 + " " + "Iм'я: " + theGalaxy.Name2 + " " + "Рiк народження: " + theGalaxy.Year + " " + "Курс: " + theGalaxy.Kyrs + " " + " Група: " + theGalaxy.Group + " " + "Чисельнi Методи: " + theGalaxy.Metodu + " " + "Програмування: " + theGalaxy.Proga + " " + "Англiйська: " + theGalaxy.English + " " + "Українська: " + theGalaxy.Ukr + " " + "Iсторiя: " + theGalaxy.Hist);
                Console.WriteLine();
            }
            Console.WriteLine("\nAfter sort by Kyrs:");
            var sorted = theGalaxies.OrderBy(c => c.Kyrs).ThenBy(c => c.Name1);
           foreach (Galaxy user in sorted)
                Console.WriteLine(user.Name1 + " " + user.Name2 + " " + user.Kyrs + " курс");
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------");

            var group1 = from p in theGalaxies
                                 where p.Group == "IK-12"
                                 select p;
            var y = group1.Select(x => x.Metodu).Average();
            var y1 = group1.Select(x => x.Proga).Average();
            var y3 = group1.Select(x => x.English).Average();
            var y4 = group1.Select(x => x.Ukr).Average();
            var y5 = group1.Select(x => x.Hist).Average();

            Console.WriteLine("Середнiй бал групи по предметах: ");
            Console.WriteLine();
            Console.WriteLine("Група IК-12 " + "Metodu " + y + ";  Proga " + y1 + ";  English " + y3 + ";  Ukr " + y4 + ";  Hist " + y5);
            Console.WriteLine();



            var group2 = from p in theGalaxies
                         where p.Group == "IK-13"
                         select p;
            var k = group2.Select(x => x.Metodu).Average();
            var k1 = group2.Select(x => x.Proga).Average();
            var k3 = group2.Select(x => x.English).Average();
            var k4 = group2.Select(x => x.Ukr).Average();
            var k5 = group2.Select(x => x.Hist).Average();
            Console.WriteLine("Група IК-13 " + "Metodu " + k + ";  Proga " + k1 + ";  English " + k3 + ";  Ukr " + k4 + ";  Hist " + k5);

            var min = theGalaxies.Select(x => x.Year).Min();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Найстаршi студенти: ");

            foreach (Galaxy user in theGalaxies)
            {
                if (user.Year == min)
                {
                    Console.WriteLine(user.Name1 + " " + user.Name2 + " " + user.Year);
                }
            }

         
        var max = theGalaxies.Select(x => x.Year).Max();

            Console.WriteLine();
            Console.WriteLine("Наймолодшi студенти: ");

            foreach (Galaxy user in theGalaxies)
            {
                if (user.Year == max)
                {
                    Console.WriteLine(user.Name1 + " " + user.Name2 + " " + user.Year);
                }
            }

            var smart = from p in theGalaxies
                         where p.Group == "IK-13"
                         select p;
            var s = smart.Select(x => x.Metodu + x.Proga + x.Ukr + x.Hist + x.English).Max();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Найуспiшнiшi студенти групи IК-13: ");
            foreach (Galaxy user in smart)
            {
                if (user.Metodu + user.Hist + user.Proga + user.Ukr + user.English == s)
                {
                    Console.WriteLine(user.Name1 + " " + user.Name2 + " середнiй бал: " + s/5);
                }
            }


            var smart1 = from p in theGalaxies
                        where p.Group == "IK-12"
                        select p;
            var s1 = smart.Select(x => x.Metodu + x.Proga + x.Ukr + x.Hist + x.English).Max();
            Console.WriteLine();
            Console.WriteLine("Найуспiшнiшi студенти групи IК-12: ");
            foreach (Galaxy user in smart1)
            {
                if (user.Metodu + user.Hist + user.Proga + user.Ukr + user.English == s)
                {
                    Console.WriteLine(user.Name1 + " " + user.Name2 + " середнiй бал: " + s1 / 5);
                }
            }
            Console.WriteLine();
        }
         }

    }
public class Galaxy
{
    public string Name1 { get; set; }
    public string Name2 { get; set; }
    public string Name3 { get; set; }
    public string Group { get; set; }

    public int Year { get; set; }
    public int Kyrs { get; set; }
    public int Metodu { get; set; }
    public int Proga { get; set; }
    public int English { get; set; }
    public int Ukr { get; set; }
    public int Hist { get; set; }
}





