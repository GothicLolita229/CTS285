using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DatamanLibrary;
namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userChoice = "";
            do
            {
                MenuInstructions.MainMenuDisplay();
                userChoice = Console.ReadLine();
                switch (userChoice.ToLower())
                {
                    case "1":
                        MenuInstructions.AnswerCheckerOption();
                        string userProblem = Console.ReadLine();
                        DatamanLogic.CheckProblem(userProblem);
                        Console.ReadKey();
                        break;
                    case "2":

                        break;
                    case "z":
                        Console.WriteLine("Goodbye");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }
                
            } while(userChoice != "z");

        }
    }
}
