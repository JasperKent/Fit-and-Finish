namespace PeopleLibrary
{
    public class Employee : Person
    {
        public string Department { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string department)
            :base(name)
        {
            Department = department;
        }
    }
}
