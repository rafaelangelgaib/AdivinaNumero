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

namespace AdivinaNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numero;
        public MainWindow()
        {
            InitializeComponent();
            GenerarNumero();
        }
        private void GenerarNumero()
        {
            Random rand = new Random();
            numero = rand.Next(0, 101);

        }

        private void Comprobar_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(Numerousuario.Text);
            if (input == numero) {
                Respuesta.Text = "!Has acertado¡";
            }
            else if (input < numero){
                Respuesta.Text = "Te has quedado corto";
            }
            else { Respuesta.Text = "Te has pasado"; }
        }

        private void Reiniciar_Click(object sender, RoutedEventArgs e)
        {
            GenerarNumero();
            Respuesta.Text = "";
            Numerousuario.Text = "";
        }
    }
}
