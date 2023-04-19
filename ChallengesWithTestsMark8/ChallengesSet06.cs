using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool testWord = false;

            if(string.Equals(words, null) || words.Contains(null))
                {
                return false;     
                }

            if(ignoreCase)
            {
                word = word.ToLower();

                List<string> lc = words.Select(x => x.ToLower()).ToList();
                
                testWord = lc.Contains(word);
            }

            if(!ignoreCase)
            {
                testWord = words.Contains(word);
            }

            return testWord;

        }

        public bool IsPrimeNumber(int num)
        {
            var primeNum = false;

            if(num >= 0)
            {
                if(num % 2 != 0 && num % 3 != 0)
                {
                       primeNum = true;
                }
            }
            if((num == 2) || (num == 3))
            {
                primeNum = true;
            }
            if(num ==1)
            {
                primeNum = false;
            }
            return primeNum;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uniIndex;

            for(int i = 0; i < str.Length; i++)
            {
                uniIndex = true;
                for(int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniIndex = false;
                    }
                }
                if(uniIndex)
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
                
                for(int x = i + 1; x < numbers.Length; x++)
                {
                    if (numbers[i] != numbers[x])
                    {
                        break;
                    }
                    currentCount++;
                }
                if(currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();

            if(elements == null || n<= 0 ||  elements.Count == 0)
            {
                return result.ToArray();
            }
            
            for(int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
               
            }
            return result.ToArray();
        }
    }
}
