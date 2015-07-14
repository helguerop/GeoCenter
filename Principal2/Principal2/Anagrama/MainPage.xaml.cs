using Principal2.Anagrama.Clases;
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
    public sealed partial class MainPage : Page
    {
        ListaPaises L1 = new ListaPaises();
        Random r = new Random();
        DispatcherTimer t = new DispatcherTimer();
        int index = 0, puntos = 0;
        public MainPage()
        {
            this.InitializeComponent();
            t.Interval = new TimeSpan(0, 0, 1);
            //t.Start();
            SetPais();
            t.Tick += t_Tick;
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        void t_Tick(object sender, object e)
        {
            if (prgb.Value > 0)
            {
                prgb.Value--;
            }
            else
            {
                t.Stop();
                txtb.IsEnabled = false;
                this.sonidito.Stop();
                Frame.Navigate(typeof(Puntaje), puntos);
            }

        }

        private void SetPais()
        {
            t.Start();
            index = r.Next(0, L1.ListaDePaises.Count);
            Pais p = L1.ListaDePaises[index];
            txtb.IsEnabled = true;
            p.GetAnagrama();
            DataContext = p;
            prgb.Value = 15;
            txtb.Text = "";
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        /// 
        //DisplayOrientations onEntryOrientations;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SetPais();
            puntos = 0;
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        
        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            SetPais();
            puntos = 0;
        }

        private void txtb_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text.Trim().Equals(L1.ListaDePaises[index].Nombre))
            {
                t.Stop();
                SetPais();
                puntos++;
                txt_puntos.Text = puntos.ToString();
            }
        }
    }
}
