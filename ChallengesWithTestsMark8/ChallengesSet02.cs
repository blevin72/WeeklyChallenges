using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var letters = "abcdefghijklmnopqrstuvwxyz";
            if (letters.Contains(char.ToLower(c)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var counts = vals.Length;
            return (counts % 2 == 0);

        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;

        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            double max = double.MaxValue;
            double min = double.MinValue;
            foreach (double number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < max)
                {
                    min = number;
                }
            }
            return max + min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int answer = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
            }
            return answer;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int answer = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    answer += i;
                }
            }
            return answer;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return (sum % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number < 0 ? 0 : number / 2;
        }
    }
}
