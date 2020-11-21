namespace SenhorBolo.view
{
    partial class CadastroFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblAsteristico = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCampoObrigatorio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.txtEndereco = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEndereco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescricao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCidade = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCNPJ = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCNPJ = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.separator = new Guna.UI2.WinForms.Guna2Separator();
            this.lblCadastroFornecedores = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtContato = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblContato = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // controlFechar
            // 
            this.controlFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlFechar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controlFechar.HoverState.Parent = this.controlFechar;
            this.controlFechar.IconColor = System.Drawing.Color.White;
            this.controlFechar.Location = new System.Drawing.Point(892, 12);
            this.controlFechar.Name = "controlFechar";
            this.controlFechar.ShadowDecoration.Parent = this.controlFechar;
            this.controlFechar.Size = new System.Drawing.Size(25, 25);
            this.controlFechar.TabIndex = 62;
            // 
            // lblAsteristico
            // 
            this.lblAsteristico.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteristico.Font = new System.Drawing.Font("Arial", 13F);
            this.lblAsteristico.ForeColor = System.Drawing.Color.Red;
            this.lblAsteristico.Location = new System.Drawing.Point(123, 624);
            this.lblAsteristico.Name = "lblAsteristico";
            this.lblAsteristico.Size = new System.Drawing.Size(13, 33);
            this.lblAsteristico.TabIndex = 61;
            this.lblAsteristico.Text = "*";
            // 
            // lblCampoObrigatorio
            // 
            this.lblCampoObrigatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblCampoObrigatorio.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCampoObrigatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lblCampoObrigatorio.Location = new System.Drawing.Point(145, 624);
            this.lblCampoObrigatorio.Name = "lblCampoObrigatorio";
            this.lblCampoObrigatorio.Size = new System.Drawing.Size(212, 29);
            this.lblCampoObrigatorio.TabIndex = 60;
            this.lblCampoObrigatorio.Text = "Campos obrigatório";
            // 
            // btnLimpar
            // 
            this.btnLimpar.CheckedState.Parent = this.btnLimpar;
            this.btnLimpar.CustomImages.Parent = this.btnLimpar;
            this.btnLimpar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 13.5F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.HoverState.Parent = this.btnLimpar;
            this.btnLimpar.Location = new System.Drawing.Point(500, 614);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.ShadowDecoration.Parent = this.btnLimpar;
            this.btnLimpar.Size = new System.Drawing.Size(145, 36);
            this.btnLimpar.TabIndex = 59;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.CheckedState.Parent = this.btnRegistrar;
            this.btnRegistrar.CustomImages.Parent = this.btnRegistrar;
            this.btnRegistrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(153)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 13.5F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.HoverState.Parent = this.btnRegistrar;
            this.btnRegistrar.Location = new System.Drawing.Point(660, 614);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.ShadowDecoration.Parent = this.btnRegistrar;
            this.btnRegistrar.Size = new System.Drawing.Size(145, 36);
            this.btnRegistrar.TabIndex = 58;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.DefaultText = "";
            this.txtEndereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEndereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEndereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndereco.DisabledState.Parent = this.txtEndereco;
            this.txtEndereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.FocusedState.Parent = this.txtEndereco;
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.HoverState.Parent = this.txtEndereco;
            this.txtEndereco.Location = new System.Drawing.Point(543, 313);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtEndereco.PlaceholderText = "";
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.ShadowDecoration.Parent = this.txtEndereco;
            this.txtEndereco.Size = new System.Drawing.Size(252, 35);
            this.txtEndereco.TabIndex = 57;
            // 
            // lblEndereco
            // 
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 13.5F);
            this.lblEndereco.ForeColor = System.Drawing.Color.Black;
            this.lblEndereco.Location = new System.Drawing.Point(543, 286);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(119, 34);
            this.lblEndereco.TabIndex = 56;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.DefaultText = "";
            this.txtDescricao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescricao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescricao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescricao.DisabledState.Parent = this.txtDescricao;
            this.txtDescricao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescricao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescricao.FocusedState.Parent = this.txtDescricao;
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescricao.HoverState.Parent = this.txtDescricao;
            this.txtDescricao.Location = new System.Drawing.Point(127, 350);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDescricao.PlaceholderText = "";
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.ShadowDecoration.Parent = this.txtDescricao;
            this.txtDescricao.Size = new System.Drawing.Size(252, 35);
            this.txtDescricao.TabIndex = 55;
            this.txtDescricao.UseSystemPasswordChar = true;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 13.5F);
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(127, 323);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(125, 34);
            this.lblDescricao.TabIndex = 54;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCidade.DefaultText = "";
            this.txtCidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCidade.DisabledState.Parent = this.txtCidade;
            this.txtCidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCidade.FocusedState.Parent = this.txtCidade;
            this.txtCidade.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Black;
            this.txtCidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCidade.HoverState.Parent = this.txtCidade;
            this.txtCidade.Location = new System.Drawing.Point(543, 395);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCidade.PlaceholderText = "";
            this.txtCidade.SelectedText = "";
            this.txtCidade.ShadowDecoration.Parent = this.txtCidade;
            this.txtCidade.Size = new System.Drawing.Size(252, 35);
            this.txtCidade.TabIndex = 53;
            // 
            // lblCidade
            // 
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 13.5F);
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(543, 368);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(89, 34);
            this.lblCidade.TabIndex = 52;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCNPJ.DefaultText = "";
            this.txtCNPJ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCNPJ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCNPJ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCNPJ.DisabledState.Parent = this.txtCNPJ;
            this.txtCNPJ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCNPJ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCNPJ.FocusedState.Parent = this.txtCNPJ;
            this.txtCNPJ.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.ForeColor = System.Drawing.Color.Black;
            this.txtCNPJ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCNPJ.HoverState.Parent = this.txtCNPJ;
            this.txtCNPJ.Location = new System.Drawing.Point(127, 268);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.PasswordChar = '\0';
            this.txtCNPJ.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCNPJ.PlaceholderText = "";
            this.txtCNPJ.SelectedText = "";
            this.txtCNPJ.ShadowDecoration.Parent = this.txtCNPJ;
            this.txtCNPJ.Size = new System.Drawing.Size(252, 35);
            this.txtCNPJ.TabIndex = 51;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.lblCNPJ.Font = new System.Drawing.Font("Arial", 13.5F);
            this.lblCNPJ.ForeColor = System.Drawing.Color.Black;
            this.lblCNPJ.Location = new System.Drawing.Point(127, 241);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(72, 34);
            this.lblCNPJ.TabIndex = 50;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // separator
            // 
            this.separator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.separator.FillThickness = 2;
            this.separator.Location = new System.Drawing.Point(56, 102);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(816, 10);
            this.separator.TabIndex = 49;
            // 
            // lblCadastroFornecedores
            // 
            this.lblCadastroFornecedores.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroFornecedores.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.lblCadastroFornecedores.Location = new System.Drawing.Point(56, 47);
            this.lblCadastroFornecedores.Name = "lblCadastroFornecedores";
            this.lblCadastroFornecedores.Size = new System.Drawing.Size(545, 53);
            this.lblCadastroFornecedores.TabIndex = 48;
            this.lblCadastroFornecedores.Text = "Cadastro de fornecedores";
            // 
            // txtContato
            // 
            this.txtContato.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContato.DefaultText = "";
            this.txtContato.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContato.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContato.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContato.DisabledState.Parent = this.txtContato;
            this.txtContato.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContato.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContato.FocusedState.Parent = this.txtContato;
            this.txtContato.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.ForeColor = System.Drawing.Color.Black;
            this.txtContato.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContato.HoverState.Parent = this.txtContato;
            this.txtContato.Location = new System.Drawing.Point(127, 432);
            this.txtContato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContato.Name = "txtContato";
            this.txtContato.PasswordChar = '\0';
            this.txtContato.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtContato.PlaceholderText = "";
            this.txtContato.SelectedText = "";
            this.txtContato.ShadowDecoration.Parent = this.txtContato;
            this.txtContato.Size = new System.Drawing.Size(252, 35);
            this.txtContato.TabIndex = 64;
            this.txtContato.UseSystemPasswordChar = true;
            // 
            // lblContato
            // 
            this.lblContato.BackColor = System.Drawing.Color.Transparent;
            this.lblContato.Font = new System.Drawing.Font("Arial", 13.5F);
            this.lblContato.ForeColor = System.Drawing.Color.Black;
            this.lblContato.Location = new System.Drawing.Point(127, 405);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(99, 34);
            this.lblContato.TabIndex = 63;
            this.lblContato.Text = "Contato";
            // 
            // CadastroFornecedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 686);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.controlFechar);
            this.Controls.Add(this.lblAsteristico);
            this.Controls.Add(this.lblCampoObrigatorio);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.lblCadastroFornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroFornecedor";
            this.Text = "CadastrarFornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox controlFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAsteristico;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCampoObrigatorio;
        private Guna.UI2.WinForms.Guna2Button btnLimpar;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private Guna.UI2.WinForms.Guna2TextBox txtEndereco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEndereco;
        private Guna.UI2.WinForms.Guna2TextBox txtDescricao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescricao;
        private Guna.UI2.WinForms.Guna2TextBox txtCidade;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCidade;
        private Guna.UI2.WinForms.Guna2TextBox txtCNPJ;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCNPJ;
        private Guna.UI2.WinForms.Guna2Separator separator;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCadastroFornecedores;
        private Guna.UI2.WinForms.Guna2TextBox txtContato;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContato;
    }
}