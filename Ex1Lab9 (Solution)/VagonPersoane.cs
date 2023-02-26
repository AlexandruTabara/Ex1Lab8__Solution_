using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Lab8__Solution_
{
    class VagonPersoane : Vagon
    {
        private int nrPersoane;
        public VagonPersoane(int nrPersoane, int anFabricatie)
               :base(anFabricatie, 3000)
        {
            this.nrPersoane = nrPersoane;
        }
        //Supraincarcarea constructorului
        public VagonPersoane(int nrPersoane, int anFabricatie, int masa)
              : base(anFabricatie, masa)
        {
            this.nrPersoane = nrPersoane;
        }

        public void InchideUsile()
        {
            Console.WriteLine("Inchide usile");
        }

        public void DeschideUsile()
        {
            Console.WriteLine("Deschide usile");
        }

        public int NrPersoane { get { return this.nrPersoane; } }
    }
}
