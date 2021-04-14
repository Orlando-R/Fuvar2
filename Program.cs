using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("fuvar.csv");
            List<Fuvar> fuvarok = new List<Fuvar>();

            foreach (string sor in sorok.Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));
            }

            int N = fuvarok.Count;
            Console.WriteLine($"3 feladat: {N} fuvar");

            Console.ReadLine();
        }
    }
}
