using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPFinal.View.Livro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovoLivroView : ContentPage
    {
        private int isbn = 0;

        public object LivroModel { get; }

        public NovoLivroView()
        {
            InitializeComponent();
        }
        public NovoLivroView(int ISBN)
        {
            InitializeComponent();
            var livro = App.LivroModel.GetLivro(ISBN);
            txtNome.Text = livro.Nome;
            txtNomeAutor.Text = livro.NomeAutor;
            txtEmailAutor.Text = livro.EmailAutor;
            isbn = livro.ISBN;
            //latitude = livro.Latitude;
            //longitude = livro.Longitude;
        }
        public async void OnSalvar(object sender, EventArgs args)
        {
            try
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;

                var p = await locator.GetPositionAsync(TimeSpan.FromSeconds(20));

                TPFinal.Model.Livro livro = new
                TPFinal.Model.Livro
                {
                    Nome = txtNome.Text,
                    NomeAutor = txtNomeAutor.Text,
                    EmailAutor = txtEmailAutor.Text,
                    ISBN = isbn,
                    Latitude = p.Latitude,
                    Longitude = p.Longitude
                };
                Limpar();
                App.LivroModel.SalvarLivro(livro);
                Navigation.PopToRootAsync();
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro : ", ex.Message, "OK");
            }
        }
        public void OnCancelar(object sender, EventArgs args)
        {
            Limpar();
            Navigation.PopAsync();
        }
        private void Limpar()
        {
            txtNome.Text = txtEmailAutor.Text = txtNomeAutor.Text = string.Empty;         
        }


    }
}