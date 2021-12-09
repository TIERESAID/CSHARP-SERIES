using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{

    /// <summary>
    /// Organization of data storage and generation
    /// </summary>
    class Repository
    {
        /// <summary>
        /// name data base
        /// </summary>
        static readonly string[] firstNames;

        /// <summary>
        /// first name data base
        /// </summary>
        static readonly string[] lastNames;

        /// <summary>
        /// Pseudo-random number generator
        /// </summary>
        static Random randomize;

        /// <summary>
        /// Static constructor, which "stores"
        /// data on the first and last names of the databases firstNames and lastNames
        /// </summary>
        static Repository()
        {
            randomize = new Random(); // Placement of a random number generator in memory

            // Placing names in the firstNames database
            firstNames = new string[] {
                "Агата",
                "Агнес",
                "Аделаида",
                "Аделина",
                "Алдона",
                "Алима",
                "Аманда",
            };

            // Place the last names in the lastNames database
            lastNames = new string[]
            {
                "Иванова",
                "Петрова",
                "Васильева",
                "Кузнецова",
                "Ковалёва",
                "Попова",
                "Пономарёва",
                "Дьячкова",
                "Коновалова",
                "Соколова",
                "Лебедева",
                "Соловьёва",
                "Козлова",
                "Волкова",
                "Зайцева",
                "Ершова",
                "Карпова",
                "Щукина",
                "Виноградова",
                "Цветкова",
                "Калинина"
            };
        }

        /// <summary>
        /// Employee database, which stores
        /// Name, surname, age and salary of each employee
        /// </summary>
        public List<Worker> Workers { get; set; }

        /// <summary>
        /// Constructor that populates the Workers database
        /// </summary>
        /// <param name="Count">Number of employees to create</param>
        public Repository(int Count)
        {
            this.Workers = new List<Worker>(); // Allocate memory for storing the Worker databases

            for (int i = 0; i < Count; i++)    // Populating the Workers database. Runs Count times
            {
                // Add a new worker to the Workers database
                this.Workers.Add(
                    new Worker(
                        // choose a random name from the name database
                        firstNames[Repository.randomize.Next(Repository.firstNames.Length)],
                        
                        // select a random name from the surname database
                        lastNames[Repository.randomize.Next(Repository.lastNames.Length)],

                        // Generate a random age in the range 19 years - 60 years
                        randomize.Next(19, 60),

                        // Generate a random salary in the range of 10,000 rubles - 80,000 rubles
                        randomize.Next(10000, 80000)
                        ));
            }
        }

        /// <summary>
        /// Method for outputting the Workers database to the console
        /// </summary>
        /// <param name="Text">Auxiliary text that will be printed before the base output</param>
        public void Print(string Text)
        {
            Console.WriteLine(Text);    // Printing Help Text to the Console

            // Change the font color for printing in the console to Dark Blue
            Console.ForegroundColor = ConsoleColor.DarkBlue; 

            // Displaying Database Column Headers
            Console.WriteLine($"{"Name",15} {"Last Name",15} {"Age",10} {"Salary",15}");

            // Change font color for printing in console to Gray
            Console.ForegroundColor = ConsoleColor.Gray;

            
            foreach (var worker in this.Workers) //
            {                                    // We print all workers to the console
                Console.WriteLine(worker);       //
            }                                    //
            Console.WriteLine($"Total: {this.Workers.Count}\n");    // Consolidated report. How many workers have been printed
        }

        /// <summary>
        /// Method that fires employees with more than a specified salary
        /// </summary>
        /// <param name="MaxSalary">The salary level of the employee to be fired</param>
        public void DeleteWorkerBySalary(int MaxSalary)
        {
            this.Workers.RemoveAll(e => e.Salary > MaxSalary);//Removing employees whose salary is higher than the specified MaxSalary
        }

        /// <summary>
        /// Method that fires workers with a given name
        /// </summary>
        /// <param name="CurrentName">Name of employees to be fired</param>
        public void DeleteWorkerByName(string CurrentName)
        {
            this.Workers.RemoveAll(e => e.FirstName == CurrentName);//Removing workers whose name matches the selected CurrentName
        }
    }
}
