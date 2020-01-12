using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    class Program
    {
        static void Main()
        {
            #region Extensions
            /*
            Console.WriteLine("Dzielenie z reszta");
            int liczba = Convert.ToInt32(Console.ReadLine());
            int wynik, resztaZDzielenia;
            (wynik, resztaZDzielenia) = liczba.DzielenieZReszta(3);
            Console.WriteLine($"{liczba}/3 = {wynik}r{resztaZDzielenia}");

            Console.WriteLine("Liczenie liter");
            Console.WriteLine("Podaj slowo:");
            string tekst = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Podaj litere");
            char litera = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"{tekst.ZliczLitery(litera)}");
            */
            #endregion

            Reklama reklama = new Reklama("Kup Teraz!", PrzedzialWiekowy.Dzieci, Zainteresowania.Elektronika);
            reklama.Test();

            Reklama reklama2 = new Reklama("Kup Teraz!", PrzedzialWiekowy.Dorosli | PrzedzialWiekowy.Starsi, Zainteresowania.Elektronika);
            reklama2.Test();
        }
    }
}
