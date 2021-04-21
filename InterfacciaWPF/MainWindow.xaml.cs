using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Figure;
using Politiche;

namespace InterfacciaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            c1.Nome = "c1";
            c2.Nome = "c2";
            contenitori.Add(c1);
            contenitori.Add(c2);
        }

        Contenitore c1 = new Contenitore();
        Contenitore c2 = new Contenitore();

        List<Contenitore> contenitori = new List<Contenitore>() {};

        string[] elementi = new string[] {"Contenitore","Selettore","Quadrato","Cerchio"};
        string[] politiche = new string[] {"Area Massima","Minimo Lati","Perimetro Minimo"};

        private void cmbElemento_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string s in elementi)
                cmbElemento.Items.Add(s);
        }

        private void cmbPolitica_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string s in politiche)
                cmbPolitica.Items.Add(s);
        }

        private void cmbContenitore1_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(Contenitore c in contenitori)
            {
                cmbContenitore1.Items.Add(c.Nome);
            }
        }

        private void cmbContenitore2_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Contenitore c in contenitori)
            {
                cmbContenitore2.Items.Add(c.Nome);
            }
        }

        private void cmbContenitore3_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Contenitore c in contenitori)
            {
                cmbContenitore3.Items.Add(c.Nome);
            }
        }
    }
}
