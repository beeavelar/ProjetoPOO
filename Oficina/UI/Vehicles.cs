using Business;
using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_Vehicles : Form
    {
        /// <summary>
        /// Método construtor da classe Form_Vehicles
        /// </summary>
        public Form_Vehicles()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_close -> Fecha o formulário Form_Vehicles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summar>
        /// Método do evento click do btn_search -> Pesquisa veículos pela placa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_licenseToSearch.Text))
                MessageBox.Show("Please, enter a license plate.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                dgv_vehicles.DataSource = Vehicle.VehicleList(tb_licenseToSearch.Text);
        }

        /// <summary>
        /// Método do evento click do btn_update -> Atualiza a dgv_vehicles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            dgv_vehicles.DataSource = Vehicle.VehicleList();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_Vehicles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Vehicles_Load(object sender, EventArgs e)
        {
            dgv_vehicles.DataSource = Vehicle.VehicleList();

            toolTip1.SetToolTip(btn_close, "Close");
            toolTip1.SetToolTip(btn_addManageVehicle, "Add/Manage clients");
            toolTip1.SetToolTip(btn_search, "Search");
            toolTip1.SetToolTip(btn_update, "Update");

            tb_licenseToSearch.Focus();
            tb_licenseToSearch.Select();
        }

        /// <summary>
        /// Método do evento click do btn_addManageVehicle -> Abre o Form_ManageVehicles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addManageVehicle_Click(object sender, EventArgs e)
        {
            Form_ManageVehicles _newVehicle = new Form_ManageVehicles();
            _newVehicle.ShowDialog();
        }
    }
}
