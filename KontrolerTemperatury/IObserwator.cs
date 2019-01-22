using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerTemperatury
{
    interface IObserwator
    {

        void UpdateInfo(int info, string czujnikID);
    }
}
