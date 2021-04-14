using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Rettangolo : Figura
    {
        private double altezza;

        public Rettangolo(double lato, double altezza) : base(lato, 4)
        {
            this.altezza = altezza;
        }

        public override double GetArea()
        {
            return valore * altezza;
        }

        public override string GetDescrizione()
        {
            return $"Rettangolo di base {valore} e altezza {altezza}";
        }

        public override int GetNumeroLati()
        {
            return numeroLati;
        }

        public override double GetPerimetro()
        {
            return (valore + altezza) * 2;
        }
    }
}
