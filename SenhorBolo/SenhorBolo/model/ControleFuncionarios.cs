using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenhorBolo.dao;

namespace SenhorBolo.model
{
    public class ControleFuncionarios
    {

        DataTable funcionarios = new DataTable();
        FuncionariosDAO funcionariosDAO = new FuncionariosDAO();

        public DataTable getFuncionarios()
        {
            funcionarios = funcionariosDAO.getFuncionarios();
            return funcionarios;
        }
        public bool Cadastrar(int id, string nome, string senha, string rg, double salario, string email, string telefone, string cep)
        {
            return funcionariosDAO.Cadastrar(id, nome, senha, rg, salario, email, telefone, cep);
        }

        public DataTable funcionariosCadastrados()
        {
            funcionarios = funcionariosDAO.funcionariosCadastrados();
            return funcionarios;
        }

        public void excluirFuncionario(int idFunc)
        {
            funcionariosDAO.excluirFuncionario(idFunc);
        }
        public void setFuncionario(int idFuncionario)
        {
            funcionariosDAO.setFuncionario(idFuncionario);
        }

        public bool updateFuncionario()
        {
            bool funcionou;
            funcionou = funcionariosDAO.updateFuncionario();
            return funcionou;
        }
    }
}
