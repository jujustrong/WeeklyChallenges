using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null) { return false; }

            foreach (var i in words)
            {
                if (i == null) { continue; }
                if (ignoreCase == true)
                {
                    if (string.Equals(i, word, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
                else
                {
                    if (i == word) { return true; }
                }
            }

            return false;
            
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2) { return false; }
            
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) { return false; }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var letterNums = new Dictionary<char, int>();
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            foreach (var c in str)
            {
                if (letterNums.ContainsKey(c)) { letterNums[c]++; }
                else { letterNums[c] = 1; }
            }

            for (var i = str.Length - 1; i >= 0; i--)
            {
                if (letterNums[str[i]] == 1) { return i; }
            }

            return -1;
        }
        

        public int MaxConsecutiveCount(int[] numbers)
        {
            var max = 1;
            var count = 1;

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]== numbers[i-1]) { count++; }
                else 
                {
                    max = Math.Max(max, count);
                    count = 1;
                }
            }

            max = Math.Max(max, count);
            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0) { return new double[] { }; }

            var result = new List<double>();
            for (var i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();

        }
    }
}
