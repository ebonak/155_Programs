using System;

namespace _155_Prog2
{
    class Prog2
    {
        static void Main(string[] args)
        {
            const double TAX_RATE = 0.08;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Dr. B's Fancy Cash Register Program");
            Console.WriteLine("-----------------------------------\n");

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
            Console.WriteLine("Subtotal: {0:C}", cost);
            Console.WriteLine("Tax: {0:c}", tax);
            Console.WriteLine("Total cost (incl. tax) you owe is {0:c}", total_cost);
            Console.ReadKey();

        }
    }
}
