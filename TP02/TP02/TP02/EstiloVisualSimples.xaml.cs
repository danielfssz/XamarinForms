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
    public partial class EstiloVisualSimples : ContentPage
    {
        public EstiloVisualSimples()
        {
            InitializeComponent();
        }

        private async void VoltarMenu(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            LabelValue.Text = (slider.Value * 100).ToString();
        }
    }
}