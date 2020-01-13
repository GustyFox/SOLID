using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples.LiskovSubstitution.After
{
    public class GenerateProjectsReport
    {
        //Now we want to send an email to every employee
        public void GetProjectsDetails()
        {
            List<IProject> projects = new List<IProject>();

            //We add all the employees to the list:
            projects.Add(new PermanentEmployee());
            projects.Add(new TemporaryEmployee());
            //employeeList.Add(new ConsultantEmployee());

            foreach (IProject project in projects)
            {

                project.GetProjectsDetails();
            }
        }
    }
}
