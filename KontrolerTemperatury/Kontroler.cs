using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerTemperatury
{
    class Kontroler : IObserwator
    {
        private string name;
        public Kontroler(string name)
        {
            this.name = name;
        }

        public void UpdateInfo(int temp, string czujnikID)
        {
            if (temp >= 100)
            {
                Console.WriteLine("{0}: Alarm! temperatura {1}: {2}",name,czujnikID,temp);
            }
            else
            {
                Console.WriteLine("{0}: temperatura {1}: {2}", name, czujnikID, temp);
            }
        }
    }
}
