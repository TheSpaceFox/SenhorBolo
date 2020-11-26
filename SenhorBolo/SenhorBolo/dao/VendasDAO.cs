using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorBolo.dao
{
    class VendasDAO:Conexao
    {
        public double getLucroMensal()
        {
            double lucroMensal;
            try
            {
                Conectar();
                Cmd = new SqlCommand("VendasMensais", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Object lucro = Cmd.ExecuteScalar();
                lucroMensal = Convert.ToDouble(lucro);
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao acessar os Fornecedores: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return lucroMensal;
        }

        public DataTable getMaisVendidos()
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                Cmd = new SqlCommand("MaisVendidos", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao pegar os mais vendidos: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }
    }
}
