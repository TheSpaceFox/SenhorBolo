using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SenhorBolo {
    class Conexao {

        SqlConnection con = new SqlConnection();


        public Conexao()
        {
            con.ConnectionString = @"Data Source=TREEDIAGRAM\SQLEXPRESS;Initial Catalog=SrBolo; Persist Security Info=True;User ID=sa;Password=qpwoeiruty10";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
