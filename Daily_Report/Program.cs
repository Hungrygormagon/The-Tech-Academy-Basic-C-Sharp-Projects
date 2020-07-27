using System;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Daily Student Report");
            Console.WriteLine("What is your first and last name?");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What was the last page of the " + courseName + "course have you completed?");
            string coursePage = Console.ReadLine();
            Console.WriteLine("The last page of the " + courseName + "course you completed was " + coursePage);
            Console.WriteLine("Is there anything that you need help with?");
            Console.WriteLine("Please enter 'True' or 'False'.");
            string needHelp = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperiences = Console.ReadLine();
            Console.WriteLine("We will be sure to share your experiences with the instructors, thank you for sharing.");
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today ?");
            string studyHours = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}

