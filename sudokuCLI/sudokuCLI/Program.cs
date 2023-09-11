using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Globalization;
using System.Xml.Schema;

namespace sudokuCLI
{
    internal class Program
    {
        public static Random rnd = new Random();  
        static void Main(string[] args)
        {
            //3. Feladat
            List<string> data = File.ReadAllLines("feladvanyok.txt").ToList();
            Console.WriteLine($"3. Feladat: Beolvasva {data.Count} feladvány");

            //4.
            int input = getUInput();
            int size = (int)Math.Pow(input, 2);
            int num = data.Count(x=>x.Length==size);
            Console.WriteLine($"{num} darab {input} méretű pálya van.");

            //5.
            List<string> filtered = new List<string>();
            foreach (string item in data)
            {
                if (item.Length==size)
                {
                    filtered.Add(item);
                }
            }
            string pick = filtered[rnd.Next(0, filtered.Count)];
            Console.WriteLine($"5. Feladat: A kiválasztot feladvány:\n{pick}");

            //6.
            int fillCount = pick.Count(x => !x.Equals('0'));
            Console.WriteLine($"6. Feladat: A feladvány kitöltöttsége: {Math.Round((fillCount/(float)size)*100)}%");

            //7.
            Console.WriteLine($"7. Feladat: A feladvány kirajzolva: ");
            Feladvany f = new Feladvany(pick);
            f.Kirajzol();

            //8.
            File.WriteAllLines($"sudoku{input}.txt",filtered);
            Console.ReadKey();
        }
        public static int getUInput()
        {
            Console.Write("4. Feladat: Kérem a feladvány méretét [4..9]: ");
            int input;
            int.TryParse(Console.ReadLine(), out input);
            return (input >= 4 && input <= 9) ? input : getUInput();
        }
    }
}