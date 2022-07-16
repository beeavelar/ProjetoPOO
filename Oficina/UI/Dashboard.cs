using Business;
using Oficina.UI;
using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_Dashboard : Form
    {
        private Form _activeForm = null;
        public Form_Dashboard()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panel_settingSubpanel.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panel_settingSubpanel.Visible == true)
                panel_settingSubpanel.Visible = false;
        }

        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        /// <summary>
        /// Método auxiliar que controla o que cada tipo de users tem acesso no sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserAccess()
        {
            if (lbl_permission.Text == "Frontdesk")
            {
                btn_settings.Visible = false;
                btn_mechanic.Visible = false;
                btn_repair.Visible = false;
            }

            if (lbl_permission.Text == "Mechanic")
            {
                btn_vehicle.Visible = false;
                btn_client.Visible = false;
                btn_mechanic.Visible = false;
                btn_repair.Visible = false;
                btn_schedule.Visible = false;
                btn_invoice.Visible = false;
                btn_communication.Visible = false;
                btn_settings.Visible = false;
            }

            if (lbl_permission.Text == "Manager")
            {
                btn_settings.Visible = false;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
                _activeForm.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_principal.Controls.Add(childForm);
            panel_principal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// Método do evento click do btn_home -> Abre o Form_Home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Home());
        }

        /// <summary>
        /// Método do evento click do btn_vehicle -> Abre o Form_Vehicles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_vehicle_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Vehicles());
        }

        /// <summary>
        /// Método do evento click do btn_client -> Abre o Form_Clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_client_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Clients());
        }

        /// <summary>
        /// Método do evento click do btn_mechanic -> Abre o Form_Mechanic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mechanic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Mechanic());
        }

        /// <summary>
        /// Método do evento click do btn_repair -> Abre o Form_Repairs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_repair_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Repairs());
        }

        /// <summary>
        /// Método do evento click do btn_schedule -> Abre o Form_Schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_schedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Schedule());
        }

        /// <summary>
        /// Método do evento click do btn_invoice -> Abre o Form_Invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_invoice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Invoice());
        }

        /// <summary>
        /// Método do evento click do btn_logout -> Confirma se o user deseja sair do sistema, sai do sistema e volta para o Form_Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to exit the System?", "Confirm Logout", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                Form_Login FormLogin = new Form_Login();
                FormLogin.Show();
            }
        }

        /// <summary>
        /// Método do evento Load do formulário form_Dashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_Dashboard_Load(object sender, EventArgs e)
        {
            //Preenche a lbl_name e a lbl_permission com os dados correspondentes do user logado
            lbl_name.Text = User.UserLogged.Name;
            lbl_permission.Text = User.UserLogged.Permission;

            //Chama o método UserAccess() que controla o que cada tipo de users tem acesso no sistema
            UserAccess();

            //Inica o timer1
            timer1.Start();

            toolTip1.SetToolTip(btn_logout, "Logout");
        }

        /// <summary>
        /// Método do evento click do btn_settings -> Abre o submenu que contém o btn_newUser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_settings_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_settingSubpanel);
        }

        /// <summary>
        /// Método do evento click do btn_newUser -> Abre o Form_ManageUsers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_newUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_ManageUsers());
        }

        /// <summary>
        /// Método do evento Tick do timer1 -> Mostra a data e hora atual na lbl_hours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hours.Text = ($"{(DateTime.Now).DayOfWeek.ToString()},{Convert.ToString(DateTime.Now)}");
        }

        /// <summary>
        /// Método do evento click do btn_communication -> Abre o Form_Communication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_communication_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Communication());
        }

        /// <summary>
        /// Método do evento click do btn_about -> Abre o Form_About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_about_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_About());
        }
    }
}
