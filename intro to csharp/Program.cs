using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a database of X employees
            Repository repository = new Repository(40);

            // Show all employees
            repository.Print("Database before Deletion");

            // Delete all name with name "Агата"
            repository.DeleteWorkerByName("Агата");

            // Print to the console of employees who did not get fired
            repository.Print("Database after first Deletion");

           // Delete all employees named "Аделина"
            repository.DeleteWorkerByName("Аделина");

            // Print to the console of employees who did not get fired
            repository.Print("Database after second deletion");


            #region Homework

            // Difficulty level: simple
            // *Task 1. Redesign the program so that before the first wave of dismissal in the department there were no more than 20 employees

            //  Difficulty level: medium difficulty
            // * Task 2. Create a department of 40 employees and implement several layoffs, based on the results
            // which in the department should not be more than 30 employees
            
            // Difficulty level: hard
            // ** Task 3. Create a department of 50 employees and implement the dismissal of employees
            // whose salary exceeds 30,000 rubles

            #endregion

        }
    }
}
