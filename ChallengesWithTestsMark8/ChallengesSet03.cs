using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
          for(int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return false;
                }
                
            }
            return true;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers.Count() == 0 || numbers == null)
            {
                return false;
            }
            var sum = numbers.Sum();

            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

            public bool PasswordContainsUpperLowerAndNumber(string password)
             {

                     var cUpper = false;
                     var cLower = false;
                     var cNumber = false;

                     for(int i = 0; i < password.Count();i++)
                     {
                         if (char.IsLower(password[i]))
                         {
                             cUpper = true;
                         }
                         if (char.IsUpper(password[i]))
                         {
                             cLower = true;
                         }
                         if (char.IsNumber(password[1]))
                         {
                             cNumber = true;
                         }

                         if(cUpper == true && cLower == true && cNumber == true)
                         {
                             return true;
                         }
                             return false;
                     }
            return false;
            }

             public char GetFirstLetterOfString(string val)
             {
                  return val.First();

             }

             public char GetLastLetterOfString(string val)
             {
                return val[val.Length - 1];
             }

             public decimal Divide(decimal dividend, decimal divisor)
             {
                if(divisor == 0)
                     {
                         return 0;
                     }

                return dividend / divisor;
             }

             public int LastMinusFirst(int[] nums)
             {
                     return nums[nums.Length - 1] - nums[0];
             }

             public int[] GetOddsBelow100()
             {
                     int[] i = new int[49];
                     int a = 0;
                     for(int x = 0; x <100; x++)
                     {
                         if(x % 2 != 0)
                         {
                             i[a] = x;
                             a++;
                         }
                     }
                     return i;
             }

             public void ChangeAllElementsToUppercase(string[] words)
                {
                    for(int i = 0; i < words.Length; i++)
                    {
                            words[i] = words[i].ToUpper();
                    }
           
            
                }
        
    }
}
