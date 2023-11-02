using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progFrazione
{
    class Frazione
    {
        public int Numeratore { get; set; }
        public int Denominatore { get; set; }


        public Frazione(int numeratore,int denominatore)  
        {
            Numeratore= numeratore;
            Denominatore= denominatore;
        }


        public Frazione(Frazione altraFr)
        {
            Numeratore= altraFr.Numeratore;
            Denominatore = altraFr.Denominatore;
        }
         
        public void semplificaFrazione()
        {
            int mcd=MCD(Numeratore,Denominatore);
            Numeratore/= mcd;
            Denominatore/= mcd;  
        }
        public Frazione Somma(Frazione altraFr)
        {
            int NuovoNumeratore= Numeratore*altraFr.Denominatore+altraFr.Numeratore*Denominatore;
            int NuovoDenominatore = Denominatore * altraFr.Numeratore + altraFr.Denominatore * Numeratore;
            return new Frazione(NuovoNumeratore, NuovoDenominatore);
        }

        public Frazione Sottrazione(Frazione altraFr)
        {
            int NuovoNumeratore = Numeratore * altraFr.Denominatore - altraFr.Numeratore * Denominatore;
            int NuovoDenominatore = Denominatore * altraFr.Numeratore - altraFr.Denominatore * Numeratore;
            return new Frazione(NuovoNumeratore, NuovoDenominatore);
        }
    }
    }
}
