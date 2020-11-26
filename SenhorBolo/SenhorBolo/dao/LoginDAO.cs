using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenhorBolo.common;

namespace SenhorBolo.dao
{
    class LoginDAO : Conexao
    {
        public bool Acesso = false; //Informa se o login é valido
        public bool Acessar(int userType, string login, String senha)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("AcessoSistema", Con); //Procedimento que retorna o login
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@userType", userType);
                Cmd.Parameters.AddWithValue("@login", login);
                Cmd.Parameters.AddWithValue("@senha", senha);
                Dr = Cmd.ExecuteReader();
                if (Dr.HasRows) //Caso seja o sql tenha retorno, o valor é tido como valido
                {
                    if (userType == 0)
                    {
                        while (Dr.Read())
                        {
                            Funcionario.idFuncionario = Dr.GetInt32(0);
                            Funcionario.nomeFunc = Dr.GetString(1);
                        }
                    }
                    else {
                        while (Dr.Read())
                        {
                            Administrador.idAdmin = Dr.GetInt32(0);
                            Administrador.nomeAdmin = Dr.GetString(1);
                        }
                    }
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
