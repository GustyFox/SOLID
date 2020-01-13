using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples.SingleResponsability.Before
{
    /// <summary>
    /// This class has 3 responsabilities: 
    /// First: It is the abstraction of the Employee object.
    /// Second: It inserts into the database.
    /// Tirdh: It communicates the employee details to a manager.
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public bool InsertEmployee(Employee employee)
        {
            //Insert into employee table
            return true;
        }

        public void RemeberId(int id)
        {
            //Email the employee id to the employee email;
        }
    }
}
