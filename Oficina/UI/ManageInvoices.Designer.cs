namespace Oficina.UI
{
    partial class Form_ManageInvoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_nif = new System.Windows.Forms.Label();
            this.tb_nif = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.lbl_client = new System.Windows.Forms.Label();
            this.cb_vehicle = new System.Windows.Forms.ComboBox();
            this.cb_mechanic = new System.Windows.Forms.ComboBox();
            this.cb_repair = new System.Windows.Forms.ComboBox();
            this.cb_serviceOrder = new System.Windows.Forms.ComboBox();
            this.lbl_serviceOrder = new System.Windows.Forms.Label();
            this.lbl_mechanic = new System.Windows.Forms.Label();
            this.lbl_repair = new System.Windows.Forms.Label();
            this.lbl_vehicle = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_repairPrice = new System.Windows.Forms.TextBox();
            this.lbl_repairPrice = new System.Windows.Forms.Label();
            this.lbl_invoiceSearch = new System.Windows.Forms.Label();
            this.lbl_invoicesForm = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_laborPrice = new System.Windows.Forms.TextBox();
            this.lbl_laborPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.dt_issueDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_issueDate = new System.Windows.Forms.Label();
            this.cb_paymentType = new System.Windows.Forms.ComboBox();
            this.lbl_paymentType = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtp_issueDateSearch = new System.Windows.Forms.DateTimePicker();
            this.dgv_invoices = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clearData = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_email);
            this.panel2.Controls.Add(this.lbl_nif);
            this.panel2.Controls.Add(this.tb_nif);
            this.panel2.Controls.Add(this.lbl_email);
            this.panel2.Controls.Add(this.cb_client);
            this.panel2.Controls.Add(this.lbl_client);
            this.panel2.Controls.Add(this.cb_vehicle);
            this.panel2.Controls.Add(this.cb_mechanic);
            this.panel2.Controls.Add(this.cb_repair);
            this.panel2.Controls.Add(this.cb_serviceOrder);
            this.panel2.Controls.Add(this.lbl_serviceOrder);
            this.panel2.Controls.Add(this.lbl_mechanic);
            this.panel2.Controls.Add(this.lbl_repair);
            this.panel2.Controls.Add(this.lbl_vehicle);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.tb_id);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(37, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 314);
            this.panel2.TabIndex = 46;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_email.Location = new System.Drawing.Point(101, 270);
            this.tb_email.MaxLength = 9;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(348, 26);
            this.tb_email.TabIndex = 7;
            // 
            // lbl_nif
            // 
            this.lbl_nif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nif.ForeColor = System.Drawing.Color.White;
            this.lbl_nif.Location = new System.Drawing.Point(10, 228);
            this.lbl_nif.Name = "lbl_nif";
            this.lbl_nif.Size = new System.Drawing.Size(85, 32);
            this.lbl_nif.TabIndex = 66;
            this.lbl_nif.Text = "Nif:";
            this.lbl_nif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_nif
            // 
            this.tb_nif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_nif.Location = new System.Drawing.Point(101, 228);
            this.tb_nif.MaxLength = 9;
            this.tb_nif.Name = "tb_nif";
            this.tb_nif.Size = new System.Drawing.Size(174, 26);
            this.tb_nif.TabIndex = 6;
            this.tb_nif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nif_KeyPress);
            this.tb_nif.Leave += new System.EventHandler(this.tb_nif_Leave);
            // 
            // lbl_email
            // 
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(10, 270);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(85, 32);
            this.lbl_email.TabIndex = 64;
            this.lbl_email.Text = "E-mail:";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_client
            // 
            this.cb_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(101, 184);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(348, 28);
            this.cb_client.TabIndex = 5;
            this.cb_client.SelectedIndexChanged += new System.EventHandler(this.cb_client_SelectedIndexChanged);
            // 
            // lbl_client
            // 
            this.lbl_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_client.ForeColor = System.Drawing.Color.White;
            this.lbl_client.Location = new System.Drawing.Point(-4, 184);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(99, 32);
            this.lbl_client.TabIndex = 62;
            this.lbl_client.Text = "Client:";
            this.lbl_client.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_vehicle
            // 
            this.cb_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_vehicle.FormattingEnabled = true;
            this.cb_vehicle.Location = new System.Drawing.Point(317, 55);
            this.cb_vehicle.Name = "cb_vehicle";
            this.cb_vehicle.Size = new System.Drawing.Size(132, 28);
            this.cb_vehicle.TabIndex = 2;
            // 
            // cb_mechanic
            // 
            this.cb_mechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mechanic.FormattingEnabled = true;
            this.cb_mechanic.Location = new System.Drawing.Point(101, 140);
            this.cb_mechanic.Name = "cb_mechanic";
            this.cb_mechanic.Size = new System.Drawing.Size(348, 28);
            this.cb_mechanic.TabIndex = 4;
            // 
            // cb_repair
            // 
            this.cb_repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_repair.FormattingEnabled = true;
            this.cb_repair.Location = new System.Drawing.Point(101, 99);
            this.cb_repair.Name = "cb_repair";
            this.cb_repair.Size = new System.Drawing.Size(348, 28);
            this.cb_repair.TabIndex = 3;
            this.cb_repair.SelectedIndexChanged += new System.EventHandler(this.cb_repair_SelectedIndexChanged_1);
            // 
            // cb_serviceOrder
            // 
            this.cb_serviceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_serviceOrder.FormattingEnabled = true;
            this.cb_serviceOrder.Location = new System.Drawing.Point(101, 55);
            this.cb_serviceOrder.Name = "cb_serviceOrder";
            this.cb_serviceOrder.Size = new System.Drawing.Size(109, 28);
            this.cb_serviceOrder.TabIndex = 1;
            this.cb_serviceOrder.SelectedIndexChanged += new System.EventHandler(this.cb_serviceOrder_SelectedIndexChanged);
            this.cb_serviceOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_serviceOrder_KeyPress);
            // 
            // lbl_serviceOrder
            // 
            this.lbl_serviceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serviceOrder.ForeColor = System.Drawing.Color.White;
            this.lbl_serviceOrder.Location = new System.Drawing.Point(12, 55);
            this.lbl_serviceOrder.Name = "lbl_serviceOrder";
            this.lbl_serviceOrder.Size = new System.Drawing.Size(83, 30);
            this.lbl_serviceOrder.TabIndex = 50;
            this.lbl_serviceOrder.Text = "S.O:";
            this.lbl_serviceOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_mechanic
            // 
            this.lbl_mechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mechanic.ForeColor = System.Drawing.Color.White;
            this.lbl_mechanic.Location = new System.Drawing.Point(-4, 140);
            this.lbl_mechanic.Name = "lbl_mechanic";
            this.lbl_mechanic.Size = new System.Drawing.Size(99, 32);
            this.lbl_mechanic.TabIndex = 48;
            this.lbl_mechanic.Text = "Mechanic:";
            this.lbl_mechanic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_repair
            // 
            this.lbl_repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repair.ForeColor = System.Drawing.Color.White;
            this.lbl_repair.Location = new System.Drawing.Point(0, 97);
            this.lbl_repair.Name = "lbl_repair";
            this.lbl_repair.Size = new System.Drawing.Size(95, 30);
            this.lbl_repair.TabIndex = 42;
            this.lbl_repair.Text = "Repair:";
            this.lbl_repair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_vehicle
            // 
            this.lbl_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicle.ForeColor = System.Drawing.Color.White;
            this.lbl_vehicle.Location = new System.Drawing.Point(228, 55);
            this.lbl_vehicle.Name = "lbl_vehicle";
            this.lbl_vehicle.Size = new System.Drawing.Size(83, 30);
            this.lbl_vehicle.TabIndex = 40;
            this.lbl_vehicle.Text = "Vehicle:";
            this.lbl_vehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(5, 11);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(90, 33);
            this.lbl_id.TabIndex = 29;
            this.lbl_id.Text = "Id:";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_id
            // 
            this.tb_id.AcceptsReturn = true;
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_id.Location = new System.Drawing.Point(101, 15);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(56, 26);
            this.tb_id.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "€";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_repairPrice
            // 
            this.tb_repairPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_repairPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_repairPrice.Location = new System.Drawing.Point(150, 166);
            this.tb_repairPrice.Name = "tb_repairPrice";
            this.tb_repairPrice.Size = new System.Drawing.Size(142, 26);
            this.tb_repairPrice.TabIndex = 10;
            this.tb_repairPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_repairPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_repairPrice_KeyPress);
            // 
            // lbl_repairPrice
            // 
            this.lbl_repairPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repairPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_repairPrice.Location = new System.Drawing.Point(7, 155);
            this.lbl_repairPrice.Name = "lbl_repairPrice";
            this.lbl_repairPrice.Size = new System.Drawing.Size(133, 51);
            this.lbl_repairPrice.TabIndex = 31;
            this.lbl_repairPrice.Text = "Repair price with IVA (23%):";
            this.lbl_repairPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_invoiceSearch
            // 
            this.lbl_invoiceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoiceSearch.ForeColor = System.Drawing.Color.White;
            this.lbl_invoiceSearch.Location = new System.Drawing.Point(208, 420);
            this.lbl_invoiceSearch.Name = "lbl_invoiceSearch";
            this.lbl_invoiceSearch.Size = new System.Drawing.Size(188, 33);
            this.lbl_invoiceSearch.TabIndex = 50;
            this.lbl_invoiceSearch.Text = "Search by issue date:";
            this.lbl_invoiceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_invoicesForm
            // 
            this.lbl_invoicesForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoicesForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_invoicesForm.Location = new System.Drawing.Point(38, 11);
            this.lbl_invoicesForm.Name = "lbl_invoicesForm";
            this.lbl_invoicesForm.Size = new System.Drawing.Size(401, 41);
            this.lbl_invoicesForm.TabIndex = 45;
            this.lbl_invoicesForm.Text = "INVOICE´S FORM";
            this.lbl_invoicesForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tb_total);
            this.panel3.Controls.Add(this.lbl_total);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tb_laborPrice);
            this.panel3.Controls.Add(this.lbl_laborPrice);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbl_payment);
            this.panel3.Controls.Add(this.dt_issueDate);
            this.panel3.Controls.Add(this.lbl_issueDate);
            this.panel3.Controls.Add(this.cb_paymentType);
            this.panel3.Controls.Add(this.lbl_paymentType);
            this.panel3.Controls.Add(this.tb_repairPrice);
            this.panel3.Controls.Add(this.lbl_repairPrice);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(521, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 314);
            this.panel3.TabIndex = 52;
            // 
            // tb_total
            // 
            this.tb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_total.Location = new System.Drawing.Point(150, 246);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(142, 26);
            this.tb_total.TabIndex = 12;
            this.tb_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_total_KeyPress);
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(11, 245);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(129, 27);
            this.lbl_total.TabIndex = 59;
            this.lbl_total.Text = "Total:";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(296, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 30);
            this.label4.TabIndex = 60;
            this.label4.Text = "€";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_laborPrice
            // 
            this.tb_laborPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_laborPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_laborPrice.Location = new System.Drawing.Point(150, 207);
            this.tb_laborPrice.Name = "tb_laborPrice";
            this.tb_laborPrice.Size = new System.Drawing.Size(142, 26);
            this.tb_laborPrice.TabIndex = 11;
            this.tb_laborPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_laborPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_laborPrice_KeyPress);
            // 
            // lbl_laborPrice
            // 
            this.lbl_laborPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laborPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_laborPrice.Location = new System.Drawing.Point(11, 206);
            this.lbl_laborPrice.Name = "lbl_laborPrice";
            this.lbl_laborPrice.Size = new System.Drawing.Size(133, 27);
            this.lbl_laborPrice.TabIndex = 56;
            this.lbl_laborPrice.Text = "Labor price:";
            this.lbl_laborPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(296, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 30);
            this.label3.TabIndex = 57;
            this.label3.Text = "€";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_payment
            // 
            this.lbl_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment.ForeColor = System.Drawing.Color.White;
            this.lbl_payment.Location = new System.Drawing.Point(104, 15);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(137, 32);
            this.lbl_payment.TabIndex = 54;
            this.lbl_payment.Text = "PAYMENT";
            this.lbl_payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dt_issueDate
            // 
            this.dt_issueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_issueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_issueDate.Location = new System.Drawing.Point(150, 125);
            this.dt_issueDate.Name = "dt_issueDate";
            this.dt_issueDate.Size = new System.Drawing.Size(142, 26);
            this.dt_issueDate.TabIndex = 9;
            // 
            // lbl_issueDate
            // 
            this.lbl_issueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_issueDate.ForeColor = System.Drawing.Color.White;
            this.lbl_issueDate.Location = new System.Drawing.Point(39, 122);
            this.lbl_issueDate.Name = "lbl_issueDate";
            this.lbl_issueDate.Size = new System.Drawing.Size(105, 30);
            this.lbl_issueDate.TabIndex = 53;
            this.lbl_issueDate.Text = "Issue date:";
            this.lbl_issueDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_paymentType
            // 
            this.cb_paymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_paymentType.FormattingEnabled = true;
            this.cb_paymentType.ItemHeight = 20;
            this.cb_paymentType.Items.AddRange(new object[] {
            "Money",
            "Multibanco",
            "Credit card",
            "Bank transfer",
            "MBWay"});
            this.cb_paymentType.Location = new System.Drawing.Point(150, 82);
            this.cb_paymentType.Name = "cb_paymentType";
            this.cb_paymentType.Size = new System.Drawing.Size(140, 28);
            this.cb_paymentType.TabIndex = 8;
            // 
            // lbl_paymentType
            // 
            this.lbl_paymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentType.ForeColor = System.Drawing.Color.White;
            this.lbl_paymentType.Location = new System.Drawing.Point(7, 78);
            this.lbl_paymentType.Name = "lbl_paymentType";
            this.lbl_paymentType.Size = new System.Drawing.Size(137, 32);
            this.lbl_paymentType.TabIndex = 50;
            this.lbl_paymentType.Text = "Payment type:";
            this.lbl_paymentType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_issueDateSearch
            // 
            this.dtp_issueDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_issueDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_issueDateSearch.Location = new System.Drawing.Point(405, 421);
            this.dtp_issueDateSearch.Name = "dtp_issueDateSearch";
            this.dtp_issueDateSearch.Size = new System.Drawing.Size(165, 26);
            this.dtp_issueDateSearch.TabIndex = 15;
            // 
            // dgv_invoices
            // 
            this.dgv_invoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_invoices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_invoices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgv_invoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_invoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_invoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_invoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_invoices.ColumnHeadersHeight = 27;
            this.dgv_invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_invoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_invoices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_invoices.EnableHeadersVisualStyles = false;
            this.dgv_invoices.GridColor = System.Drawing.Color.White;
            this.dgv_invoices.Location = new System.Drawing.Point(37, 475);
            this.dgv_invoices.Name = "dgv_invoices";
            this.dgv_invoices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_invoices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_invoices.RowHeadersVisible = false;
            this.dgv_invoices.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_invoices.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_invoices.RowTemplate.Height = 28;
            this.dgv_invoices.Size = new System.Drawing.Size(826, 206);
            this.dgv_invoices.TabIndex = 93;
            this.dgv_invoices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_invoices_CellDoubleClick_1);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 82;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Aqua;
            this.btn_search.Image = global::Oficina.Properties.Resources.lupa__3_1;
            this.btn_search.Location = new System.Drawing.Point(578, 415);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 42);
            this.btn_search.TabIndex = 16;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Aqua;
            this.btn_update.Image = global::Oficina.Properties.Resources.setas_circulares;
            this.btn_update.Location = new System.Drawing.Point(631, 415);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(43, 42);
            this.btn_update.TabIndex = 17;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::Oficina.Properties.Resources.salve_1;
            this.btn_save.Location = new System.Drawing.Point(873, 57);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(52, 52);
            this.btn_save.TabIndex = 13;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::Oficina.Properties.Resources.bin__2_;
            this.btn_delete.Location = new System.Drawing.Point(873, 629);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(52, 52);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clearData
            // 
            this.btn_clearData.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_clearData.FlatAppearance.BorderSize = 0;
            this.btn_clearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearData.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_clearData.Image = global::Oficina.Properties.Resources.esfregar__3_;
            this.btn_clearData.Location = new System.Drawing.Point(873, 130);
            this.btn_clearData.Name = "btn_clearData";
            this.btn_clearData.Size = new System.Drawing.Size(52, 52);
            this.btn_clearData.TabIndex = 14;
            this.btn_clearData.UseVisualStyleBackColor = true;
            this.btn_clearData.Click += new System.EventHandler(this.btn_clearData_Click);
            // 
            // Form_ManageInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(945, 734);
            this.Controls.Add(this.dgv_invoices);
            this.Controls.Add(this.dtp_issueDateSearch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_invoiceSearch);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clearData);
            this.Controls.Add(this.lbl_invoicesForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ManageInvoices";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Manage Invoice";
            this.Load += new System.EventHandler(this.Form_ManageInvoices_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_repair;
        private System.Windows.Forms.Label lbl_vehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_repairPrice;
        private System.Windows.Forms.Label lbl_repairPrice;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lbl_invoiceSearch;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clearData;
        private System.Windows.Forms.Label lbl_invoicesForm;
        private System.Windows.Forms.Label lbl_mechanic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_paymentType;
        private System.Windows.Forms.Label lbl_paymentType;
        private System.Windows.Forms.DateTimePicker dt_issueDate;
        private System.Windows.Forms.Label lbl_issueDate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dtp_issueDateSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cb_repair;
        private System.Windows.Forms.DataGridView dgv_invoices;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ComboBox cb_vehicle;
        private System.Windows.Forms.ComboBox cb_mechanic;
        private System.Windows.Forms.Label lbl_payment;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_laborPrice;
        private System.Windows.Forms.Label lbl_laborPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_serviceOrder;
        private System.Windows.Forms.Label lbl_serviceOrder;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_nif;
        private System.Windows.Forms.TextBox tb_nif;
    }
}