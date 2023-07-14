using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals?.Contains(false) ?? false;
        }


        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers?.Any() ?? false ? numbers.Sum() % 2 != 0 : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsNumber);
            //bool hasUpperCase = false;
            //bool hasLowerCase = false;
            //bool hasNumber = false;

            //foreach (char c in password)
            //{
            //    if (char.IsUpper(c))
            //    {
            //        hasUpperCase = true;
            //    }
            //    else if (char.IsLower(c))
            //    {
            //        hasLowerCase = true;
            //    }
            //    else if (char.IsDigit(c))
            //    {
            //        hasNumber = true;
            //    }
            //}

            //return hasUpperCase && hasLowerCase && hasNumber;


        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0]
        }
        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(0, 100).Where(i => i % 2 != 0).ToArray();
            //var ans = new List<int>();
            //for (int i = 0 ) ; int<=100; i+=2)
            //    if (int % 2 != 0)
            //    {
            //       ans.Add(i);
            //    }
            //    return ans.ToAArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
