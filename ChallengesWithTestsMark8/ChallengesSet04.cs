using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Any() == false)
            {
                return 0;
            }
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
                else if (number % 2 == 1)
                {
                    result -= number;
                }
            }
            return result;
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return Math.Min(Math.Min(str1.Length, str2.Length), Math.Min(str3.Length, str4.Length));
        }
        

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
            
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz.Name != "TrueCoders")
            {
                biz.Name = "TrueCoders";
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var S1S2 = sideLength1 + sideLength2;
            var S1S3 = sideLength1 + sideLength3;
            var S2S3 = sideLength2 + sideLength3;

            return S1S2 > sideLength3 && S1S3 > sideLength2 && S2S3 > sideLength1;

        }
        
        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }

            bool isDigit = double.TryParse(input, out double number);
            return isDigit;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int isNull = 0;
            int nonNull = 0;      
            bool result = false;

            foreach (object o in objs)
            {
                if (o == null)
                {
                    isNull++;
                }
                else if (o is string || o is int || o is bool)
                {
                    nonNull++;
                }

                
                if (nonNull < isNull )
                {
                    result = true;
                }
                else if (nonNull >= isNull ) 
                {
                    result = false;
                }
                
            }
            return result;
        }

        public double AverageEvens(int[] numbers)
        {
            List<int> evens = new List<int>();
            if (numbers == null)
            {
                return 0;

            }
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    evens.Add(n);
                }
            }

            if (evens.Any() == false)
            {
                return 0;
            }
            
            return evens.Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number <= 1)
            {
                return 1;
            }
            else 
            {
                int factorial = number * Factorial(number - 1);

                return factorial; 
                
            }
           
        }
    }
}
