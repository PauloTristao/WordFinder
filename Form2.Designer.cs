namespace Projeto_Termooo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnRegras = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(120, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao WORDFINDER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJogar.Location = new System.Drawing.Point(175, 181);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(104, 23);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnRegras
            // 
            this.btnRegras.BackColor = System.Drawing.Color.Cyan;
            this.btnRegras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegras.Location = new System.Drawing.Point(342, 181);
            this.btnRegras.Name = "btnRegras";
            this.btnRegras.Size = new System.Drawing.Size(104, 23);
            this.btnRegras.TabIndex = 2;
            this.btnRegras.Text = "Regras do jogo";
            this.btnRegras.UseVisualStyleBackColor = false;
            this.btnRegras.Click += new System.EventHandler(this.btnRegras_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Salmon;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Location = new System.Drawing.Point(500, 269);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Termooo.Properties.Resources.question_sign_art_creative_questions_1_;
            this.ClientSize = new System.Drawing.Size(622, 328);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRegras);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WORDFINDER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnRegras;
        private System.Windows.Forms.Button btnFechar;
    }
}