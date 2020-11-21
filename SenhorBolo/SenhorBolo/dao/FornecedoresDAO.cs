using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorBolo.dao
{
    class FornecedoresDAO : Conexao
    {
        DataTable Dt = new DataTable();
        public DataTable pesquisaTabela(string pesquisa, string campo)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("PesquisarFornecedores", Con);
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

        public DataTable fornecedoresCadastros()
        {
            try 
            {
                Conectar();
                Cmd = new SqlCommand("ListarForncedores", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao acessar os Fornecedores: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }
        public void Cadastrar(string cnpj, string descfor, string contato, string endereco, string cidade)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("CadastrarFornecedores", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@cnpj", cnpj);
                Cmd.Parameters.AddWithValue("@descFor", descfor);
                Cmd.Parameters.AddWithValue("@contato", contato);
                Cmd.Parameters.AddWithValue("@endereco", endereco);
                Cmd.Parameters.AddWithValue("@cidade", cidade);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar:" + e.Message);
            }
            finally 
            {
                Desconectar();
            }

        }
    }
        
}
