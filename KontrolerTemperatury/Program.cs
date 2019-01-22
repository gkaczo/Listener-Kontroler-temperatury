using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerTemperatury
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontroler k1 = new Kontroler("kontroler1");
            Kontroler k2 = new Kontroler("kontroler2");

            Czujnik c1 = new Czujnik("c1");
            c1.AddObserwator(k1);
            c1.AddObserwator(k2);

            Czujnik c2 = new Czujnik("c2");
            c2.AddObserwator(k2);

            c1.CheckTemperature(150);
            c2.CheckTemperature(50);

            Console.ReadLine();
        }
    }
}
