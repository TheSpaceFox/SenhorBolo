using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenhorBolo.dao;

namespace SenhorBolo.model
{
    class ControleProdutos
    {
        public int ID;
        DataTable produtos = new DataTable();
        ProdutosDAO gerenciar = new ProdutosDAO();

        public void Cadastrar(int id, string descprod, double preco, double maisvalia)
        {
            gerenciar.Cadastrar(id, descprod, preco, maisvalia);
        }

        public DataTable ProdutosCadastrados()
        {
            produtos = gerenciar.produtosCadastros();
            return produtos;
        }
    }
}