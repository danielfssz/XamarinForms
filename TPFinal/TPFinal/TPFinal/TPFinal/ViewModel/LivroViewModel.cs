using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPFinal.Model;

namespace TPFinal.ViewModel
{
    public class LivroViewModel
    {
        public LivroViewModel() { }
        #region Propriedades
        public string Nome { get; set; }
        public string NomeAutor { get; set; }
        public string EmailAutor { get; set; }

        public int ISBN { get; set; }
        public List<Livro> Livros
        {
            get
            {
                return App.LivroModel.GetLivros().ToList();
            }
        }
        #endregion
    }
}
