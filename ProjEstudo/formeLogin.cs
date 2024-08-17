using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjEstudo
{
    public partial class formeLogin : Form
    {
        public formeLogin()
        {
            InitializeComponent();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string password = "admin";


            if (txtUsuario.Text == user & txtSenha.Text == password)
            {
                MessageBox.Show("Login efetuado com sucesso!");
                Form1 FrmMain = new Form1();
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário/Senha incorretos! ");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
