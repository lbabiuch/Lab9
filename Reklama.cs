using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    public class Reklama
    {
        public string Tekst;
        public PrzedzialWiekowy przedzialWiekowy;
        public Zainteresowania zainteresowania;

        public Reklama(string tekst, PrzedzialWiekowy przedzialWiekowy, Zainteresowania zainteresowania)
        {
            Tekst = tekst;
            this.przedzialWiekowy = przedzialWiekowy;
            this.zainteresowania = zainteresowania;
        }

        public void Test()
        {
            if (przedzialWiekowy.HasFlag(PrzedzialWiekowy.Dzieci))
            {
                Console.WriteLine("Reklama dla dzieci");
            }
            if (przedzialWiekowy >= PrzedzialWiekowy.Dorosli)
            {
                Console.WriteLine("Reklama dla doroslych");
            }
        }
    }
}
