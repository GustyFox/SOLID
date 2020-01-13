using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples.LiskovSubstitution.Before
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public virtual string GetProjectDetails(int employeeId)
        {
            return "Base Project";
        }
        public virtual string GetEmployeeDetails(int employeeId)
        {
            return "Base Employee";
        }
    }

    public class PermanentEmployee : Employee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Project Details";
        }
        
        public override string GetEmployeeDetails(int employeeId)
        {
            return "Employee Details";
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Project Details";
        }

        public override string GetEmployeeDetails(int employeeId)
        {
            return "Employee Details";
        }
    }

    public class ConsultantEmployee : Employee
    {
        //Our consultor doesn't have a project, he helps teams to manage their projects
        public override string GetProjectDetails(int employeeId)
        {
            throw new NotImplementedException();
        }

        //We probably don't have the consultor on the Employee DB, we only have a contract with a Consultancy Company
        public override string GetEmployeeDetails(int employeeId)
        {
            return "Consultor Details";
        }
    }
}
