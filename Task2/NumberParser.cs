using System;
using System.Collections.Generic;

namespace Task2
{
    public class NumberParser : INumberParser
    {
        public int Parse(string input)
        {
            if (input == null)
                throw new ArgumentNullException();

            if (string.IsNullOrWhiteSpace(input))
                throw new FormatException();

            input = input.Replace(" ", "");
            var len = input.Length;
            var set = new HashSet<char>();
            double number = 0;

            for (int i = 0; i < len; i++)
            {
                if (!IsNumber(set, input[i], i))
                    throw new FormatException();

                set.Add(input[i]);

                if (CheckCharacter(input[i]))
                    continue;

                number += Math.Pow(10, len - i - 1) * (int)char.GetNumericValue(input[i]);
            }

            number = input[0] == '-' ? -number : number;

            if (number > int.MaxValue || number < int.MinValue)
                throw new OverflowException();

            return (int)number;
        }

        private static bool IsNumber(HashSet<char> set, char ch, int index)
        {
            return ((set.Contains(ch) && CheckCharacter(ch))
                    || (!char.IsDigit(ch) && index != 0)
                    || (!char.IsDigit(ch) && !CheckCharacter(ch)));
        }

        private static bool CheckCharacter(char ch)
        {
            return ch == '+' || ch == '-';
        }
    }
}