using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Around.Modele
{
    class KlientIPModel
    {
        public string AdresIP { get; private set; }
        public DateTime OstatniaAktualizacja { get; private set; }

        public KlientIPModel(string ip, DateTime lastUpdated)
        {
            AdresIP = ip;
            OstatniaAktualizacja = lastUpdated;
        }

        public bool CzyModelJestAktualny()
        {
            var teraz = DateTime.Now;
            var różnica = (teraz - OstatniaAktualizacja).TotalSeconds;

            if (różnica > 5)
                return false; //Obiekt jest nieaktualny
            else
                return true; //Obiekt jest aktualny
        }

        public void Aktualizuj()
        {
            OstatniaAktualizacja = DateTime.Now;
        }
    }
}
