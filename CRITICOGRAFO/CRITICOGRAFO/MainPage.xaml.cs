using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace CRITICOGRAFO
{
    public partial class MainPage : ContentPage
    {
        private string generoSeleccionado = string.Empty;

        public MainPage()
        {
            InitializeComponent();
        }

        private void GeneroCambiado(object sender, CheckedChangedEventArgs e)
        {
            if (sender == Hombre && e.Value)
            {
                generoSeleccionado = "Hombre";
            }
            else if (sender == Mujer && e.Value)
            {
                generoSeleccionado = "Mujer";
            }
        }

        private void CriticarButton_Clicked(object sender, EventArgs e)
        {
            string estadoCheckboxes = ObtenerEstadoCheckboxes();

            info.Text = $"{Nombre.Text} ES {estadoCheckboxes}";
        }

        private string ObtenerEstadoCheckboxes()
        {
            string estadoCheckboxes = string.Empty;
            string aux = string.Empty;
            if (generoSeleccionado == "Hombre")
            {
                if (Alto.IsChecked)
                    estadoCheckboxes += " ALTO";
                if (Feo.IsChecked)
                    estadoCheckboxes += " FEO";
                if (Listo.IsChecked)
                    estadoCheckboxes += " LISTO";
                if (Extravagante.IsChecked)
                    estadoCheckboxes += " EXTRAVAGANTE";
                if (Raro.IsChecked)
                    estadoCheckboxes += " RARO";
                if (Grande.IsChecked)
                    estadoCheckboxes += " GRANDE";
            }
            else if (generoSeleccionado == "Mujer")
            {
                if (Alto.IsChecked)
                    estadoCheckboxes += " ALTA";
                if (Feo.IsChecked) 
                    estadoCheckboxes += " FEA";
                if (Listo.IsChecked)
                    estadoCheckboxes += " LISTA";
                if (Extravagante.IsChecked)
                    estadoCheckboxes += " EXTRAVAGANTE";
                if (Raro.IsChecked)
                    estadoCheckboxes += " RARA";
                if (Grande.IsChecked)
                    estadoCheckboxes += " GRANDE";
            }

            if (generoSeleccionado == "Mujer")
            {
                string[] subs = estadoCheckboxes.Split(' ');

                for (int i = 1; i < subs.Length; i++)
                {
                    if(i == 1)
                    {
                        aux += " " + subs[i];

                    }
                    else if (i == subs.Length -1 )
                    {
                        aux += " Y "+ subs[i]+". ";
                    }
                  
                    else if (i != subs.Length)
                    {
                        aux +=  ", "+ subs[i];

                    }
                    //JUAN ES, FEA, Y LISTA.
                }
            }
            else if(generoSeleccionado == "Hombre")
            {
                string[] subs = estadoCheckboxes.Split(' ');

                for (int i = 1; i < subs.Length; i++)
                {
                    if (i == 1)
                    {
                        aux += " " + subs[i];

                    }
                    else if (i == subs.Length - 1)
                    {
                        aux += " Y " + subs[i] + ". ";
                    }

                    else if (i != subs.Length)
                    {
                        aux += ", " + subs[i];

                    }
                    //JUAN ES, FEA, Y LISTA.
                }

            }
            return aux;

        }
       
       

    }
    

}
