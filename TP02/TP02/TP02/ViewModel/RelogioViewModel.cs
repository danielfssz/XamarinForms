using System;
using System.ComponentModel;
using TP02.Model;

namespace TP02.ViewModel
{
    class RelogioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _tempo;

        public string Tempo
        {
            get { return _tempo; }
            set
            {
                _tempo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Tempo)));
            }
        }

        public static DateTime GetTempoUTC()
        {
            DateTime dateTime = DateTime.UtcNow;
            TimeZoneInfo horaBrasilia = TimeZoneInfo.FindSystemTimeZoneById("America/Buenos_Aires");
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, horaBrasilia);
        }
    }
}