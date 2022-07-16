using System;
using System.Windows.Forms;

namespace Oficina
{
    public partial class Form_About : Form
    {
        /// <summary>
        /// Método construtor da classe Form_About
        /// </summary>
        public Form_About()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método do evento click do btn_close -> Fecha o formulário Form_About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
