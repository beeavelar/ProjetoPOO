using Business;
using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_ScheduleList : Form
    {
        /// <summary>
        /// Método construtor da classe Form_ScheduleList
        /// </summary>
        public Form_ScheduleList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_ScheduleList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_ScheduleList_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_schedule com os dados da tabela Schedules da base de dados
            dgv_schedule.DataSource = Schedule.ScheduleList();
        }
    }
}
