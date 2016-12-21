using System;

namespace _155_Prog6
{
    class Prog6
    {
        static void Main(string[] args)
        {
            banner();
            int number_of_calcs = 0;

            Console.Write("How many calculations would you like? ");
            try
            {
                number_of_calcs = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.Error.WriteLine("Problem with input - program terminating");
                Environment.Exit(-1);
            }

            for (int i = 0; i < number_of_calcs; i++)
            {
                int numb1 = 0;
                int numb2 = 0;
                try
                {
                    Console.Write("\nEnter first number: ");
                    numb1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    numb2 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Problem with input - program terminating");
                    Environment.Exit(-2);
                }

                string op = showMenu();
                if (op != "invalid")
                {
                    int result = doMath(op, numb1, numb2);
                    printResult(op, numb1, numb2, result);
                }
                else
                    Console.Error.WriteLine("Invalid command.");
            }

            banner();
        }

        static string showMenu()
        // only a valid op (in lower case), or the string "invalid" will be returned.
        {
            Console.WriteLine("\n\nMENU");
            Console.WriteLine("=============");
            Console.WriteLine("Add");
            Console.WriteLine("Sub");
            Console.WriteLine("Mul");
            Console.WriteLine("Div");
            Console.WriteLine("=============");
            Console.Write("choice? ");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "add":
                case "sub":
                case "mul":
                case "div":
                    break;
                default:
                    choice = "invalid";
                    break;
            }

            return choice;
        }

        static int doMath(string op, int num1, int num2)
        //  only a valid op can be passed to this function.
        {
            int result = num1 + num2;

            switch (op)
            {
                case "sub":
                    result = num1 - num2;
                    break;

                case "mul":
                    result = num1 * num2;
                    break;

                case "div":
                    try
                    {
                        result = num1 / num2;
                    }
                    catch(DivideByZeroException)
                    {
                        Console.Error.WriteLine("Division by zero!!");
                        //Console.Error.WriteLine(ex);
                        Console.Error.WriteLine("Ignoring request - program continuing...");
                    }
                    break;
            }

            return result;
        }


        static void printResult(string op, int num1, int num2, int result)
        {
            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, result);
        }


        static void banner()
        {
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("This is a banner for Program #7.");
            Console.WriteLine("--------------------------------");
        }
    }
}
