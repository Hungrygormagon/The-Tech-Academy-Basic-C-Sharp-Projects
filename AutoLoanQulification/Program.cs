using System;

namespace AutoLoanQulification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Acme Auto Insurance and Brokerage!");
            Console.WriteLine("Please enter the Drivers age:");
            int driversAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Has the Driver had any DUIs in the past? True or False:");
            bool driverDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Please enter the number of speeding tickets the Driver has had in the last 7 years:");
            int driverTickets = Convert.ToInt32(Console.ReadLine());
            if (driversAge >= 15 && driverDUI == false && driverTickets < 3)
            {
                Console.WriteLine("Driver is approved for Insurance Coverage.");
            }
            else
            {
                Console.WriteLine("Driver is NOT approved for Insurance Coverage");
            }
            Console.WriteLine("Please press any key to Exit");
            Console.ReadLine();
        }
    }
}
