using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\User\Desktop\PP2\week2\Task4\ConsoleApp1\Input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter wr = new StreamWriter(fs);

            string line = "blajfakjsfklajdasd";

            wr.WriteLine(line);
            wr.Close();
            fs.Close();

            //FileInfo fi = new FileInfo(@"C:\Users\DzSee\Documents\pp2\w2\Lab2\for_T4_create.txt");
            File.Copy(@"C:\Users\User\Desktop\PP2\week2\Task4\ConsoleApp1\Input.txt", @"C:\Users\User\Desktop\PP2\week2\Task4\ConsoleApp1\Sanzhar\copy.txt");

            File.Delete(@"C:\Users\User\Desktop\PP2\week2\Task4\ConsoleApp1\Input.txt");



        }
    }
}