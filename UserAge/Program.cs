using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for choosing Omega Airlines. What is your name?");
            string Name = Console.ReadLine();
            int today = DateTime.Now.Year;
                        bool runProgram = true;
            while (runProgram)
            {
                try
                {
                    bool validAnswer = false;
                    int age = 0;
                    while (!validAnswer)
                    {
                        Console.WriteLine("And how old are you today?");
                        validAnswer = int.TryParse(Console.ReadLine(), out age);
                        int birthyear = today - age;
                        Console.WriteLine("You were born in the year {0}", birthyear);
                        Console.WriteLine("Please press enter to continue.");
                        Console.ReadLine();
                        if (!validAnswer) Console.WriteLine("Please enter whole numbers only.");
                    }
                    if (age < 0)
                    {
                        throw new NegAgeException();
                    }
                    if (age>0 && validAnswer)
                    {
                        Console.WriteLine("{0} you are {1} years old.", Name, age);
                        Console.ReadLine();
                        runProgram = false;
                    }
                }
                catch (NegAgeException)
                {
                    Console.WriteLine("Please enter a positive number");
                    Console.ReadLine();
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("An error has occured. Please contact your System Administrator.");
                    Console.ReadLine();
                    return;
                }
            }
        }
    }
}
