using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenhorBolo.dao;

namespace SenhorBolo.model
{
    class ControleVendas
    {
        VendasDAO vendasDAO = new VendasDAO();
        double lucroMensal;
        string vendas = "R$ 0,00" ;
        public string getLucroMensal()
        {
            lucroMensal = vendasDAO.getLucroMensal();
            if (vendas != null)
            {
                vendas = "R$ " + lucroMensal.ToString("F2");
            }
            return vendas;
        }

        public DataTable maisVendidos()
        {
            DataTable maisVendidos = new DataTable();
            maisVendidos = vendasDAO.getMaisVendidos();
            return maisVendidos;
        }

        public DataTable getVendasMensais()
        {
            return vendasDAO.getVendasMensais();
        }
    }
}
