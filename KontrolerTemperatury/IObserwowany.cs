using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerTemperatury
{
    interface IObserwowany
    {
        void AddObserwator(IObserwator obserwator);
        void DeleteObserwator(IObserwator obserwator);

        //void SendInfo(int tmp);

        void CheckTemperature(int tmp);
    }
}
