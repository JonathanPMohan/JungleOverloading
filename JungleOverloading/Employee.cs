using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        static Random rnd = new Random();

        static List<string> restaurants = new List<string>
        {
            "Cancun Mexican Restaurant",
            "Hattie B's Hot Chicken",
            "Fat Mo's Burgers & Fries",
            "Pizza Perfect",

        };

        public int generateRandomNum()
        {
            // creates a number between 1 and the length of the list
            int randNum = rnd.Next(1, restaurants.Count);
            return randNum;
        }

        public void Eat()
        {
            Console.WriteLine($"{FirstName} {LastName} is eating at {restaurants[generateRandomNum()]}.");
            Console.ReadKey();
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
            Console.ReadKey();
        }

        public void Eat(List<Employee> companions)
        {
            string foodies = "";
            for (int i = 0; i < companions.Count; i++)
            {
                if (companions[i].FirstName != FirstName)
                {
                    if (i != companions.Count - 1)
                    {
                        foodies += companions[i].FirstName + ",";
                    }
                    else
                    {
                        foodies += "and " + companions[i].FirstName;
                    }
                }
            }
            Console.WriteLine($"{FirstName} is eating at {restaurants[generateRandomNum()]} with {foodies}.");
            Console.ReadKey();
        }

        public void Eat(string food, List<Employee> companions)
        {
            string foodies = "";
            for (int i = 0; i < companions.Count; i++)
            {
                if (companions[i].FirstName != FirstName)
                {
                    if (i != companions.Count - 1)
                    {
                        foodies += companions[i].FirstName + ",";
                    }
                    else
                    {
                        foodies += "and " + companions[i].FirstName;
                    }
                }
            }
            Console.WriteLine($"{FirstName} is eating {food} at {restaurants[generateRandomNum()]} with {foodies}.");
            Console.ReadKey();
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
