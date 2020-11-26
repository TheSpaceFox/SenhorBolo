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
            maisVendidos();
            setLucroMensal();
            setVendasMensais();
            dataGridMaisVendidos.ClearSelection();
            dataGridVendasMensais.ClearSelection();
        }

        public void maisVendidos()
        {
            DataTable teste = new DataTable();
            teste = vendasControle.maisVendidos();
            dataGridMaisVendidos.DataSource = teste;
        }

        public void setLucroMensal()
        {
            txtLucroMensal.Text = vendasControle.getLucroMensal();
        }

        public void setVendasMensais()
        {
            dataGridVendasMensais.DataSource = vendasControle.getVendasMensais();
        }

        private void dataGridMaisVendidos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           dataGridMaisVendidos.ClearSelection();
        }

        private void controlFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
