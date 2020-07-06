using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTatoo
{
    class Connection
    {
        //05/11/2019 - Mfacine - Metodo da classe que retorna o caminho da conexão
        public static string ConnectionPath()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marcus.fgfacine\Documents\Visual Studio 2015\Projects\AppTatoo\AppTatoo\BD_APPTATOO.mdf;Integrated Security=True; Connect Timeout = 30";
        }
    }
}