using Business;
using iTextSharp.text.pdf;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.UI
{
    public partial class Form_ManageInvoices : Form
    {
        //Variáveis globais criadas porque podem ser acessadas em todos os métodos da classe Form_ManageInvoices
        //No método do CreatePDF() elas recebem valores e depois esses valores são utilizados no método SendEmail()
        string _newPdf = string.Empty;
        string _pdfName = string.Empty;

        /// <summary>
        /// Método construtor da classe Form_ManageInvoices
        /// </summary>
        public Form_ManageInvoices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_ManageInvoices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_ManageInvoices_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_invoices com os dados da tabela Invoices da base de dados
            dgv_invoices.DataSource = Invoice.InvoiceList();

            //Carrega a cb_serviceOrder com os Ids das marcações cadastradas na tabela Schedules da base de dados
            cb_serviceOrder.DataSource = Schedule.ScheduleList();
            cb_serviceOrder.DisplayMember = "Id";

            //Carrega a cb_vehicle com a placa dos veículos cadastrados na tabela Vehicles da base de dados
            cb_vehicle.DataSource = Vehicle.VehicleList();
            cb_vehicle.DisplayMember = "LicensePlate";

            //Carrega a cb_repair com a descrição dos reparos cadastrados na tabela Repairs da base de dados
            cb_repair.DataSource = Repair.RepairList();
            cb_repair.DisplayMember = "Description";

            //Carrega a cb_client com o nome dos clientes cadastrados na tabela Clients da base de dados
            cb_client.DataSource = Client.ClientList();
            cb_client.DisplayMember = "Name";

            //Carrega a cb_mechanic com o nome dos mecânicos cadastrados na tabela Mechanics da base de dados
            cb_mechanic.DataSource = Mechanic.MechanicList();
            cb_mechanic.DisplayMember = "Name";

            ClearData();

            toolTip1.SetToolTip(btn_save, "Save and send the invoice by email");
            toolTip1.SetToolTip(btn_clearData, "Clear data");
            toolTip1.SetToolTip(btn_delete, "Delete");
            toolTip1.SetToolTip(btn_search, "Search");
            toolTip1.SetToolTip(btn_update, "Update");

            cb_serviceOrder.Focus();
            cb_serviceOrder.Select();
        }

        /// <summary>
        /// Método do evento click do btn_save -> Valida (ValidateData()), salva no banco de dados as informações inseridas no formulário "INVOICES´S FORM" e envia e-mail com a fatura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                if (string.IsNullOrEmpty(tb_id.Text)) tb_id.Text = "0";

                var _newInvoice = new Invoice()
                {
                    Id = Convert.ToInt32(tb_id.Text),
                    ServiceOrder = Convert.ToInt32(cb_serviceOrder.Text),
                    Vehicle = cb_vehicle.Text,
                    Repair = cb_repair.Text,
                    Mechanic = cb_mechanic.Text,
                    Client = cb_client.Text,
                    Nif = Convert.ToInt32(tb_nif.Text),
                    PaymentType = cb_paymentType.Text,
                    IssueDate = Convert.ToDateTime(dt_issueDate.Text),
                    RepairPrice = Convert.ToDecimal(tb_repairPrice.Text),
                    LaborPrice = Convert.ToDecimal(tb_laborPrice.Text),
                    Total = Convert.ToDecimal(tb_total.Text)
                };
                _newInvoice.Save();

                if (tb_id.Text == "0")
                {
                    //Chamar o método CreatePDF() para o PDF ser criado
                    CreatePDF();
                    //Chamar o método SendEmail() para enviar um email a confirmar que a fatura foi salva e também enviar a fatura (em PDF) em anexo desse email
                    await SendEmail(tb_email.Text, "Repair Shop - Invoice");
                    MessageBox.Show("New invoice has been saved successfully and an e-mail was sent with the invoice attached.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Data has been updated successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearData();
                dgv_invoices.DataSource = Invoice.InvoiceList();
            }
        }

        /// <summary>
        /// Método auxiliar para fazer o envio de emails
        /// </summary>
        public async Task SendEmail(string _email, string _subject)
        {
            try
            {
                //Indicar a Apikey e guardar ela na variável "apikey" -- >logando no website do Sendgrid é possível criar uma Apikey
                var _apiKey = "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";

                //O método da biblioteca auxiliar SendGridClient(), passa a apikey para a API v3 em um cabeçalho de autorização usando a autenticação de token de portador
                var _client = new SendGridClient(_apiKey);

                //Indicar o email do remetente
                var _from = new EmailAddress("cet69.repairshop@gmail.com", "Repair Shop");
                //O email do destinatário vai ser passada através da variável "email" porque ele vem da tb_email
                var _to = new EmailAddress(_email);

                //Mensagem que vai aparecer no e-mail
                var _plainTextContent = "Dear Sr.(a) " + cb_client.Text + ",\n\n" +
                                        "The Repair Shop has completed the service on your vehicle. Your invoice is attached.\n\n" +
                                        "We thank you for your preference.\n\n" +
                                        "Best regards,\n" +
                                        "Repais Shop";

                var _htmlContent = "";

                //Criação do e-mail
                var _msg = MailHelper.CreateSingleEmail(_from, _to, _subject, _plainTextContent, _htmlContent);

                //Busca pelo PDF e anexa ele ao e-mail
                using (var fileStream = File.OpenRead(_newPdf)) //Abre o pdf
                {
                    await _msg.AddAttachmentAsync(_pdfName, fileStream); //Atribui o anexo a mensagem
                }

                //Solicitar à API SendGrid Mail Send para enviar o e-mail
                var _response = await _client.SendEmailAsync(_msg);
            }
            catch (Exception)
            {
                MessageBox.Show("Error sending the email.", "Erro Envio de Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método auxiliar de criação da fatura em PDF
        /// </summary>
        public void CreatePDF()
        {
            //Pasta onde está o template
            String _template = @"C:\Projetos\ProjetoPOO2\Templates\InvoiceTemplate.pdf";

            //Pasta onde os pdfs criados serão guardados
            string _folderToNewPdf = @"C:\Projetos\ProjetoPOO2\Invoices\";
            Guid _id = Guid.NewGuid();
            _pdfName = _id + ".pdf";
            _newPdf = _folderToNewPdf + _pdfName;

            //Criando o pdf
            if (File.Exists(_template)) //Verificação se o template existe na pasta Tempates
            {
                //Leitura do InvoiceTemplate.pdf
                PdfReader _pdfreader = new PdfReader(_template);

                PdfStamper _pdfStamper = new PdfStamper(_pdfreader, new FileStream(_newPdf, FileMode.Create));

                AcroFields _fields = _pdfStamper.AcroFields;

                //Escrevendo nos campos do PDF template
                _fields.SetField("id", tb_id.Text);
                _fields.SetField("date", DateTime.Now.ToShortDateString());
                _fields.SetField("clientname", cb_client.Text);
                _fields.SetField("nif", tb_nif.Text);
                _fields.SetField("paymenttype", cb_paymentType.Text);
                _fields.SetField("repair", cb_repair.Text);
                _fields.SetField("repairprice", tb_repairPrice.Text + " €");
                _fields.SetField("labor", "Mão de Obra");
                _fields.SetField("laborprice", tb_laborPrice.Text + " €");
                _fields.SetField("total", tb_total.Text + " €");

                _pdfStamper.Close();
            }
        }

        /// <summary>
        /// Método do evento click do btn_clearData -> Limpa todos os campos do formulário "INVOICE´S FORM"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clearData_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        /// <summary>
        /// Método do evento click do btn_delete -> Deleta faturas cadastradas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var _invoice = (Invoice)dgv_invoices.Rows[dgv_invoices.SelectedCells[0].RowIndex].DataBoundItem;

            var _confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (_confirmResult == DialogResult.Yes)
            {
                Invoice.Delete(_invoice.Id);
                MessageBox.Show("The selected item has been deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_invoices.DataSource = Invoice.InvoiceList();
            }
        }

        /// <summary>
        /// Método auxiliar criado para limpar os dados inseridos no formulário "INVOICE´S FORM"
        /// </summary>
        private void ClearData()
        {
            tb_id.Text = "";
            cb_serviceOrder.Text = "";
            cb_vehicle.Text = "";
            cb_repair.Text = "";
            cb_mechanic.Text = "";
            cb_client.Text = "";
            tb_email.Text = "";
            tb_nif.Text = "";
            cb_paymentType.Text = "";
            dt_issueDate.Text = DateTime.Today.ToString();
            tb_repairPrice.Text = "";
            tb_laborPrice.Text = "";
            tb_total.Text = "";
        }

        /// <summary>
        /// Método que valida se todos os campos do formulário foram preenchidos
        /// </summary>
        private bool CheckEmptyFields()
        {
            bool _output = true;

            if (string.IsNullOrEmpty(cb_serviceOrder.Text) || string.IsNullOrEmpty(cb_vehicle.Text) || string.IsNullOrEmpty(cb_repair.Text) || string.IsNullOrEmpty(cb_mechanic.Text) || string.IsNullOrEmpty(cb_client.Text) || string.IsNullOrEmpty(tb_email.Text) || string.IsNullOrEmpty(cb_paymentType.Text) || string.IsNullOrEmpty(dt_issueDate.Text) || string.IsNullOrEmpty(tb_repairPrice.Text) || string.IsNullOrEmpty(tb_laborPrice.Text) || string.IsNullOrEmpty(tb_total.Text))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _output = false;
            }
            return _output;
        }

        /// <summary>
        /// Método do evento click do btn_update -> Atualiza a dgv_invoices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            //Carrega a dgv_invoices com os dados da tabela Invoices da base de dados
            dgv_invoices.DataSource = Invoice.InvoiceList();
        }

        /// <summary>
        /// Método do evento click do btn_search -> Pesquisa faturas pela data de emissão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime _searchIssueDate = Convert.ToDateTime(dtp_issueDateSearch.Value.ToString("yyyy-MM-dd"));

            var _searchDate = new DataBase.Invoice().InvoiceListIssueDate(_searchIssueDate);

            if (_searchDate.Rows.Count == 0)
                MessageBox.Show("No appointment was found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dgv_invoices.DataSource = Invoice.InvoiceListIssueDate(_searchIssueDate);
        }

        /// <summary>
        /// Método do evento double click na dgv_invoices -> Caso seja necessário fazer update, damos dois cliques na célula da dgv_invoices, os campos do formulário serão preenchidos automaticamente
        /// e então é possível fazer o update do campo que queremos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_invoices_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var _invoice = (Invoice)dgv_invoices.Rows[e.RowIndex].DataBoundItem;

            tb_id.Text = _invoice.Id.ToString();
            cb_serviceOrder.Text = _invoice.ServiceOrder.ToString();
            cb_vehicle.Text = _invoice.Vehicle;
            cb_repair.Text = _invoice.Repair;
            cb_mechanic.Text = _invoice.Mechanic;
            cb_client.Text = _invoice.Client;
            tb_email.Text = _invoice.Nif.ToString();
            cb_paymentType.Text = _invoice.PaymentType;
            dt_issueDate.Text = _invoice.IssueDate.ToString();
            tb_repairPrice.Text = Decimal.Round(_invoice.RepairPrice, 2).ToString();
            tb_laborPrice.Text = Decimal.Round(_invoice.LaborPrice, 2).ToString();
            tb_total.Text = Decimal.Round(_invoice.Total, 2).ToString();
        }

        /// <summary>
        /// Método do evento Leave da tb_nif que valida se o NIF inserido é válido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_nif_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tb_email.Text, @"\d{9}$"))
            {
                MessageBox.Show("Invalid NIF. Please, enter a valid NIF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_email.Focus();
            }
        }


        /// <summary>
        /// Método do evento KeyPress da tb_nif que valida se os dados inseridos são numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_nif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("This field only accepts numbers.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método do evento KeyPress da tb_repairPrice que permite inserir apenas números e vígula e faz a configuração do valor inserido para o formato monetário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_repairPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                MessageBox.Show("This field only accepts numbers and comma.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }

            if ((e.KeyChar == (char)13))
                tb_repairPrice.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", double.Parse(tb_repairPrice.Text));
        }

        /// <summary>
        /// Método do evento KeyPress da tb_laborPrice que permite inserir apenas números e vígula e faz a configuração do valor inserido para o formato monetário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_laborPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                MessageBox.Show("This field only accepts numbers and comma.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }

            if ((e.KeyChar == (char)13))
                tb_laborPrice.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", double.Parse(tb_laborPrice.Text));
        }

        /// <summary>
        /// Método do evento KeyPress da tb_total que permite inserir apenas números e vígula e faz a configuração do valor inserido para o formato monetário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                MessageBox.Show("This field only accepts numbers and comma.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }

            if ((e.KeyChar == (char)13))
                tb_total.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", double.Parse(tb_total.Text));
        }

        /// <summary>
        /// Método do evento SelectedIndexChanged do cb_repair -> Busca na tabela Repairs, da base dados, o preço do reparo que foi selecionado na cb_repair, 
        /// faz os cáculos (valor total = valor do reparo + IVA + mão-de-obra) e preenche automaticamente a tb_repairPrice, tb_laborPrice e tb_total com os valores correspondentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_repair_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_serviceOrder.SelectedItem != null)
            {
                decimal _iva = 0.23M;

                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-604TISA7;Initial Catalog=Oficina;Integrated Security=True"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("select * from Repairs where Description='" + cb_repair.Text + "'", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //Cálculo do valor do reparo + IVA
                        var _repairPrice = Convert.ToDecimal(reader["Price"]);
                        var _repairPriceWithIva = (_repairPrice * _iva) + _repairPrice;

                        //Mostrar na o valor do reparo na tb_repairPrice
                        tb_repairPrice.Text = Decimal.Round(_repairPriceWithIva, 2).ToString();

                        tb_laborPrice.Text = reader["Laborprice"].ToString();

                        var _laborPrice = Convert.ToDecimal(reader["Laborprice"]);

                        var _repairTotal = _repairPriceWithIva + _laborPrice;

                        tb_total.Text = Decimal.Round(_repairTotal, 2).ToString();
                    }
                }
            }
        }

        /// <summary>
        /// Método do evento SelectedIndexChanged do cb_client -> Busca na tabela Client, na base de dados, o nome que foi selecionado na cb_client e preenche automaticamente a tb_email com o email do cliente correspondente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_serviceOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_serviceOrder.SelectedItem != null)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-604TISA7;Initial Catalog=Oficina;Integrated Security=True"))
                {
                    connection.Open();

                    string _sql = "select * from Schedules where Id = " + (cb_serviceOrder.SelectedItem as Schedule)?.Id;

                    SqlCommand command = new SqlCommand(_sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cb_vehicle.Text = reader["Vehicle"].ToString();
                        cb_repair.Text = reader["Repair"].ToString();
                        cb_mechanic.Text = reader["Mechanic"].ToString();
                        cb_client.Text = reader["Client"].ToString();
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
                        tb_nif.Text = reader["Nif"].ToString();
                        tb_email.Text = reader["Email"].ToString();
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Método do evento KeyPress da tb_phone que valida se os dados inseridos são numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_serviceOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("This field only accepts numbers.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }
    }
}
