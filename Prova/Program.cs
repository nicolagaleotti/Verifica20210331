using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure;
using Politiche;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Contenitore c = new Contenitore();
            Cerchio f1 = new Cerchio(10);
            Quadrato f2 = new Quadrato(2);
            Quadrato f3 = new Quadrato(10);
            c.AggiungiFigura(f1);
            c.AggiungiFigura(f2);
            c.AggiungiFigura(f3);
            Selettore s = new Selettore();

            Console.WriteLine("Figure in Contenitore:");
            Console.WriteLine($"- {f1.GetDescrizione()} (p : {f1.GetPerimetro()}; a : {f1.GetArea()})");
            Console.WriteLine($"- {f2.GetDescrizione()} (p : {f2.GetPerimetro()}; a : {f2.GetArea()})");
            Console.WriteLine($"- {f3.GetDescrizione()} (p : {f3.GetPerimetro()}; a : {f3.GetArea()})");

            Console.WriteLine();

            Console.WriteLine("POLITICA: PerimetroMinimo(15)");
            s.ImpostaPolitica(new PerimetroMinimo(15));
            s.ScansionaContenitore(c);
            Console.WriteLine(s.ElencaFigure());
            s.Svuota();

            Console.WriteLine("POLITICA: AreaMassima(15)");
            s.ImpostaPolitica(new AreaMassima(15));
            s.ScansionaContenitore(c);
            Console.WriteLine(s.ElencaFigure());
            s.Svuota();

            Console.ReadLine();
        }
    }
}
