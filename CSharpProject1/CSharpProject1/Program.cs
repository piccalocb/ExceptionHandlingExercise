using System;

namespace CSharpProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Charles"; //declare and initialized a variable. My real name
            int age = 35; //not my real age
            int weight = 180; //my real weight
            bool isMarried = true; //Camel Casing
            double savingsAccount = 185.02;
            string fullName = "Charles Balce";




            Console.WriteLine($"My name is {name}, I am {age} years old, my weight is {weight}, " +
                $"Am I married? {isMarried}, I have {savingsAccount} dollars in my bank, my full name is {fullName}");
        }
    }
}
