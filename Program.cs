using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Do = 'y';
            while(Do == 'y')
            {
                try
                {
                    Console.WriteLine("***************************");
                    Console.WriteLine("1. File Creation");
                    Console.WriteLine("2. File Reading");
                    Console.WriteLine("3. File Appending");
                    Console.WriteLine("4. File Deletion");
                    Console.WriteLine("Enter your choice: ");
                    int ch = int.Parse(Console.ReadLine());

                    string path = "D:\\Mphasis\\.net\\Day8\\";
                    string fname;
                    Console.WriteLine("Enter file name: ");
                    fname = Console.ReadLine();
                    string fpath = path + fname;

                    switch (ch)
                    {
                        case 1:
                            {
                                if (File.Exists(fpath))
                                {
                                    Console.WriteLine("File already exist!!");
                                }
                                else
                                {
                                    File.Create(fpath);
                                    Console.WriteLine("File created!!");
                                }
                                Console.WriteLine();
                                break;
                            }
                        case 2:
                            {
                                if (File.Exists(fpath))
                                {
                                    string[] lines = File.ReadAllLines(fpath);
                                    foreach (string line in lines)
                                    {
                                        Console.WriteLine(line);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("File not exist");
                                }
                                
                                break;
                            }
                        case 3:
                            {
                                if (File.Exists(fpath))
                                {
                                    StreamWriter sw = File.AppendText(fpath);
                                    sw.WriteLine("Welcome to .net File handling");
                                    sw.Dispose();
                                    sw.Close();
                                    Console.WriteLine("Text Appended Successfully!!");

                                }
                                else
                                {
                                    Console.WriteLine("File not Exist");
                                }
                                Console.WriteLine();
                                break;
                            }
                        case 4:
                            {
                                if (File.Exists(fpath))
                                {
                                    File.Delete(fpath);
                                    Console.WriteLine("File deleted permanently");
                                }
                                else
                                {
                                    Console.WriteLine("File not exist");
                                }
                                Console.WriteLine();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Choice");
                                break;
                            }
                    }

                }
                catch (Exception ex) { Console.WriteLine("Error!! " + ex.Message); }
                finally
                {
                    Console.WriteLine("Do you want to continue? ");
                    Do = char.Parse(Console.ReadLine());
                }
            }
            Console.ReadKey();
        }
    }
}
