using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFAula01
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new ContentPage
            {
                Content = new Label
                {
                    Text = "Hello World Xamarim Forms0",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                },
            };
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
