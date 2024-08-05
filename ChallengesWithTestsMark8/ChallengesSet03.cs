using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

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
                if (number % 2 == 1)
                {
                    sumOfOdds += number;
                }
            }
            return (sumOfOdds % 2 == 1);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
            string lowerCaseChars = "abscefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
           
            if (password.Any(char.IsDigit) && password.Contains(upperCaseChars) && password.Contains(lowerCaseChars) || password.Any(char.IsDigit) && password.Contains(upperCaseChars))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            for (int i = 0; i <= 1; i++)
            {
                return (char)val[i];
            }
            return '\0';
        }

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
