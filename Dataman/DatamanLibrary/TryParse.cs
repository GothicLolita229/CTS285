using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanLibrary
{
    public static class TryParse
    {
        public static int ParseInt(string input)
        {
            int number;
            int.TryParse(input, out number);
            return number;
        }
        public static double ParseDouble(string input)
        {
            double number;
            double.TryParse(input, out number);
            return number;
        }
    }
}
