using System;

namespace PackageExpressAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for choosing Package Express!");
            Console.WriteLine("Please enter your package weight: ");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight >= 50)
            {
                Console.WriteLine("We're sorry, that package is unable to be shipped through us. Have a nice day. Press any key to exit");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter your package height: ");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your package length: ");
                int pkgLength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your package width: ");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());
                int pkgTotalDim = pkgHeight + pkgWidth + pkgLength;
                int pkgDimensions = pkgHeight * pkgLength * pkgWeight;
                int pkgCost = pkgDimensions / 100;
                if (pkgTotalDim >= 50)
                {
                    Console.WriteLine("We're sorry, that package is unable to be shipped through us. Have a nice day. Press any key to exit");
                    Console.ReadLine();
                }
                else {
                    Console.WriteLine("The package is shippable! It will cost $" + pkgCost + ".00 to ship.");
                    Console.WriteLine("Thank you for choosing Package Express, press any key to continue.");
                    Console.ReadLine();
                }
                
            };

        }
    }
}



