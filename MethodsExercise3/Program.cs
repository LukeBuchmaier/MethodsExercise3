using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRange(1000, -1000);
            PrintAllThree(3, 999);

            var isEqual = IsEqual(10, 100);
            Console.WriteLine($"isEqual: {isEqual}");

            var isEvenOrOdd = IsEvenOrOdd(40);
            Console.WriteLine($"isEvenOrOdd: {isEvenOrOdd}");

            var positiveOrNegative = PosotiveOrNegative(100);
            Console.WriteLine($"positiveOrNegative: {positiveOrNegative}");

            UserCanVote(18, 76);
            UserInputCheck(-10, 10);
            PrintMultiplicationTable(8);
        }

        //Write a method that will print to the console all numbers 1000 through -1000.
        public static void PrintRange(int max, int min)
        {
            for (int i = max; i >= min; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintAllThree(int start, int finish)
        {
            for (int k = start; k <= finish; k += 3)
            {
                Console.WriteLine(k);
            }
        }
        //Write a method to accept two integers as parameters and check whether they are equal or not.

        public static bool IsEqual(int a, int b)
        {
            return a == b;
        }

        //Write a method to check whether a given number is even or odd.
        public static string IsEvenOrOdd(int num)
        {
            return num % 2 == 0 ? "even" : "odd";
        }
        //Write a method to check whether a given number is positive or negative.
        public static string PosotiveOrNegative(int num)
        {
            return num < 0 ? "negative" : "positive";
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        public static void UserCanVote(int youngest, int oldest)

        {
            Console.WriteLine("Hello, please input your age");
            int userAge = int.Parse(Console.ReadLine());

            //for this example, voting age is between 18 and 76

            if (userAge >= youngest && userAge <= oldest)
            {
                Console.WriteLine($"you are {userAge}, which is in our voting range!");
            }
            else
            {
                Console.WriteLine($"you are {userAge}, which is not in our voting range!");
            }
        }
        //Write a method to check if an integer (from the user) is in the range -10 to 10.
        public static void UserInputCheck(int lower, int upper)
        {
            Console.WriteLine("Hello, please give me a number.");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber >= lower && userNumber <= upper)
            {
                Console.WriteLine($"{userNumber} falls within our desired range");
            }
            else
            {
                Console.WriteLine($"{userNumber} does not fall within our desired range");

            }

        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer.


        public static void PrintMultiplicationTable(int baseNumber)
        {
            for (var i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{baseNumber} * {i} = {baseNumber * i}");
            }
        }
    }
}

