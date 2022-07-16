using Business;
using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_ManageVehicles : Form
    {
        /// <summary>
        /// Método construtor da classe Form_ManageVehicles
        /// </summary>
        public Form_ManageVehicles()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que valida se todos os campos do formulário foram preenchidos
        /// </summary>
        private bool CheckEmptyFields()
        {
            bool _output = true;

            if (string.IsNullOrEmpty(cb_client.Text) || string.IsNullOrEmpty(tb_licensePlate.Text) || string.IsNullOrEmpty(cb_brands.Text) || string.IsNullOrEmpty(cb_category.Text) || string.IsNullOrEmpty(tb_model.Text) || string.IsNullOrEmpty(tb_color.Text) || string.IsNullOrEmpty(tb_year.Text))
            {
                MessageBox.Show("All fields must be filled.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _output = false;
            }
            return _output;
        }

        /// <summary>
        /// Método do evento click do btn_clearData -> Limpa todos os campos do formulário "VEHICLE´S FORM"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clearData_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        /// <summary>
        /// Método do evento click do btn_delete -> Deleta veículos cadastrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var _vehicle = (Vehicle)dgv_vehicles.Rows[dgv_vehicles.SelectedCells[0].RowIndex].DataBoundItem;

            var _confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (_confirmResult == DialogResult.Yes)
            {
                Vehicle.Delete(_vehicle.Id);
                MessageBox.Show("The selected item has been deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_vehicles.DataSource = Vehicle.VehicleList();
            }
        }

        /// <summary>
        /// Método do evento click do btn_search -> Pesquisa veículos pela placa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_licenseToSearch.Text))
                MessageBox.Show("Please, enter a vehicle license plate.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                dgv_vehicles.DataSource = Vehicle.VehicleList(tb_licenseToSearch.Text);
        }

        /// <summary>
        /// Método auxiliar criado para limpar os dados inseridos no formulário "VEHICLE´S FORM"
        /// </summary>
        private void ClearData()
        {
            tb_id.Text = "";
            cb_client.Text = "";
            tb_licensePlate.Text = "";
            cb_brands.Text = "";
            cb_category.Text = "";
            tb_model.Text = "";
            tb_color.Text = "";
            tb_year.Text = "";
        }

        /// <summary>
        /// Método do evento KeyPress da tb_year que valida se os dados inseridos são numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("This field only accepts numbers.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método do evento Load do formulário Form_ManageVehicles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_ManageVehicles_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_vehicles com os dados da tabela Vehicles da base de dados
            dgv_vehicles.DataSource = Vehicle.VehicleList();

            //Carrega a cb_client com os nomes dos clientes cadastrados na tabela Clients da base de dados
            cb_client.DataSource = Client.ClientList();
            cb_client.DisplayMember = "Name";

            toolTip1.SetToolTip(btn_save, "Save");
            toolTip1.SetToolTip(btn_clearData, "Clear data");
            toolTip1.SetToolTip(btn_delete, "Delete");
            toolTip1.SetToolTip(btn_search, "Search");

            ClearData();

            cb_client.Focus();
            cb_client.Select();
        }

        /// <summary>
        /// Método do evento click do btn_update -> Atualiza a dgv_vehicles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            //Carrega a dgv_vehicles com os dados da tabela Vehicles da base de dados
            dgv_vehicles.DataSource = Vehicle.VehicleList();
        }

        /// <summary>
        /// Método do evento click do btn_save -> Valida (ValidateData()) e salva no banco de dados as informações inseridas no formulário "VEHICLE´S FORM"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                if (string.IsNullOrEmpty(tb_id.Text)) tb_id.Text = "0";

                var _newVehicle = new Vehicle()
                {
                    Id = Convert.ToInt32(tb_id.Text),
                    ClientName = cb_client.Text,
                    LicensePlate = tb_licensePlate.Text,
                    Brand = cb_brands.Text,
                    Category = cb_category.Text,
                    Model = tb_model.Text,
                    Color = tb_color.Text,
                    VehicleYear = Convert.ToInt32(tb_year.Text)
                };
                _newVehicle.Save();

                if (tb_id.Text == "0")
                    MessageBox.Show("New vehicle has been saved successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                    MessageBox.Show("Data has been updated successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearData();
                dgv_vehicles.DataSource = Vehicle.VehicleList();
            }
        }

        /// <summary>
        /// Método do evento double click na dgv_vehicles -> Caso seja necessário fazer update, damos dois cliques na célula da dgv_vehicles, os campos do formulário serão preenchidos automaticamente
        /// e então é possível fazer o update do campo que queremos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_vehicles_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var _vehicle = (Vehicle)dgv_vehicles.Rows[e.RowIndex].DataBoundItem;

            tb_id.Text = _vehicle.Id.ToString();
            cb_client.Text = _vehicle.ClientName;
            tb_licensePlate.Text = _vehicle.LicensePlate;
            cb_brands.Text = _vehicle.Brand;
            cb_category.Text = _vehicle.Category;
            tb_model.Text = _vehicle.Model;
            tb_color.Text = _vehicle.Color;
            tb_year.Text = _vehicle.VehicleYear.ToString();
        }
    }
}
