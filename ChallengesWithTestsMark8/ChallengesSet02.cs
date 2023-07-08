using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;
using System.Windows.Markup;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var letters = "abcdefghijklmnopqrstuvwxyz";

            //option 1 but missing test for Caps - if (letters.Contains(c))

            //Option 2 which works
            //if (letters.Contains(Char.ToLower(c)))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //Option 3 which i want to get confortable with
            return (letters.Contains(Char.ToLower(c)));

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            // this works 
            //var count = vals.Length;
            //return (vals.Length % 2 == 0);

            //if you are going to use the var one
            // This way works fine
            return (vals.Length % 2 == 0);

            //If else can be used as another option
            //if(count % 2 == 0)
            //{
            //        return true;
            //    }
            //else
            //    {
            //        return false;
            //    }

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
            //My Code did not work not sure why - got build error - missing Parenthesis- it worked
            if (numbers == null)
            {
                return 0;

            }
            double max = double.MinValue;
            double min = double.MaxValue;
            foreach (double number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            return max + min;
            //return numbers?.Any() == true ? numbers.Min() + numbers.Max() : 0;
        }


        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int answer = 0;
            for(int i=0; i<numbers.Length; i++)
            {
            answer += numbers[i];
            
            }
            return answer;
            //Better return mumbers.Sum();
            //Best return numbers:.Sum() ?? 0;
        }

        public int SumEvens(int[] numbers)
        {
            //My code did not work
            //if(numbers == null)
            //{ 
            //    return 0; 
            //}

            //int answer = 0;
            //foreach (int n in numbers)
            //{
            //    if (n % 2 == 0)
            //    {
            //        answer += n;
            //    }
            //    return answer;
            //}
            return numbers?.Where(x => x % 2 == 0).Sum() ?? 0;
            // aggregate
            // return number?.Aggregate(0, (total, next) ==> next % 2 == 0 ? total + next : total) ?? 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
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
            return number < 0 ? 0 : number /2;
        }
    }
}


