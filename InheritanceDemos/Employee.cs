using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemos
{
    class Employee
    {
        int id;
        string name;
        string dept;
        string manager;
        public Employee()
        {
                
        }
        public Employee(int id, string name , string dept, string manager)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
            this.manager = manager;
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter ID");
            id = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter dept");
            dept = Console.ReadLine();
            Console.WriteLine("Enter manager");
            manager = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Id: {id}\nName: {name}\nDept: {dept}\nManager: {manager}");
        }
    }
}
