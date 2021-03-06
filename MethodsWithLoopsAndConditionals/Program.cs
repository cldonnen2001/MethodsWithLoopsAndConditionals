using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Print1000(); //  do not  put var ==  because method aleady exisited down below  this is the call for # 1
            PrintBy3();  // for overload would put (10)  this is hte call for #2
            EqualOrNot(1, 2);  // call for #3
            EvenOrOdd(33);  // call for #4
            EvenOrOdda(6);  // call for #4
            IsPositiveOrNegative(42);  // call for #5
            OldEnoughToVote(); // call for #6
            CanVote(3);  //  call for #6 again
            InRange(10);  //
            InRangeA();  //
            MultiplicationTable(5); //
            MultiTable(); //  
        }
        // LUKE WARM

        //1.	Write a method that will print to the console all numbers 1000 through -1000
        public static void Print1000()  //  void is the abscent of a return type so won't have "return" Print1000 is method name a d () is peramter  this creatd the method, still need to call,
        { 
        for (int i = 1000; i >= -1000; i--)  // initize to 1000
            {
                Console.WriteLine(i);
            }
        }
        //2.	Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void PrintBy3()  // ov overload change paramaters so would do (int x)  // different signature (data type of parmeenter, number of parameters or both (so int x, int y would be two parameters)
        {
            for (int i = 3; i <=99; i+=3) //  same as i = i + 3;  
            {
                Console.WriteLine(i);   // declared, need to call
            }
        }

        //3.	Write a method to accept two integers as parameters and check whether they are equal or not.

        public static void EqualOrNot (int num1, int num2)  // could be (int x, int y)  num1 and num2 are from the call part where I have (1,2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Num1 is equal to num2");
            }
            else
            {
                Console.WriteLine("Num1 is not equal to num2");  // breaks out of a scope  break;
            }
        }

        //4.	Write a method to check whether a given number is even or odd.

        public static bool EvenOrOdd(int x)  // this method is type bool
        //public static void EvenOrOdd(int x)
        {
            if (x % 2 == 0)  // %  division with remainder, remainder as to = 0 for true
            {
                Console.WriteLine("this is an even number");  // can leave this Console.WriteLine off as the instructions did not ask for words
                return true;  //  this won't print to console
            }
            else
            {
                Console.WriteLine("this is an odd number");  // can leave this Console.WriteLine off as the instructions did not ask for words
                return false;  // this won't print to console
            }
        }
            //4.	Write a method to check whether a given number is even or odd. a different way

        public static bool EvenOrOdda(int z)
        {
                return z % 2 == 0;   // this will be the same as above  return x % 2 == 0 ? true : false;    //    this is a teranary condition that is the same as the first part
        }
           
        //5.	Write a method to check whether a given number is positive or negative.

        public static void IsPositiveOrNegative(int y)
        {
            if (y > 0)
            {
                Console.WriteLine("this is postivie");
            }
            else if (y < 0)
            {
                Console.WriteLine("this is negative");
            }
            else
            {
                Console.WriteLine("this is zero");
            }
        }

        //6.	Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!

        public static void OldEnoughToVote()
        {
            Console.WriteLine("What is your age");
            int age = Int32.Parse(Console.ReadLine()); // Parse means looking thru something - take string and convert to int

            if (age >= 18)
                {
                    Console.WriteLine("You are old enough to vote");
                }
                else
                {
                    Console.WriteLine("You are not old enough to vote");
                }
        }

        //6.	Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        public static void CanVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Go vote");
            }
            else
            {
                Console.WriteLine("No vote for you");
            }
        }

        //Heating up

        //1.	Write a method to check if an integer(from the user) is in the range -10 to 10.
        
        public static void InRange (int userInput)
        {
            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine("the number is wtihin the range of -10 thru 10");
            }
            else
            {
                Console.WriteLine("the number is outside the range of -10 thru 10");
            }
        }

        //1.	Write a method to check if an integer(from the user) is in the range -10 to 10.
        public static void InRangeA()
        {
            Console.WriteLine("Give me a number:");
            var userInputx = Int32.Parse(Console.ReadLine());
            {
                if (userInputx >= -10 && userInputx <= 10)
                {
                    Console.WriteLine("You are in range");         
                }
                else
                {
                    Console.WriteLine("You are no go");      
                }
            }
        }


        //2.	Write a method to display the multiplication table(from 1 to 12) of a given integer.
        public static void MultiplicationTable (int number)
        {
            //Console.WriteLine(Please ENtera a number for it's multiplication table: ");
            //var number = int.Parse(Console.Readline());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }

        //2.	Write a method to display the multiplication table(from 1 to 12) of a given integer. -- CW via Adam
        public static void MultiTable()
        {
            Console.WriteLine("Please enter a number, i'll givve you the multiplication table: ");
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i<=12; i++)
            {
                Console.WriteLine($"{number} * {1} = {number * i}");
            }
        }
    }
}