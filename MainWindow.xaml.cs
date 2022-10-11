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

namespace Tema3_Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Boton0RadioButton.Tag = 0;
            Boton1RadioButton.Tag = 1;
            Boton2RadioButton.Tag = 2;
            Boton3RadioButton.Tag = 3;
            Boton4RadioButton.Tag = 4;
            Boton5RadioButton.Tag = 5;
            Boton6RadioButton.Tag = 6;
            Boton7RadioButton.Tag = 7;
            Boton8RadioButton.Tag = 8;
            Boton9RadioButton.Tag = 9;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            CuadroTextBlock.Text += boton.Tag;
        }
    }
}
