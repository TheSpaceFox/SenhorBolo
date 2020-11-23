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
