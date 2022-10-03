using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanLibrary
{
    public class Problem
    {
        public Problem() { }
        public Problem(int firstInt, string operand, int secondInt, double answer)
        {
            FirstInt = firstInt;
            Operand = operand;
            SecondInt = secondInt;
            Answer = answer;
        }

        public int FirstInt { get; set; }
        public int SecondInt { get; set; }
        public string Operand { get; set; }
        public double Answer { get; set; }
    }
}
