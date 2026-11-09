using System;
using System.Collections.Generic;
using System.Text;

namespace MuzeumApp
{
    internal class Mutargy
    {
        public string Azonosito { get; set; }
        protected int becsultErtek;
        public int BecsultErtek
        {
            get { return becsultErtek; }
            set
            {
                if (value <= 0)
                {
                    becsultErtek = 50000;
                }
                else becsultErtek = value;
            }
        }
        private static int osszesMutargySzama;
        public Mutargy(string a, int b)
        {
            Azonosito = a;
            BecsultErtek = b;
            osszesMutargySzama++;
        }

        public virtual int BiztositasDij()
        {
            return (int)(BecsultErtek * 0.02);
        }
        public override string ToString()
        {
            return $"Műtárgy: {Azonosito} | Becsült érték: {BecsultErtek} Ft | Biztosítás: {BiztositasDij()} Ft";
        }

    }
}
