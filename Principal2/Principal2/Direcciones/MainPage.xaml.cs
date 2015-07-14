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
using Principal2.Direcciones;
using Direcciones.DataModel;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Graphics.Display;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Principal2.Direcciones
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public int time = 30;
        Pais paisAleatorio;
        string PaisBuscado;
        Paises paises;
        DispatcherTimer dispatch = new DispatcherTimer();
        public int cntA = 0;
        public int nivel = 1;

        public MainPage()
        {
            this.InitializeComponent();

            paises = new Paises();
            dispatch.Interval = new TimeSpan(0, 0, 1);
            dispatch.Start();
            dispatch.Tick += dispatch_Tick;

            this.Norte.Tapped += Norte_Tapped;
            this.Sur.Tapped += Sur_Tapped;
            this.Este.Tapped += Este_Tapped;
            this.Oeste.Tapped += Oeste_Tapped;

            this.NorEste.Tapped += NorEste_Tapped;
            this.NorOeste.Tapped += NorOeste_Tapped;
            this.SurEste.Tapped += SurEste_Tapped;
            this.SurOeste.Tapped += SurOeste_Tapped;

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        void SurOeste_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (paisAleatorio.SurOeste == PaisBuscado)
                cntA += 1;
            Generar();
        }

        void SurEste_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (paisAleatorio.SurEste == PaisBuscado)
                cntA += 1;
            Generar();
        }

        void NorOeste_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (paisAleatorio.NorOeste == PaisBuscado)
                cntA += 1;
            Generar();
        }

        void NorEste_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (paisAleatorio.NorEste == PaisBuscado)
                cntA += 1;
            Generar();
        }

        void Oeste_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (paisAleatorio.Oeste == PaisBuscado)
                cntA += 1;
            Generar();
        }

        void Este_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (paisAleatorio.Este == PaisBuscado)
                cntA += 1;
            Generar();
        }

        void Sur_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (paisAleatorio.Sur == PaisBuscado)
                cntA += 1;
            Generar();
        }

        void Norte_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (paisAleatorio.Norte == PaisBuscado)
                cntA += 1;
            Generar();
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
            nivel = 1;
            int max = 30;
            TimeProgress.Maximum = max;
            TimeProgress.Value = 0;
            
            Generar();
        }

     

        private void Generar()
        {
            Random RndNumber = new Random();
            int PosicionPais = RndNumber.Next(0, 3 * nivel);
            paisAleatorio = paises.getCountries(PosicionPais);
            imgPaisBuscado.Source = new BitmapImage(new Uri(this.BaseUri, paisAleatorio.DirImagen));
            PaisBuscado = Asignador();
            txtPaisBuscado.Text = "Donde está " + PaisBuscado + "?";
            nombrePaisBuscado.Text = paisAleatorio.Nombre;
        }

        private string Asignador()
        {
            Random num = new Random();
            int x = num.Next(1, 9);
            string a = string.Empty;
            switch (x)
            {
                case 1:
                    a = paisAleatorio.Norte;
                    break;
                case 2:
                    a = paisAleatorio.Sur;
                    break;
                case 3:
                    a = paisAleatorio.Este;
                    break;
                case 4:
                    a = paisAleatorio.Oeste;
                    break;
                case 5:
                    a = paisAleatorio.NorEste;
                    break;
                case 6:
                    a = paisAleatorio.SurEste;
                    break;
                case 7:
                    a = paisAleatorio.NorOeste;
                    break;
                case 8:
                    a = paisAleatorio.SurOeste;
                    break;
                default:
                    return string.Empty;
            }

            if (a == string.Empty)
                return Asignador();
            else
                return a;
        }

        void dispatch_Tick(object sender, object e)
        {
            TimeProgress.Value += 1;
            ContadorAciertos.Text = cntA + "";
            time--;
            if (time < 0)
            {
                dispatch.Stop();
                this.sonidito.Stop();
                Frame.Navigate(typeof(Principal2.Anagrama.Puntaje),cntA);
            }

            if (TimeProgress.Value == 10 * (nivel + 1))
                nivel++;
        }
    }
}
