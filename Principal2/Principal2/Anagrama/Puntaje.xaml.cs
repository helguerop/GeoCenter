using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Principal2.Anagrama
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Puntaje : Page
    {
        int p = 0;
        public Puntaje()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        /// 
        ///DisplayOrientations onEntryOrientations;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //onEntryOrientations = DisplayInformation.AutoRotationPreferences;
            //Windows.Graphics.Display.DisplayInformation.AutoRotationPreferences = Windows.Graphics.Display.DisplayOrientations.Portrait;
            p = (int)e.Parameter;
            txt_points.Text = p.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Usuarios.Manejador.ListaU.AddUsuario(new Usuarios.Usuario() { Nombre = txt_nombre.Text, Puntos = int.Parse(txt_points.Text) });
        }

        private void ToggleMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void ToggleMenuFlyoutItem2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Principal2.MainPage));
        }



    }
}
