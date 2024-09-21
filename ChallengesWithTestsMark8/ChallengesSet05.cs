using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Transactions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }

            bool isDivisible = false;
            startNumber++;
            while (isDivisible == false)
            {
                if (startNumber % n == 0)
                {
                    isDivisible = true;
                }
                else
                {
                    startNumber++;
                }
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            {
                foreach (var business in businesses)
                {
                    if (business.TotalRevenue == 0d)
                    {
                        business.Name = "CLOSED";
                    }
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            var arrayLength = numbers.Length;

            if (arrayLength == 0)
            {
                return false;
            }

            for (int i = 1; i < arrayLength; i++)

                // Unsorted pair found
                if (numbers[i - 1] > numbers[i])
                    return false;

            // No unsorted pair found
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers is null)
            {
                return 0;
            }
            int total = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    total += numbers[i + 1];
                }
            }

            return total;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words is null || words.Length == 0)
            {
                return "";
            }

            var sentence = string.Empty;

            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }
            if (sentence == string.Empty)
            {
                return "";
            }
            sentence = sentence.Trim() + ".";

            return sentence;

        }

        //TODO: Get every fourth element
        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            { return Array.Empty<double>(); }

            if (elements.Count == 0 || elements.Count < 4)
            { return Array.Empty<double>(); }

            var everyFourthElementList = new List<double>();
            var counter = 0;
           
            for (int i = 0; i < elements.Count; i++)
            {
                counter++;
                if (counter == 4)
                {
                    everyFourthElementList.Add(elements[i]);
                    counter = 0;
                }      
                    
            }

            double[] everyFourthElementArray = everyFourthElementList.ToArray();
            return everyFourthElementArray;


        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                     { return true; }    
                }
            }
            return false;
        }
    }
}
