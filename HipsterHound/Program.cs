using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HipsterHound
{
    class Program
    {
        public static string musicPath = @"c:\Temp\hurr";


        static void Main(string[] args)
        {
            // List existing music files, store them in the DB, and create a playlist out of them

            if (!Directory.Exists(musicPath))
            { 
                foreach (var file in Directory.GetFiles(musicPath))
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("The directory {0} does not exist or is inaccessible");
            }
        }    
    }
}
