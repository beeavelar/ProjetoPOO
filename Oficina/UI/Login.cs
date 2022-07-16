using Business;
using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_Login : Form
    {
        /// <summary>
        /// Método construtor da classe Form_Login
        /// </summary>
        public Form_Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_close -> Fecha o formulário Form_Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_Login_Load(object sender, EventArgs e)
        {
            tb_username.Focus();
            tb_username.Select();
        }

        /// <summary>
        /// Método do evento click do btn_login -> Verifica se as credenciais (username e password) inseridas existem no banco de dados e entra no sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "" || tb_password.Text == "")
                MessageBox.Show("Fill in all data.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!User.CheckLoginData(tb_username.Text, tb_password.Text))
                    MessageBox.Show("Invalid username/password, please try again.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Hello, " + User.UserLogged.Name + "!" + " Welcome to the System!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Form_Dashboard().Show();
                }
            }
        }

        /// <summary>
        /// Método do evento KeyPress que não permite inserir espaços no tb_password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método do evento click do btn_cancel -> Limpa a tb_username e a tb_password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_username.Text = "";
            tb_password.Text = "";
        }

        /// <summary>
        /// Método do evento CheckedChanged da checkbox_showHidePassword mostra e esconde a password inserida na tb_password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkbox_showHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_showHidePassword.Checked)
                tb_password.UseSystemPasswordChar = false;

            else
                tb_password.UseSystemPasswordChar = true;
        }

    }
}
