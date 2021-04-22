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
        }

        List<Contenitore> contenitori = new List<Contenitore>() { };

        string[] elementi = new string[] { "Contenitore", "Selettore", "Quadrato", "Cerchio" };
        string[] politiche = new string[] { "Area Massima", "Minimo Lati", "Perimetro Minimo" };

        private void cmbElemento_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string s in elementi)
                cmbElemento.Items.Add(s);
        }

        private void cmbElemento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbElemento.SelectedIndex == -1 || cmbElemento.SelectedIndex == 0 || cmbElemento.SelectedIndex == 1)
            {
                txtValore.IsEnabled = false;
            }
            else if (cmbElemento.SelectedIndex == 2 || cmbElemento.SelectedIndex == 3)
            {
                txtValore.IsEnabled = true;
            }
        }

        private void cmbPolitica_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string s in politiche)
                cmbPolitica.Items.Add(s);
        }

        private void btnCrea_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbElemento.SelectedIndex == -1)
                    throw new Exception("Selezionare un elemento!");
                else if (cmbElemento.SelectedIndex == 0 || cmbElemento.SelectedIndex == 1)
                {
                    if (txtNome.Text == "")
                        throw new Exception("Immettere un nome!");

                    if (cmbElemento.SelectedIndex == 0)
                    {
                        Contenitore c = new Contenitore();
                        c.Nome = txtNome.Text;
                        c.ID = int.Parse(txtID.Text);
                        txtID.Text = (int.Parse(txtID.Text) + 1).ToString();
                        if (cmbContenitore1.SelectedIndex != -1)
                            contenitori[cmbContenitore1.SelectedIndex].AggiungiContenitore(c);
                        contenitori.Add(c);
                    }
                    if (cmbElemento.SelectedIndex == 1)
                    {
                        Selettore s = new Selettore();
                        s.Nome = txtNome.Text;
                        s.ID = int.Parse(txtID.Text);
                        txtID.Text = (int.Parse(txtID.Text) + 1).ToString();
                        if (cmbContenitore1.SelectedIndex != -1)
                            contenitori[cmbContenitore1.SelectedIndex].AggiungiContenitore(s);
                        contenitori.Add(s);
                    }

                    cmbContenitore1.Items.Add(contenitori[contenitori.Count - 1].Nome);
                    cmbContenitore2.Items.Add(contenitori[contenitori.Count - 1].Nome);
                    cmbContenitore3.Items.Add(contenitori[contenitori.Count - 1].Nome);
                }
                else if (cmbElemento.SelectedIndex == 2 || cmbElemento.SelectedIndex == 3)
                {
                    if (txtValore.Text == "")
                        throw new Exception("Immettere un valore!");
                    if (txtNome.Text == "")
                        throw new Exception("Immettere un nome!");
                    if (cmbContenitore1.SelectedIndex == -1)
                        throw new Exception("Selezionare un contenitore!");

                    if (cmbElemento.SelectedIndex == 2)
                    {
                        Quadrato q = new Quadrato(double.Parse(txtValore.Text));
                        q.Nome = txtNome.Text;
                        contenitori[cmbContenitore1.SelectedIndex].AggiungiFigura(q);
                    }
                    if (cmbElemento.SelectedIndex == 3)
                    {
                        Cerchio c = new Cerchio(double.Parse(txtValore.Text));
                        c.Nome = txtNome.Text;
                        contenitori[cmbContenitore1.SelectedIndex].AggiungiFigura(c);
                    }
                }

                cmbElemento.SelectedIndex = -1;
                txtValore.Text = "";
                txtNome.Text = "";
                cmbContenitore1.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStampaPolitiche_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbPolitiche.Items.Clear();

                if (cmbPolitica.SelectedIndex == -1)
                    throw new Exception("Selezionare una politica di selezione!");
                if (txtParametro.Text == "")
                    throw new Exception("Immettere un parametro!");
                if (cmbContenitore2.SelectedIndex == -1)
                    throw new Exception("Selezionare un contenitore da scansionare!");

                PoliticaSelezione politica = null;
                if (cmbPolitica.SelectedIndex == 0)
                    politica = new AreaMassima(double.Parse(txtParametro.Text));
                if (cmbPolitica.SelectedIndex == 1)
                    politica = new MinimoLati(int.Parse(txtParametro.Text));
                if (cmbPolitica.SelectedIndex == 2)
                    politica = new PerimetroMinimo(double.Parse(txtParametro.Text));

                Selettore s = new Selettore();
                s.ImpostaPolitica(politica);
                s.ScansionaContenitore(contenitori[cmbContenitore2.SelectedIndex]);

                foreach (Figura f in s.GetFigure())
                {
                    lbPolitiche.Items.Add(f.GetDescrizione());
                }

                cmbPolitica.SelectedIndex = -1;
                txtParametro.Text = "";
                cmbContenitore2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStampaContenitori_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
