using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanLibrary
{
    public class DatamanLogic
    {
        public static void CheckProblem(string userProblem)
        {
            
            string[] tokens = userProblem.Split(' ');
            int firstNum = TryParse.ParseInt(tokens[0]);
            string operand = tokens[1];
            int secondNum = TryParse.ParseInt(tokens[2]);
            double userAnswer = TryParse.ParseDouble(tokens[4]);
            double correctAnswer;
            //int remainder;


            Problem problem = new Problem(firstNum, operand, secondNum, userAnswer);

            switch (operand)
            {
                case "+":
                    correctAnswer = firstNum + secondNum;
                    Console.WriteLine($"Your problem is {firstNum} + {secondNum} = {userAnswer}");
                    if (userAnswer == correctAnswer)
                    { Console.WriteLine("Your answer is correct!"); }
                    else 
                    { 
                        Console.WriteLine("Your answer is incorrect.");
                        Console.WriteLine($"The correct answer is {correctAnswer}");
                    }
                    Console.ReadKey();
                    break;
                case "-":
                    correctAnswer = firstNum - secondNum;
                    Console.WriteLine($"Your problem is {firstNum} - {secondNum} = {userAnswer}");
                    if (userAnswer == correctAnswer)
                    { Console.WriteLine("Your answer is correct!"); }
                    else 
                    {
                        Console.WriteLine("Your answer is incorrect.");
                        Console.WriteLine($"The correct answer is {correctAnswer}");
                    }
                    break;
                case "/":
                    int remainder;
                    correctAnswer = firstNum / secondNum;
                    Console.WriteLine($"Your problem is {firstNum} / {secondNum} = {userAnswer}");
                    int correctAnswer2 = Math.DivRem(firstNum, secondNum, out remainder);
                    // https://www.geeksforgeeks.org/c-sharp-math-divrem-method/
                    if (userAnswer == correctAnswer)
                    { Console.WriteLine("Your answer is correct!");
                        Console.WriteLine($"Correct answer with remainder is {correctAnswer2} R {remainder}");
                    }
                    else 
                    {   
                        Console.WriteLine("Your answer is incorrect.");
                        Console.WriteLine($"The correct answer is {correctAnswer2} R {remainder}");
                    }
                    break;
                case "*":
                    correctAnswer = firstNum * secondNum;
                    Console.WriteLine($"Your problem is {firstNum} * {secondNum} = {userAnswer}");
                    if (userAnswer == correctAnswer)
                    { Console.WriteLine("Your answer is correct!"); }
                    else 
                    {   
                        Console.WriteLine("Your answer is incorrect.");
                        Console.WriteLine($"The correct answer is {correctAnswer}");
                    }
                    break;

            }

        }

        
    }
}
