using System;

namespace AnonymousIncomeSurvey
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Survey");
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is the hourly wage for Person 1?");
            int personOneSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 1 makes $" + personOneSalary + "/hr.");
            Console.WriteLine("How many hours did Person 1 work this week?");
            int personOneHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 1 worked " + personOneHours + " hours this week.");
            Console.WriteLine("The annual salary for Person 1 is: ");
            int personOneYearly = ((personOneHours * 52) * personOneSalary);
            Console.WriteLine(personOneYearly);
            Console.WriteLine("Person 2:");
            Console.WriteLine("What is the hourly wage for Person 2?");
            int personTwoSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2 makes $" + personTwoSalary + "/hr.");
            Console.WriteLine("How many hours did Person 2 work this week?");
            int personTwoHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2 worked " + personTwoHours + " hours this week.");
            Console.WriteLine("The annual salary for Person 2 is: ");
            int personTwoYearly = ((personTwoHours * 52) * personTwoSalary);
            Console.WriteLine(personTwoYearly);
            if (personOneYearly > personTwoYearly){
                Console.WriteLine("Person 1 makes more money than Person 2");
            }
            else if (personOneYearly < personTwoYearly){
                Console.WriteLine("Person 2 makes more money than Person 1");
            }
            else
                Console.WriteLine("Person 1 and Person 2 make the same amount of money per year");
            Console.ReadLine();




        }
    }
}
