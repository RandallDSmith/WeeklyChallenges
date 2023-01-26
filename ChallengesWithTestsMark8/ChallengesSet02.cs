using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int i = 0;
            for(i = 0; i < vals.Length; i++) 
            {
                continue;
            }
            if(i % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0) 
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if(num % 2 != 0) 
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if( numbers == null)
            {
                return 0;
            }
            if (numbers.Count() ==0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length > str2.Length)
            {
                return str2.Length;
            }
              return str1.Length;
            
            /*int i = str1.Length;
            int j = str2.Length;
            if(i > j)
            {
                return j;
            }
            return i;*/
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            int a = 0;
            for(int i = 0; i < numbers.Length; i++) 
            {
                a += numbers[i];
            }
            return a;
            /*int i = numbers.Length;
            int j = 0;
            int a = 0;
            while(j< i) 
            {
                a += numbers[j];
                j++;
            }
            return a;*/
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int total = 0;
            for(int i = 0; i < numbers.Length;i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    total+= numbers[i];
                }
            }
            return total;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) 
            {
                return false;
            }
            int total = 0;
            for(int i = numbers.Count -1; i >= 0; i--) 
            {
                if (numbers[i] % 2 != 0) 
                {
                    total+= numbers[i];
                }
            }
             if(total % 2 != 0)
            {
                return true;
            }
             return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
