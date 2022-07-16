using Business;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.UI
{
    public partial class Form_ManageSchedule : Form
    {
        /// <summary>
        /// Método construtor da classe Form_ManageSchedule
        /// </summary>
        public Form_ManageSchedule()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Método que valida se todos os campos do formulário foram preenchidos
        /// </summary>
        private bool CheckEmptyFields()
        {
            bool _output = true;

            if (string.IsNullOrEmpty(cb_vehicle.Text) || string.IsNullOrEmpty(cb_repair.Text) || string.IsNullOrEmpty(cb_mechanic.Text) || string.IsNullOrEmpty(cb_client.Text) || string.IsNullOrEmpty(dtp_startDate.Text) || string.IsNullOrEmpty(dtp_endDate.Text) || string.IsNullOrEmpty(dtp_alertDate.Text) || string.IsNullOrEmpty(tb_time.Text) || !tb_time.MaskCompleted)
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _output = false;
            }
            return _output;
        }

        /// <summary>
        /// Método do evento click do btn_close -> Fecha o formulário Form_ManageSchedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_ManageSchedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_ManageSchedule_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_schedules com os dados da tabela Schedules da base de dados
            //Carrega a dgv_schedules com os dados da tabela Schedules da base de dados
            dgv_schedules.DataSource = Schedule.ScheduleList();

            //Carrega a cb_vehicle com a placa dos veículos cadastrados na tabela Vehicles da base de dados
            cb_vehicle.DataSource = Vehicle.VehicleList();
            cb_vehicle.DisplayMember = "LicensePlate";

            //Carrega a cb_repair com a descrição dos reparos cadastrados na tabela Repairs da base de dados
            cb_repair.DataSource = Repair.RepairList();
            cb_repair.DisplayMember = "Description";

            //Carrega a cb_mechanic com o nome dos mecânicos cadastrados na tabela Mechanics da base de dados
            cb_mechanic.DataSource = Mechanic.MechanicList();
            cb_mechanic.DisplayMember = "Name";

            //Carrega a cb_client com o nome dos clientes cadastrados na tabela Clients da base de dados
            cb_client.DataSource = Client.ClientList();
            cb_client.DisplayMember = "Name";

            ClearData();

            toolTip1.SetToolTip(btn_save, "Save");
            toolTip1.SetToolTip(btn_clearData, "Clear data");
            toolTip1.SetToolTip(btn_delete, "Delete");
            toolTip1.SetToolTip(btn_search, "Search");
            toolTip1.SetToolTip(btn_update, "Update");

            cb_vehicle.Focus();
            cb_vehicle.Select();
        }

        /// <summary>
        /// Método do evento click do btn_save -> Valida (ValidateData()), salva no banco de dados as informações inseridas no formulário "SCHEDULE´S FORM" e envia e-mail confirmando a marcação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                if (string.IsNullOrEmpty(tb_id.Text)) tb_id.Text = "0";

                var _newSchedule = new Schedule()
                {
                    Id = Convert.ToInt32(tb_id.Text),
                    Vehicle = cb_vehicle.Text,
                    Repair = cb_repair.Text,
                    Mechanic = cb_mechanic.Text,
                    Client = cb_client.Text,
                    StartDate = Convert.ToDateTime(dtp_startDate.Text),
                    EndDate = Convert.ToDateTime(dtp_endDate.Text),
                    Alertdate = Convert.ToDateTime(dtp_alertDate.Text),
                    Time = tb_time.Text,
                    Email = tb_email.Text
                };
                _newSchedule.Save();

                if (tb_id.Text == "0")
                {
                    await SendEmail(tb_email.Text, "Repair Shop - Repair schedule confirmation");
                    MessageBox.Show("New schedule has been saved successfully and an e-mail was sent to the client.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await SendEmail(tb_email.Text, "Repair schedule confirmation");
                    MessageBox.Show("Data has been updated successfully and an e-mail was sent to the client.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClearData();
                dgv_schedules.DataSource = Schedule.ScheduleList();
            }
        }

        /// <summary>
        /// Método auxiliar para fazer o envio de emails
        /// </summary>
        public async Task SendEmail(string _email, string _subject)
        {
            try
            {
                //Indicar a Apikey e guardar ela na variável "_apikey" -- >logando no website do Sendgrid é possível criar uma Apikey
                var _apiKey = "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";

                //O método da biblioteca auxiliar SendGridClient(), passa a apikey para a API v3 em um cabeçalho de autorização usando a autenticação de token de portador
                var _client = new SendGridClient(_apiKey);

                //Indicar o email do remetente
                var _from = new EmailAddress("cet69.repairshop@gmail.com", "Repair Shop");
                //O email do destinatário vai ser passada através da variável "_email" porque ele vem da tb_email
                var _to = new EmailAddress(_email);

                //Mensagem que vai aparecer no e-mail
                var _plainTextContent = "Dear Sr.(a) " + cb_client.Text + ",\n\n" +
                                        "Your schedule at Repair Shop is confirmed/updated to " + dtp_startDate.Text + " at " + tb_time.Text + ".\n\n" +
                                        "We thank you for your preference.\n\n" +
                                        "Best regards,\n" +
                                        "Repais Shop";
                var _htmlContent = "";

                //Criação do e-mail
                var _msg = MailHelper.CreateSingleEmail(_from, _to, _subject, _plainTextContent, _htmlContent);

                //Solicitar à API SendGrid Mail Send para enviar o e-mail
                var _response = await _client.SendEmailAsync(_msg);
            }
            catch (Exception)
            {
                MessageBox.Show("Error sending the email.", "Erro Envio de Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método auxiliar criado para limpar os dados inseridos no formulário "SCHEDULE´S FORM"
        /// </summary>
        private void ClearData()
        {
            tb_id.Text = "";
            cb_vehicle.Text = "";
            cb_repair.Text = "";
            cb_mechanic.Text = "";
            cb_client.Text = "";
            dtp_startDate.MinDate = DateTime.Today; ;
            dtp_endDate.MinDate = DateTime.Today;
            dtp_alertDate.MinDate = DateTime.Today;
            tb_time.Text = DateTime.Now.ToString("HH:MM");
            tb_email.Text = "";
        }

        /// <summary>
        /// Método do evento click do btn_clearData -> Limpa todos os campos do formulário "SCHEDULE´S FORM"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clearData_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        /// <summary>
        /// Método do evento click do btn_delete -> Deleta marcações cadastradas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var _schedule = (Schedule)dgv_schedules.Rows[dgv_schedules.SelectedCells[0].RowIndex].DataBoundItem;

            var _confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (_confirmResult == DialogResult.Yes)
            {
                Schedule.Delete(_schedule.Id);
                MessageBox.Show("The selected item has been deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_schedules.DataSource = Schedule.ScheduleList();
            }
        }

        /// <summary>
        /// Método do evento double click na dgv_schedules -> Caso seja necessário fazer update, damos dois cliques na célula da dgv_schedules, os campos do formulário serão preenchidos automaticamente
        /// e então é possível fazer o update do campo que queremos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_schedules_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var _schedule = (Schedule)dgv_schedules.Rows[e.RowIndex].DataBoundItem;

            tb_id.Text = _schedule.Id.ToString();
            cb_vehicle.Text = _schedule.Vehicle;
            cb_repair.Text = _schedule.Repair;
            cb_mechanic.Text = _schedule.Mechanic;
            cb_client.Text = _schedule.Client;
            dtp_startDate.Text = _schedule.StartDate.ToString();
            dtp_endDate.Text = _schedule.EndDate.ToString();
            dtp_alertDate.Text = _schedule.Alertdate.ToString();
            tb_time.Text = _schedule.Time.ToString();
            tb_email.Text = _schedule.Email.ToString();
        }

        /// <summary>
        /// Método do evento click do btn_search -> Pesquisa marcações pela data de entrada do veículo na oficina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click_1(object sender, EventArgs e)
        {
            DateTime _searchStartDate = Convert.ToDateTime(dtp_startDateSearch.Value.ToString("yyyy-MM-dd"));
            DateTime _searchEndDate = Convert.ToDateTime(dtp_endDateSearch.Value.ToString("yyyy-MM-dd"));

            var _searchDate = new DataBase.Schedule().ScheduleListStartDate(_searchStartDate, _searchEndDate);

            if (_searchDate.Rows.Count == 0)
                MessageBox.Show("No appointment was found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dgv_schedules.DataSource = Schedule.ScheduleListStartDate(_searchStartDate, _searchEndDate);
        }

        /// <summary>
        /// Método do evento click do btn_update -> Atualiza a dgv_schedules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click_1(object sender, EventArgs e)
        {
            //Carrega a dgv_schedules com os dados da tabela Schedules da base de dados
            dgv_schedules.DataSource = Schedule.ScheduleList();
        }

        /// <summary>
        /// Método do evento SelectedIndexChanged do cb_vehicle -> Busca na tabela Vehicles, da base dados, a placa que foi selecionada na cb_vehicle e preenche automaticamente a cb_client com o nome do cliente correspondente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_vehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_vehicle.SelectedItem != null)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-604TISA7;Initial Catalog=Oficina;Integrated Security=True"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("select * from Vehicles where Licenseplate='" + cb_vehicle.Text + "'", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cb_client.Text = reader["Clientname"].ToString();
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Método do evento SelectedIndexChanged do cb_client -> Busca na tabela Client, na base de dados, o nome que foi selecionado na cb_client e preenche automaticamente a tb_email com o email do cliente correspondente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_client.SelectedItem != null)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-604TISA7;Initial Catalog=Oficina;Integrated Security=True"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("select * from Clients where Name='" + cb_client.Text + "'", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        tb_email.Text = reader["Email"].ToString();
                    }
                    connection.Close();
                }
            }
        }
    }
}
