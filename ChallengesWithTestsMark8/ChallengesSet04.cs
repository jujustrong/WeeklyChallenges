using System;
using System.Collections.Generic;
using System.Linq;
using Array = System.Array;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            return numbers.Sum(x => x % 2 == 0 ? x : -x);
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> strList = [];
            strList.Add(str1);
            strList.Add(str2);
            strList.Add(str3);
            strList.Add(str4);
            return strList.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numList = [];
            numList.Add(number1);
            numList.Add(number2);
            numList.Add(number3);
            numList.Add(number4);
            return numList.Min(x => x);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] triSides = [sideLength1, sideLength2, sideLength3];
            Array.Sort(triSides);
            return triSides[0] + triSides[1] > triSides[2];


        }

        public bool IsStringANumber(string input)
        {
            var parsedNum = double.TryParse(input, out var isNum);
            return parsedNum;

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            List<object> nonNulls = [];
            List<object> nulls = [];
            foreach (var obj in objs)
            {
                if (obj != null) { nonNulls.Add(obj); }
                else { nulls.Add(obj); }
            }

            return nulls.Count > nonNulls.Count;

        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 || numbers.All(x=> x % 2 != 0))
            {
                return 0;
            }
            return numbers.Where(x => x %  2 == 0).Average();
        }

        public int Factorial(int number)
        {
            while (number > 0)
            {
                var answer = 1;
                for (var i = 1; i <= number; i++)
                {
                    answer *= i;
                }
                return answer;
            }

            throw new ArgumentOutOfRangeException();

        }
    }
}
