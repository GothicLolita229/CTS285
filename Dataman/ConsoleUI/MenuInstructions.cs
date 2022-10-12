using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class MenuInstructions
    {
        public static void MainMenuDisplay()
        {
            Console.WriteLine("Dataman Main Menu");
            Console.WriteLine("1. Answer Checker");
            Console.WriteLine("2. Memory Bank");
            Console.WriteLine("Press Z to exit");
        }

        public static void AnswerCheckerOption()
        {
            
            Console.WriteLine("Your format should be (int operand int = answer)");
            Console.WriteLine("+ , - , / , or * ");
            Console.WriteLine("Example: 4 * 4 = 16");
            Console.Write("Please enter a math problem > ");
        }

        public static void MemoryBankOption()
        {
            Console.WriteLine("A. Store Problems");
            Console.WriteLine("B. Solve Memory Bank problems");
            Console.WriteLine("C. Clear Memory Bank");
            Console.WriteLine("D. Back to Main");
        }
    }
}
