using System;
using System.Collections.Generic;
using System.Text;

namespace MuzeumApp
{
    internal class Festmeny : Mutargy
    {
        public int KorEvekben { get; set; }
        public Festmeny(string a, int b, int k) : base (a,b)
        {
            KorEvekben = k;
        }
        public override int BiztositasDij()
        {
            return (base.BiztositasDij()) + (KorEvekben*500);
        }
        public override string ToString()
        {
            return base.ToString() + $" | Kor : {KorEvekben} év";
        }
    }
}
