using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Lab8__Solution_
{
    class Incarcatura
    {
        public int Cantitate { get; set; }
        public TipMarfa TipMarfa { get; set; }

        public Incarcatura(int Cantitate, TipMarfa tipMarfa)
        {
            this.Cantitate = Cantitate;
            this.TipMarfa = tipMarfa;
        }

        public Incarcatura(TipMarfa tipMarfa)
        {
            TipMarfa = tipMarfa;
        }
    }
}
