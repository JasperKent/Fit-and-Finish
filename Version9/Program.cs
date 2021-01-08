using PeopleLibrary;
using System;

namespace Version9
{
    class Program
    {
        private static Person owner;

        static void SomeFunc(Person p)
        {

        }

        static void Main()
        {
            Customer c = new();

            Employee e1 = new() { Name = "Wilma", Department = "Rocks" };
            Employee e2 = new("Fred", "Dinoburgers");

            SomeFunc(new());

            owner = new();

            Console.WriteLine("[C]ustomer of [E]mployee? ");
            string type = Console.ReadLine().ToUpper();

            Person p = type == "C" ? new Customer() : new Employee();
        }
    }
}
