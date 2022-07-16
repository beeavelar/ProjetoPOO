using Business;
using Oficina.UI;
using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_Schedule : Form
    {
        /// <summary>
        /// Método construtor da classe Form_Schedule
        /// </summary>
        public Form_Schedule()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_close -> Fecha o formulário Form_Schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método do evento click do btn_addManageSchedule -> Abre o Form_ManageSchedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addManageSchedule_Click(object sender, EventArgs e)
        {
            Form_ManageSchedule _formNewSchedule = new Form_ManageSchedule();
            _formNewSchedule.ShowDialog();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_Schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Schedule_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_schedules com os dados da tabela Schedules da base de dados
            dgv_schedules.DataSource = Schedule.ScheduleList();

            toolTip1.SetToolTip(btn_close, "Close");
            toolTip1.SetToolTip(btn_addManageSchedule, "Add/Manage schedules");
            toolTip1.SetToolTip(btn_searchStartDate, "Search");

            dtp_startDateSearch.Focus();
            dtp_startDateSearch.Select();
        }

        /// <summary>
        /// Método do evento click do  btn_searchStartDate -> Pesquisa marcações pela data de entrada do veículo na oficina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_searchStartDate_Click(object sender, EventArgs e)
        {
            DateTime _searchStartDate = Convert.ToDateTime(dtp_startDateSearch.Value.ToString("yyyy-MM-dd"));
            DateTime _searchEndDate = Convert.ToDateTime(dtp_endDateSearch.Value.ToString("yyyy-MM-dd"));

            var _searchDate = new DataBase.Schedule().ScheduleListStartDate(_searchStartDate, _searchEndDate);

            if (_searchDate.Rows.Count == 0)
                MessageBox.Show("No schedule was found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dgv_schedules.DataSource = Schedule.ScheduleListStartDate(_searchStartDate, _searchEndDate);
        }

        /// <summary>
        /// Método do evento click do btn_update -> Atualiza a dgv_schedules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            dgv_schedules.DataSource = Schedule.ScheduleList();
        }
    }
}
