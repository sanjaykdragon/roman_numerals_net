using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace roman_numerals_net
{
    class Program
    {
        private static int from_roman(char curr, char next)
        {
            switch (curr)
            {
                case 'I':
                    if (next != ' ' && next != 'I')
                        return -1; //so that we are 1 less than the 2nd number
                    else
                        return 1;
                    break;
                case 'V':
                    return 5;
                    break;
                case 'X':
                    return 10;
                    break;
                case 'L':
                    return 50;
                    break;
                case 'C':
                    return 100;
                    break;
            }

            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a roman numeral:");
            string roman_num = Console.ReadLine();

            int total_value = 0; //this is int this time so we can do -1 and not mess stuff up severely
            for (uint i = 0; i < roman_num.Length; i++)
            {
                char curr_char = roman_num.ToCharArray()[i];
                char next_char = (i == roman_num.Length - 1) ? ' ' : roman_num.ToCharArray()[i + 1]; //won't let me use null, need to use ' '

                total_value += from_roman(curr_char, next_char);
            }

            Console.WriteLine("Value of entered number is {0}", total_value);
            Console.ReadKey();
        }
    }
}
