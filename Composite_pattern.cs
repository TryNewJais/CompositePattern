using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern
{
    /*
     * describes a group of objects that is treated the same way as a single instance of the same type of object.
     */

    public interface Employee
    {
        void ShowDetail();
    }
    public class Devloper : Employee
    {
        protected string firstName;
        protected string lastName;
        public Devloper(string firstName, string Lastname)
        {
            this.firstName = firstName;
            this.lastName = Lastname;
        }

        public void ShowDetail()
        {
            Console.WriteLine( "Devloper:"+firstName+" "+lastName);
        }
    }

    public class JuniorDevloper:Devloper
    {
        public JuniorDevloper(string FName, string Lname) : base(FName, Lname)
        {

        }

    }

    public class CompanyDirectory:Employee
    {
        List<Employee> employees = new List<Employee>();
        
        public void addEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        public void removeEmployee(Employee emp)
        {
            employees.Remove(emp);
        }

        public void ShowDetail()
        {
            foreach(Employee emp in employees)
            {
                emp.ShowDetail();
            }
        }
    }


    public class Client
    {
        public void callerMain()
        {
            CompanyDirectory directory = new CompanyDirectory();
            directory.addEmployee(new Devloper("kavi", "Jais"));
            directory.addEmployee(new JuniorDevloper("kom", "jais"));

            directory.ShowDetail();
        }
    }

}
