using System;
using System.Collections.Generic;
using CarNumberExtractorHelper;

namespace ExtractCarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> carNumbers = new List<string>();
            string inputCarNumbers = string.Empty;
            Console.WriteLine("Enter Car numbers:");
            inputCarNumbers = Console.ReadLine();
            // inputCarNumbers="WB09J3487WB89BB4573";
            carNumbers = CarNumberExtractor.NumberExtractorRegEx(inputCarNumbers);
            foreach (var r in carNumbers)
            {
                Console.WriteLine(r);
            }


        }
    }
}
