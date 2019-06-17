using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TPFinal.Model;

namespace TPFinal.View.Livro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailLivro : ContentPage
    {
        private Model.Livro livro;
        public DetailLivro(Model.Livro _livro)
        {
            InitializeComponent();
            livro = _livro;
        }

        private async void GoToLocation(object sender, EventArgs e)
        {
            try
            {
                var location = new Location(livro.Latitude, livro.Longitude);
                var options = new MapLaunchOptions
                {
                    Name = "Localização do Cadastro"
                };
                await Map.OpenAsync(location, options);
            }
            catch (Exception ex)
            {
                // Não foi possivel acessar o mapa
                await DisplayAlert("Erro : ", ex.Message, "Ok");
            }
        }

        private void GoToEdit(object sender, EventArgs e)
        {
            var nvLivro = new NovoLivroView(livro.ISBN);
            Navigation.PushAsync(nvLivro);
        }

        private async void GoToDelete(object sender, EventArgs e)
        {
            await ShowMessage("Deseja realmente excluir?", "Excluir", "Ok", async () =>
            {
                livro.RemoverLivro(livro.ISBN);
                Navigation.PopToRootAsync();
            });
            
        }

        public async Task ShowMessage(string message,
            string title,
            string buttonText,
            Action afterHideCallback)
        {
            await DisplayAlert(
                title,
                message,
                buttonText);

            afterHideCallback?.Invoke();
        }
    }
}