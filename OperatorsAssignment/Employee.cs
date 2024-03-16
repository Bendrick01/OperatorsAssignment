using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    public class Employee
    {
        //Setting properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor for the Employee class.
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Overloading the '==' operator.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            //
            if (Equals(employee1, employee2)) return true;

            // Handling null
            if (employee1 is null || employee2 is null) return false;

            // Comparing the ID's
            return employee1.Id == employee2.Id;
        }

        // Overloading the '!=' operator.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
        return !(employee1 == employee2);
        }
    }
}