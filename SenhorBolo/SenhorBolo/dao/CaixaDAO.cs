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
                Cmd = new SqlCommand("valorUnit", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idFunc", Funcionario.idFuncionario);
                Cmd.Parameters.AddWithValue("@data", DateTime.Now.ToString("MM-dd-yyyy"));
                Cmd.ExecuteNonQuery();
            }
            finally{
                Desconectar();
            }
        }
    }
}
