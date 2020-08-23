using System;
using System.Collections.Generic;
using System.Text;

namespace MathClasses
{
    public class MathOperations
    {
        public int DivisionMethod(int Num1) 
        {
            int result = Num1 / 3;
            Console.WriteLine(Num1 + " divided by 3 is equal to " + result);
            return result;
        }
        public int MultiplicationMethod(int Num1)
        {
            int result = Num1 * 50;
            Console.WriteLine(Num1 + " multiplied by 50 is equal to " + result);
            return result;
        }
        public int AdditionMethod(int Num1)
        {
            int result = Num1 + 12358;
            Console.WriteLine(Num1 + " added to 12358 is equal to " + result);
            return result;
        }
    }
}
