using Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiche
{
    public abstract class PoliticaSelezione
    {
        protected double soglia;

        public PoliticaSelezione(double soglia)
        {
            this.soglia = soglia;
        }

        public abstract bool Seleziona(Figura figura);
    }
}
