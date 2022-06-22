namespace Projeto_Termooo
{
    partial class Form1
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar1 = new System.Windows.Forms.Button();
            this.rtbEscrever = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoJogo.Location = new System.Drawing.Point(12, 15);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(75, 25);
            this.btnNovoJogo.TabIndex = 0;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Location = new System.Drawing.Point(387, 283);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(57, 21);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.DetectUrls = false;
            this.rtbMostrar.Enabled = false;
            this.rtbMostrar.Font = new System.Drawing.Font("NimbusSanL", 21.5F);
            this.rtbMostrar.Location = new System.Drawing.Point(159, 56);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.ReadOnly = true;
            this.rtbMostrar.Size = new System.Drawing.Size(222, 206);
            this.rtbMostrar.TabIndex = 5;
            this.rtbMostrar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(198, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "WORDFINDER";
            // 
            // btnVoltar1
            // 
            this.btnVoltar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar1.Location = new System.Drawing.Point(466, 338);
            this.btnVoltar1.Name = "btnVoltar1";
            this.btnVoltar1.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar1.TabIndex = 7;
            this.btnVoltar1.Text = "Voltar";
            this.btnVoltar1.UseVisualStyleBackColor = true;
            this.btnVoltar1.Click += new System.EventHandler(this.btnVoltar1_Click);
            // 
            // rtbEscrever
            // 
            this.rtbEscrever.Location = new System.Drawing.Point(159, 283);
            this.rtbEscrever.MaxLength = 5;
            this.rtbEscrever.Name = "rtbEscrever";
            this.rtbEscrever.Size = new System.Drawing.Size(222, 20);
            this.rtbEscrever.TabIndex = 8;
            this.rtbEscrever.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbEscrever_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Termooo.Properties.Resources._864421_A_Barite_1348x693;
            this.ClientSize = new System.Drawing.Size(553, 373);
            this.Controls.Add(this.rtbEscrever);
            this.Controls.Add(this.btnVoltar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnNovoJogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WORDFINDER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar1;
        private System.Windows.Forms.TextBox rtbEscrever;
    }
}

