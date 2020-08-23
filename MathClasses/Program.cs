using System;

namespace MathClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Math Class!");
            Console.WriteLine("Please choose a non-zero number: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            MathOperations operations = new MathOperations();
            operations.DivisionMethod(Num1);
            operations.MultiplicationMethod(Num1);
            operations.AdditionMethod(Num1);


            Console.ReadLine();
        }
    }
}
