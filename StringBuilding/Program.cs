using System;
using System.Text;

namespace StringBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "Hello!";
            string stringTwo = " I am a program ";
            string stringThree = "written in C# language";

            Console.WriteLine(stringOne + stringTwo + stringThree);

            string stringFour=stringOne.ToUpper();
            Console.WriteLine(stringFour);

            StringBuilder sb = new StringBuilder("\t Hello world!");
            sb.Append("This is an example of the stringbuilder utility.");
            sb.AppendLine("It is useful for adding information to new strings,");
            sb.AppendLine("and it helps to contain memory, and not overwhelm a computer");

            Console.WriteLine(sb.ToString());


        }
    }
}
