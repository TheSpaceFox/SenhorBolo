using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorBolo.dao
{
    class FuncionariosDAO : Conexao
    {
        DataTable Dt = new DataTable();
        public DataTable pesquisaTabela(string pesquisa, string campo)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("PesquisarFuncionarios", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Campo", campo);
                Cmd.Parameters.AddWithValue("@Pesquisa", pesquisa);
                
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao pesquisar: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }

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

    }
}
