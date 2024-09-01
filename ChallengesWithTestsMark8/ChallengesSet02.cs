using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string UppercaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return lowercaseAlphabet.Contains(c) || UppercaseAlphabet.Contains(c) ? true : false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers==null || numbers.Count()==0)
            {
                return 0;
            }

            var min = numbers.Min();
            var max = numbers.Max();
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length) {return str1.Length;}
            else {return str2.Length;}
        }

        public int Sum(int[] numbers)
        {
            if (numbers==null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers==null || numbers.Count()==0)
            {
                return 0;
            }
            
            int total = 0;
            foreach (var num in numbers)
            {
                if (num%2==0)
                {
                    total += num;
                }
            }

            return total;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers==null || numbers.Count()==0)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0 ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1) { return 0; }

            return (number - 1) / 2;

        } 
    }
}
