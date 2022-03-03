using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metody04_08GitHub
{
    class CelaCisla
    {
        public static string Mocnina(int a, int b)
        {
            int vypocet = 1;
            string vysledek = vypocet.ToString();
            if (b != 0)
            {
                if (b < 0)
                {
                    b = -b;
                    for (int i = 0; i < b; ++i)
                    {
                        vypocet *= a;
                    }
                    vysledek = "1/(" + vypocet + ")";
                }
                else
                {
                    for (int i = 0; i < b; ++i)
                    {
                        vypocet *= a;
                    }
                    vysledek = vypocet.ToString();
                }
            }
            return vysledek;
        }
        public static int Faktorial(int x)
        {
            int vysledek = 1;
            if (x >= 0)
            {
                for (int i = 1; i <= x; ++i)
                {
                    vysledek *= i;
                }
            }
            return vysledek;
        }
        public static int LichCifSoucet(int x)
        {
            int soucet = 0;
            while (x > 0)
            {
                int cifra = x % 10;
                if (cifra % 2 != 0)
                {
                    soucet += cifra;
                }
                x = x / 10;
            }
            return soucet;
        }
        public static bool JePrvocislo(int x)
        {
            bool jePrvocislo = x != 1;
            for (int delitel = 2; delitel <= Math.Sqrt(x) && jePrvocislo; ++delitel)
            {
                if (x % delitel == 0) jePrvocislo = false;
            }
            return jePrvocislo;
        }
        public static int PocSudDel(int x)
        {
            int pocSudDel = 0;
            for (int i = 1; i <= x; ++i)
            {
                if (x % i == 0)
                {
                    if (i % 2 == 0) ++pocSudDel;
                }
            }

            return pocSudDel;
        }
    }
}
