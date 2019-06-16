using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPFinal.View.Livro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        LivroViewModel vmLivro;
        public MainPage()
        {
            vmLivro = new LivroViewModel();
            BindingContext = vmLivro;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            vmLivro = new LivroViewModel();
            BindingContext = vmLivro;
            base.OnAppearing();
        }
        private void OnNovo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovoLivroView());
        }
        private void OnLivroTapped(object sender, ItemTappedEventArgs args)
        {
            var selecionado = args.Item as TPFinal.Model.Livro;
            DisplayAlert("Livro selecionado", "Livro: " + selecionado.ISBN, "OK");
        }
    }
}