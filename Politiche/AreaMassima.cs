using Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiche
{
    public class AreaMassima : PoliticaSelezione
    {
        public AreaMassima(double area) : base(area) { }

        public override bool Seleziona(Figura figura)
        {
            return figura.GetArea() <= soglia;
        }
    }
}
