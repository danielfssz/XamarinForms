using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void EstiloPadrao(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloVisualSimples());           
        }

        private async void EstiloDinamico(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloDinamico());
        }
    }
}
