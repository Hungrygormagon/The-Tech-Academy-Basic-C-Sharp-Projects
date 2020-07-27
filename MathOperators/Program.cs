using System;
using System.Xml.Schema;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Showing how math operators work in C# programming language");
            Console.WriteLine("Please enter a number: ");
            int multNumber = Convert.ToInt32(Console.ReadLine());
            int multtotal = multNumber * 50;
            Console.WriteLine(multNumber + " times 50 is equal to: " + multtotal);
            Console.WriteLine("Please enter a number: ");
            int addNumber = Convert.ToInt32(Console.ReadLine());
            int addtotal = addNumber + 25;
            Console.WriteLine(addNumber + " plus 25 is equal to: " + addtotal);
            Console.WriteLine("Please enter a number: ");
            int divNumber = Convert.ToInt32(Console.ReadLine());
            double divtotal = (double)divNumber/(double)12.5;
            Console.WriteLine(divNumber + " divided by 12.5 is equal to: " + divtotal);
            Console.WriteLine("Please enter a number: ");
            int greaterNumber = Convert.ToInt32(Console.ReadLine());
            bool greatertotal =greaterNumber > 50;
            Console.WriteLine("Is " + greaterNumber + " greater than 50? " + greatertotal);
            Console.WriteLine("Please enter a number: ");
            int remainderNumber = Convert.ToInt32(Console.ReadLine());
            int remaindertotal = remainderNumber % 7;
            Console.WriteLine("The remainder of " + remainderNumber + " and 7 is " + remaindertotal);
        }
    }
}
