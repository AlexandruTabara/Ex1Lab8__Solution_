using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Lab8__Solution_
{
    class VagonClasa1: VagonPersoane
    {
        public VagonClasa1(int nrPersoane, int anFabricatie)
            :base(nrPersoane, anFabricatie, 3500)
        {

        }
        public void PornesteAC()
        {
            Console.WriteLine("Porneste AC");
        }

        public void OpresteAC()
        {
            Console.WriteLine("Opreste AC");
        }
    }
}
