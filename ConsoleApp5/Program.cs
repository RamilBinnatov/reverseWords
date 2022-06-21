using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write("enter name: ");
            a = Console.ReadLine();
            StringReverse(a);
        }

        static void StringReverse(string a)
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
        
    }
}
