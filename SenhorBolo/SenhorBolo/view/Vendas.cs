using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenhorBolo.model;


namespace SenhorBolo.view
{
    public partial class Vendas : Form
    {
        ControleVendas vendasControle = new ControleVendas();
        public Vendas()
        {
            InitializeComponent();
            setVendasMensais();
            maisVendidos();
        }

        public void maisVendidos()
        {
            DataTable teste = new DataTable();
            teste = vendasControle.maisVendidos();
            dataGridMaisVendidos.DataSource = teste;
        }

        public void setVendasMensais()
        {
            MessageBox.Show(vendasControle.vendasMensais());
            txtLucroMensal.Text = vendasControle.vendasMensais();
        }
    }
}
