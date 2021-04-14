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

        public Figura(double valore)
        {
            this.valore = valore;
        }

        public abstract string GetDescrizione();

        public abstract double GetPerimetro();

        public abstract double GetArea();
    }
}
