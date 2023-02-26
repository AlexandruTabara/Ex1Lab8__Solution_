using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Lab8__Solution_
{
    class VagonMarfa : Vagon
    {
        private TipMarfa tipMarfa;
        private int cantitatea;
        public VagonMarfa(int anFabricatie, int masa, TipMarfa tipMarfa, int cantitatea)
                   :base(anFabricatie,masa)
        {
            this.tipMarfa = tipMarfa;
            this.cantitatea = cantitatea;
        }
        
        public TipMarfa TipMarfa { get { return this.tipMarfa; } }
        public int Cantitatea { get { return this.cantitatea; } }

    }
}
