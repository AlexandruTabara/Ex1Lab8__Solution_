using System;
using System.Collections.Generic;

namespace Ex1Lab8__Solution_
{
    class Program
    {
        static void Main(string[] args)
        {
            Locomotiva lcmt = new Locomotiva();
            Tren tren = new Tren("ACC Lemne", lcmt);
            tren.AdaugaVagon(new VagonPersoane(150, 2019));
            tren.AdaugaVagon(new VagonClasa1(124, 2002));
            tren.AdaugaVagon(new VagonPersoane(66, 1999, 3001));

            tren.AdaugaVagon(new VagonMarfa(1997, 3500, TipMarfa.Carbuni, 150));
            tren.AdaugaVagon(new VagonMarfa(2002, 3000, TipMarfa.Cereale, 200));
            tren.AdaugaVagon(new VagonMarfa(2002, 3000, TipMarfa.Otel, 333));

            tren.PornesteDiNGara();

            Console.WriteLine("Dupa 100 de ore...");

            tren.OpresteInGara();

            Console.WriteLine($"Nr total de locuri {tren.NrLocuri}");
            List<Incarcatura> sumarMarfa = tren.GetSumarMarfa();

            foreach(Incarcatura incarcatura in sumarMarfa)
            {
                Console.WriteLine($"{incarcatura.TipMarfa} - {incarcatura.Cantitate}");
            }

        }
    }
}
