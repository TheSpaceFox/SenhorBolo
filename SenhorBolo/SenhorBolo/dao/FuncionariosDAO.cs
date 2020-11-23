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
    class FuncionariosDAO : Conexao
    {
        DataTable Dt = new DataTable();

        public DataTable funcionariosCadastrados()
        {
            try
            {
                Conectar();
                
                Cmd = new SqlCommand("ListarFuncionarios", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            } 
            catch (Exception e)
            {
                throw new Exception("Erro ao acessar os funcionários: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }

        public void Cadastrar(int id, string nome, string senha, string rg, double salario, string email, string telefone, string cep)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("CadastrarFuncionarios", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idFuncionario", id);
                Cmd.Parameters.AddWithValue("@nomeFunc", nome);
                Cmd.Parameters.AddWithValue("@senhaFunc", senha);
                Cmd.Parameters.AddWithValue("@RG", rg);
                Cmd.Parameters.AddWithValue("@salario", salario);
                Cmd.Parameters.AddWithValue("@email", email);
                Cmd.Parameters.AddWithValue("@telefone", telefone);
                Cmd.Parameters.AddWithValue("@CEP", cep);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar: " + e.Message);
            }
            finally
            {
                Desconectar();
            }

        }

        public DataTable getFuncionarios()
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("SELECT idFuncionario FROM tblFuncionarios", Con);
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao pegar id: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }

        public void setFuncionario(int idFunc)
        {
            try{
                Conectar();
                Cmd = new SqlCommand("ListarFuncionario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idFuncionario", idFunc);
                Dr = Cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        funcionario.idFuncionario = Dr.GetInt32(0);
                        funcionario.nomeFunc = Dr.GetString(1);
                        funcionario.senhaFunc = Dr.GetString(2);
                        funcionario.RG = Dr.GetString(3);
                        funcionario.salario = Dr.GetDouble(4);
                        funcionario.email = Dr.GetString(5);
                        funcionario.telefone = Dr.GetString(6);
                        funcionario.cep = Dr.GetString(7);
                    }
                }

            }
            finally
            {
                Desconectar();
            }

        }

        public bool updateFuncionario()
        {
            bool funcionou = false;
            try
            {
                Conectar();
                Cmd = new SqlCommand("EditarFuncionario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@id", funcionario.idFuncionario);
                Cmd.Parameters.AddWithValue("@nome", funcionario.nomeFunc);
                Cmd.Parameters.AddWithValue("@senha", funcionario.senhaFunc);
                Cmd.Parameters.AddWithValue("@RG", funcionario.RG);
                Cmd.Parameters.AddWithValue("@salario", funcionario.salario);
                Cmd.Parameters.AddWithValue("@email", funcionario.email);
                Cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
                Cmd.Parameters.AddWithValue("@CEP", funcionario.cep);
                Cmd.ExecuteNonQuery();
                funcionou = true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao dar update: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return funcionou;
        }

    }

}
