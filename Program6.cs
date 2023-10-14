using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._4
{
    internal class Program6
    {
        public static void Main(string[] args) {
            string dir = Directory.GetCurrentDirectory();
            string fileNmae = dir + "\\data.txt";
            if(File.Exists(fileNmae) ) {
                Console.WriteLine(fileNmae+" exists");
            }
            else
            {
                Console.WriteLine(fileNmae + " not exists");
                    }
        using (StreamWriter wrt=File.CreateText(fileNmae))
            {
                wrt.WriteLine("This is line 1");
                wrt.WriteLine("This is line 2");
                wrt.WriteLine("This is line 3");
                wrt.WriteLine("This is line 4");
                wrt.WriteLine("This is line 5");
            }
            Console.WriteLine(fileNmae +" is created.");
            string[] lenes=File.ReadAllLines(fileNmae);
            foreach(string str in lenes)
            {
                Console.WriteLine(str);
            }
            string text=File.ReadAllText(fileNmae);
            Console.WriteLine(text);
            File.Delete(fileNmae);
            Console.WriteLine(fileNmae+" was deleted.");
        }
    }
}
