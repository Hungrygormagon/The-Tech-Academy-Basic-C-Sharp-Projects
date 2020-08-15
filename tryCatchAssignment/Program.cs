using System;
using System.Collections.Generic;

namespace tryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Divisors = new List<int>();
                Divisors.Add(80);
                Divisors.Add(8);
                Divisors.Add(879);
                Divisors.Add(90);
                Divisors.Add(69);
                Divisors.Add(420);

                Console.WriteLine("Please enter a number to divide all numbers by: ");
                int userNum = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < Divisors.Count; i++)
                {
                    Console.WriteLine("The quotient of " + userNum + " and " + Divisors[i] + " is: " + Divisors[i] / userNum);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a whole number");
                return;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero.");
                return;
            }
            finally
            {
                Console.WriteLine("Goodbye");
                Console.ReadLine();
            }
        }
    }
}
