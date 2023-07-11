using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num; // Add even number
                }
                else
                {
                    sum -= num; // Subtract odd number
                }
            }

            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int minLength = int.MaxValue;

            if (str1.Length < minLength)
            {
                minLength = str1.Length;
            }

            if (str2.Length < minLength)
            {
                minLength = str2.Length;
            }

            if (str3.Length < minLength)
            {
                minLength = str3.Length;
            }

            if (str4.Length < minLength)
            {
                minLength = str4.Length;
            }

            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1;

            if (number2 < smallest)
            {
                smallest = number2;
            }

            if (number3 < smallest)
            {
                smallest = number3;
            }

            if (number4 < smallest)
            {
                smallest = number4;
            }

            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //Need help with this
            biz.Name = "TrueCoders";

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) &&
            (sideLength2 + sideLength3 > sideLength1) &&
            (sideLength1 + sideLength3 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            //Need help with this
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //Need help with this
            int nullCount = 0;
            int nonNullCount = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
                else
                {
                    nonNullCount++;
                }
            }

            return nullCount > nonNullCount;
        }

        public double AverageEvens(int[] numbers)
        {
            int sum = 0;
            int count = 0;

            if (numbers == null)
            {
                return 0;

            }
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;  // Add even number to the sum
                    count++;     // Increment the count of even numbers
                }
            }

            if (count == 0)
            {
                return 0;  // Handle the case when there are no even numbers
            }

            return (double)sum / count;  // Calculate the average
        }

        public int Factorial(int number)
        {
            // Need help - 3 test can't pass
            if (number == 0)
            {
                return 1; // Base case: factorial of 0 is 1
            }
            else
            {
                return number * Factorial(number - 1); // Recursive case: factorial of n is n * factorial of (n-1)
            }
        }
    }
}
