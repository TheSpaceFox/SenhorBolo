namespace SenhorBolo
{
    partial class CadastroProduto
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
            this.lblPreco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescricao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaisValia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.separator = new Guna.UI2.WinForms.Guna2Separator();
            this.lblCadastroFuncionarios = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaisValia = new System.Windows.Forms.MaskedTextBox();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
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
            this.controlFechar.TabIndex = 47;
            // 
            // lblAsteristico
            // 
            this.lblAsteristico.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteristico.Font = new System.Drawing.Font("Helvetica", 13F);
            this.lblAsteristico.ForeColor = System.Drawing.Color.Red;
            this.lblAsteristico.Location = new System.Drawing.Point(123, 624);
            this.lblAsteristico.Name = "lblAsteristico";
            this.lblAsteristico.Size = new System.Drawing.Size(10, 22);
            this.lblAsteristico.TabIndex = 46;
            this.lblAsteristico.Text = "*";
            // 
            // lblCampoObrigatorio
            // 
            this.lblCampoObrigatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblCampoObrigatorio.Font = new System.Drawing.Font("Helvetica", 12F);
            this.lblCampoObrigatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lblCampoObrigatorio.Location = new System.Drawing.Point(145, 624);
            this.lblCampoObrigatorio.Name = "lblCampoObrigatorio";
            this.lblCampoObrigatorio.Size = new System.Drawing.Size(143, 21);
            this.lblCampoObrigatorio.TabIndex = 45;
            this.lblCampoObrigatorio.Text = "Campos obrigatório";
            // 
            // btnLimpar
            // 
            this.btnLimpar.CheckedState.Parent = this.btnLimpar;
            this.btnLimpar.CustomImages.Parent = this.btnLimpar;
            this.btnLimpar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.btnLimpar.Font = new System.Drawing.Font("Helvetica", 13.5F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.HoverState.Parent = this.btnLimpar;
            this.btnLimpar.Location = new System.Drawing.Point(500, 614);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.ShadowDecoration.Parent = this.btnLimpar;
            this.btnLimpar.Size = new System.Drawing.Size(145, 36);
            this.btnLimpar.TabIndex = 44;
            this.btnLimpar.Text = "Limpar";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.CheckedState.Parent = this.btnRegistrar;
            this.btnRegistrar.CustomImages.Parent = this.btnRegistrar;
            this.btnRegistrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(153)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Helvetica", 13.5F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.HoverState.Parent = this.btnRegistrar;
            this.btnRegistrar.Location = new System.Drawing.Point(660, 614);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.ShadowDecoration.Parent = this.btnRegistrar;
            this.btnRegistrar.Size = new System.Drawing.Size(145, 36);
            this.btnRegistrar.TabIndex = 43;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Helvetica", 13.5F);
            this.lblPreco.ForeColor = System.Drawing.Color.Black;
            this.lblPreco.Location = new System.Drawing.Point(553, 276);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 23);
            this.lblPreco.TabIndex = 39;
            this.lblPreco.Text = "Preço";
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
            this.txtDescricao.Font = new System.Drawing.Font("Helvetica", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescricao.HoverState.Parent = this.txtDescricao;
            this.txtDescricao.Location = new System.Drawing.Point(124, 385);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDescricao.PlaceholderText = "";
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.ShadowDecoration.Parent = this.txtDescricao;
            this.txtDescricao.Size = new System.Drawing.Size(252, 35);
            this.txtDescricao.TabIndex = 32;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Helvetica", 13.5F);
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(124, 358);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(83, 23);
            this.lblDescricao.TabIndex = 31;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblMaisValia
            // 
            this.lblMaisValia.BackColor = System.Drawing.Color.Transparent;
            this.lblMaisValia.Font = new System.Drawing.Font("Helvetica", 13.5F);
            this.lblMaisValia.ForeColor = System.Drawing.Color.Black;
            this.lblMaisValia.Location = new System.Drawing.Point(553, 358);
            this.lblMaisValia.Name = "lblMaisValia";
            this.lblMaisValia.Size = new System.Drawing.Size(86, 23);
            this.lblMaisValia.TabIndex = 29;
            this.lblMaisValia.Text = "Mais Valia";
            // 
            // txtID
            // 
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.Font = new System.Drawing.Font("Helvetica", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(124, 303);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(252, 35);
            this.txtID.TabIndex = 28;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Helvetica", 13.5F);
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(124, 276);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 23);
            this.lblId.TabIndex = 27;
            this.lblId.Text = "ID";
            // 
            // separator
            // 
            this.separator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.separator.FillThickness = 2;
            this.separator.Location = new System.Drawing.Point(56, 102);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(816, 10);
            this.separator.TabIndex = 26;
            // 
            // lblCadastroFuncionarios
            // 
            this.lblCadastroFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroFuncionarios.Font = new System.Drawing.Font("Helvetica", 22F, System.Drawing.FontStyle.Bold);
            this.lblCadastroFuncionarios.Location = new System.Drawing.Point(56, 47);
            this.lblCadastroFuncionarios.Name = "lblCadastroFuncionarios";
            this.lblCadastroFuncionarios.Size = new System.Drawing.Size(307, 37);
            this.lblCadastroFuncionarios.TabIndex = 25;
            this.lblCadastroFuncionarios.Text = "Cadastro de Produtos";
            // 
            // txtMaisValia
            // 
            this.txtMaisValia.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaisValia.Location = new System.Drawing.Point(553, 385);
            this.txtMaisValia.Mask = "$00.00";
            this.txtMaisValia.Name = "txtMaisValia";
            this.txtMaisValia.Size = new System.Drawing.Size(252, 30);
            this.txtMaisValia.TabIndex = 48;
            this.txtMaisValia.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(553, 303);
            this.txtPreco.Mask = "$00.00";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(252, 30);
            this.txtPreco.TabIndex = 49;
            this.txtPreco.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // CadastroProduto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 686);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtMaisValia);
            this.Controls.Add(this.controlFechar);
            this.Controls.Add(this.lblAsteristico);
            this.Controls.Add(this.lblCampoObrigatorio);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblMaisValia);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.lblCadastroFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox controlFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAsteristico;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCampoObrigatorio;
        private Guna.UI2.WinForms.Guna2Button btnLimpar;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPreco;
        private Guna.UI2.WinForms.Guna2TextBox txtDescricao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescricao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaisValia;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblId;
        private Guna.UI2.WinForms.Guna2Separator separator;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCadastroFuncionarios;
        private System.Windows.Forms.MaskedTextBox txtMaisValia;
        private System.Windows.Forms.MaskedTextBox txtPreco;
    }
}