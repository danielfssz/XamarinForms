using System;
using System.Collections.Generic;
using System.Text;
using TP02.Model;

namespace TP02.ViewModel
{
    class RelogioViewModel
    {
        public DateTime Tempo { get; set; }

        public RelogioViewModel(Relogio relogio)
        {
            this.Tempo = relogio.Tempo;
        }

        public static Relogio GetTempo()
        {
            var relogio = new Relogio()
            {
                Tempo = new DateTime()
            };
            return relogio;
        }
    }
}
