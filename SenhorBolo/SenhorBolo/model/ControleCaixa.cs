using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenhorBolo.dao;

namespace SenhorBolo.model
{
    class ControleCaixa
    {
        CaixaDAO caixa = new CaixaDAO();
        public void getProduto(int codBarras)
        {
            caixa.getProduto(codBarras);
        }

        public void gerarVenda()
        {
            caixa.gerarVenda();
        }

        /*
        public void gerarDetalheVenda(int idProduto, int qtde, double valorTotal)
        {
            caixa.gerarDetalheVenda();
        }
        */
    }
}
