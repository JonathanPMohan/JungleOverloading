using System;
using System.Collections.Generic;


namespace JungleOverloading
{
    class Program
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>();

        static void Main(string[] args)
        {

            Employee link = new Employee("Link", "Zelda");
            Employee samus = new Employee("Samus", "Metroid");
            Employee gannon = new Employee("Gannon", "Monster");
            Employee bowser = new Employee("Bowser", "Koopa");

            Employees.Add(link);
            Employees.Add(samus);
            Employees.Add(gannon);
            Employees.Add(bowser);


            gannon.Eat();
            gannon.Eat("microwavable garbage");
            gannon.Eat(Employees);
            gannon.Eat("some good grub", Employees);

        }
    }
}