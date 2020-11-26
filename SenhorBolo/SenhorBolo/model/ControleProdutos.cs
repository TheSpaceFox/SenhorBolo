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
        DataTable produtos = new DataTable();
        ProdutosDAO produtosDAO = new ProdutosDAO();

        public DataTable getProdutos()
        {
            produtos = produtosDAO.getProdutos();
            return produtos;

        }
        public void Cadastrar(int id, string descprod, double preco, double maisvalia)
        {
            produtosDAO.Cadastrar(id, descprod, preco, maisvalia);
        }

        public DataTable ProdutosCadastrados()
        {
            produtos = produtosDAO.produtosCadastros();
            return produtos;
        }

        public void setProduto(int idProduto)
        {
            produtosDAO.setProdutos(idProduto);
        }

        public bool updateProduto()
        {
            bool funcionou;
            funcionou = produtosDAO.updateProduto();
            return funcionou;
        }

        public void excluirProduto(int idProd)
        {
            produtosDAO.excluirProduto(idProd);
        }


    }
}