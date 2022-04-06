using System;
using System.IO;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using System.Text;
using System.IO.Compression;

namespace _06._Work_with_file
{
    class Program
    {
        /// <summary>
        ///     Take the number N  and return the number of different possible groupe .
        /// </summary>
        /// <param name="N"></param>
        /// <returns>M</returns>
        static int numberOfGroup(int N)
        {
            int M = (int)Math.Floor(Math.Log(N, 2)) + 1;
            return M;
        }

        /// <summary>
        ///    Take N argument and return  groups needeed 
        /// </summary>
        /// <param name="N"></param>
        /// <returns> the 2D  array (groups) </returns>
        static int[][] groupArray(int N)
        {

            int M = numberOfGroup(N);
            int[][] groups = new int[M][];
            groups[0] = new int[] { 1 };
            groups[1] = new int[N / 2];
            groups[1][0] = 2;

            for (int i = 3; i <= N; i++)
            {
                int group = 1;
                int j = 0;
                while (groups[group][j] != 0)
                {
                    if (i % groups[group][j] == 0)
                    {
                        group++;
                        j = 0;
                        if (groups[group] == null)
                        {
                            groups[group] = new int[N / 2];
                            break;
                        }
                    }
                    else
                    {
                        j++;
                    }

                }
                groups[group][j] = i;
            }

            // for(int i = 0 ; i <groups.Length;i++){
            //     for(int j = 0 ; j<groups[i].Length; j++){
            //         Console.Write(groups[i][j] + " ");
            //     }
            //     Console.WriteLine();
            //}
            return groups;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="path_to_write"></param>
        static void writeToFile(int[][] groups, string path_to_write)
        {

            using (StreamWriter streamWriter = new StreamWriter(path_to_write, false, Encoding.UTF8))
            {
                for (int i = 0; i < groups.Length; i++)
                {
                    for (int j = 0; j < groups[i].Length; j++)
                    {
                        if (groups[i][j] == 0)
                        {
                            break;
                        }
                        else
                        {
                            streamWriter.Write(groups[i][j] + " ");
                        }

                    }
                    streamWriter.WriteLine();
                }
            }

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="zipFileName"></param>
        static void zipCSVfile(string source, string zipFileName)
        {
            using (FileStream csvfile = new FileStream(source, FileMode.OpenOrCreate))
            {
                using (FileStream zipfile = File.Create(zipFileName))   // поток для записи сжатого файла
                {
                    // поток архивации
                    using (GZipStream compressedZipFile = new GZipStream(zipfile, CompressionMode.Compress))
                    {
                        csvfile.CopyTo(compressedZipFile); // копируем байты из одного потока в другой
                        Console.WriteLine("File {0} compression completed. From: {1} to: {2}.",
                                            source,
                                            csvfile.Length,
                                            zipfile.Length
                                            );
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            DateTime dateStart = DateTime.Now;

            Console.WriteLine("Enter the name of the file: ");
            string fileName = Console.ReadLine();
            fileName = fileName + ".txt";

            // Combine the current folder path with filename   
            string file = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            // check if file exist  to perform operation 
            int N;
            if (File.Exists(file))
            {
                N = Convert.ToInt32(File.ReadAllText(file));
            }
            else
            {
                Console.WriteLine("File does not exist!");
                return;
            }

            int M = numberOfGroup(N);
            int[][] groups = groupArray(N);

            string path_to_write = "result.txt";

            TimeSpan workTime = DateTime.Now - dateStart;
            writeToFile(groups, path_to_write);
            Console.WriteLine($"N = {N} M = {M}");
            Console.WriteLine($"Time Elasped: {workTime}");

            Console.WriteLine("Do you want to archive file? Y/N");
            string x = Console.ReadLine();

            if (x == "Y")
            {
                Console.WriteLine("Zipping Process......");
                zipCSVfile(path_to_write,"group.zip");
            }
            else if (x == "N")
            {
                Console.WriteLine("File is not zipped");
            }
            else
            {
                Console.WriteLine("Bad keyword");
                return;
            }

        }
    }

}