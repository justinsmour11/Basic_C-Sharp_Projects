using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a number:");
            File.WriteAllText(@"C:\Users\justi\Desktop\myDoc.txt", Console.ReadLine());
            string text = File.ReadAllText(@"C:\Users\justi\Desktop\myDoc.txt");
            Console.WriteLine(text);
            Console.Read();
        }
    }
}
