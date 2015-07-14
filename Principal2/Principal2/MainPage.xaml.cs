using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Principal2.Usuarios;
using Windows.Graphics.Display;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Principal2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Manejador.ListaU = new ListaUsuarios();

            this.GeoQuiz.Tapped += GeoQuiz_Tapped;
            this.DondeEstaMiVecino.Tapped += DondeEstaMiVecino_Tapped;
            this.GeoGramas.Tapped += GeoGramas_Tapped;
            this.SoyElMayor.Tapped += SoyElMayor_Tapped;

            this.Punuaciones.Tapped += Punuaciones_Tapped;

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        void Punuaciones_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Puntuaciones));
            this.sonidito.Stop();
        }

        void SoyElMayor_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Principal2.Soy_El_Mayor.Instrucciones));
            this.sonidito.Stop();
        }

        void GeoGramas_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Principal2.Anagrama.Instrucciones));
            this.sonidito.Stop();
        }

        void DondeEstaMiVecino_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Principal2.Direcciones.Intrucciones));
            this.sonidito.Stop();
        }

        void GeoQuiz_Tapped(object sender, TappedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        //DisplayOrientations onEntryOrientations;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }
    }
}
