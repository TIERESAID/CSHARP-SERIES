using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07._Structures_and_introduction_to_OOP
{
    struct Notepad 
    {
        public List<Content> content ;
        string[] titles ;           // Notebook titles
        public Notepad(params Content[] Args)
        {
            content = Args.ToList();
            titles = new string[]{"Date", "Name", "Surname", "Organisation", "Position"}; // Initialize headers
        }

        /// <summary>
        /// Method for creating/adding records
        /// </summary>
        /// <param name="contentLine"></param>
        public void AddLine(Content contentLine)
        {
            content.Add(contentLine);
        }

        /// <summary>
        /// Method for loading data from a file
        /// </summary>
        /// <param name="path"></param>
        public void Load(string path)
        {
            //Clear the list before uploading a new file
            content.Clear();
            using (StreamReader read = new StreamReader(path))
            {
                while(!read.EndOfStream)
                {
                    string[] arg = read.ReadLine().Split(",");
                    AddLine(new Content(arg[0], arg[1], arg[2], arg[3], arg[4]));
                }
            }
        }

        /// <summary>
        /// Method for adding a row with your data
        /// </summary>
        /// <param name="arg"></param>
        public void AddItem(params string[] arg)
        {
            AddLine(new Content(arg[0], arg[1], arg[2], arg[3], arg[4]));
        }

        /// <summary>
        /// Method to print Block Note data to the screen
        /// </summary>
        public void PrintDB()
        {
            Console.WriteLine($"{titles[0],30} {titles[1],10} {titles[2],10} {titles[3],15} {titles[4],15}\n");
            for(int i = 0 ; i< content.Count; i++ )
            {
                Console.WriteLine(content[i].Print());
            }
            Console.WriteLine($"\n Number of elements saved to the List : {content.Count -1 }");
        }

        /// <summary>
        /// Method for detele  mumber of line 
        /// </summary>
        /// <param name="line"> number of line to delete</param>
        public void Del(int line)
        {
            content.RemoveAt(line-1);
        }

        /// <summary>
        /// Method to save data to the file 
        /// </summary>
        /// <param name="savepath"></param>
        public void Save(string savepath)
        {
            File.Delete(savepath); // Delete file if already exist ;
            string line = String.Format($"{titles[0],10} {titles[1],10} {titles[2],10} {titles[3],15} {titles[4],15}");
            File.AppendAllText(savepath, $"{line}\n");
            
            for(int i = 0 ; i<content.Count; i++)
            {
                line  = String.Format($"{content[i].Date},{content[i].Name},{content[i].Surname},{content[i].Org},{content[i].Position}");
                File.AppendAllText(savepath, $"{line}\n");
                
            }
        }

        /// <summary>
        /// Method to add  data from the file 
        /// </summary>
        /// <param name="addfile"></param>
        public void Merge (string addfile)
        {
            using (StreamReader read = new StreamReader(addfile))
            {
                while(!read.EndOfStream)
                {
                    string[] arg = read.ReadLine().Split(",");
                    AddLine(new Content(arg[0], arg[1], arg[2], arg[3], arg[4]));
                }
            }
        }

        /// <summary>
        /// Method to import from file considering the interval of time 
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <param name="importfile"> File path to import</param>
        public void Import(string date1, string date2, string importfile)
        {
            DateTime startDate = Convert.ToDateTime(date1);
            DateTime endDate = Convert.ToDateTime(date2);

            using (StreamReader read = new StreamReader(importfile))
            {
                while(!read.EndOfStream)
                {
                    string[] arg = read.ReadLine().Split(",");
                    DateTime arg0 = Convert.ToDateTime(arg[0]);

                    if(arg0 >= startDate && arg0 <= endDate)
                    {
                        AddLine(new Content(arg[0], arg[1], arg[2], arg[3], arg[4]));
                    }
                }
            }
        }


        //!help//

        /// <summary>
        /// Метод сортировки записей по выбранному полю
        /// </summary>
        /// <param name="line">Номер поля для редактирования</param>
        public void Sort(int line)
        {
            switch (line)
            {
                case 1:
                    content = content.OrderBy(e => e.Date)
                        .ThenBy(e => e.Name)
                        .ThenBy(e => e.Surname)
                        .ThenBy(e => e.Org)
                        .ThenBy(e => e.Position)
                        .ToList();
                    break;

                case 2:
                    content = content.OrderBy(e => e.Name)
                        .ThenBy(e => e.Date)
                        .ThenBy(e => e.Surname)
                        .ThenBy(e => e.Org)
                        .ThenBy(e => e.Position)
                        .ToList();
                    break;

                case 3:
                    content = content.OrderBy(e => e.Surname)
                        .ThenBy(e => e.Name)
                        .ThenBy(e => e.Date)
                        .ThenBy(e => e.Org)
                        .ThenBy(e => e.Position)
                        .ToList();
                    break;

                case 4:
                    content = content.OrderBy(e => e.Org)
                        .ThenBy(e => e.Name)
                        .ThenBy(e => e.Surname)
                        .ThenBy(e => e.Date)
                        .ThenBy(e => e.Position)
                        .ToList();
                    break;

                case 5:
                    content = content.OrderBy(e => e.Position)
                        .ThenBy(e => e.Name)
                        .ThenBy(e => e.Surname)
                        .ThenBy(e => e.Date)
                        .ThenBy(e => e.Org)
                        .ToList();
                    break;


                default:
                    break;
            }
        }


            /// <summary>
            /// Method to edit data 
            /// </summary>
            /// <param name="line"> Line to modify </param>
            public void Edit(int line)
            {
                Content temp = new Content(); 
                Console.WriteLine("Enter a new date");
                temp.Date = Console.ReadLine();
                Console.WriteLine("Enter a new name");
                temp.Name = Console.ReadLine();
                Console.WriteLine("Enter a new Surname");
                temp.Surname = Console.ReadLine();
                Console.WriteLine("Enter a new Organisation");
                temp.Org = Console.ReadLine();
                Console.WriteLine("Enter a new Position");
                temp.Position = Console.ReadLine();
                content[line -1] = temp ; // Throw the changed data from the variable back into the list

            }


    }
}
