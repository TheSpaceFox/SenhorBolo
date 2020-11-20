using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenhorBolo.dao;

namespace SenhorBolo.model
{
    class CadastroFuncionarioModel
    {
            public bool Ednaldo;
            public bool Cadastrar(int id, string nome, string senha, string rg, string cpf, double salario, string email, string telefone, string cep)
            {
                CadastroFuncionarioDAO cadDao = new CadastroFuncionarioDAO();
                Ednaldo = cadDao.Cadastrar(id, nome, senha, rg, cpf, salario, email, telefone, cep);
                return Ednaldo;
            }
     }
}
