namespace PeopleLibrary
{
    public class Customer : Person
    {
        public decimal Credit { get; set; }

        public Customer()
        {

        }

        public Customer(string name, decimal credit)
            :base(name)
        {
            Credit = credit;
        }
    }
}
