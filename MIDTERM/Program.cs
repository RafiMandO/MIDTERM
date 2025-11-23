using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM
{
    internal class Program
    {
        static void Main(string[] args)
        {


            RegularPackage rp = new RegularPackage("Clothes", 10, 400);
            rp.CalculateCost(rp.Distance);
            rp.DisplayInfo();

            FastPackage fp = new FastPackage("Laptop", 3, 750);
            fp.CalculateCost(fp.Distance);
            fp.DisplayInfo();


            Console.ReadLine();


        }
    }
}
