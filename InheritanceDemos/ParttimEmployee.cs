using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemos
{
    class ParttimeEmployee : Employee
    {
        string projectName;
        string duration;
        public ParttimeEmployee() : base() { }
        public ParttimeEmployee(int id, string name, string dept, string manager, string projectName, string duration)
            : base(id, name, dept, manager)
        {
            this.projectName = projectName;
            this.duration = duration;
        }
        //public void GetParttimeEmployeeDetails()
        //{
        //    Console.WriteLine("Enter Project Name");
        //    projectName = Console.ReadLine();
        //    Console.WriteLine("Enter Duration");
        //    duration = Console.ReadLine();
        //}
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Project Name");
            projectName = Console.ReadLine();
            Console.WriteLine("Enter Duration");
            duration = Console.ReadLine();
        }
        //public void DisplayParttimeEmployeeDetails()
        //{
        //    Console.WriteLine($"Project Name: {projectName}\nDuration is: {duration}");
        //}
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Project Name: {projectName}\nDuration is: {duration}");
        }
    }
}
