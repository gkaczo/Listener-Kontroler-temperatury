using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerTemperatury
{
    class Czujnik : IObserwowany
    {
        string id;
        public Czujnik(string id)
        {
            this.id = id;
        }

        public delegate void StatusUpdate(int info, string czujnikID);

        public event StatusUpdate OnStatusUpdate = null;

        public void AddObserwator(IObserwator kontroler)
        {
            // dodajemy zdarzenie dla obserwatora
            OnStatusUpdate += new StatusUpdate(kontroler.UpdateInfo);
        }

        public void DeleteObserwator(IObserwator kontroler)
        {
            // usuwamy zdarzenie dla obserwatora
            OnStatusUpdate -= new StatusUpdate(kontroler.UpdateInfo);
        }

        //wersja uproszczona wywolania zdarzenia dla okreslonego watku
        public void CheckTemperature(int temp)
        {
            OnStatusUpdate?.Invoke(temp,id);
        }

    }
}
