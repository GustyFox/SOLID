using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples.LiskovSubstitution.Before
{
    public class GenerateProjectsReport
    {
        //Now we want to send an email to every employee
        public void GetProjectsDetails()
        {
            List<Employee> employeeList = new List<Employee>();
            
            //We add all the employees to the list:
            employeeList.Add(new PermanentEmployee());
            employeeList.Add(new TemporaryEmployee());
            employeeList.Add(new ConsultantEmployee());

            foreach (Employee employee in employeeList)
            {
                employee.GetProjectDetails(employee.Id);
            }
        }
    }
}

