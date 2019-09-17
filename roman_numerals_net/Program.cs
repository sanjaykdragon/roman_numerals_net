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
                    return (next != ' ' && next != 'I') ? -1 : 1; //cool
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
            int string_size = roman_num.Length;
            for (uint i = 0; i < string_size; i++)
            {
                char[] char_array = roman_num.ToCharArray();

                char curr_char = char_array[i];
                char next_char = (i == string_size - 1) ? ' ' : char_array[i + 1]; //won't let me use null, need to use ' '

                total_value += from_roman(curr_char, next_char);
            }

            Console.WriteLine("Value of entered number is {0}", total_value);
            Console.ReadKey();
        }
    }
}
