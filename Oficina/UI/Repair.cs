using Business;
using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_Repairs : Form
    {
        /// <summary>
        /// Método construtor da classe Form_Repairs
        /// </summary>
        public Form_Repairs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_close -> Fecha o formulário Form_Repairs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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
        /// Método do evento click do btn_update -> Atualiza a dgv_repairs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            dgv_repairs.DataSource = Repair.RepairList();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_Repairs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Repairs_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_repairs com os dados da tabela Repairs da base de dados
            dgv_repairs.DataSource = Repair.RepairList();

            toolTip1.SetToolTip(btn_close, "Close");
            toolTip1.SetToolTip(btn_addManageRepair, "Add/Manage repairs");
            toolTip1.SetToolTip(btn_search, "Search");
            toolTip1.SetToolTip(btn_update, "Update");

            tb_repairSearch.Focus();
            tb_repairSearch.Select();
        }

        /// <summary>
        /// Método do evento click do btn_addManageRepair -> Abre o Form_ManageRepairs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addManageRepair_Click(object sender, EventArgs e)
        {
            Form_ManageRepairs _newRepair = new Form_ManageRepairs();
            _newRepair.ShowDialog();
        }
    }
}
