using Business;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_ManageMechanics : Form
    {
        /// <summary>
        /// Método construtor da classe Form_ManageMechanics
        /// </summary>
        public Form_ManageMechanics()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método auxiliar criado para limpar os dados inseridos no formulário "MECHANIC´S FORM"
        /// </summary>
        private void ClearData()
        {
            tb_id.Text = "";
            tb_name.Text = "";
            tb_address.Text = "";
            tb_postalCode.Text = "";
            tb_email.Text = "";
            tb_cc.Text = "";
            tb_phone.Text = "";
            tb_nif.Text = "";
            tb_niss.Text = "";
        }

        /// <summary>
        /// Método que valida se todos os campos do formulário foram preenchidos
        /// </summary>
        private bool CheckEmptyFields()
        {
            bool _output = true;

            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_address.Text) || !tb_postalCode.MaskCompleted || string.IsNullOrEmpty(tb_email.Text) || string.IsNullOrEmpty(tb_cc.Text) || string.IsNullOrEmpty(tb_phone.Text) || string.IsNullOrEmpty(tb_nif.Text) || string.IsNullOrEmpty(tb_niss.Text))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _output = false;
            }
            return _output;
        }

        /// <summary>
        /// Método do evento click do btn_save -> Valida (ValidateData()) e salva no banco de dados as informações inseridas no formulário "MECHANIC´S FORM"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                if (string.IsNullOrEmpty(tb_id.Text)) tb_id.Text = "0";

                var _newMechanic = new Mechanic()
                {
                    Id = Convert.ToInt32(tb_id.Text),
                    Name = tb_name.Text,
                    Address = tb_address.Text,
                    PostalCode = tb_postalCode.Text,
                    Email = tb_email.Text,
                    CC = Convert.ToInt32(tb_cc.Text),
                    Phone = Convert.ToInt32(tb_phone.Text),
                    Nif = Convert.ToInt32(tb_nif.Text),
                    Niss = tb_niss.Text
                };
                _newMechanic.Save();

                if (tb_id.Text == "0")
                    MessageBox.Show("New mechanic has been saved successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                    MessageBox.Show("Data has been updated successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearData();
                dgv_mechanics.DataSource = Mechanic.MechanicList();
            }
        }

        /// <summary>
        /// Método do evento Load do formulário Form_ManageMechanics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_ManageMechanics_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_mechanics com os dados da tabela Mechanics da base de dados
            dgv_mechanics.DataSource = Mechanic.MechanicList();

            toolTip1.SetToolTip(btn_save, "Save");
            toolTip1.SetToolTip(btn_clearData, "Clear data");
            toolTip1.SetToolTip(btn_delete, "Delete");
            toolTip1.SetToolTip(btn_search, "Search");

            tb_name.Focus();
            tb_name.Select();
        }

        /// <summary>
        /// Método do evento click do btn_clearData -> Limpa todos os campos do formulário "MECHANIC´S FORM"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clearData_Click(object sender, EventArgs e)
        {
            //Clama o método ClearData();
            ClearData();
        }

        /// <summary>
        /// Método do evento click do btn_search -> Pesquisa mecânicos pelo nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nameToSearch.Text))
                MessageBox.Show("Please, enter a mechanic name.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                dgv_mechanics.DataSource = Mechanic.MechanicList(tb_nameToSearch.Text);
        }

        /// <summary>
        /// Método do evento click do btn_delete -> Deleta mecânicos cadastrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var _mechanic = (Mechanic)dgv_mechanics.Rows[dgv_mechanics.SelectedCells[0].RowIndex].DataBoundItem;

            var _confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (_confirmResult == DialogResult.Yes)
            {
                Mechanic.Delete(_mechanic.Id);
                MessageBox.Show("The selected item has been deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_mechanics.DataSource = Mechanic.MechanicList();
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
        /// Método do evento KeyPress da tb_cc que valida se os dados inseridos são numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_cc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("This field only accepts numbers.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
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
        /// Método do evento KeyPress da tb_niss que valida se os dados inseridos são numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_niss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("This field only accepts numbers.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
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
        /// Método do evento Leave da tb_cc que valida se o número do cartão cidadão inserido é válido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_cc_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tb_cc.Text, @"\d{8}$"))
            {
                MessageBox.Show("Invalid ID card number. Please, enter a valid ID card number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_nif.Focus();
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
            }
        }

        /// <summary>
        /// Método do evento Leave da tb_niss que valida se o NISS inserido é válido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_niss_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tb_niss.Text, @"\d{11}$"))
            {
                MessageBox.Show("Invalid NISS. Please, enter a valid NISS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_niss.Focus();
            }
        }

        /// <summary>
        /// Método do evento click do btn_update -> Atualiza a dgv_mechanics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            //Carrega a dgv_mechanics com os dados da tabela Mechanics da base de dados
            dgv_mechanics.DataSource = Mechanic.MechanicList();
        }

        /// <summary>
        /// Método do evento double click na dgv_mechanics -> Caso seja necessário fazer update, damos dois cliques na célula da dgv_mechanics, os campos do formulário serão preenchidos automaticamente
        /// e então é possível fazer o update do campo que queremos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_mechanics_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var _mechanic = (Mechanic)dgv_mechanics.Rows[e.RowIndex].DataBoundItem;

            tb_id.Text = _mechanic.Id.ToString();
            tb_name.Text = _mechanic.Name;
            tb_address.Text = _mechanic.Address;
            tb_postalCode.Text = _mechanic.PostalCode;
            tb_email.Text = _mechanic.Email;
            tb_cc.Text = _mechanic.CC.ToString();
            tb_phone.Text = _mechanic.Phone.ToString();
            tb_nif.Text = _mechanic.Nif.ToString();
            tb_niss.Text = _mechanic.Niss;
        }

        /// <summary>
        /// Método do evento Leave da tb_nif que valida se o NIF inserido é válido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_nif_Leave_1(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tb_nif.Text, @"\d{9}$"))
            {
                MessageBox.Show("Invalid NIF. Please, enter a valid NIF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_nif.Focus();
            }
        }
    }
}
