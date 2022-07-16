using Business;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.UI
{
    public partial class Form_ManageUsers : Form
    {
        private string connString = "";

        /// <summary>
        /// Método construtor da classe Form_ManageUsers
        /// </summary>
        public Form_ManageUsers()
        {
            InitializeComponent();
            connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        }

        /// <summary>
        /// Método do evento click do btn_close --> Fecha o Form_ManageUsers
        /// </summary>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método que valida se todos os campos do formulário foram preenchidos
        /// </summary>
        private bool CheckEmptyFields()
        {
            bool _output = true;

            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_username.Text) || string.IsNullOrEmpty(tb_email.Text) || string.IsNullOrEmpty(cb_permissions.Text) || string.IsNullOrEmpty(tb_password.Text))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _output = false;
            }
            return _output;
        }

        /// <summary>
        /// Método auxiliar para fazer o envio de emails
        /// </summary>
        public async Task SendEmail(string _email, string _subject)
        {
            try
            {
                //Indicar a Apikey e guardar ela na variável "_apikey" -- >logando no website do Sendgrid é possível criar uma Apikey
                var _apiKey = "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";

                ///O método da biblioteca auxiliar SendGridClient(), passa a apikey para a API v3 em um cabeçalho de autorização usando a autenticação de token de portador
                var _client = new SendGridClient(_apiKey);

                //Indicar o email do remetente
                var _from = new EmailAddress("cet69.repairshop@gmail.com", "Repair Shop");
                //O email do destinatário vai ser passada através da variável "_email" porque ele vem da tb_email
                var _to = new EmailAddress(_email);

                //Mensagem que vai aparecer no e-mail
                var _plainTextContent = "Dear Sr.(a) " + tb_name.Text + ",\n\n" +
                                        "Your login access was created/updated successfully.\n\n" +
                                        "Username: " + tb_username.Text + "\n" +
                                        "Password: " + tb_password.Text + "\n\n" +
                                        "Best regards,\n" +
                                        "Repais Shop";
                var _htmlContent = "";

                //Criação do e-mail
                var _msg = MailHelper.CreateSingleEmail(_from, _to, _subject, _plainTextContent, _htmlContent);

                //Solicitar à API SendGrid Mail Send para enviar o e-mail
                var _response = await _client.SendEmailAsync(_msg);
            }
            catch (Exception)
            {
                MessageBox.Show("Error sending the email.", "Erro Envio de Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método auxiliar criado para limpar os dados inseridos no formulário "Create new user"
        /// </summary>
        private void ClearData()
        {
            tb_id.Text = "";
            tb_name.Text = "";
            tb_username.Text = "";
            tb_email.Text = "";
            cb_permissions.Text = "";
            tb_password.Text = "";
            tb_confirmPassword.Text = "";
        }

        /// <summary>
        /// Método do evento Leave da tb_email que valida se o email inserido é válido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_email_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tb_email.Text, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$"))
            {
                MessageBox.Show("Invalid email. Please, enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_email.Focus();
            }
        }

        /// <summary>
        /// Método do evento click do btn_clearData -> Limpa todos os campos do formulário "Create new user"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clearData_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        /// <summary>
        /// Método do evento click do btn_delete -> Deleta users cadastrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var _user = (User)dgv_users.Rows[dgv_users.SelectedCells[0].RowIndex].DataBoundItem;

            var _confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (_confirmResult == DialogResult.Yes)
            {
                User.Delete(_user.Id);
                MessageBox.Show("The selected item has been deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_users.DataSource = User.UserList();
            }
        }

        /// <summary>
        /// Método do evento double click na dgv_users -> Caso seja necessário fazer update, damos dois cliques na célula da dgv_users, os campos do formulário serão preenchidos automaticamente
        /// e então é possível fazer o update do campo que queremos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _user = (User)dgv_users.Rows[e.RowIndex].DataBoundItem;

            tb_id.Text = _user.Id.ToString();
            tb_name.Text = _user.Name;
            tb_username.Text = _user.Username;
            tb_email.Text = _user.Email;
            cb_permissions.Text = _user.Permission;
            tb_password.Text = _user.Password;
        }

        /// <summary>
        /// Método do evento click do btn_search -> Pesquisa users pelo nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nameToSearch.Text))
                MessageBox.Show("Please, enter a name.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                dgv_users.DataSource = User.UserList(tb_nameToSearch.Text);
        }

        /// <summary>
        /// Método do evento click do btn_update -> Atualiza a dgv_users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            //Carrega a dgv_users com os dados da tabela Users da base de dados
            dgv_users.DataSource = User.UserList();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_ManageUsers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_ManageUsers_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_users com os dados da tabela Users da base de dados
            dgv_users.DataSource = User.UserList();

            toolTip1.SetToolTip(btn_save, "Save");
            toolTip1.SetToolTip(btn_clearData, "Clear data");
            toolTip1.SetToolTip(btn_delete, "Delete");
            toolTip1.SetToolTip(btn_search, "Search");

            tb_name.Focus();
            tb_name.Select();
        }

        /// <summary>
        /// Método do evento click do btn_save -> Valida (ValidateData()), salva no banco de dados as informações inseridas no formulário "Create new user" e envia e-mail com o login e a senha do novo user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                if (tb_password.Text != tb_confirmPassword.Text)
                {
                    MessageBox.Show("Passwords are not the same.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_confirmPassword.Focus();
                    tb_confirmPassword.Select();
                    return;
                }

                if (string.IsNullOrEmpty(tb_id.Text)) tb_id.Text = "0";

                var _newUser = new User()
                {
                    Id = Convert.ToInt32(tb_id.Text),
                    Name = tb_name.Text,
                    Username = tb_username.Text,
                    Email = tb_email.Text,
                    Permission = cb_permissions.Text,
                    Password = tb_password.Text
                };
                _newUser.Save();

                if (tb_id.Text == "0")
                {
                    await SendEmail(tb_email.Text, "Repair Shop - New user confirmation");
                    MessageBox.Show("New user has been saved successfully and an e-mail was sent to the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await SendEmail(tb_email.Text, "Repair Shop - New user confirmation");
                    MessageBox.Show("Data has been updated successfully and an e-mail was sent to the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_id.Text = "0";
                }
                ClearData();
                dgv_users.DataSource = User.UserList();
            }
        }
    }
}
