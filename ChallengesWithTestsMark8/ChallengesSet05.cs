using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return Enumerable.Range(startNumber, n*2)
                .First(x => x > startNumber && x % n == 0);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var x in businesses) { if (x.TotalRevenue == 0) { x.Name = "CLOSED"; } }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers==null || numbers.Count()==0) { return false; }
            
            if (numbers.Length == 1) { return true;}

            int i, j;
            for (i = numbers[0], j= numbers[1]; j <= numbers.Length; i++, j++)
            {
                if (i > j) { return false; }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers==null) { return 0; }
            
            var counter = 0;
            int i;
            for (i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] % 2 == 0) { counter += numbers[i + 1]; }
            }
            
            return counter;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return string.Empty;
            }

            List<string> validWords = [];

            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    validWords.Add(word.Trim());
                }
            }

            return string.Join(" ", validWords) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = [];

            if (elements == null || elements.Count == 0)
            {
                return result.ToArray();
            }
            
            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber) { return true; }
                }
            }
            return false;
        }
    }
}
