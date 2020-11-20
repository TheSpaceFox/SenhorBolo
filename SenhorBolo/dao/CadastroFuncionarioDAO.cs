using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhorBolo.dao
{
    class CadastroFuncionarioDAO
    {
        public bool Ednaldo = false;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public bool Cadastrar(int id, string nome, string senha, string rg, string cpf, double salario, string email, string telefone, string cep)
        {
            cmd.CommandText = "insert into tblFuncinarios(idFuncionario, nomeFunc, senhaFunc, RG, CPF, salario, email, telefone, CEP) values (@idFunc, @nomeFunc, @senhaFunc, @rg, @cpf, @salario, @email, @telefone, @cep)";
            cmd.Parameters.AddWithValue("@idFunc", id);
            cmd.Parameters.AddWithValue("@nomeFunc", nome);
            cmd.Parameters.AddWithValue("@senhaFunc", senha);
            cmd.Parameters.AddWithValue("@rg", rg);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@salario", salario);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@cep", cep);
            try
            {}
            catch (SqlException)
            {
                throw;
            }
            return Ednaldo;
        }
    }
}
