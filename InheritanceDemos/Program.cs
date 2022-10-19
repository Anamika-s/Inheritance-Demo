using System;
using System.Collections.Generic;

namespace InheritanceDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of Objects
            //Employee[] employee = new Employee[10];
            // Generic Collection 
            //List<Employee> list = new List<Employee>();
            // Initialize List
            //List<Employee> list = new List<Employee>()
            //{
            //    new Employee(100,"Ajay","HR", "Karan"),
            //    new Employee(101,"Jay","HR", "Karan"),
            //    new Employee(102,"Vijay","Accts", "Magan"),
            //    new Employee(103,"Sagar","HR", "Karan"),
            //    new Employee(104,"Gagan","Accts", "Gagan"),
            //    new Employee(105,"Deepak","Sales", "Sagan"),
            //};

            //foreach(Employee employee in list)
            //{
            //       employee.DisplayDetails();
            //}

            Console.WriteLine("Employee");
            Employee employee = new Employee();
          
            employee.GetDetails();
            employee.DisplayDetails();
            Console.WriteLine("FullTime Employee");
           
            FullTimEmployee fullTimEmployee = new FullTimEmployee();
            fullTimEmployee.GetDetails();
            //fullTimEmployee.GetFullTimEmployeeDetails();
            fullTimEmployee.DisplayDetails();
            //fullTimEmployee.DisplayFullTimEmployeeDetails();

            Console.WriteLine("PartTime Employee");
            ParttimeEmployee parttimeEmployee = new ParttimeEmployee();
            parttimeEmployee.GetDetails();
            //parttimeEmployee.GetParttimeEmployeeDetails();
            parttimeEmployee.DisplayDetails();
            //parttimeEmployee.DisplayParttimeEmployeeDetails();

        }
    }
}
