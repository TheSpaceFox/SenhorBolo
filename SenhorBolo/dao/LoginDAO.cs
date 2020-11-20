using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorBolo.dao
{
    class LoginDAO
    {
        public bool Acesso = false;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool Acessar(int userType, string login, String senha)
        {
            if (userType == 0) {
                cmd.CommandText = "select * from tblAdministrador where idAdministrador = @login and senhaADM = @senha";
            } else {
                cmd.CommandText = "select * from tblFuncionarios where idFuncionario = @login and senhaFunc = @senha";
            } 
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Acesso = true;
                }
            }
            catch(SqlException)
            {
                throw;
            }
            return Acesso;
        }
    }
}
