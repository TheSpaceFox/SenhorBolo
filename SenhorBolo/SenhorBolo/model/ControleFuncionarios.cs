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
        FuncionariosDAO gerenciar = new FuncionariosDAO();

        public DataTable getFuncionarios()
        {
            funcionarios = gerenciar.getFuncionarios();
            return funcionarios;
        }
        public void Cadastrar(int id, string nome, string senha, string rg, double salario, string email, string telefone, string cep)
        {
            gerenciar.Cadastrar(id, nome, senha, rg, salario, email, telefone, cep);
        }

        public DataTable funcionariosCadastrados()
        {
            funcionarios = gerenciar.funcionariosCadastrados();
            return funcionarios;
        }

        public void setFuncionario(int idFuncionario)
        {
            gerenciar.setFuncionario(idFuncionario);
        }

        public bool updateFuncionario()
        {
            bool funcionou;
            funcionou = gerenciar.updateFuncionario();
            return funcionou;
        }
    }
}
