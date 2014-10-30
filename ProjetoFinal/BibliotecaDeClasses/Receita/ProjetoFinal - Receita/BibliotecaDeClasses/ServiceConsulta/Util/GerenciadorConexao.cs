using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ServiceConsulta.Util
{
    public class GerenciadorConexao
    {
        public SqlConnection sqlConn;

        //string conexão
        string connStringSqlServer = "Data Source=GISOMARJUNIOR\\GISOMAR;Initial Catalog=EasyMed;Integrated Security=True";

        public void abrirConexao()
        {
            this.sqlConn = new SqlConnection(connStringSqlServer);
            this.sqlConn.Open();
        }

        public void fecharConexao()
        {
            this.sqlConn.Close();
            this.sqlConn.Dispose();
        }
    }
}