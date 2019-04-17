using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02.ViewModel;
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
            //await Navigation.PushAsync(new EstiloDinamico());
            await Navigation.PushAsync(new RelogioView());
        }

        private async void EstiloEventTrigger(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloEventTrigger());
        }

        private async void EstiloListView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloListView());
        }

        private async void clicked_Produto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormularioProduto());
        }
    }
}
