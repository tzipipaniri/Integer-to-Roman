using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Roman
{
    internal class Program
    {
        //        Seven different symbols represent Roman numerals with the following values:

        //Symbol Value
        //I	1
        //V	5
        //X	10
        //L	50
        //C	100
        //D	500
        //M	1000
        //Roman numerals are formed by appending the conversions of decimal place values from highest to lowest.Converting a decimal place value into a Roman numeral has the following rules:

        //If the value does not start with 4 or 9, select the symbol of the maximal value that can be subtracted from the input, append that symbol to the result, subtract its value, and convert the remainder to a Roman numeral.
        //If the value starts with 4 or 9 use the subtractive form representing one symbol subtracted from the following symbol, for example, 4 is 1 (I) less than 5 (V): IV and 9 is 1 (I) less than 10 (X): IX.Only the following subtractive forms are used: 4 (IV), 9 (IX), 40 (XL), 90 (XC), 400 (CD) and 900 (CM).
        //Only powers of 10 (I, X, C, M) can be appended consecutively at most 3 times to represent multiples of 10. You cannot append 5 (V), 50 (L), or 500 (D) multiple times.If you need to append a symbol 4 times use the subtractive form.
        //Given an integer, convert it to a Roman numeral.




        //Example 1:

        //Input: num = 3749

        //Output: "MMMDCCXLIX"

        //Explanation:

        //3000 = MMM as 1000 (M) + 1000 (M) + 1000 (M)
        // 700 = DCC as 500 (D) + 100 (C) + 100 (C)
        //  40 = XL as 10 (X) less of 50 (L)
        //   9 = IX as 1 (I) less of 10 (X)
        //Note: 49 is not 1 (I) less of 50 (L) because the conversion is based on decimal places
        //Example 2:

        //Input: num = 58

        //Output: "LVIII"

        //Explanation:

        //50 = L
        // 8 = VIII
        //Example 3:

        //Input: num = 1994

        //Output: "MCMXCIV"

        //Explanation:

        //1000 = M
        // 900 = CM
        //  90 = XC
        //   4 = IV


        //Constraints:

        //1 <= num <= 3999
        public class Solution
        {
            public string IntToRoman(int num)
            {
                string s = "";
                int mul = 1;
                while (num > 0)
                {
                    int d = num % 10;
                    int n = d * mul;
                    mul *= 10;
                    if (d == 4 || d == 9)
                    {
                        switch (n)
                        {
                            case 4:
                                s = "IV" + s;
                                break;
                            case 40:
                                s = "XL" + s;
                                break;
                            case 400:
                                s = "CD" + s;
                                break;
                            case 9:
                                s = "IX" + s;
                                break;
                            case 90:
                                s = "XC" + s;
                                break;
                            case 900:
                                s = "CM" + s;
                                break;
                        }
                    }
                    else
                    {
                        string str = "";
                        while (n > 0)
                        {
                            if (n >= 1000)
                            {
                                str += "M";
                                n -= 1000;
                                continue;
                            }

                            if (n >= 500)
                            {

                                str += "D";
                                n -= 500;
                                continue;
                            }
                            if (n >= 100)
                            {

                                str += "C";
                                n -= 100;
                                continue;
                            }
                            if (n >= 50)
                            {

                                str += "L";
                                n -= 50;
                                continue;
                            }
                            if (n >= 10)
                            {

                                str += "X";
                                n -= 10;
                                continue;
                            }
                            if (n >= 5)
                            {

                                str += "V";
                                n -= 5;
                                continue;
                            }
                            if (n >= 1)
                            {

                                str += "I";
                                n -= 1;
                                continue;
                            }
                        }
                        s = str + s;
                    }
                    num /= 10;
                }
                return s;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
