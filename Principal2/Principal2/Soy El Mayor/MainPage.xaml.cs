using PoblacionComp2.Soy_el_Mayor;
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

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkID=390556

namespace Principal2.Soy_El_Mayor
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public int time = 30;
        Pais paisAleatorio1;
        Pais paisAleatorio2;
        Paises paises;
        DispatcherTimer dispatch = new DispatcherTimer();
        public int cntA = 0;
        public int b = 0;

        public MainPage()
        {
            this.InitializeComponent();

            paises = new Paises();
            dispatch.Interval = new TimeSpan(0, 0, 1);
            dispatch.Start();
            dispatch.Tick += dispatch_Tick;

            this.imgVerdadero.Tapped += imgVerdadero_Tapped;
            this.imgFalso.Tapped += imgFalso_Tapped;
        }

        void imgFalso_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (paisAleatorio2.Poblacion > paisAleatorio1.Poblacion)
                cntA++;
            Generar();
        }

        void imgVerdadero_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (paisAleatorio1.Poblacion > paisAleatorio2.Poblacion)
                cntA++;
            Generar();
        }

        private void dispatch_Tick(object sender, object e)
        {
            TimeProgress.Value += 1;
            ContadorAciertos.Text = cntA + "";
            time--;
            if (time < 0)
            {
                dispatch.Stop();
                this.sonidito.Stop();
                Frame.Navigate(typeof(Principal2.Anagrama.Puntaje), cntA);
            }
        }

        /// <summary>
        /// Se invoca cuando esta página se va a mostrar en un objeto Frame.
        /// </summary>
        /// <param name="e">Datos de evento que describen cómo se llegó a esta página.
        /// Este parámetro se usa normalmente para configurar la página.</param>
        /// 

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            time = 30;
            cntA = 0;
            int max = 30;
            TimeProgress.Maximum = max;
            TimeProgress.Value = 0;

            Generar();
        }

        private void Generar()
        {
            Random rnd = new Random();
            int PosicionPais1 = rnd.Next(0, 12);
            paisAleatorio1 = paises.GetPais(PosicionPais1);
            Random pao = new Random();
            int PosicionPais2 = pao.Next(0, 12);
            while (PosicionPais1 == PosicionPais2)
            {
                PosicionPais2 = pao.Next(0, 12);
            }
            paisAleatorio2 = paises.GetPais(PosicionPais2);
            txtPaisesComparados.Text = paisAleatorio1.Nombre + " > " + paisAleatorio2.Nombre;
        }
    }
}
