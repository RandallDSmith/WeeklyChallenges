using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(var i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for(var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;

        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var total = 0;
            for(var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0)
                {
                    total += numbers[i];
                }
            }
            return total;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";

            foreach(var word in words)
            {
                if(word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }

            }
            
            if(sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Trim();
            sentence += ".";
            return sentence;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            List<double> result = new List<double>();

            for(var i = 3; i < elements.Count; i+= 4) 
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if(nums == null || nums.Length == 0)
            {
                return false;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                for (int x = i + 1; x < nums.Length; x++)
                {
                    if (nums[x] + nums[i] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
