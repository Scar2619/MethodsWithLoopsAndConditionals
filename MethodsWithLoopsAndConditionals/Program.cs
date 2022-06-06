using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            PrintThousand();
            Console.WriteLine();
            PrintByThree();
            Console.WriteLine();
            Console.WriteLine(IsEqual(2, 9));
            Console.WriteLine();
            EvenOdd();
            Console.WriteLine();
            PosNeg();
            Console.WriteLine();
            VotingAge();
            UserChoice();
            MultTable();

        }


        //Write a method that will print to the console all numbers
        //1000 through -1000.
        public static void PrintThousand()
        {
            Console.WriteLine("Enter 'Go!' and watch me count thousands of numbers in seconds.");
            Console.ReadLine();
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Pretty impressive, right?");
        }

        //Write a method that will print to the console numbers 3-999 by
        //3 each time.
        public static void PrintByThree()
        {
            Console.WriteLine("Now watch this! Enter 'Not impressed.'");
            Console.ReadLine();
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Boom. I impress myself sometimes.");
        }

        //Write a method to accept two integers as
        //parameters and check whether they are equal or not.
        public static bool IsEqual(int a, int b)
        {
            Console.WriteLine($"Is {a} equal to {b}? Type 'Tell me!'");
            Console.ReadLine();
            var k = (a == b) ? true : false;
            return k;
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOdd()
        {
            Console.WriteLine("Enter a number to see if it is odd or even.");
            var k = Convert.ToInt32(Console.ReadLine());

            if (k % 2 == 0)
            {
                Console.WriteLine("This is an even number!");
            }
            else
            {
                Console.WriteLine("This is an odd number!");
            }
        }

        //Write a method to check whether a given number is positive or negative.
        public static void PosNeg()
            {
                Console.WriteLine("I can also tell if a whole number is positive or negative. Test me!");
                var k = Convert.ToInt32(Console.ReadLine());
               
                if (k < 0)
                {
                    Console.WriteLine("Nice try! That is negative!");
                }
                else
                {
                    Console.WriteLine("Nice try! That is positive!");
                }
            }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void VotingAge()
        {
            Console.WriteLine("Input your age to see your voting eligibility.");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Unfortunately, you still have a while until you can vote.");
            }
            else
            {
                Console.WriteLine("Congrats!! You are eligible to vote.");
            }
        }

        //Write a method to check if an integer (from the user) is in the range -10 to 10
        public static void UserChoice()
        {
            Console.WriteLine("Pick a number between -10 and 10.");
            var x = Convert.ToInt32(Console.ReadLine());

            if (x > -10 && x < 10)
            {
                Console.WriteLine("Great job.");
            }
            else
            {
                Console.WriteLine("Your number was not between the given range.");
            }
        }

        //Write a method to display the multiplication table (from 1 to 12) of a given integer
        public static void MultTable()
        {
            Console.WriteLine();
            Console.WriteLine("Here is a multiplication table for 1-12.");
            Console.WriteLine();
            for (int i = 0; i <= 12; i++)
            {
                Console.Write(i + "\t");
                for (int j = 1; j <= 12; j++)
                {
                    if (i > 0)
                    {
                        Console.Write(i * j + "\t");
                    }
                    else
                    {
                        Console.Write(j + "\t");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}

