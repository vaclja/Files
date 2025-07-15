using Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo programu ke spuštění");
            Console.WriteLine("1 - BasicCV.cs");
            Console.WriteLine("2 - FileNOtParse.cs");
            Console.WriteLine("3 - Files1.cs");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    A1FileStr.Run();
                    break;
                case "2":
                    FileNotParse.Run();
                    break;
                case "3":
                    Files1.Run();
                    break;
                default:
                    Console.WriteLine("Neplatná volba.");
                    break;
            }
        }
    }
}
