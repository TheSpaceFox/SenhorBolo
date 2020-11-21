using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorBolo.dao
{
    class LoginDAO : Conexao
    {
        public bool Acesso = false;
        public bool Acessar(int userType, string login, String senha)
        {
            try
            {
                Conectar();
                if (userType == 0)
                {
                    Cmd = new SqlCommand("select * from tblAdministrador where idAdministrador = @login and senhaADM = @senha", Con);
                }
                else
                {
                    Cmd = new SqlCommand("select * from tblFuncionarios where idFuncionario = @login and senhaFunc = @senha", Con);
                }
                Cmd.Parameters.AddWithValue("@login", login);
                Cmd.Parameters.AddWithValue("@senha", senha);
                Dr = Cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    Acesso = true;
                }
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao cadastrar: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Acesso;
        }
    }
}
