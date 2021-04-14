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
            //2 feladat
            string[] sorok = File.ReadAllLines("fuvar.csv");
            List<Fuvar> fuvarok = new List<Fuvar>();

            foreach (string sor in sorok.Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));
            }

            //3 feladat
            int N = fuvarok.Count;
            Console.WriteLine($"3 feladat: {N} fuvar");

            //4 feladat
            int fuvarDb = 0;
            double bevetel = 0;
            foreach (Fuvar fuvar in fuvarok)
            {
                if (fuvar.Id == 6185)
                {
                    fuvarDb++;
                    bevetel += fuvar.Viteldij + fuvar.Borravalo;
                }
            }
            Console.WriteLine($"4 feladat: {fuvarDb} fuvar alatt {bevetel}$");

            //5 feladat

            Console.ReadLine();
        }
    }
}
