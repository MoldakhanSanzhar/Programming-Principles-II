using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool Check(string s)
        {
            /*
            char[] c = s.ToCharArray();
            Array.Reverse(c);
            string rev = new string(c);
            */

            string rev = new string(s.ToCharArray().Reverse().ToArray());

            if (rev == s)
                return true;
            else return false;
        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\User\Desktop\PP2\week2\Task1\ConsoleApp1\Input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();           
            sr.Close();
            fs.Close();

            if (Check(s))
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}