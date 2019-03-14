using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnClickOk(object sender, EventArgs args)
        {
            string password = Password.Text;
            string id = Id.Text;

            if (String.IsNullOrEmpty(id))
            {
                await DisplayAlert("ID Nulo", "O ID não pode ser nulo!", "Fechar");
                return;
            }


            if (String.IsNullOrEmpty(password))
            {
                await DisplayAlert("Senha Nula", "A senha não pode ser nula!", "Fechar");
                return;
            }

            if (id == "admin" && password == "@dmin")
                await DisplayAlert("Login", "Login efetuado com sucesso!", "Continuar");
            else
                await DisplayAlert("Login", "Login e senha inválidos", "Fechar");

        }

        void OnClickLimpar(object sender, EventArgs args)
        {
            Id.Text = "";
            Password.Text = "";
            Id.Focus();
        }

        async void OnClickCreditos(object sender, EventArgs args)
        {
            await DisplayAlert("Créditos", "Desenvolvido por Daniel Souza e Nilson Alves", "Fechar");
        }
    }
}
