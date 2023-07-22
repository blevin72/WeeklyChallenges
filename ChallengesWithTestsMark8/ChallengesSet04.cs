using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    answer += numbers[i];
                }
                else
                {
                    answer -= numbers[i];
                }
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int lengthOne = str1.Length;
            int lengthTwo = str2.Length;
            int lengthThree = str3.Length;
            int lengthFour = str3.Length;

            int shortestLength = new[] { str1.Length, str2.Length, str3.Length, str4.Length }.Min();
            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNumber = new[] { number1, number2, number3, number4 }.Min();
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3 &&
                    sideLength2 + sideLength3 > sideLength1 &&
                    sideLength3 + sideLength1 > sideLength2);

            //if (sideLength1 + sideLength2 > sideLength3 &&
            //   sideLength2 + sideLength3 > sideLength1 &&
            //   sideLength3 + sideLength1 > sideLength2)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }


        public bool IsStringANumber(string input)
        {
            double n;
            bool isNumber = double.TryParse(input, out n);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int objsNull = objs.Count(o => o is null);
            int objsNotNull = objs.Count(o => o is not null);
            //int objsNull = 0;
            //int objsNotNull = 0;

            //foreach(object o in objs)
            //{
            //    if(objs is null)
            //    {
            //        objsNull++;
            //    }
            //    else
            //    {
            //        objsNotNull++;
            //    }
            //}
            return objsNull > objsNotNull;
        }

        public double AverageEvens(int[] numbers)
        {
            try
            {
                return numbers.Where(n => n % 2 == 0).Average();
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(number == 1 || number == 0)
            {
                return 1;
            }
            if(number >= 2)
            {
                var factorial = number * Factorial(number - 1);
                return factorial;
            }
            return 0;
        }
    }
}
