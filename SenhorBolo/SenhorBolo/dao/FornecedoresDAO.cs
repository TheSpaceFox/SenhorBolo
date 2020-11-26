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
    class FornecedoresDAO : Conexao
    {
        DataTable Dt = new DataTable();
        public DataTable fornecedoresCadastros()
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("ListarFornecedores", Con);
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

        public DataTable getFornecedores()
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("SELECT CNPJ FROM tblFornecedor", Con);
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

        public void setFornecedores(string cnpj)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("ListarFornecedor", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@CNPJ", cnpj);
                Dr = Cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        fornecedor.cnpj = Dr.GetString(0);
                        fornecedor.descFor = Dr.GetString(1);
                        fornecedor.contatoFor = Dr.GetString(2);
                        fornecedor.enderecoFor = Dr.GetString(3);
                        fornecedor.cidade = Dr.GetString(4);
                    }
                }

            }
            finally
            {
                Desconectar();
            }
        }

        public bool updateFornecedor()
        {
            bool funcionou = false;
            try
            {
                Conectar();
                Cmd = new SqlCommand("EditarFornecedor", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@CNPJ", fornecedor.cnpj);
                Cmd.Parameters.AddWithValue("@descFor", fornecedor.descFor);
                Cmd.Parameters.AddWithValue("@contatoFor", fornecedor.contatoFor);
                Cmd.Parameters.AddWithValue("@enderecoFor", fornecedor.enderecoFor);
                Cmd.Parameters.AddWithValue("@cidade", fornecedor.cidade);
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

        public void deleteFornecedor(string CNPJ)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("DELETE FROM tblFornecedor WHERE CNPJ = @CNPJ", Con);
                Cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o fornecedor: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
