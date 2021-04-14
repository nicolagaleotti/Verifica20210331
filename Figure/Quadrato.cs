using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Quadrato : Figura
    {
        public Quadrato(double lato) : base(lato) { }

        public override string GetDescrizione()
        {
            return $"Quadrato di lato {valore}";
        }

        public override double GetPerimetro()
        {
            return 4 * valore;
        }

        public override double GetArea()
        {
            return valore * valore;
        }
    }
}
