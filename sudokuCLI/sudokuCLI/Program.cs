using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sudokuCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = File.ReadAllLines("feladvanyok.txt");
            Console.WriteLine();
            Console.WriteLine("Adj meg egy számot 4 és 9 között!");
            int input = getUInput();



            Console.ReadKey();
        }
        public static int getUInput()
        {
            return 0;
        }
    }

}
