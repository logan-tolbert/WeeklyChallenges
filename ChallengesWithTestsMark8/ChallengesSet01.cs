using System;
using System.Net.Http;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend; 
        }

        
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        
        public int GetSmallestNumber(int number1, int number2)
        {
            return Math.Min(number1, number2);
        }

        
        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;           
        }

        
        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                var greeting = "Hello!";
                return greeting;
            }
            else
            {
                var greeting = $"Hello, {nameOfPerson}!";
                return greeting;           
            }
        }

        
        public string GetHey()
        {
            var sayHey = "HEY!";
            return sayHey;
        }
    }
}
