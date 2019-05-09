using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MonkeyHub.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Descricao { get; set;}

        public MainViewModel()
        {
            Descricao = "Olá Mundo, eu estou aqui!";

            Task.Delay(3000).ContinueWith(t =>
            {
                Descricao = "Meu texto mudou!";

                if (PropertyChanged != null)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Descricao)));
                }
            });
                
        }

        
    }
}
