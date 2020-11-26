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
    class CaixaDAO : Conexao
    {
        public double getProduto(int codBarras)
        {
            double precoUnit = 0;
            try
            {
                Conectar();
                Cmd = new SqlCommand("valorUnit", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@codBarras", codBarras);
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

            finally{
                Desconectar();
            }
            return precoUnit;
        }

        public void gerarVenda() {
            try
            {
                Conectar();
                Cmd = new SqlCommand("gerarVenda", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@data", DateTime.Now.ToString("dd-MM-yyyy"));
                Cmd.Parameters.AddWithValue("@idFuncionario", Funcionario.idFuncionario);
                Cmd.ExecuteNonQuery();
            }
            finally{
                Desconectar();
            }
        }

        public void gerarDetalheVenda(string descProd, int qtde, double valorTotal)
        {
            try
            {
                Conectar();
                Cmd = new SqlCommand("pegarID", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@nomeProd", descProd);
                Cmd.ExecuteNonQuery();
                Object id = Cmd.ExecuteScalar();
                int idProduto = Convert.ToInt32(id);
                Cmd = new SqlCommand("gerarDetalheVenda", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idVenda", 0);
                Cmd.Parameters.AddWithValue("@idProduto", idProduto);
                Cmd.Parameters.AddWithValue("@qtde", qtde);
                Cmd.Parameters.AddWithValue("@valorTotal", valorTotal);
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
