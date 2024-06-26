using System.Collections.Generic;
using System.Linq;


namespace Inheritance
{ 
        public class Customer
        {
        public int Revenue { get; set; }
        public Customer(int revenue)
        {
            Revenue = revenue;
        }
        }
    public class ORM
    {
        public List<Customer> Customers = new List<Customer>();
        public ORM()
        {
            Customers.Add(new Customer(2256));
            Customers.Add(new Customer(226));
            Customers.Add(new Customer(256));
            Customers.Add(new Customer(225));
            Customers.Add(new Customer(26));
            Customers.Add(new Customer(56));
            Customers.Add(new Customer(62));
            Customers.Add(new Customer(5262));
            Customers.Add(new Customer(2562));
            Customers.Add(new Customer(2526));
        }
        public IQueryable<Customer> GetCustomersAsQueryable()
        {
            return Customers.AsQueryable();
        }
        public IEnumerable<Customer> GetCustomersAsEnumerable() 
        {
            return Customers.AsEnumerable();
        }
    }
}
