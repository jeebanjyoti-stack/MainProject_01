using System;
using System.IO;

namespace MainProject_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string path = "D:\\C# Programme\\MainProject\\MainProject_1\\MainProject_1\\";
                Console.WriteLine("Enter file name to read out form");
                string fname = Console.ReadLine();
                string fpath = path + fname;
                if (File.Exists(fpath))
                {
                    string[] lines = File.ReadAllLines(fpath);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else { Console.WriteLine("File does not exist"); }


            }
            catch (Exception ex)

            {
                Console.WriteLine("Error!!!" + ex.Message);
            }

            finally
            {
                Console.ReadKey();
            }
        }
    }
}
