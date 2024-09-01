using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals==null || vals.Count()==0) { return false; }
            return vals.Contains(false) ? true : false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers==null || numbers.Count()==0) { return false; }
            return numbers.Sum() % 2 != 0 ? true : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password==null || password.Count()==0) { return false; }

            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
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
            if (divisor == 0 && divisor == 0) { return 0; }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums==null || nums.Count()==0) { return 0; }

            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            for (var i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            var newArr = odds.ToArray();
            return newArr;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
