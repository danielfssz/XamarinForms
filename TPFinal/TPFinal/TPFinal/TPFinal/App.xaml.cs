using System;
using TPFinal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPFinal
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new View.Livro.MainPage());
        }

        static Livro livroModel;
        public static Livro LivroModel
        {
            get
            {
                if (livroModel == null)
                {
                    livroModel = new Livro();
                }
                return livroModel;
            }
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
