using System;

namespace DataTypeApps
{
    internal class DatatTypeProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of the Apple(s): ");
            int pieces = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of the " + pieces + " apple: ");
            double price = Convert.ToDouble(Console.ReadLine());

            int con_price = (int) price;
            Console.WriteLine("The total value of " + pieces + " apple(s) is " + price);
            Console.WriteLine("The orginal value is " + price);
            Console.WriteLine("The Converted price is " + con_price);
            Console.Write("press any key to exit...");
            Console.ReadKey();
        }
    }
}