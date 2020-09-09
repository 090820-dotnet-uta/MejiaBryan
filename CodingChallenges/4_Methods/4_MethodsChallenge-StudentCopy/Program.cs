using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");


        }

        public static string GetName()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Enter your name");
            return Console.ReadLine();
        }

        public static void GreetFriend(string name)
        {
            //Greeting should be: Hello, nameVar. You are my friend
            //Ex: Hello, Jim. You are my friend
            // throw new NotImplementedException();
            Console.WriteLine("Hello, {0}. You are my friend", name);
        }

        public static double GetNumber()
        {
            //Should throw FormatException if the user did not input a number
            Console.WriteLine("Enter a double value");
            string input = Console.ReadLine();
            double double_input;
            bool isDouble = double.TryParse(input, out double_input);
            if (isDouble) return double_input;
            throw new FormatException();
        }

        public static int GetAction()
        {
            int int_input;
            while(true){
                Console.WriteLine("Please select action [1:Add, 2:Subtract, 3:Multiply, 4:Divide]");
                string input = Console.ReadLine();
                bool isInt = int.TryParse(input, out int_input);
                if (isInt && (int_input > 0 && int_input <= 4)) break;
            }
            return int_input;
        }

        public static double DoAction(double x, double y, int z)
        {
            // throw new NotImplementedException();
            double result = 0.0;
            switch (z){
                //Addition
                case 1:
                    result = x + y;
                    break;
                //Subtraction
                case 2:
                    result = y - x;
                    break;
                //Multiplication
                case 3:
                    result = x * y;
                    break;
                //Division
                case 4:
                    result = y / x;
                    break;
                default:
                    throw new FormatException();
            }
            return result;
        }
    }
}
