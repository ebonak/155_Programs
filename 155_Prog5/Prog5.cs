using System;

namespace _155_Prog5
{
    class Prog5
    {
        static void Main(string[] args)
        {
            banner();
            Console.WriteLine("This program computes your BMI");

            bool stop = false;

            while (!stop)
            {

                Console.Write("What is your first name? ");
                string name = Console.ReadLine();

                Console.Write("Enter your weight in pounds: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Enter your height in inches: ");
                double height = double.Parse(Console.ReadLine());

                double bmi = computeBMI(height, weight);
                printResult(name, bmi);

                Console.Write("\nDo you want to continue? ");
                string response = Console.ReadLine();

                if (response.ToLower() == "no")
                    stop = true;
            }

            Console.WriteLine("Ok, thanks for using this program.");

            banner();
        }


        static double computeBMI(double height, double weight)
        {
            return (weight * 703) / (height * height);
        }


        static void printResult(string name, double bmi)
        {
            string category = "underweight";

            if ((bmi >= 18.5) && (bmi < 25))
                category = "normal weight";
            else if ((bmi >= 25) && (bmi < 30))
                category = "overweight";
            else if (bmi >= 30)
                category = "obese";

            Console.WriteLine("\nDear {0}, your BMI is {1:f1} and you are {2}.", 
                                name.ToLower(), bmi, category);
        }


        static void banner()
        {
            Console.WriteLine("\n------------------");
            Console.WriteLine("This is a banner.");
            Console.WriteLine("------------------");
        }

    }
}
