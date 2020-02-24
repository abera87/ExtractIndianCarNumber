using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CarNumberExtractorHelper
{
    public class CarNumberExtractor
    {
        public static List<string> NumberExtractor(string carNumbers)
        {
            List<string> numbers = new List<string>();
            carNumbers = carNumbers.Replace(" ", "");
            int position = 0;
            do
            {
                //check 6th position charecter is numeric or not
                if (int.TryParse(carNumbers[position + 5].ToString(), out _))
                {
                    numbers.Add(carNumbers.Substring(position, 9));
                    position += 9;
                }
                else
                {
                    numbers.Add(carNumbers.Substring(position, 10));
                    position += 10;
                }

            } while (position < carNumbers.Length);
            return numbers;
        }
        public static List<string> NumberExtractorRegEx(string carNumbers)
        {
            string pattern = @"([a-zA-Z][a-zA-Z]\d\d[a-zA-Z]{1,2}\d\d\d\d)";
            List<string> numbers = new List<string>();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(carNumbers);
            foreach (var r in matches)
            {                
                numbers.Add(r.ToString());
            }
            return numbers;
        }
    }
}