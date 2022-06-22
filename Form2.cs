using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Termooo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog(); //abre a janela do forms 1 (tela do jogo)
            Hide(); //esconde a janela atual
            Close();
            

        }

        private void btnRegras_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog(); //abre a janela do forms 3 (regras do jogo)
            Hide(); //esconde a janela atual
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
