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

        public string Stampa()
        {
            return $"({Nome}{StampaContenitori()}{StampaFigure()})";
        }

        private string StampaContenitori()
        {
            string s = $"";
            foreach (Contenitore c in contenitori)
            {
                s += $"{c.Stampa()}";
            }
            return s;
        }

        private string StampaFigure()
        {
            string s = $"";
            foreach (Figura f in figure)
            {
                if (f == figure[0] && f == figure[figure.Count - 1])
                    s += $"[{f.Nome}]";
                else
                {
                    if (f == figure[0])
                        s += $"[{f.Nome},";
                    if (f != figure[figure.Count - 1])
                        s += $"{f.Nome},";
                    if (f == figure[figure.Count - 1])
                        s += $"{f.Nome}]";
                }
            }
            return s;
        }
    }
}
