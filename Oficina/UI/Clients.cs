using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_Clients : Form
    {
        /// <summary>
        /// Método construtor da classe Form_Clients
        /// </summary>
        public Form_Clients()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_close -> Fecha o formulário Form_Clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método do evento click do btn_search -> Pesquisa clientes pelo nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nameToSearch.Text))
                MessageBox.Show("Please, enter a customer name.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                dgv_clients.DataSource = Client.ClientList(tb_nameToSearch.Text);
        }

        /// <summary>
        /// Método do evento click do btn_update -> Atualiza a dgv_clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            dgv_clients.DataSource = Client.ClientList();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_Clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Clients_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_clients com os dados da tabela Clients da base de dados
            dgv_clients.DataSource = Client.ClientList();

            toolTip1.SetToolTip(btn_close, "Close");
            toolTip1.SetToolTip(btn_addManageClient, "Add/Manage clients");
            toolTip1.SetToolTip(btn_search, "Search");
            toolTip1.SetToolTip(btn_update, "Update");

            tb_nameToSearch.Focus();
            tb_nameToSearch.Select();
        }

        /// <summary>
        /// Método do evento click do btn_addManageClient -> Abre o Form_ManageClients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addManageClient_Click(object sender, EventArgs e)
        {
            Form_ManageClients _newClient = new Form_ManageClients();
            _newClient.ShowDialog();
        }

    }
}
