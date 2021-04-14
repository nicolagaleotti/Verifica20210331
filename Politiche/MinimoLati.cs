using Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiche
{
    public class MinimoLati : PoliticaSelezione
    {
        public MinimoLati(int lati) : base(lati) { }

        public override bool Seleziona(Figura figura)
        {
            return figura.GetNumeroLati() >= soglia;
        }
    }
}
