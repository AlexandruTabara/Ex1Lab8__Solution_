using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Lab8__Solution_
{
    class Tren
    {
        private string nume;
        private Locomotiva locomotiva;
        private List<Vagon> vagoane = new List<Vagon>();

        public Tren(string nume, Locomotiva locomotiva)
        {
            this.nume = nume;
            this.locomotiva = locomotiva;
        }
        
        public int NrLocuri
        {
            get
            {
                int nrLocuri = 0;
                foreach (Vagon vagon in vagoane)
                {
                    if (vagon is VagonPersoane)
                    {
                        nrLocuri += (vagon as VagonPersoane).NrPersoane;
                    }
                }

                 return nrLocuri;

            }
        }
        public void AdaugaVagon(Vagon vagon)
        {
            vagoane.Add(vagon);

            //if (vagon is VagonPersoane)
            //{
            //    nrLocuri += (vagon as VagonPersoane).NrPersoane;
            //}
        }

        public List<Incarcatura> GetSumarMarfa()
        {
            List<Incarcatura> rezultat = new List<Incarcatura>();

            foreach(Vagon vagon in vagoane){
                if (!(vagon is VagonMarfa))
                { 
                    continue; 
                }

                Vagon deMarfa = vagon as VagonMarfa;

                Incarcatura incarcatura = null;
                foreach(Incarcatura incarcaturaExistenta in rezultat)
                {
                    if(incarcaturaExistenta.TipMarfa == deMarfa.TipMarfa)

                    {
                        incarcatura = incarcaturaExistenta;
                        break;
                    }
                }

                if (incarcatura != null)
                {
                    incarcatura.Cantitate += deMarfa.Cantitatea;
                }
                else
                {
                    incarcatura = new Incarcatura(deMarfa.TipMarfa);
                    incarcatura.Cantitate = deMarfa.Cantitatea;

                    rezultat.Add(incarcatura);
                }
            }

            return rezultat;
        }
        public void PornesteDiNGara()
        {
            foreach (Vagon vagon in vagoane)
            {
                if (vagon is VagonClasa1)
                {
                    VagonClasa1 vagonClasa1 = vagon as VagonClasa1;
                    vagonClasa1.InchideUsile();
                    vagonClasa1.PornesteAC();
                }
                else if (vagon is VagonPersoane)
                {
                    VagonPersoane vagonDePersoane = vagon as VagonPersoane;
                    vagonDePersoane.InchideUsile();
                }
            }
            locomotiva.Porneste();
        }

        public void OpresteInGara()
        {
            foreach (Vagon vagon in vagoane)
            {
                if (vagon is VagonClasa1)
                {
                    VagonClasa1 vagonClasa1 = vagon as VagonClasa1;
                    vagonClasa1.DeschideUsile();
                    vagonClasa1.OpresteAC();
                }
                else if (vagon is VagonPersoane)
                {
                    VagonPersoane vagonDePersoane = vagon as VagonPersoane;
                    vagonDePersoane.DeschideUsile();
                }
                locomotiva.Opreste();
            }
        }
    }
}

