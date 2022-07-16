using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_Home : Form
    {
        /// <summary>
        /// Método construtor da classe Form_Home
        /// </summary>
        public Form_Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_close -> Fecha o formulário Form_Home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método do evento click do btn_schedule -> Abri o Form_ScheduleList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_schedule_Click(object sender, EventArgs e)
        {
            Form_ScheduleList _formScheduleList = new Form_ScheduleList();
            _formScheduleList.ShowDialog();
        }

        /// <summary>
        /// Método do evento click do btn_services -> Abri o Form_ServicesList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_services_Click(object sender, EventArgs e)
        {
            Form_ServicesList _formServiceList = new Form_ServicesList();
            _formServiceList.ShowDialog();
        }

        /// <summary>
        /// Método do evento click do btn_products -> Abri o Form_ProductsList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_products_Click(object sender, EventArgs e)
        {
            Form_ProductsList _formProductList = new Form_ProductsList();
            _formProductList.ShowDialog();
        }

        /// <summary>
        /// Método do evento click do btn_sales -> Abri o Form_Sales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sales_Click(object sender, EventArgs e)
        {
            Form_Sales _formSalesList = new Form_Sales();
            _formSalesList.ShowDialog();
        }

    }
}
