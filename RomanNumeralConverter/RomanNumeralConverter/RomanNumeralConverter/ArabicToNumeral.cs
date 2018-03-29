using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{

    class ArabicToNumeral
    {

        // Map digits to letters.
        public static string[] ThouLetters = { "", "M", "MM", "MMM" };
        public static string[] HundLetters =
            { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        public static string[] TensLetters =
            { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        public static string[] OnesLetters =
            { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };


        // Convert Roman numerals to an integer.
        public static string ArabicToRoman(int arabic)
        {
            try
            {
                // See if it's >= 4000.
                if (arabic >= 4000)
                {
                    // Use parentheses.
                    int thou = arabic / 1000;
                    arabic %= 1000;
                    return "(" + ArabicToRoman(thou) + ")" +
                        ArabicToRoman(arabic);
                }

                // Otherwise process the letters.
                string result = "";

                // Pull out thousands.
                int num;
                num = arabic / 1000;
                result += ThouLetters[num];
                arabic %= 1000;

                // Handle hundreds.
                num = arabic / 100;
                result += HundLetters[num];
                arabic %= 100;

                // Handle tens.
                num = arabic / 10;
                result += TensLetters[num];
                arabic %= 10;

                // Handle ones.
                result += OnesLetters[arabic];

                return result;

               

            }

            catch (Exception ex)
            {
                throw (ex);
            }
      }
    


    }

}
