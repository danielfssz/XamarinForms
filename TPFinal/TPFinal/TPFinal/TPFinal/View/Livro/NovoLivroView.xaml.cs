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
        }
        public void OnSalvar(object sender, EventArgs args)
        {
            TPFinal.Model.Livro livro = new
            TPFinal.Model.Livro
            {
                Nome = txtNome.Text,
                NomeAutor = txtNomeAutor.Text,
                EmailAutor = txtEmailAutor.Text,                
                ISBN = isbn
            };
            Limpar();
            App.LivroModel.SalvarLivro(livro);
            Navigation.PopAsync();
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