using System;

namespace _07._Structures_and_introduction_to_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
        
            #region DZ
                /// Develop a diary.
                /// In the diary, implement the possibility
                /// - creations +
                /// - deletions +
                /// - react +
                /// records
                ///
                /// A separate entry must have at least five fields (date, first name, last name, organization, position)
                ///
                /// Implement the feature
                /// - Load data from file +
                /// - Uploading data to a file +
                /// - Adding data to the current diary from the selected file +
                /// - Import records for the selected date range +
                /// - Ordering diary entries by the selected field +
            #endregion

            string path = "data.csv";
            string savepath = "savedata.csv";
            string addfile = "add_data.csv";
            string  importfile = "importfile.csv";
            int line ;
            string date, date1, date2, name, surname, org, position;

            Notepad notepad = new Notepad(new Content());

                        while (true)
            {
                Console.WriteLine("MENU:\n");
                Console.WriteLine("1 - Load File ");
                Console.WriteLine("2 - Save data to the file");
                Console.WriteLine("3 - adding data to the current notebook from a file");
                Console.WriteLine("4 - create record");
                Console.WriteLine("5 - deleting an entry");
                Console.WriteLine("6 - post editing");
                Console.WriteLine("7 - import records by selected date range");
                Console.WriteLine("8 - sort records by selected field");
                Console.WriteLine("9 - display notepad on screen");
                Console.WriteLine("0 - output");
                int key = int.Parse(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        notepad.Load(path);
                        Console.Clear();
                        Console.WriteLine("File loaded\n\n");
                        notepad.PrintDB();
                        Console.ReadLine();
                        break;

                    case 2:
                        notepad.Save(savepath);
                        Console.Clear();
                        Console.WriteLine("File saved\n\n");
                        notepad.PrintDB();
                        Console.ReadLine();
                        break;

                    case 3:
                        notepad.Merge(addfile);
                        Console.Clear();
                        Console.WriteLine("Data added\n\n");
                        notepad.PrintDB();
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Enter date(format yy-mm-dd): ");
                        date = Console.ReadLine();
                        Console.WriteLine("Enter name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Surname: ");
                        surname = Console.ReadLine();
                        Console.WriteLine("Enter Organisation ");
                        org = Console.ReadLine();
                        Console.WriteLine("Enter Position: ");
                        position = Console.ReadLine();
                        notepad.AddItem(date, name, surname, org, position);
                        Console.Clear();
                        Console.WriteLine("Data added\n\n");
                        notepad.PrintDB();
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Line number to delete");
                        line = int.Parse(Console.ReadLine());
                        notepad.Del(line);
                        Console.Clear();
                        Console.WriteLine("Line deleted\n\n");
                        notepad.PrintDB();
                        Console.ReadLine();
                        break;

                    case 6:
                        Console.WriteLine("Line to modify data");
                        line = int.Parse(Console.ReadLine());
                        notepad.Edit(line);
                        Console.Clear();
                        Console.WriteLine("Data modified\n\n");
                        notepad.PrintDB();
                        Console.ReadLine();
                        break;

                    case 7:
                        Console.WriteLine("Enter start date (format yy-mm-dd):");
                        date1 = Console.ReadLine();
                        Console.WriteLine("Enter end date (format yy-mm-dd):");
                        date2 = Console.ReadLine();
                        notepad.Import(date1, date2, importfile);
                        Console.Clear();
                        Console.WriteLine("Data imported\n\n");
                        notepad.PrintDB();
                        Console.ReadLine();
                        break;

                    case 8:
                        Console.WriteLine("Sort by different order : choose between(1-5)");
                        line = int.Parse(Console.ReadLine());
                        notepad.Sort(line);
                        Console.Clear();
                        Console.WriteLine("Data sorted\n\n");
                        notepad.PrintDB();
                        Console.ReadLine();
                        break;

                    case 9:
                        Console.Clear();
                        notepad.PrintDB();
                        Console.ReadLine();
                        break;

                    case 0:
                        return;

                    default:
                        break;
                }
        }
    }
}
}