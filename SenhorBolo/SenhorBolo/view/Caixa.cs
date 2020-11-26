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
                txtPrecoUnitario.Text = "R$" + Produto.preco.ToString("0,00");
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
            }
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTotalItem.Text = Convert.ToString(int.Parse(txtQuantidade.Text) * int.Parse(txtPrecoUnitario.Text));
                subTotal += double.Parse(txtTotalItem.Text);
                adicionarProduto();
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
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
            datagridListaProdutos[5, linha].Value = txtTotalItem.Text;
            limparTextoProduto();
        }

        public void limparTextoProduto()
        {
            txtCodigo.Text = null;
            txtPrecoUnitario.Text = null;
            txtQuantidade.Text = null;
            txtTotalItem.Text = null;
        }

        private void Caixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtSubtotal.Text = subTotal.ToString();
            }
        }

    }
}
