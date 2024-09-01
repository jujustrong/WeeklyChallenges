using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            return num1 == num2 ? true : false;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var answer = minuend - subtrahend;
            return answer;
        }

        public int Add(int number1, int number2)
        {
            var answer = number1 + number2;
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return number1 < number2 ? number1 : number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (String.IsNullOrEmpty(nameOfPerson))
            {
                return "Hello!";
            }
            var greeting = $"Hello, {nameOfPerson}!";
            return greeting;
        }

        public string GetHey()
        {
            return $"HEY!";
        }
    }
}
