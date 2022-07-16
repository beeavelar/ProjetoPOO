using Business;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_ManageClients : Form
    {
        /// <summary>
        /// Método construtor da classe Form_ManageClients
        /// </summary>
        public Form_ManageClients()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_save -> Valida (ValidateData()) e salva no banco de dados as informações inseridas no formulário "CLIENT´S FORM"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            //Primeiro passa na validação do método CheckEmptyFields()
            if (CheckEmptyFields())
            {
                //Depois, se a tb_id estiver vazia, determina que ela recebe o valor 0
                if (string.IsNullOrEmpty(tb_id.Text)) tb_id.Text = "0";

                //Instancia um novo cliente da Classe Client e passa os valores inseridos no form para as propriedades dessa classe
                var _newClient = new Client()
                {
                    Id = Convert.ToInt32(tb_id.Text),
                    Name = tb_name.Text,
                    Address = tb_address.Text,
                    PostalCode = tb_postalCode.Text,
                    Phone = Convert.ToInt32(tb_phone.Text),
                    Email = tb_email.Text,
                    Nif = Convert.ToInt32(tb_nif.Text)
                };
                //Manda salvar esse novo cliente na base de dados
                _newClient.Save();

                //Se a tb_id estiver com valor 0 é porque se trata de um novo cliente, então vai mostrar a mensagem avisando que os dados do novo cliente foram salvos na base de dados
                if (tb_id.Text == "0")
                    MessageBox.Show("New client has been saved successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Se a tb_id estiver com valor diferente de 0 é porque se trata de um update, então vai mostrar a mensagem avisando que os dados do cliente foram atualizados na base de dados
                else
                {
                    MessageBox.Show("Data has been updated successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_id.Text = "0";
                }
                //Limpa dos dados do formulário   
                ClearData();

                //Atualiza a dgv_clients com o novo cliente inserido/atualizado na base de dados
                dgv_clients.DataSource = Client.ClientList();
            }
        }

        /// <summary>
        /// Método auxiliar criado para limpar os dados inseridos no formulário "CLIENT´S FORM"
        /// </summary>
        private void ClearData()
        {
            tb_id.Text = "";
            tb_name.Text = "";
            tb_address.Text = "";
            tb_postalCode.Text = "";
            tb_email.Text = "";
            tb_phone.Text = "";
            tb_nif.Text = "";
        }

        /// <summary>
        /// Método do evento click do btn_clearData -> Limpa todos os campos do formulário "CLIENT´S FORM"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clearData_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        /// <summary>
        /// Método que valida se todos os campos do formulário foram preenchidos
        /// </summary>
        private bool CheckEmptyFields()
        {
            bool _output = true;

            //Se os campos estiverem vazios ou nulos, mostrar mensagem avisando que todos os campos devem ser preenchidos
            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_address.Text) || !tb_postalCode.MaskCompleted || string.IsNullOrEmpty(tb_email.Text) || string.IsNullOrEmpty(tb_phone.Text) || string.IsNullOrEmpty(tb_nif.Text))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _output = false;
            }
            //Se todos os campos estiverem preenchidos, está ok
            return _output;
        }

        /// <summary>
        /// Método do evento KeyPress da tb_nif que valida se os dados inseridos são numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_nif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("This field only accepts numbers.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método do evento click do btn_search -> Pesquisa clientes pelo nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nameToSearch.Text)) //Se a tb_nameToSearch estiver vazia ou nula, mostrar mensagem avisando que o campo deve ser preenchido
                MessageBox.Show("Please, enter a customer name.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                //Buscar na ClientList da Classe Client da camada Business o nome que foi inserido na tb_nameToSearch e mostrar na dgv_clients
                dgv_clients.DataSource = Client.ClientList(tb_nameToSearch.Text);
        }

        /// <summary>
        /// Método do evento click do btn_delete -> Deleta clientes cadastrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //Verificar qual linha foi selecionada na dgv_clients e guardar na variável "_client"
            var _client = (Client)dgv_clients.Rows[dgv_clients.SelectedCells[0].RowIndex].DataBoundItem;

            //Confirmar se o user quer mesmo deletar o item selecionado e guardar a resposta na variável "confirmResult"
            var _confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);

            //Se a resposta o valor do _confirmResult é igual a "Yes"
            if (_confirmResult == DialogResult.Yes)
            {
                //Mandar o id do cliente selecionado para o método Delete() da classe Client da camada Business
                Client.Delete(_client.Id);
                //Mostrar uma mensagem confirmando que o item foi deletado da bsase de dados
                MessageBox.Show("The selected item has been deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Atualizar a dgv_clients com a lista de clientes que constam na base de dados
                dgv_clients.DataSource = Client.ClientList();
            }
        }

        /// <summary>
        /// Método do evento Leave da tb_phone que valida se o telefone inserido é válido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_phone_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tb_phone.Text, @"^(91|92|93|96)\d{7}$"))
            {
                MessageBox.Show("Invalid phone number. Please, enter a valid phone number.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_phone.Focus();
                tb_phone.Select();
            }
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
        /// Método do evento KeyPress da tb_phone que valida se os dados inseridos são numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("This field only accepts numbers.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método do evento Load do formulário Form_ManageClients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_ManageClients_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_clients com os dados da tabela Clients da base de dados
            dgv_clients.DataSource = Client.ClientList();

            toolTip1.SetToolTip(btn_save, "Save");
            toolTip1.SetToolTip(btn_clearData, "Clear data");
            toolTip1.SetToolTip(btn_delete, "Delete");
            toolTip1.SetToolTip(btn_search, "Search");

            tb_name.Focus();
            tb_name.Select();
        }

        /// <summary>
        /// Método do evento click do btn_update -> Atualiza a dgv_clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            //Carrega a dgv_clients com os dados da tabela Clients da base de dados
            dgv_clients.DataSource = Client.ClientList();
        }

        /// <summary>
        /// Método do evento double click na dgv_clients -> Caso seja necessário fazer update, damos dois cliques na célula da dgv_clients, os campos do formulário serão preenchidos automaticamente
        /// e então é possível fazer o update do campo que queremos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_clients_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Verificar qual linha foi selecionada na dgv_clients e guardar na variável "_client"
            var _client = (Client)dgv_clients.Rows[e.RowIndex].DataBoundItem;

            //Preencher os campos do formulário com os dados salvos no banco de dados do cliente selecionado
            tb_id.Text = _client.Id.ToString();
            tb_name.Text = _client.Name;
            tb_address.Text = _client.Address;
            tb_postalCode.Text = _client.PostalCode;
            tb_email.Text = _client.Email;
            tb_phone.Text = _client.Phone.ToString();
            tb_nif.Text = _client.Nif.ToString();
        }

        /// <summary>
        /// Método do evento KeyPress da tb_postalCode que valida se os dados inseridos são numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_postalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("This field only accepts numbers.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método do evento Leave da tb_nif que valida se o NIF inserido é válido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_nif_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tb_nif.Text, @"\d{9}$"))
            {
                MessageBox.Show("Invalid NIF. Please, enter a valid NIF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_nif.Focus();
            }
        }
    }
}
