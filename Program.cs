using System;
using System.ComponentModel.Design;

namespace VendingMachine
{
    class Vend
    {
        static void Main(string[] args)
        {
            //Declare variable
            decimal [] price = new decimal[] {1.50m, 1.75m, 2.50m, 3.00m};
            string[] drink = new string[] {"Coke", "Pepsi", "Dr. Pepper", "Evian" };
            decimal payment;
            int choice;

            //Display selection

            Console.WriteLine("Please make a selection.");
            Console.WriteLine("1 " + drink[0] + "  $" + price[0]);
            Console.WriteLine("2 " + drink[1] + "  $" + price[1]);
            Console.WriteLine("3 " + drink[2] + "  $" + price[2]);
            Console.WriteLine("4 " + drink[3] + "  $" + price[3]);
            
            //capture selction
            choice = Convert.ToInt32(Console.ReadLine()) - 1;
            
            //capture payment
            Console.WriteLine("Please deposit $" + price[choice] );
            payment = decimal.Parse(Console.ReadLine());

            //verify correct payment made
            while (payment < price[choice])
            {
                Console.WriteLine("Please deposit $" + price[choice]);
                payment = decimal.Parse(Console.ReadLine());
             }
            
             Console.WriteLine("Please enjoy your " + drink[choice], ".");
            
        }
    }
}

