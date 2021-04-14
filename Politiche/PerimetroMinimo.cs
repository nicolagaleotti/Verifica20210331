using Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiche
{
    public class PerimetroMinimo : PoliticaSelezione
    {
        public PerimetroMinimo(double perimetro) : base(perimetro) { }

        public override bool Seleziona(Figura figura)
        {
            return figura.GetPerimetro() >= soglia;
        }
    }
}
