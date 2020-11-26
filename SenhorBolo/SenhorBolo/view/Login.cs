using SenhorBolo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenhorBolo.common;

namespace SenhorBolo {
    public partial class Login : Form {
        public Login()
        {
            InitializeComponent();
            
        }

        int userType = 0;
        private void comboLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            userType = comboLogin.SelectedIndex;
        }

        private void login()
        {    
            ControleLogin controle = new ControleLogin(); //Instanciamento de objeto para verificar login
            controle.Acessar(userType, txtLogin.Text, txtSenha.Text);

            if (controle.Acesso) //Verifica se o login é valido, e abre o form de acordo com o usuário
            {
                this.Close();
                if (userType == 1)
                {
                    Caixa caixa = new Caixa();
                    caixa.Show();
                }
                else
                {
                    Gerenciamento gerenciamento = new Gerenciamento();
                    gerenciamento.Show();
                }
            }
            else
            {
                MessageBox.Show("Login inválido, tente novamente", "Erro de Acesso"); //Mensagem de erro
                txtLogin.Text = null;
                txtSenha.Text = null;
                txtLogin.Focus();
            }
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            login();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Login com a tecla enter
            {
                login();
            }
        }
    }
}
