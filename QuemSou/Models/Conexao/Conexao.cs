using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace QuemSou.Models.Conexao
{
    public class Conexao
    {
        public SqlConnection acesso;
        public Conexao()
        {
            acesso = new SqlConnection(ConfigurationManager.AppSettings["conexaoDB"]);

        }
    }
}