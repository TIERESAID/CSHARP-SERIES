using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    /// <summary>
    /// A class describing the worker model
    /// </summary>
    class Worker
    {
        /// <summary>
        /// Employee name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// /// Employee's surname
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Employee age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Employee salary
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// A constructor that allows you to assign a value to the corresponding employee fields
        /// </summary>
        /// <param name="FirstName">FirstName</param>
        /// <param name="LastName">LastName</param>
        /// <param name="Age">Age</param>
        /// <param name="Salary">Salary</param>
        public Worker(string FirstName, string LastName, int Age, int Salary)
        {
            this.FirstName = FirstName; // Store passed name value
            this.LastName = LastName;   // Store passed last name value
            this.Age = Age;             // Save passed age value
            this.Salary = Salary;       // Save the transferred salary value
        }

        /// <summary>
        /// Organization of the output of information about the employee
        /// </summary>
        /// <returns>String representation of information</returns>
        public override string ToString()
        {
            return $"{FirstName,15} {LastName,15} {Age,10} {Salary.ToString("## ###"),10} руб.";
        }
    }
}