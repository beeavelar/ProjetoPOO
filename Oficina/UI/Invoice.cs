using Business;
using Oficina.UI;
using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_Invoice : Form
    {
        /// <summary>
        /// Método construtor da classe Form_Invoice
        /// </summary>
        public Form_Invoice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_close -> Fecha o formulário Form_Invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método do evento Load do formulário Form_Invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Invoice_Load(object sender, EventArgs e)
        {
            //Carrega a dgv_invoices com os dados da tabela Invoices da base de dados
            dgv_invoices.DataSource = Invoice.InvoiceList();

            toolTip1.SetToolTip(btn_close, "Close");
            toolTip1.SetToolTip(btn_addManageInvoice, "Add/Manage invoices");
            toolTip1.SetToolTip(btn_search, "Search");
            toolTip1.SetToolTip(btn_update, "Update");

            dtp_issueDateSearch.Focus();
            dtp_issueDateSearch.Select();
        }

        /// <summary>
        /// Método do evento click do btn_addManageInvoice -> Abre o Form_ManageInvoices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addManageInvoice_Click(object sender, EventArgs e)
        {
            Form_ManageInvoices _newInvoice = new Form_ManageInvoices();
            _newInvoice.ShowDialog();
        }

        /// <summary>
        /// Método do evento click do  btn_search -> Pesquisa faturas pela data de emissão
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
        /// Método do evento click do btn_update -> Atualiza a dgv_invoices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            dgv_invoices.DataSource = Invoice.InvoiceList();
        }
    }
}
