using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanLibrary
{
    public class Problem
    {
        public Problem(int firstInt, int secondInt, char mapping, int answer)
        {
            FirstInt = firstInt;
            SecondInt = secondInt;
            Mapping = mapping;
            Answer = answer;
        }

        public int FirstInt { get; set; }
        public int SecondInt { get; set; }
        public char Mapping { get; set; }
        public int Answer { get; set; }
    }
}
