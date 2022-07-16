using Business;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.UI
{
    public partial class Form_EmailAlert : Form
    {
        /// <summary>
        /// Método construtor da classe Form_EmailAlert
        /// </summary>
        public Form_EmailAlert()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_EmailAlert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Email_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_schedules com os dados da tabela Schedules da base de dados
            dgv_schedules.DataSource = Schedule.ScheduleList();

            toolTip1.SetToolTip(btn_send, "Send");
            toolTip1.SetToolTip(btn_searchDateAlert, "Search");
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
                                    "We would like to alert you that you have an appointment at the Repair Shop for tomorrow at " + tb_time.Text + ".\n\n" +
                                    "We thank you for your preference.\n\n" +
                                    "Best regards,\n" +
                                    "Repais Shop";
            var _htmlContent = "";

            var _msg = MailHelper.CreateSingleEmail(_from, _to, _subject, _plainTextContent, _htmlContent);

            var _response = await _client.SendEmailAsync(_msg);
        }

        /// <summary>
        /// Método do evento click do btn_searchDateAlert -> Pesquisa marcações pela data de alerta da marcação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_searchDateAlert_Click_2(object sender, EventArgs e)
        {
            DateTime _searchAlertdate = Convert.ToDateTime(dtp_alertDate.Value.ToString("yyyy-MM-dd"));

            var _searchDate = new DataBase.Schedule().ScheduleListAlertDate(_searchAlertdate);

            if (_searchDate.Rows.Count == 0)
                MessageBox.Show("No schedule was found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dgv_schedules.DataSource = Schedule.ScheduleListAlertDate(_searchAlertdate);
        }

        /// <summary>
        /// Método do evento click do btn_send -> Chama o método SendEmail() e envia um email a alertar o cliente da data da marcação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_send_Click(object sender, EventArgs e)
        {
            await SendEmail(tb_to.Text, "Repair Shop - Repair schedule alert");
            MessageBox.Show("Email successfully sent.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
