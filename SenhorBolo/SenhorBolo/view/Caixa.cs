using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenhorBolo.common;
using SenhorBolo.model;

namespace SenhorBolo {
    public partial class Caixa : Form {
        public Caixa()
        {
            InitializeComponent();
            lblNomeFuncionario.Text = Funcionario.nomeFunc;
        }

        ControleCaixa caixa = new ControleCaixa();
        double subTotal = 0;


        private void relógio_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = DateTime.Now.ToString("T");
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                caixa.getProduto(int.Parse(txtCodigo.Text));
                txtPrecoUnitario.Text = Produto.preco.ToString("F2");
                txtQuantidade.Focus();
            }
            if (e.KeyCode == Keys.F1)
            {
                txtSubtotal.Text = "R$ " + subTotal.ToString("F2");
                txtValorPago.Enabled = true;
                txtCodigo.Enabled = false;
                txtQuantidade.Enabled = false;
                txtValorPago.Focus();
            }
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
;
                txtTotalItem.Text = Convert.ToString(double.Parse(txtQuantidade.Text) * double.Parse(txtPrecoUnitario.Text));
                subTotal += double.Parse(txtTotalItem.Text);
                adicionarProduto();
                txtCodigo.Focus();
            }

            if (e.KeyCode == Keys.F1)
            {
                txtSubtotal.Text = "R$ " + subTotal.ToString("0.00");
            }
        }

        public void adicionarProduto()
        {
            int linha = 0;
            datagridListaProdutos.Rows.Add();
            linha = datagridListaProdutos.Rows.Count - 2;
            datagridListaProdutos[0, linha].Value = linha;
            datagridListaProdutos[1, linha].Value = Produto.idProduto;
            datagridListaProdutos[2, linha].Value = Produto.descProd;
            datagridListaProdutos[3, linha].Value = txtQuantidade.Text;
            datagridListaProdutos[4, linha].Value = Produto.preco;
            datagridListaProdutos[5, linha].Value = subTotal; 
            limparTextoProduto();
        }

        public void limparTextoProduto()
        {
            txtCodigo.Text = null;
            txtPrecoUnitario.Text = null;
            txtQuantidade.Text = null;
            txtTotalItem.Text = null;
            txtSubtotal.Text = null;
            txtTroco.Text = null;
            txtValorPago.Text = null;
        }

        private void txtValorPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTroco.Text = "R$ " + (double.Parse(txtValorPago.Text) - subTotal).ToString();
                txtValorPago.Enabled = false;
                finalizarCompra();
            }
        }

        private void finalizarCompra()
        {
            if (MessageBox.Show("Deseja finalizar compra?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string produto;
                int qtde;
                double valorTotal;
                caixa.gerarVenda();
                for (int i = 0; i < datagridListaProdutos.Rows.Count - 1; i++)
                {
                    produto = Convert.ToString(datagridListaProdutos.Rows[i].Cells[2].Value);
                    qtde = Convert.ToInt32(datagridListaProdutos.Rows[i].Cells[3].Value);
                    valorTotal = Convert.ToInt32(datagridListaProdutos.Rows[i].Cells[5].Value);
                    caixa.gerarDetalheVenda(produto, qtde, valorTotal);
                }
                limparTextoProduto();
                txtCodigo.Enabled = true;
                txtQuantidade.Enabled = true;
                txtCodigo.Focus();
                datagridListaProdutos.Rows.Clear();
                datagridListaProdutos.Refresh();
            }
        }

        private void Caixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                finalizarCompra();
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            double qtde = 0;
            double.TryParse(txtQuantidade.Text, out qtde);
            double valorUnit = 0;
            double.TryParse(txtPrecoUnitario.Text, out valorUnit);
            double totalItem = qtde * valorUnit;
            txtTotalItem.Text = totalItem.ToString("F2");
        }
    }
}
