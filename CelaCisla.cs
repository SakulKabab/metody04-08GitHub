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
    }
}
