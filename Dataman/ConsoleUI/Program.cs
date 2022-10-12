using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DatamanLibrary;

/*
 *Lourdes Linares 
 *10.3.2022
 *Dataman Project
 */
namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Problem> memoryBankProblems = new List<Problem>();
            string userChoice = "";
            string userProblem;
            do
            {
                MenuInstructions.MainMenuDisplay();
                userChoice = Console.ReadLine();
                switch (userChoice.ToLower())
                {
                    case "1":
                        MenuInstructions.AnswerCheckerOption();
                        userProblem = Console.ReadLine();
                        DatamanLogic.CheckProblem(userProblem);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Memory Bank is pending....");
                        MenuInstructions.MemoryBankOption();
                        string mbchoice = Console.ReadLine();
                        switch (mbchoice.ToLower())
                        {
                            case "a":
                                //Input problems into Memory Bank
                                Console.Write("How many problems (up to 10) would you like to input to Memory Bank? ");
                                int numOfProbs = TryParse.ParseInt(Console.ReadLine());
                                MenuInstructions.AnswerCheckerOption();
                                for(int i = 1; i <= numOfProbs && i <= 10; i++)
                                {
                                    Console.Write($"Enter problem #{i} =>");
                                    userProblem = Console.ReadLine();
                                    memoryBankProblems = DatamanLogic.MemoryBank(userProblem, memoryBankProblems);
                                }
                                break;
                            case "b":
                                //Solve problems from Memory Bank
                                //Logic.memoryBankSolve(memoryBankProblems);
                                break;
                            case "c":
                                //Clear Memory Bank
                                //DatamanLogic.MemoryBankProblems.Clear();
                                break;
                            case "d":
                                Console.WriteLine("Going back to Main...");
                                break;
                            default:
                                Console.WriteLine("Please enter either A, B, or C");
                                break;
                        }
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
