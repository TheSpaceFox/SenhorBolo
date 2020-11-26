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

        public bool Cadastrar(int id, string nome, string senha, string rg, double salario, string email, string telefone, string cep)
        {
            bool cadastro = false;
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
                cadastro = true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return cadastro;
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
                        Funcionario.idFuncionario = Dr.GetInt32(0);
                        Funcionario.nomeFunc = Dr.GetString(1);
                        Funcionario.senhaFunc = Dr.GetString(2);
                        Funcionario.RG = Dr.GetString(3);
                        Funcionario.salario = Dr.GetDouble(4);
                        Funcionario.email = Dr.GetString(5);
                        Funcionario.telefone = Dr.GetString(6);
                        Funcionario.cep = Dr.GetString(7);
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
                Cmd.Parameters.AddWithValue("@id", Funcionario.idFuncionario);
                Cmd.Parameters.AddWithValue("@nome", Funcionario.nomeFunc);
                Cmd.Parameters.AddWithValue("@senha", Funcionario.senhaFunc);
                Cmd.Parameters.AddWithValue("@RG", Funcionario.RG);
                Cmd.Parameters.AddWithValue("@salario", Funcionario.salario);
                Cmd.Parameters.AddWithValue("@email", Funcionario.email);
                Cmd.Parameters.AddWithValue("@telefone", Funcionario.telefone);
                Cmd.Parameters.AddWithValue("@CEP", Funcionario.cep);
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

        public void excluirFuncionario(int idFunc)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("DELETE FROM tblFuncionarios WHERE idFuncionario = @idFunc", Con);
                Cmd.Parameters.AddWithValue("@idFunc", idFunc);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o funcionário: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
        }

    }

}
