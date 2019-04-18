using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaContatosView : ContentPage
	{
        public static List<Contato> listaContatos = new List<Contato>();

        public ListaContatosView ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            MessagingCenter.Send(this, "OnAppearing");
            base.OnAppearing();
            lv4.ItemsSource = listaContatos;            
        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private async void CriarContato(object sender, EventArgs e)
        {   
            await Navigation.PushAsync(new FormularioContato());
        }
    }
}