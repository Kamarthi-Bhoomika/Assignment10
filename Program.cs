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

                    string path = "D:\\";
                    string fname;
                    Console.WriteLine("Enter file name: ");
                    fname = Console.ReadLine();
                    string fpath = path + fname;

                    void CreateFile()
                    {
                        File.Create(fpath);
                        Console.WriteLine("File created!!");
                    }

                    void ReadFile()
                    {
                        string[] lines = File.ReadAllLines(fpath);
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                    }

                    void AppendToFile()
                    {
                        StreamWriter sw = File.AppendText(fpath);
                        Console.WriteLine("Enter text to append: ");
                        string str = Console.ReadLine();
                        sw.WriteLine(str);
                        sw.Dispose();
                        sw.Close();
                        Console.WriteLine("Text Appended Successfully!!");
                    }

                    void DeleteFile()
                    {
                        File.Delete(fpath);
                        Console.WriteLine("File deleted permanently");
                    }

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
                                    CreateFile();
                                }
                                break;
                            }
                        case 2:
                            {
                                if (File.Exists(fpath))
                                {
                                    ReadFile();
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
                                    AppendToFile();
                                }
                                else
                                {
                                    Console.WriteLine("File not Exist");
                                }
                                break;
                            }
                        case 4:
                            {
                                if (File.Exists(fpath))
                                {
                                    DeleteFile();
                                }
                                else
                                {
                                    Console.WriteLine("File not exist");
                                }
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
                    Console.WriteLine("Do you want to continue? Enter y to continue:  ");
                    Do = char.Parse(Console.ReadLine());
                }
            }
            Console.ReadKey();
        }
    }
}
