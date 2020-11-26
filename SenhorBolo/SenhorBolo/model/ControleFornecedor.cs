using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenhorBolo.dao;

namespace SenhorBolo.model
{
    class ControleFornecedor
    {
        FornecedoresDAO gerenciar = new FornecedoresDAO();
        DataTable fornecedores = new DataTable();

        public DataTable getFornecedores()
        {
            fornecedores = gerenciar.getFornecedores();
            return fornecedores;
        }
        public bool Cadastrar(string cnpj, string descfor, string contato, string endereco, string cidade)
        {
            return gerenciar.Cadastrar(cnpj, descfor, contato, endereco, cidade);
        }

        public DataTable fornecedoresCadastros()
        {
            fornecedores = gerenciar.fornecedoresCadastros();
            return fornecedores;
        }

        public void setFornecedores(string cnpj)
        {
            gerenciar.setFornecedores(cnpj);
        }

        public bool updateFornecedor()
        {
            bool funcionou;
            funcionou = gerenciar.updateFornecedor();
            return funcionou;
        }

        public void deleteFornecedor(string CNPJ)
        {
            gerenciar.deleteFornecedor(CNPJ);
        }
    }
}
