using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Versioning;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Length == 0)
            {
                return false;
            }
            for (int i = 0; i <= vals.Length - 1; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sumOfOdds = 0;
           
            if (numbers == null || numbers.Any())
            {
                return false;
            }

            var iterable = numbers.GetEnumerator();
            int number = iterable.Current;

            while (iterable.MoveNext())
            {
                if (number % 3 == 0)
                {
                    sumOfOdds += number;
                }
            }
            return (sumOfOdds % 3 == 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
            string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            
            if (password.Contains(numbers) && password.Contains(upperCaseChars) || password.Contains(lowerCaseChars))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            //for (int i = 0; i <= 1; i++)
            //{
            //    return (char)val[i];
            //}
            //return '\0';

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            decimal quotient = dividend / divisor;
            return quotient;
        }

        public int LastMinusFirst(int[] nums)
        {
            return (nums[nums.Length - 1] - nums[0]);
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddsList = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                { oddsList.Add(i); }
            }
            int[] oddsArray = oddsList.ToArray();
            return oddsArray;
        }


        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
