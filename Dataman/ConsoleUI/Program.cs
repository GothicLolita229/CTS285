using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInstructions.MainMenuDisplay();

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "Z":
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
        }
    }
}
