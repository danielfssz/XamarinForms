using System;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.ViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelogioView : ContentPage
    {
        RelogioViewModel vmRelogio;

        public RelogioView()
        {
            try
            {  
                vmRelogio = new RelogioViewModel();

                BindingContext = vmRelogio;
            }
            catch (Exception)
            {
                throw;
            }
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                vmRelogio.Tempo = RelogioViewModel.GetTempoUTC().ToString("dd/MM/yyyy HH:mm:ss");
                return true;
            });
        }
    }
}