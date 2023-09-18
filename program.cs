using System;

namespace RestockingTool
{
    class Program
    {
        static void Main(string[] args)
        {
            int sodaStock = 100;
            int sodaRestockValue = 40;

            int chipsStock = 40;
            int chipsRestockValue = 20;

            int candyStock = 60;
            int candyRestockValue = 40;

            Console.WriteLine("Welcome to the restocking tool.");

            void UpdateStock(string itemName, ref int stock, int restockValue)
            {
                Console.Write($"How many {itemName} have been sold today? {stock} are in stock\n> ");
                if (int.TryParse(Console.ReadLine(), out int soldQuantity))
                {
                    if (soldQuantity >= 0)
                    {
                        stock -= soldQuantity;
                        Console.WriteLine($"There are {stock} {itemName}s left");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Quantity must be a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            
            UpdateStock("Sodas", ref sodaStock, sodaRestockValue);
            UpdateStock("Chips", ref chipsStock, chipsRestockValue);
            UpdateStock("Candys", ref candyStock, candyRestockValue);

            
            Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
            if (sodaStock <= sodaRestockValue)
                Console.WriteLine("Sodas needs to be restocked");
            if (chipsStock <= chipsRestockValue)
                Console.WriteLine("Chips needs to be restocked");
            if (candyStock <= candyRestockValue)
                Console.WriteLine("Candy needs to be restocked");

            Console.WriteLine("see ya!!");
        }
    }
}
