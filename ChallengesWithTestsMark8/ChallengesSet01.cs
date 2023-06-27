using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            //Complete
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //Complete
            double answer = minuend - subtrahend;
            return answer;
        }

        public int Add(int number1, int number2)
        {
            //Complete
            int answer;
            answer = number1 + number2;
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //Complete
            if (number1 < number2)
            {
                return number1;
            }
            else return number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            //Complete
            long answer;
            answer = factor1 * factor2;
            return answer;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //In Progress
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
            //string expectedGreeting = "Hello!";
            //Console.WriteLine("Write your name");
            //nameOfPerson = Console.ReadLine();
            //for (nameOfPerson != null);
            //{
            //    Console.WriteLine($"Hello, {nameOfPerson}!");
            //} 
            //return expectedGreeting;
        }

        public string GetHey()
        {
            //Complete
            //Console.WriteLine("type HEY!");
            //return Console.ReadLine();
            return "HEY!";
        }
    }
}
