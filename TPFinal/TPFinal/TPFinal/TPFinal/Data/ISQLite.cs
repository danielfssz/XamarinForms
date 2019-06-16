using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TPFinal.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConexao();
    }
}
