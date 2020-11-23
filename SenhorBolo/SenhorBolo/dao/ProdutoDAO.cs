using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SenhorBolo.dao
{
    class ProdutosDAO : Conexao
    {
        DataTable Dt = new DataTable();
        public DataTable pesquisaTabela(string pesquisa, string campo)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("PesquisarProdutos", Con);
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
        public DataTable produtosCadastros()
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("ListarProdutos", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao acessar os Produtos: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }

        public void Cadastrar(int id, string descprod, double preco, double maisvalia)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("CadastrarProdutos", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idProd", id);
                Cmd.Parameters.AddWithValue("@descProd", descprod);
                Cmd.Parameters.AddWithValue("@preco", preco);
                Cmd.Parameters.AddWithValue("@maisvalia", maisvalia);
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
