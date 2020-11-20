namespace SenhorBolo {
    partial class Splash {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fundo = new System.Windows.Forms.PictureBox();
            this.fundoCarregamento = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // fundo
            // 
            this.fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundo.Image = global::SenhorBolo.Properties.Resources.Splash;
            this.fundo.Location = new System.Drawing.Point(0, 0);
            this.fundo.Name = "fundo";
            this.fundo.Size = new System.Drawing.Size(525, 300);
            this.fundo.TabIndex = 0;
            this.fundo.TabStop = false;
            // 
            // fundoCarregamento
            // 
            this.fundoCarregamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.fundoCarregamento.Location = new System.Drawing.Point(0, 288);
            this.fundoCarregamento.Name = "fundoCarregamento";
            this.fundoCarregamento.Size = new System.Drawing.Size(49, 12);
            this.fundoCarregamento.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 300);
            this.Controls.Add(this.fundoCarregamento);
            this.Controls.Add(this.fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox fundo;
        private System.Windows.Forms.Panel fundoCarregamento;
        private System.Windows.Forms.Timer timer;
    }
}

