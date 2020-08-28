using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of a company.
            Company company1 = new Company("Parks Department");

            //create three employees
            Employee employee1 = new Employee();
            employee1.FirstName = "Leslie";
            employee1.LastName = "Knope";
            employee1.Title = "deputy director Parks and Rec";
            employee1.StartDate = new DateTime(2010, 2, 1, 9, 0, 0);

            Employee employee2 = new Employee();
            employee2.FirstName = "Ron";
            employee2.LastName = "Swanson";
            employee2.Title = "director Parks and Rec";
            employee2.StartDate = new DateTime(2008, 3, 1, 7, 0, 0);

            Employee employee3 = new Employee();
            employee3.FirstName = "Andy";
            employee3.LastName = "Dwyer";
            employee3.Title = "the best";
            employee3.StartDate = new DateTime(2016, 2, 1, 4, 0, 0);

            company1.AssignEmployee(employee1);
            company1.AssignEmployee(employee2);
            company1.AssignEmployee(employee3);

            company1.ListEmployees();

        }
    }
}