using System;
using System.Windows;

namespace AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random seed;
        int numeroAAcertar;

        public MainWindow()
        {
            InitializeComponent();

            seed = new Random();
            numeroAAcertar = seed.Next(0, 101);
        }


        private void Comprobar_Click(object sender, RoutedEventArgs e)
        {
            int numeroEnviado = int.Parse(NumeroTextBox.Text);
            if (numeroEnviado == numeroAAcertar) {
                MensajeTextBlock.Text = "Has acertado";
            }
            else if(numeroEnviado > numeroAAcertar)
            {
                MensajeTextBlock.Text = "Te has pasado";
            }
            else
            {
                MensajeTextBlock.Text = "Te has quedado corto";
            }
        }

        private void Reiniciar_Click(object sender, RoutedEventArgs e)
        {
            seed = new Random();
            numeroAAcertar = seed.Next(0, 101);

            MensajeTextBlock.Text = "Introduce un número:";
            NumeroTextBox.Text = "";
        }
    }
}
