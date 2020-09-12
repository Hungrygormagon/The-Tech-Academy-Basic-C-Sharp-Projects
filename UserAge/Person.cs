using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace UserAge
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public void userAge()
        {
            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how old are you today?");
                validAnswer = int.TryParse(Console.ReadLine(), out age);
                if (!validAnswer) Console.WriteLine("Please enter whole numbers only.");
            }
            return;
        }
    }

}
