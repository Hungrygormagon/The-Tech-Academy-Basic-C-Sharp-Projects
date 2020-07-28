using System;
using System.Collections.Generic;

namespace LIstArraysAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;
            do
            {
                int[] intArray = { 120, 24, 599, 230, 1200 };
                Console.WriteLine("Please enter a number in range 0-4");
                int indexSelect = Convert.ToInt32(Console.ReadLine());
                if (indexSelect > 4)
                {
                    Console.WriteLine("Oops, that option is not avaliable. Try again? Enter true or False");
                    tryAgain = Convert.ToBoolean(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("The number you chose is: " + intArray[indexSelect]);
                    tryAgain = false;
                };
            }
            while (tryAgain);

            do
            {
                string[] strArray = { "Adam", "Bill", "Carlin", "Dwight", "Eunice" };
                Console.WriteLine("Please enter a number in range 0-4 to choose a name.");
                int strSelect = Convert.ToInt32(Console.ReadLine());
                if (strSelect > 4)
                {
                    Console.WriteLine("Oops, that option is not avaliable. Try again? Enter true or False");
                    tryAgain = Convert.ToBoolean(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("The name you chose is: " + strArray[strSelect]);
                    tryAgain = false;
                };
            }
            while (tryAgain);
            do
            {
                List<string> strList = new List<string>();
                strList.Add("Bob");
                strList.Add("Mike");
                strList.Add("Nick");
                strList.Add("Ford");
                strList.Add("Garvey");

                Console.WriteLine("Please enter a number in range 0-4 to choose a name.");
                int strSelect = Convert.ToInt32(Console.ReadLine());
                if (strSelect > 4)
                {
                    Console.WriteLine("Oops, that option is not avaliable. Try again? Enter true or False");
                    tryAgain = Convert.ToBoolean(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("The name you chose is: " + strList[strSelect]);
                    tryAgain = false;
                };
            }
            while (tryAgain);
            Console.ReadLine();
        }
    }
}