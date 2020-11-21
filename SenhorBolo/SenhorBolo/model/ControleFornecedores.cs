using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenhorBolo.dao;

namespace SenhorBolo.model
{
    class ControleFornecedores
    {
        public int ID;
        public string Campo;
        public bool Ednaldo;
        DataTable fornecedores = new DataTable();
        FornecedoresDAO gerenciar = new FornecedoresDAO();

        public DataTable Pesquisa(String pesquisa, int comboBox)
        {
            switch (comboBox)
            {
                case 0:
                    Campo = "cnpj";
                    break;
                case 1:
                    Campo = "descfor";
                    break;
                case 2:
                    Campo = "contato";
                    break;
                case 3:
                    Campo = "endereco";
                    break;
                case 4:
                    Campo = "cidade";
                    break;
            }
            Campo = "cidade";
            fornecedores = gerenciar.pesquisaTabela(pesquisa, Campo);
            return fornecedores;

        }
        public void Cadastrar(string cnpj, string descfor, string contato, string endereco, string cidade)
        {
            gerenciar.Cadastrar(cnpj, descfor, contato, endereco, cidade);
        }

        public DataTable fornecedoresCadastros()
        {
            fornecedores = gerenciar.fornecedoresCadastros();
            return fornecedores;
        }
    }
}
