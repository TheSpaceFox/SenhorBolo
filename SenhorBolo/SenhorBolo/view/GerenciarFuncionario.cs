using SenhorBolo.view;
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
using System.Data.SqlClient;

namespace SenhorBolo
{
    public partial class GerenciarFuncionario : Form
    {
        ControleFuncionarios funcionarios = new ControleFuncionarios();
        DataTable funcionariosCadastrados = new DataTable();
        public GerenciarFuncionario()
        {
            InitializeComponent();
            listarFuncionarios();
        }

        public void listarFuncionarios()
        {
            funcionariosCadastrados = funcionarios.funcionariosCadastrados();
            dataGrid_Funcionario.DataSource = funcionariosCadastrados;
        }
        
        private void controlFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarFuncionario gerenciar = new EditarFuncionario();
            gerenciar.Show();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            DataView data = funcionariosCadastrados.DefaultView;
            switch(comboBox_Pesquisa.SelectedIndex)
            {
                case 0:
                    data.RowFilter = string.Format("CONVERT(idFuncionario, 'System.String') like '%{0}%'", txtPesquisa.Text);
                    break;
                case 1:
                    data.RowFilter = string.Format("nomeFunc like '%{0}%'", txtPesquisa.Text);
                    break;
                case 2:
                    data.RowFilter = string.Format("senhaFunc like '%{0}%'", txtPesquisa.Text);
                    break;
                case 3:
                    data.RowFilter = string.Format("RG like '%{0}%'", txtPesquisa.Text);
                    break;
                case 4:
                    data.RowFilter = string.Format("CONVERT(salario, 'System.String') like '%{0}%'", txtPesquisa.Text);
                    break;
                case 5:
                    data.RowFilter = string.Format("email like '%{0}%'", txtPesquisa.Text);
                    break;
                case 6:
                    data.RowFilter = string.Format("telefone like '%{0}%'", txtPesquisa.Text);
                    break;
                case 7:
                    data.RowFilter = string.Format("CEP like '%{0}%'", txtPesquisa.Text);
                    break;
            }
            dataGrid_Funcionario.DataSource = data.ToTable(); ;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idFuncionario = dataGrid_Funcionario.CurrentRow.Index + 1;
            funcionarios.excluirFuncionario(idFuncionario);
            dataGrid_Funcionario.Rows.RemoveAt(dataGrid_Funcionario.CurrentRow.Index);
        }
    }
}
