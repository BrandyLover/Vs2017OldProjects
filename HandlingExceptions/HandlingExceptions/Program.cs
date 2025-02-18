﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Exampl.txt");
                Console.WriteLine(content);
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine("Make sure the name of the file is named correctly: Exampl.txt");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(@"Make sure the file is in the directory of : C:\Lesson22\Exampl.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                // Code to finalize
                // Setting objects to null
                //
            }
            Console.ReadLine();
        }
    }
}
