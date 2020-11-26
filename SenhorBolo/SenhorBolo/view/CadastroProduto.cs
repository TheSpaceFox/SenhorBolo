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

namespace SenhorBolo
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
            ControlHeightWidth();
        }

        ControleProdutos produto = new ControleProdutos();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == ""  || txtDescricao.Text == "" || txtPreco.Text == "" || txtMaisValia.Text == "")
            {
                MessageBox.Show("Pro favor, preencha todos os campos obrigatórios");
            }
            else
            {
                double preco = (Convert.ToDouble(txtPreco.Text) / 100);
                double maisValia = (Convert.ToDouble(txtMaisValia.Text) / 100);
                if (produto.Cadastrar(Convert.ToInt32(txtID.Text), txtDescricao.Text, preco, maisValia))
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar ;-;");
                }
                limparTexto();
            }
        }

        private void limparTexto()
        {
            txtID.Text = null;
            txtDescricao.Text = null;
            txtPreco.Text = null;
            txtMaisValia.Text = null;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTexto();
        }

        private void ControlHeightWidth()
        {
            foreach (Control c in this.Controls)
            {
                if ((c.GetType() == typeof(MaskedTextBox)))
                {
                    ((MaskedTextBox)c).AutoSize = false;
                    c.Size = new Size(252, 35);
                }
            }
        }
    }
}