using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
           

            var containsWord = false;

            if (String.Equals(words, null) || words.Contains(null))
            { return false; }

            if (ignoreCase)
            {
                word = word.ToLower();

                List<string> lowerCaseWords = new List<string>();
                
                foreach(var wrd in words)
                    {
                        lowerCaseWords.Add(wrd.ToLower());
                    }
                containsWord = lowerCaseWords.Contains(word);

            }
            if (ignoreCase == false)
            {
                var wordList = words.ToList();
                containsWord = words.Contains(word);

            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;
            if (num >= 0)
            { 
                if(num % 2 != 0 && num % 3 != 0) 
                { isPrime = true; } 
            }

            if ((num == 2) || (num == 3))
                { isPrime= true; }

            if(num == 1)
            { isPrime = false; }

            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool isUniqueIndex;

            for (int i = 0; i < str.Length; i++)
            {
                isUniqueIndex = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        isUniqueIndex = false;
                    }
                    
                }


                if (isUniqueIndex)
                {
                    index = i;
                }

            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for(int i = 0; i < numbers.Length; i++)
                    {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount++;
                }

                if(currentCount > count)
                { count = currentCount; }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var everyNthElementList = new List<double>();
           
            if(elements == null || n <= 0 || n > elements.Count)
            {
                
                return everyNthElementList.ToArray();
            }

            for (int i = n - 1; i < elements.Count; i += n)
            {
                everyNthElementList.Add(elements[i]);
            }

            var everyNthElementArray = everyNthElementList.ToArray();
            return everyNthElementArray;

        }
    }
}
