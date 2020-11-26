using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using SenhorBolo.common;

namespace SenhorBolo.dao
{
    class ProdutosDAO : Conexao
    {
        DataTable Dt = new DataTable();
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

        public bool Cadastrar(int id, string descprod, double preco, double maisvalia)
        {
            bool cadastro = false;
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
                cadastro = true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar:" + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return cadastro;
        }

        public DataTable getProdutos()
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("SELECT idProduto FROM tblProduto", Con);
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

        public void setProdutos(int idProd)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("ListarProduto", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@ID", idProd);
                Dr = Cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Produto.idProduto = Dr.GetInt32(0);
                        Produto.descProd = Dr.GetString(1);
                        Produto.preco = Dr.GetDouble(2);
                        Produto.maisValia = Dr.GetDouble(3);
                    }
                }
            }
            finally
            {
                Desconectar();
            }

        }
        public bool updateProduto()
        {
            bool funcionou = false;
            try
            {
                Conectar();
                Cmd = new SqlCommand("EditarProduto", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@id", Produto.idProduto);
                Cmd.Parameters.AddWithValue("@descProduto", Produto.descProd);
                Cmd.Parameters.AddWithValue("@precoProduto", Produto.preco);
                Cmd.Parameters.AddWithValue("@maisValia", Produto.maisValia);
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

        public void excluirProduto(int idProd)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("DELETE FROM tblProduto WHERE idProduto = @idProd", Con);
                Cmd.Parameters.AddWithValue("@idProd", idProd);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}