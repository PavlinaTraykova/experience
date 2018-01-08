using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BiletiZaMacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            var priceMeter = double.Parse(Console.ReadLine());
            var weightMeter = double.Parse(Console.ReadLine());

            var mreja = a*(b+ 2 * 0.30 ) ;

            var priceMreja = (h + 2 * 0.30);
            var kvadratura = mreja * h;
            var obshtoTeglo = kvadratura * weightMeter;
            Console.WriteLine(mreja);
            Console.WriteLine($"{priceMreja:f3}");
            Console.WriteLine($"{obshtoTeglo:f3}");

        }
    }
}
