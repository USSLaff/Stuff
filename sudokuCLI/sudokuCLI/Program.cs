using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace sudokuCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> data = File.ReadAllLines("feladvanyok.txt").ToList();
            

            int input = getUInput();
            int num = data.Count(x=>x.Length==Math.Pow(input,2));
            Console.WriteLine($"{num} darab {input} méretű pálya van.");


            Console.ReadKey();
        }
        public static int getUInput()
        {
            Console.WriteLine("Adj meg egy számot 4 és 9 között!");
            int input;
            int.TryParse(Console.ReadLine(), out input);
            return (input >= 4 && input <= 9) ? input : getUInput();
        }
    }

}
