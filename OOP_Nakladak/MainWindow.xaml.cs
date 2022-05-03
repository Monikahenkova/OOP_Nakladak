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

        public void Zobraz(nakladak nakladak, )
    }
}
