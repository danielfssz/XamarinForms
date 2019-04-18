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
    public partial class FormularioContato : ContentPage
    {
        
        public FormularioContato()
        {
            InitializeComponent();
        }

        private async void SalvarContato(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = Nome.Text,
                Idade = int.Parse(Idade.Text),
                Profissao = Profissao.Text,
                Pais = Pais.Text
            };

            ListaContatosView.listaContatos.Add(contato);

            await Navigation.PopAsync();
        }

        private async void DetalheContato(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = Nome.Text,
                Idade = int.Parse(Idade.Text),
                Profissao = Profissao.Text,
                Pais = Pais.Text
            };

            var detalheContato = new DetalhePage();
            detalheContato.BindingContext = contato;
            await Navigation.PushAsync(detalheContato);
        }
    }
}