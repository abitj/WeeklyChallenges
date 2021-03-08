using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            //throw new NotImplementedException();
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //throw new NotImplementedException();

            foreach (var bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;

        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            //throw new NotImplementedException();

            if (numbers == null)
            {
                return 0;
            }


            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }

            }
            return sum;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //throw new NotImplementedException();

            if (words == null)
            {
                return "";
            }
            string sentence = "";
            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";

                }
            }

            if (sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";
            return sentence;


        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            //throw new NotImplementedException();
            if (elements == null)
            {
                return new double[0];
            }


            List<double> everyFourth = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }

            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();



            /* for(int i = 0; i < nums.Length; i++)

                 for (int k = i + 1; k < nums.Length; k++)
                 {
                     if(nums[i] + nums[k] == targetNumber)
                     {
                         return true;
                     }
                 }*/
        }

    }
}