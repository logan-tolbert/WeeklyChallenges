using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool result = Char.IsLetter(c);
            return result;

            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            bool countIsEven = vals.Length % 2 == 0;
            return countIsEven;
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            bool numIsEven = number % 2 == 0;
            return numIsEven;
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            bool numIsOdd = num % 2 != 0;
            return numIsOdd;
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) 
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            double maxNum = numbers.Max();
            double minNum = numbers.Min();
            double sum;
          
            sum = maxNum + minNum;
            return sum;
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            if (length1 < length2)
            {
                return length1;
            }
            else if (length2 < length1)
            {
                return length2;
            }
            else if (length1 == length2)
            {
                return length1;
            }
          
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            int sumOfNumbers = 0;
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            foreach (int number in numbers)
            {
                
                sumOfNumbers += number;
            }
            return sumOfNumbers;
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            int sumOfEvens = 0;
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumOfEvens += number;
                }
            }
            return sumOfEvens;
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sumOfNumbers = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int number in numbers)
            {

                sumOfNumbers += number;
            }
            return (sumOfNumbers % 2 != 0);
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {

            Int32 newNums = Convert.ToInt32(number);
            if (number <= 1)
            {
                return 0;
            }
            if (number % 2 == 0)
            {
                return (newNums + 1) / (long)2;
            }
            else if (number % 2 == 1)
                return(newNums - 1) / (long)2;
            throw new NotImplementedException();
        }
    }
}
