using Business;
using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_ServicesList : Form
    {
        /// <summary>
        /// Método construtor da classe Form_ServicesList
        /// </summary>
        public Form_ServicesList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_ServicesList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_ServicesList_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_services com os dados da tabela Repairs da base de dados
            dgv_services.DataSource = Repair.RepairList();
        }
    }
}
