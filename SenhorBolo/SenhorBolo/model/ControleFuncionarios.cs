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
        public int ID;
        public string Campo;
        public bool Ednaldo;
        DataTable funcionarios = new DataTable();
        FuncionariosDAO gerenciar = new FuncionariosDAO();

        public DataTable Pesquisa(string pesquisa, int comboBox)
        {
            switch (comboBox)
            {
                case 0:
                    Campo = "idFuncionario";
                    break;
                case 1:
                    Campo = "nomeFunc";
                    break;
                case 2:
                    Campo = "senhaFunc";
                    break;
                case 3:
                    Campo = "RG";
                    break;
                case 4:
                    Campo = "salario";
                    break;
                case 5:
                    Campo = "email";
                    break;
                case 6:
                    Campo = "telefone";
                    break;
                case 7:
                    Campo = "CEP";
                    break;
            }
            Campo = "salario";
            funcionarios = gerenciar.pesquisaTabela(pesquisa, Campo);
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
    }
}
