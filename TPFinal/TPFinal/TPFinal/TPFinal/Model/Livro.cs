using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPFinal.Data;
using Xamarin.Forms;

namespace TPFinal.Model
{
    public class Livro
    {
        public Livro()
        {
            database = DependencyService.Get<ISQLite>().GetConexao();
            database.CreateTable<Livro>();
        }
        #region Propriedades
        [PrimaryKey, AutoIncrement]
        public int ISBN { get; set; }
        public string Nome { get; set; }
        public string NomeAutor { get; set; }
        public string EmailAutor { get; set; }
        #endregion

        #region Aluno Local Database
        private SQLiteConnection database;
        static object locker = new object();
        public int SalvarLivro(Livro livro)
        {
            lock (locker)
            {
                if (livro.ISBN != 0)
                {
                    database.Update(livro);
                    return livro.ISBN;
                }
                else return database.Insert(livro);
            }
        }
        public IEnumerable<Livro> GetLivros()
        {
            lock (locker)
            {
                return (from c in database.Table<Livro>()
                        select c).ToList();
            }
        }
        public Livro GetLivro(int Id)
        {
            lock (locker)
            {
                // return database.Query< Aluno>("SELECT * FROM [Aluno] WHERE[Id] = " + Id);
                return database.Table<Livro>().Where(c => c.ISBN == Id).FirstOrDefault();
            }
        }
        public int RemoverLivro(int ISBN)
        {
            lock (locker)
            {
                return database.Delete<Livro>(ISBN);
            }
        }
        #endregion

    }
}
