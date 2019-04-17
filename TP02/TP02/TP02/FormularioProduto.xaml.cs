using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormularioProduto : ContentPage
	{
		public FormularioProduto ()
		{
			InitializeComponent ();
		}

        private async void Enviar_clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Id = int.Parse(id.Text);
            produto.Descricao = descricao.Text;
            produto.Categoria = categoria.Text;
            produto.Quantidade = int.Parse(quantidade.Text);
            produto.Preco = decimal.Parse(preco.Text);

            SegundoFormularioProduto sFormulario = new SegundoFormularioProduto();
            sFormulario.RecebeProduto(produto);

            await Navigation.PushAsync(sFormulario);
        }
    }
}