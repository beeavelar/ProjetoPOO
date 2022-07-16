using Business;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.UI
{
    public partial class Form_EmaiDayOff : Form
    {
        /// <summary>
        /// Método construtor da classe Form_EmaiDayOff
        /// </summary>
        public Form_EmaiDayOff()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_send -> Chama o método SendEmail() e envia um email a avisar o cliente qua a oficina não vai abrir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_send_Click(object sender, EventArgs e)
        {
            await SendEmail(tb_to.Text, "Repair Shop - Repair schedule day off");
            MessageBox.Show("Email successfully sent.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Método auxiliar para fazer o envio de emails
        /// </summary>
        public async Task SendEmail(string _email, string _subject)
        {
            var _apiKey = "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";
            var _client = new SendGridClient(_apiKey);

            var _from = new EmailAddress("cet69.repairshop@gmail.com", "Repair Shop");
            var _to = new EmailAddress(_email);

            var _plainTextContent = "Dear Sr.(a),\n\n" +
                                    "We would like to inform that, for greater reasons, we will not be able to open the Repair Shop on the day we had scheduled for you.\n" +
                                    "Therefore, we will contact you shortly to reschedule your vehicle repair.\n\n" +
                                    "Our sincere apologies for the inconvenience.\n\n" +
                                    "Best regards,\n" +
                                    "Repais Shop";
            var _htmlContent = "";

            var _msg = MailHelper.CreateSingleEmail(_from, _to, _subject, _plainTextContent, _htmlContent);

            var _response = await _client.SendEmailAsync(_msg);
        }

        /// <summary>
        /// Método do evento Load do formulário Form_EmaiDayOff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_EmaiDayOff_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_schedules com os dados da tabela Schedules da base de dados
            dgv_schedules.DataSource = Schedule.ScheduleList();

            toolTip1.SetToolTip(btn_send, "Send");
            toolTip1.SetToolTip(btn_searchDate, "Search");
        }

        /// <summary>
        /// Método do evento click do btn_searchDate -> Pesquisa marcações pela data de início do serviço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_searchDate_Click(object sender, EventArgs e)
        {
            DateTime _searchStartDate = Convert.ToDateTime(dtp_startDateSearch.Value.ToString("yyyy-MM-dd"));
            DateTime _searchEndDate = Convert.ToDateTime(dtp_endDateSearch.Value.ToString("yyyy-MM-dd"));

            var _searchDate = new DataBase.Schedule().ScheduleListStartDate(_searchStartDate, _searchEndDate);

            if (_searchDate.Rows.Count == 0)
                MessageBox.Show("No schedule was found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dgv_schedules.DataSource = Schedule.ScheduleListStartDate(_searchStartDate, _searchEndDate);
        }
    }
}
