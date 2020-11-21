using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SenhorBolo {
    class Conexao {

        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;
        protected SqlDataAdapter Adapter;
        protected SqlTransaction Tr;
        public void Conectar()
        {
            Con = new SqlConnection(@"Data Source=TREEDIAGRAM\SQLEXPRESS;Initial Catalog=SrBolo; Persist Security Info=True;User ID=sa;Password=qpwoeiruty10");
            Con.Open();                 
        }
   
        public void Desconectar()
        {
            Con.Close();
        }
    }
}
