using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals == null || vals.Length == 0)
            {
                return false;
            }
            foreach(bool val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            int sum = 0;
            foreach(var n in numbers)
            {
                if(n % 2 != 0)
                {
                    sum += n;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isNumber = false;

            foreach(var c in password)
            {
                if (Char.IsLower(c))
                {
                    isLower = true;
                }
                if (Char.IsUpper(c))
                {
                    isUpper = true;
                }
                if (Char.IsNumber(c))
                {
                    isNumber = true;
                }
            }
            return (isUpper && isLower && isNumber);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
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
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var ans = new List<int>();
            for(int i = 0; i <= 100; i++)
            {
                if(i %2 != 0)
                {
                    ans.Add(i);
                }
            }
            return ans.ToArray();
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
