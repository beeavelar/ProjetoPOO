using System;
using System.Windows.Forms;

namespace Oficina.UI
{
    public partial class Form_Communication : Form
    {
        /// <summary>
        /// Método construtor da classe Form_Communication
        /// </summary>
        public Form_Communication()
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
        /// Método do evento click do btn_emailDayOff -> Abre o Form_EmaiDayOff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_emailDayOff_Click(object sender, EventArgs e)
        {
            Form_EmaiDayOff _formDayOff = new Form_EmaiDayOff();
            _formDayOff.ShowDialog();
        }

        /// <summary>
        /// Método do evento click do btn_emailAlert -> Abre o Form_EmailAlert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_emailAlert_Click(object sender, EventArgs e)
        {
            Form_EmailAlert _formEmailAlert = new Form_EmailAlert();
            _formEmailAlert.ShowDialog();
        }

        /// <summary>
        /// Método do evento click do btn_emailHolydays -> Abre o Form_EmailHolidays
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_emailHolydays_Click(object sender, EventArgs e)
        {
            Form_EmailHolidays _formEmailHolidays = new Form_EmailHolidays();
            _formEmailHolidays.ShowDialog();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_Communication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Communication_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_emailDayOff, "E-mail date alert");
            toolTip1.SetToolTip(btn_emailAlert, "E-mail day off");
            toolTip1.SetToolTip(btn_emailHolydays, "E-mail holidays");
        }
    }
}
