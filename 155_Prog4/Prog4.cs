using System;

namespace _155_Prog4
{
    class Prog4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program computes your BMI");

            Console.Write("What is your first name? ");
            string name = Console.ReadLine();

            Console.Write("Enter your weight in pounds: ");
            double lbs = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in inches: ");
            double height = double.Parse(Console.ReadLine());

            double bmi = (lbs * 703) / (height * height);
            string category = "normal weight";

            Console.WriteLine("Dear {0}, your BMI is {1:n} and you are {2}.", name, bmi, category);
        }
    }
}
