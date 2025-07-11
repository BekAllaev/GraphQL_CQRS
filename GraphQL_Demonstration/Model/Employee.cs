﻿namespace GraphQL_Demonstration.Model
{
    public class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
