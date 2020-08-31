using System;
using System.IO;

namespace FileWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number!");
            string userNumber = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\sjcso\usenumber.txt", true))
            {
                file.WriteLine(userNumber);
            }
            Console.WriteLine(File.ReadAllText(@"C:\Users\sjcso\usenumber.txt"));
        }
    }
}
