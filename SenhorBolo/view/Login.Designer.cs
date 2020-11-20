namespace SenhorBolo {
    partial class Login {
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboLogin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSenha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAcessar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SenhorBolo.Properties.Resources.LogoLogin;
            this.pictureBox2.Location = new System.Drawing.Point(91, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 131);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserType
            // 
            this.lblUserType.BackColor = System.Drawing.Color.Transparent;
            this.lblUserType.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(69, 160);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(183, 21);
            this.lblUserType.TabIndex = 11;
            this.lblUserType.Text = "Selecione seu usuário";
            this.lblUserType.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(74, 233);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 21);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboLogin
            // 
            this.comboLogin.Animated = true;
            this.comboLogin.BackColor = System.Drawing.Color.Transparent;
            this.comboLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.comboLogin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLogin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboLogin.FocusedState.Parent = this.comboLogin;
            this.comboLogin.Font = new System.Drawing.Font("Helvetica", 12F);
            this.comboLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.comboLogin.HoverState.Parent = this.comboLogin;
            this.comboLogin.ItemHeight = 20;
            this.comboLogin.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.comboLogin.ItemsAppearance.Parent = this.comboLogin;
            this.comboLogin.Location = new System.Drawing.Point(74, 187);
            this.comboLogin.Name = "comboLogin";
            this.comboLogin.ShadowDecoration.Parent = this.comboLogin;
            this.comboLogin.Size = new System.Drawing.Size(173, 26);
            this.comboLogin.TabIndex = 14;
            this.comboLogin.SelectedIndexChanged += new System.EventHandler(this.comboLogin_SelectedIndexChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.BorderRadius = 2;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.DefaultText = "";
            this.txtLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogin.DisabledState.Parent = this.txtLogin;
            this.txtLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogin.FocusedState.Parent = this.txtLogin;
            this.txtLogin.Font = new System.Drawing.Font("Helvetica", 11F);
            this.txtLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogin.HoverState.Parent = this.txtLogin;
            this.txtLogin.Location = new System.Drawing.Point(74, 260);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.PlaceholderText = "";
            this.txtLogin.SelectedText = "";
            this.txtLogin.ShadowDecoration.Parent = this.txtLogin;
            this.txtLogin.Size = new System.Drawing.Size(171, 31);
            this.txtLogin.TabIndex = 15;
            // 
            // txtSenha
            // 
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.DefaultText = "";
            this.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.DisabledState.Parent = this.txtSenha;
            this.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.FocusedState.Parent = this.txtSenha;
            this.txtSenha.Font = new System.Drawing.Font("Helvetica", 11F);
            this.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.HoverState.Parent = this.txtSenha;
            this.txtSenha.Location = new System.Drawing.Point(74, 332);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.PlaceholderText = "";
            this.txtSenha.SelectedText = "";
            this.txtSenha.ShadowDecoration.Parent = this.txtSenha;
            this.txtSenha.Size = new System.Drawing.Size(171, 31);
            this.txtSenha.TabIndex = 17;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(74, 305);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(55, 21);
            this.lblSenha.TabIndex = 16;
            this.lblSenha.Text = "Senha";
            this.lblSenha.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.Transparent;
            this.btnAcessar.BorderColor = System.Drawing.Color.Transparent;
            this.btnAcessar.CheckedState.Parent = this.btnAcessar;
            this.btnAcessar.CustomImages.Parent = this.btnAcessar;
            this.btnAcessar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.btnAcessar.Font = new System.Drawing.Font("Helvetica", 12F);
            this.btnAcessar.ForeColor = System.Drawing.Color.White;
            this.btnAcessar.HoverState.Parent = this.btnAcessar;
            this.btnAcessar.Location = new System.Drawing.Point(111, 385);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.ShadowDecoration.Parent = this.btnAcessar;
            this.btnAcessar.Size = new System.Drawing.Size(101, 33);
            this.btnAcessar.TabIndex = 18;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 461);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.comboLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLogin;
        private Guna.UI2.WinForms.Guna2ComboBox comboLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSenha;
        private Guna.UI2.WinForms.Guna2Button btnAcessar;
    }
}