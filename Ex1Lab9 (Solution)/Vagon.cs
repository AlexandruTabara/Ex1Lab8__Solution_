using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Lab8__Solution_
{
    class Vagon
    {
        private int anFabricatie;
        private int masa;

        public Vagon(int anFabricatie, int masa)
        {
            this.anFabricatie = anFabricatie;
            this.masa = masa;
        }

        public TipMarfa TipMarfa { get; internal set; }
        public int Cantitatea { get; internal set; }
    }
}
