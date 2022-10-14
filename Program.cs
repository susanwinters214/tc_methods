using System;

namespace tc_Modules
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();

            // Funny Message Back
            Console.WriteLine("Welcome, " + userName + ". I heard you took a " + favColor + " " + favAnimal + " to see " + favBand + " in concert last week.");


            int additionResult = Add(2, 4);
            int multiplicationResult = Multiply(10, 2);
            int subtractionResult = Subtract(50, 35);
            int divisionResult = Divide(100, 5);

            Console.WriteLine("The answer to your addition problem is: " + additionResult);
            Console.WriteLine("The answer to your multiplication problem is: " + multiplicationResult);
            Console.WriteLine("The answer to your subtraction problem is: " + subtractionResult);
            Console.WriteLine("The answer to your division problem is: " + divisionResult);
        }

       public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
