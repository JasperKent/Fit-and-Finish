using PeopleLibrary;
using System;

namespace Version8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("[C]ustomer of [E]mployee? ");
            string type = Console.ReadLine().ToUpper();

            Person p = type == "C" ? (Person)new Customer() : new Employee();
        }
    }
}
