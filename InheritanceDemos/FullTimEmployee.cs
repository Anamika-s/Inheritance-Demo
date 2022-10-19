using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemos
{
    class FullTimEmployee : Employee
    {
        int salary;
        string designation;
        public FullTimEmployee() : base() { }
        public FullTimEmployee(int id, string name, string dept, string manager, int salary, string designation)
            : base (id, name, dept, manager)
        {
            this.salary = salary;
            this.designation = designation;
        }
        //public void GetFullTimEmployeeDetails()
        //{
        //    Console.WriteLine("Enter salary");
        //    salary = Int32.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter designation");
        //    designation = Console.ReadLine();
        //}
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter salary");
            salary = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter designation");
            designation = Console.ReadLine();
        }
        //public void DisplayFullTimEmployeeDetails()
        //{
        //    Console.WriteLine($"salary: {salary}\ndesignation is: {designation}");
        //}
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"salary: {salary}\ndesignation is: {designation}");
        }
    }
}
