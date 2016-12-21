using System;

namespace _155_Prog3
{
    class Prog3
    {
        static void Main(string[] args)
        {
            const double TAX_RATE = 0.08;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Dr. B's Fancy Cash Register Program (v 2.0)");
            Console.WriteLine("-------------------------------------------\n");

            // need to figure out how to read data
            Console.Write("Description of item purchased: ");
            string description = Console.ReadLine();

            Console.Write("Cost of single item: ");
            double item_cost = Convert.ToDouble(Console.ReadLine());


            Console.Write("Number of items purchased: ");
            int number = Convert.ToInt32(Console.ReadLine());

            double cost = item_cost * number;
            double tax = cost * TAX_RATE;
            double total_cost = cost + tax;


            Console.WriteLine("\nYou bought {0} {1}(s) each costing {2:c}", number, description, item_cost);
            Console.WriteLine("Tax: {0:c}", tax);
            Console.WriteLine("Total cost (incl. tax) you owe is {0:c}", total_cost);

            Console.Write("\nEnter amount tendered: ");
            double tendered = Convert.ToDouble(Console.ReadLine());

            double change = tendered - total_cost;

            if (change > 0)
                Console.WriteLine("Thank you for your purchase - your change is {0:c}.", change);
            else
                Console.Error.WriteLine("Not enough - you are short {0:c}.", change);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Dr. B's Fancy Cash Register Program (v 2.0)");
            Console.WriteLine("-------------------------------------------\n");

            Console.ReadKey();
        }
    }
}
