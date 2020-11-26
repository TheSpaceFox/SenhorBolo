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
    public partial class GerenciarFornecedores : Form
    {
        ControleFornecedor controleFornecedores = new ControleFornecedor();
        DataTable fornecedoresCadastrados = new DataTable();
        public GerenciarFornecedores()
        {
            InitializeComponent();
            listarFornecedores();
        }

        public void listarFornecedores()
        {
            fornecedoresCadastrados = controleFornecedores.fornecedoresCadastros();
            dataGrid_Fornecedor.DataSource = fornecedoresCadastrados;
        }

        private void controlFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarFornecedor editar = new EditarFornecedor();
            editar.Show();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            DataView data = fornecedoresCadastrados.DefaultView;
            switch (comboBox_Pesquisa.SelectedIndex)
            {
                case 0:
                    data.RowFilter = string.Format("CNPJ like '%{0}%'", txtPesquisa.Text);
                    break;
                case 1:
                    data.RowFilter = string.Format("descFor like '%{0}%'", txtPesquisa.Text);
                    break;
                case 2:
                    data.RowFilter = string.Format("contatoFor like '%{0}%'", txtPesquisa.Text);
                    break;
                case 3:
                    data.RowFilter = string.Format("enderecoFor like '%{0}%'", txtPesquisa.Text);
                    break;
                case 4:
                    data.RowFilter = string.Format("cidade like '%{0}%'", txtPesquisa.Text);
                    break;
            }
            dataGrid_Fornecedor.DataSource = data.ToTable(); ;
        }

        private void btnExcluir_Click(object sender, EventArgs e) 
        {
            if (MessageBox.Show("Deseja apagar esse fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string CNPJ = dataGrid_Fornecedor.CurrentRow.Cells[0].Value.ToString();
                controleFornecedores.deleteFornecedor(CNPJ);
                dataGrid_Fornecedor.Rows.RemoveAt(dataGrid_Fornecedor.CurrentRow.Index);
                MessageBox.Show("Fornecedor apagado com sucesso", "Sucesso", MessageBoxButtons.OK);
            }
        }

    }
}
