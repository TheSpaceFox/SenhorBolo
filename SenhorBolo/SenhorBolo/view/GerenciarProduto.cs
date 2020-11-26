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
    public partial class GerenciarProduto : Form
    {
        ControleProdutos controleProdutos = new ControleProdutos();
        DataTable produtosCadastrados = new DataTable();

        public GerenciarProduto()
        {
            InitializeComponent();
            listarProdutos();
        }

        public void listarProdutos()
        {
            produtosCadastrados = controleProdutos.ProdutosCadastrados();
            dataGrid_Produtos.DataSource = produtosCadastrados;
        }
        private void controlFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            DataView data = produtosCadastrados.DefaultView;
            switch (comboBox_Pesquisa.SelectedIndex)
            {
                case 0:
                    data.RowFilter = string.Format("CONVERT(idProduto, 'System.String') like '%{0}%'", txtPesquisa.Text);
                    break;
                case 1:
                    data.RowFilter = string.Format("descProduto like '%{0}%'", txtPesquisa.Text);
                    break;
                case 2:
                    data.RowFilter = string.Format("CONVERT(precoProduto, 'System.String') like '%{0}%'", txtPesquisa.Text);
                    break;
                case 3:
                    data.RowFilter = string.Format("CONVERT(maisValia, 'System.String') like '%{0}%'", txtPesquisa.Text);
                    break;
            }
            dataGrid_Produtos.DataSource = data.ToTable(); ;
        }

        private void limparDataGrid()
        {
            for (int i = 0; i < dataGrid_Produtos.RowCount; i++)
            {
                dataGrid_Produtos.Rows[i].DataGridView.Columns.Clear();
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProduto editar = new EditarProduto();
            editar.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar esse produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idProduto = int.Parse(dataGrid_Produtos.CurrentRow.Cells[0].Value.ToString());
                controleProdutos.excluirProduto(idProduto);
                dataGrid_Produtos.Rows.RemoveAt(dataGrid_Produtos.CurrentRow.Index);
                MessageBox.Show("Produto apagado com sucesso", "Sucesso", MessageBoxButtons.OK);
            }
        }
    }
}
