using Business;
using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_Mechanic : Form
    {
        /// <summary>
        /// Método construtor da classe Form_Mechanic
        /// </summary>
        public Form_Mechanic()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_close -> Fecha o formulário Form_Mechanic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_Mechanic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Mechanic_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_mechanics com os dados da tabela Mechanics da base de dados
            dgv_mechanics.DataSource = Mechanic.MechanicList();

            toolTip1.SetToolTip(btn_close, "Close");
            toolTip1.SetToolTip(btn_addManageMechanic, "Add/Manage clients");
            toolTip1.SetToolTip(btn_search, "Search");
            toolTip1.SetToolTip(btn_update, "Update");

            tb_nameToSearch.Focus();
            tb_nameToSearch.Select();
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
        /// Método do evento click do btn_addManageMechanic -> Abre o Form_ManageMechanics 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addManageMechanic_Click(object sender, EventArgs e)
        {
            Form_ManageMechanics _newFormMechanic = new Form_ManageMechanics();
            _newFormMechanic.ShowDialog();
        }

    }
}
