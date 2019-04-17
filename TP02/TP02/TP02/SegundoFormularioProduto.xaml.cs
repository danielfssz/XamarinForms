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
	public partial class SegundoFormularioProduto : ContentPage
	{
		public SegundoFormularioProduto ()
		{
			InitializeComponent ();
		}

        public void RecebeProduto(Produto produto)
        {
            id.Text = produto.Id.ToString();
            descricao.Text = produto.Descricao;
            categoria.Text = produto.Categoria;
            quantidade.Text = produto.Quantidade.ToString();
            preco.Text = produto.Preco.ToString();
        }
    }
}