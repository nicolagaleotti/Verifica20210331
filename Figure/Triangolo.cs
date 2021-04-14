using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Triangolo : Figura
    {
        private double lato2;
        private double lato3;
        private double altezza;

        public Triangolo(double lato1, double lato2, double lato3, double altezza) : base(lato1) 
        {
            this.lato2 = lato2;
            this.lato3 = lato3;
            this.altezza = altezza;
        }

        public override double GetArea()
        {
            return valore * altezza / 2;
        }

        public override string GetDescrizione()
        {
            return $"Triangolo di lato {valore}, {lato2}, {lato3} e altezza {altezza}";
        }

        public override double GetPerimetro()
        {
            return valore + lato2 + lato3;
        }
    }
}
