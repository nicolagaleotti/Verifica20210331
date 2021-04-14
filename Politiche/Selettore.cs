using Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiche
{
    public class Selettore : Contenitore
    {
        private PoliticaSelezione politica = null;

        public void ScansionaContenitore(Contenitore contenitore)
        {
            if (politica != null)
            {
                foreach (Figura f in contenitore.GetFigure())
                    if (politica.Seleziona(f))
                        AggiungiFigura(f);
            }
        }

        public void ImpostaPolitica(PoliticaSelezione politica)
        {
            this.politica = politica;
        }
    }
}
