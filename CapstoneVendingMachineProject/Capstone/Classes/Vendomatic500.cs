using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
    public static class Vendomatic500
    {
        public static void VendomaticAscii()
        {
            string filePath = "Vendomatic500ascii.txt";
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string vendomaticAscii = sr.ReadLine();
                        Console.WriteLine(vendomaticAscii);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Vendomatic500ascii.txt. Please exit the console and copy file from Capstone.etc folder to Captone.bin.Debug folder.");
                Environment.Exit(0);
            }
        }
    }
}
