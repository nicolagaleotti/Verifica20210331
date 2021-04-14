using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public abstract class Figura
    {
        protected double valore;
        protected int numeroLati;

        public Figura(double valore, int numeroLati)
        {
            this.valore = valore;
            this.numeroLati = numeroLati;
        }

        public abstract string GetDescrizione();

        public abstract double GetPerimetro();

        public abstract double GetArea();

        public abstract int GetNumeroLati();
    }
}
