using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects with the same Id.
            Employee employee1 = new Employee(1, "Person", "One");
            Employee employee2 = new Employee(1, "Person", "Two");

            // Use the overloaded '==' operator to compare the two Employee objects.
            if (employee1 == employee2)
            {
                Console.WriteLine("emp1 and emp2 have the same ID.");
            }
            else
            {
                Console.WriteLine("emp1 and emp2 have different IDs.");
            }
        }
    }
}