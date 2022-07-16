using Business;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_ManageRepairs : Form
    {
        /// <summary>
        /// Método construtor da classe Form_ManageRepairs
        /// </summary>
        public Form_ManageRepairs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_save -> Valida (ValidateData()) e salva no banco de dados as informações inseridas no formulário "REPAIR´S FORM"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                if (string.IsNullOrEmpty(tb_id.Text)) tb_id.Text = "0";

                var _newRepair = new Repair()
                {
                    Id = Convert.ToInt32(tb_id.Text),
                    Code = tb_repairCode.Text,
                    Price = Convert.ToDecimal(tb_price.Text),
                    Description = tb_description.Text,
                    LaborPrice = Convert.ToDecimal(tb_laborPrice.Text),
                };
                _newRepair.Save();

                if (tb_id.Text == "0")
                    MessageBox.Show("New repair has been saved successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    MessageBox.Show("Data has been updated successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_id.Text = "0";
                }
                ClearData();
                dgv_repairs.DataSource = Repair.RepairList();
            }
        }

        /// <summary>
        /// Método que valida se todos os campos do formulário foram preenchidos
        /// </summary>
        private bool CheckEmptyFields()
        {
            bool _output = true;

            if (string.IsNullOrEmpty(tb_repairCode.Text) || string.IsNullOrEmpty(tb_price.Text) || string.IsNullOrEmpty(tb_laborPrice.Text) || string.IsNullOrEmpty(tb_description.Text))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _output = false;
            }
            return _output;
        }

        /// <summary>
        /// Método do evento click do btn_clearData -> Limpa todos os campos do formulário "REPAIR´S FORM"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clearData_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        /// <summary>
        /// Método auxiliar criado para limpar os dados inseridos no formulário "REPAIR´S FORM"
        /// </summary>

        private void ClearData()
        {
            tb_id.Text = "";
            tb_repairCode.Text = "";
            tb_price.Text = "";
            tb_laborPrice.Text = "";
            tb_description.Text = "";
        }

        /// <summary>
        /// Método do evento Load do formulário Form_ManageRepairs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_ManageRepairs_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_repairs com os dados da tabela Repairs da base de dados
            dgv_repairs.DataSource = Repair.RepairList();

            toolTip1.SetToolTip(btn_save, "Save");
            toolTip1.SetToolTip(btn_clearData, "Clear data");
            toolTip1.SetToolTip(btn_delete, "Delete");
            toolTip1.SetToolTip(btn_search, "Search");

            tb_repairCode.Focus();
        }

        /// <summary>
        /// Método do evento click do btn_search -> Pesquisa um reparo pela sua descrição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_repairSearch.Text))
                MessageBox.Show("Please, enter a repair code.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                dgv_repairs.DataSource = Repair.RepairList(tb_repairSearch.Text);
        }

        /// <summary>
        /// Método do evento click do btn_delete -> Deleta reparos cadastrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var _repair = (Repair)dgv_repairs.Rows[dgv_repairs.SelectedCells[0].RowIndex].DataBoundItem;

            var _confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (_confirmResult == DialogResult.Yes)
            {
                Repair.Delete(_repair.Id);
                MessageBox.Show("The selected item has been deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_repairs.DataSource = Repair.RepairList();
            }
        }

        /// <summary>
        /// Método do evento click do btn_update -> Atualiza a dgv_repairs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            //Carrega a dgv_repairs com os dados da tabela Repairs da base de dados
            dgv_repairs.DataSource = Repair.RepairList();
        }

        /// <summary>
        /// Método do evento KeyPress da tb_price que permite inserir apenas números e vígula e faz a configuração do valor inserido para o formato monetário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                MessageBox.Show("This field only accepts numbers and comma.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }

            if ((e.KeyChar == (char)13))
                tb_price.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N2}", double.Parse(tb_price.Text));
        }

        /// <summary>
        /// Método do evento double click na dgv_repairs -> Caso seja necessário fazer update, damos dois cliques na célula da dgv_repairs, os campos do formulário serão preenchidos automaticamente
        /// e então é possível fazer o update do campo que queremos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_repairs_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var _repair = (Repair)dgv_repairs.Rows[e.RowIndex].DataBoundItem;

            tb_id.Text = _repair.Id.ToString();
            tb_repairCode.Text = _repair.Code;
            tb_price.Text = Decimal.Round(_repair.Price, 2).ToString();
            tb_laborPrice.Text = Decimal.Round(_repair.LaborPrice, 2).ToString();
            tb_description.Text = _repair.Description;
        }

        /// <summary>
        /// Método do evento KeyPress da tb_laborPrice que permite inserir apenas números e vígula e faz a configuração do valor inserido para o formato monetário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_laborPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                MessageBox.Show("This field only accepts numbers and comma.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }

            if ((e.KeyChar == (char)13))
                tb_price.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", double.Parse(tb_price.Text));
        }
    }
}
