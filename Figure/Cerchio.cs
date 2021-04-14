using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Cerchio : Figura
    {
        public Cerchio(double raggio) : base(raggio, 0) { }

        public override string GetDescrizione()
        {
            return $"Cerchio di raggio {valore}";
        }

        public override double GetPerimetro()
        {
            return Math.PI * 2 * valore;
        }

        public override double GetArea()
        {
            return Math.PI * valore * valore;
        }

        public override int GetNumeroLati()
        {
            return numeroLati;
        }
    }
}
