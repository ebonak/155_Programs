using System;

namespace _155_Prog6
{
    class Prog6
    {
        static void Main(string[] args)
        {
            banner();

            bool stop = false;
            while (!stop)
            {
                Console.Write("\nEnter first number: ");
                int numb1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int numb2 = int.Parse(Console.ReadLine());

                string op = showMenu();
                if (op != "invalid")
                {
                    int result = doMath(op, numb1, numb2);
                    printResult(op, numb1, numb2, result);
                }
                else
                    Console.Error.WriteLine("Invalid command.");

                Console.Write("\nDo you want to continue (y/n)?");
                string response = Console.ReadLine().ToLower();

                if (response == "n")
                    stop = true;
                else if (response != "y")
                {
                    Console.Error.WriteLine("ERROR: Invalid response '{0}' - Terminating program.", response);
                    stop = true;
                }
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
                    result = num1 / num2;
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
            Console.WriteLine("This is a banner for Program #6.");
            Console.WriteLine("--------------------------------");
        }
    }
}
