using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panel_subMenu1.Visible = false;
            panel_subMenu2.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panel_subMenu1.Visible == true)
                panel_subMenu1.Visible = false;

            if (panel_subMenu1.Visible == true)
                panel_subMenu1.Visible = false;
        }
        private Form _activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
                _activeForm.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_principal.Controls.Add(childForm);
            panel_principal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //..
            //My Code
            //

            ShowSubMenu(panel_subMenu1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());

            //..
            //My Code
            //

            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //My Code
            //

            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //My Code
            //

            ShowSubMenu(panel_subMenu2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //My Code
            //

            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //My Code
            //

            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //My Code
            //

            HideSubMenu();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            //..
            //My Code
            //

            HideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja sair do Sistema?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            this.Close();

            //..
            //My Code
            //

            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard());
        }


    }
}
