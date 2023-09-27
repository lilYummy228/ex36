using System;
using System.Collections.Generic;

namespace ex36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstNumbersRange = { "1", "2", "1" };
            string[] secondNumbersRange = { "3", "2" };

            List<string> attachment = new List<string>();

            AddNonRepeatedNumber(attachment, firstNumbersRange.Length, firstNumbersRange);
            AddNonRepeatedNumber(attachment, secondNumbersRange.Length, secondNumbersRange);

            foreach (var number in attachment)
            {
                Console.WriteLine(number);
            }
        }

        static void AddNonRepeatedNumber(List<string> attachment, int numbersRangeLength, string[] numbersRange)
        {
            for (int i = 0; i < numbersRangeLength; i++)
            {
                if (attachment.Contains(numbersRange[i]) == false)
                {
                    attachment.Add(numbersRange[i]);
                }
            }
        }
    }
}
