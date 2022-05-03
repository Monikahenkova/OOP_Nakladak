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

namespace OOP_Nakladak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        nakladak Volvo;
        nakladak Fiat;
        
        public MainWindow()
        {
            InitializeComponent();

            Volvo = new nakladak();
            Volvo.Znacka = "Volvo";

            Fiat = new nakladak();
            Fiat.Znacka = "Fiat";
        }

        public void Zobraz1(nakladak Volvo, TextBox textBox)
        {
            Nakladak1.Text = Volvo.Znacka + "\n";
            Nakladak1.Text += "Nosnost: " + Volvo.Nosnost.ToString() + "\n";
            Nakladak1.Text += "Nalozeno: " + Volvo.Nalozeno.ToString() + "\n";
            Nakladak1.Text += "Objem nadrze: " + Volvo.Objemnadrze.ToString() + "\n";
            Nakladak1.Text += "Spotreba: " + Volvo.Spotreba.ToString() + "\n";
            Nakladak1.Text += "Palivo: " + Volvo.Palivo.ToString() + "\n";
            Nakladak1.Text += "Vzdalenost" + Volvo.Vzdalenost.ToString() + "\n";
        }


        public void Zobraz2(nakladak Fiat, TextBox textBox)
        {
            Nakladak2.Text = Volvo.Znacka + "\n";
            Nakladak2.Text += "Nosnost: " + Volvo.Nosnost.ToString() + "\n";
            Nakladak2.Text += "Nalozeno: " + Volvo.Nalozeno.ToString() + "\n";
            Nakladak2.Text += "Objem nadrze: " + Volvo.Objemnadrze.ToString() + "\n";
            Nakladak2.Text += "Spotreba: " + Volvo.Spotreba.ToString() + "\n";
            Nakladak2.Text += "Palivo: " + Volvo.Palivo.ToString() + "\n";
            Nakladak2.Text += "Vzdalenost" + Volvo.Vzdalenost.ToString() + "\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Volvo.Nalozit();
            Zobraz1(Volvo, txt1);

        }
    }
}
