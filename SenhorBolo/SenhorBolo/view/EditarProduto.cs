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
using SenhorBolo.common;

namespace SenhorBolo.view
{
    public partial class EditarProduto : Form
    {
        ControleProdutos produtos = new ControleProdutos();
        public EditarProduto()
        {
            InitializeComponent();
            comboID();
        }

        public void comboID()
        {
            DataTable Dt = new DataTable();
            Dt = produtos.getProdutos();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                comboBoxID.Items.Add(Dt.Rows[i]["idProduto"].ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTexto();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparTexto();
            produtos.setProduto(int.Parse(comboBoxID.GetItemText(comboBoxID.SelectedItem)));
            txtDescricao.Text = Produto.descProd;
            txtValor.Text = Convert.ToString(Produto.preco);
            txtMaisValia.Text = Convert.ToString(Produto.maisValia);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool funcionou;
            Produto.descProd = txtDescricao.Text;
            Produto.preco = double.Parse(txtValor.Text);
            Produto.maisValia = double.Parse(txtMaisValia.Text);
            funcionou = produtos.updateProduto();
            if (funcionou == true)
            {
                MessageBox.Show("Produto alterado com sucesso!");
            }
            LimparTexto();

        }

        public void LimparTexto()
        {
            txtDescricao.Text = null;
            txtMaisValia.Text = null;
            txtValor.Text = null;
        }
    }
}