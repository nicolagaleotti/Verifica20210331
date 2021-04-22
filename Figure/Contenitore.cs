using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Contenitore
    {
        public string Nome { get; set; }
        public int ID { get; set; }

        protected List<Figura> figure = new List<Figura>();
        protected List<Contenitore> contenitori = new List<Contenitore>();


        public Contenitore() { }

        public void AggiungiFigura(Figura figura)
        {
            figure.Add(figura);
        }

        public string ElencaFigure()
        {
            string s = "";
            foreach (Figura f in figure)
                s += $"{f.GetDescrizione()}\n";
            return s;
        }

        public List<Figura> GetFigure()
        {
            return figure;
        }

        public void AggiungiContenitore(Contenitore contenitore)
        {
            contenitori.Add(contenitore);
        }

        public List<Contenitore> GetContenitori()
        {
            return contenitori;
        }

        public void Svuota()
        {
            figure.Clear();
        }
    }
}
