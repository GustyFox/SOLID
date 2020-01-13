using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples.LiskovSubstitution.After
{

    public abstract class Employee
    {
        public int Id { get; set; }

        public virtual string GetProjectsDetails(int employeeId)
        {
            return "Base Project";
        }
        public virtual string GetEmployeeDetails(int employeeId)
        {
            return "Base Employee";
        }
    }

    public class PermanentEmployee : IEmployee, IProject
    {
        public int Id { get; set; }

        public string GetProjectsDetails(int employeeId)
        {
            return "Project Details";
        }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Employee Details";
        }
    }

    public class TemporaryEmployee : IEmployee, IProject
    {
        public int Id { get; set; }

        public string GetProjectsDetails(int employeeId)
        {
            return "Project Details";
        }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Employee Details";
        }
    }

    public class ConsultantEmployee : IEmployee
    {
        public int Id { get; set; }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Consultor Details";
        }
    }
}
