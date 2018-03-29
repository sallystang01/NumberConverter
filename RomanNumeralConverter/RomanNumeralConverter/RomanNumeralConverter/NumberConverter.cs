using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{
    class NumberConverter
    {
        public static Dictionary<char, int> RomanMap = new Dictionary<char, int>()

    {
        {'I', 1}, // I = 1
        {'V', 5}, // V = 5
        {'X', 10}, // X = 10
        {'L', 50}, // L = 50
        {'C', 100}, // C = 100
        {'D', 500}, // D = 500
        {'M', 1000} // M = 1000
    };

        public static int RomanToInteger(string roman)
        {
            int number = 0; //Starting Number is 0
            for (int i = 0; i < roman.Length; i++) //Looks at the length of the string, increments i variable by 1
            {
                if (i + 1 < roman.Length && RomanMap[roman[i]] < RomanMap[roman[i + 1]]) // if length of numeral falls in these parameters
                {
                    number -= RomanMap[roman[i]]; // Subtract from the number variable
                }
                else
                {
                    number += RomanMap[roman[i]]; // Add to the number variable
                }
            }
            return number;
        }
    }
}
