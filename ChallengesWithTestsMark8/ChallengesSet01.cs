using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        // AreTwoNumbersTheSame 
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Subtract
        public double Subtract(double minuend, double subtrahend)
        {
            double res =  minuend - subtrahend;
            return res;
        }

        // Add
        public int Add(int number1, int number2)
        {
            var res = number1 + number2;
            return res;
        }

        // GetSmallestNumber
        public int GetSmallestNumber(int number1, int number2)
        {
            if(number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        // Multiply
        public long Multiply(long factor1, long factor2)
        {
            long res = factor1 * factor2;
            return res;

        }

        // GetGreeting
        public string GetGreeting(string nameOfPerson)
        {
            if(nameOfPerson != "")
            {
                return $"Hello, {nameOfPerson}!";
            }
            else
            {
                return "Hello!";
            }
           
        }

        //GetHey
        public string GetHey()
        {
            return "HEY!";
        }
    }
}
