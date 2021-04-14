﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Contenitore
    {
        protected List<Figura> figure = new List<Figura>();

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

        public void Svuota()
        {
            figure.Clear();
        }
    }
}