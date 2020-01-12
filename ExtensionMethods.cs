using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab9
{
    public static class ExtensionMethods
    {
        public static (int wynik, int reszta) DzielenieZReszta(this int liczba, int dzielnik)
        {
            return (liczba / dzielnik, liczba % dzielnik);
        }
        public static int ZliczLitery(this string tekst, char litera)
        {
             return tekst.Where(x => x.Equals(litera)).Count();
        }
        public static int ZliczLitery(this string tekst, char litera, bool caseInvariant = true)
        {
            if (caseInvariant)
            {
                tekst = tekst.ToLower();
                litera = char.ToLower(litera);
            }
            return tekst.ZliczLitery(litera);
        }
        public static bool CzyDlaNiepelnoletnich(this PrzedzialWiekowy przedzial)
        {
            if(przedzial < PrzedzialWiekowy.Dorosli)
            {
                Console.WriteLine("Dla niepelnoletnich");
                return true;
            }
            return true;
        }
    }
}