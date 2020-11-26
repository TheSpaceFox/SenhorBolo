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
using SenhorBolo.common;
namespace SenhorBolo
{
    public partial class Gerenciamento : Form
    {
        public Gerenciamento()
        {
            InitializeComponent();
            subMenu();
            setMensagemBoasVinda();
        }

        public void setMensagemBoasVinda()
        { 
            if (DateTime.Now.Hour < 12)
            {
                lblBoasVindas.Text = "Bom dia, " + Administrador.nomeAdmin + "!";
            } else if (DateTime.Now.Hour < 18) {
                lblBoasVindas.Text = "Boa tarde, " + Administrador.nomeAdmin + "!";
            } else {
                lblBoasVindas.Text = "Boa noite, " + Administrador.nomeAdmin + "!";
            }
        }


        #region SubMenu
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void subMenu()
        {
            painelDropFornecedor.Visible = false;
            painelDropFuncionario.Visible = false;
            painelDropProduto.Visible = false;
        }

        private void hideSubMenu()
        {
            if (painelDropFornecedor.Visible == true)
            {
                painelDropFornecedor.Visible = false;
            }
            if (painelDropFuncionario.Visible == true)
            {
                painelDropFuncionario.Visible = false;
            }
            if (painelDropProduto.Visible == true)
            {
                painelDropProduto.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #endregion

        #region Funcionarios
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            showSubMenu(painelDropFuncionario);
        }
        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {

            openChildForm(new CadastroFuncionario());
            showSubMenu(painelDropFuncionario);
        }

        private void btnGerenciarFuncionarios_Click(object sender, EventArgs e)
        {
            openChildForm(new GerenciarFuncionario());
            showSubMenu(painelDropFuncionario);
        }

        #endregion

        #region Produtos
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            showSubMenu(painelDropProduto);
        }
        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            openChildForm(new CadastroProduto());
            showSubMenu(painelDropProduto);
        }
        private void btnGerenciarProdutos_Click(object sender, EventArgs e)
        {
            openChildForm(new GerenciarProduto());
            showSubMenu(painelDropProduto);
        }
        #endregion

        #region Fornecedor
        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            showSubMenu(painelDropFornecedor);
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            openChildForm(new CadastroFornecedor());
            showSubMenu(painelDropFornecedor);
        }

        private void btnGerenciarFornecedores_Click(object sender, EventArgs e)
        {
            openChildForm(new GerenciarFornecedores());
            showSubMenu(painelDropFornecedor);
        }

        #endregion

        private void btnVendas_Click(object sender, EventArgs e)
        {
            openChildForm(new Vendas());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
