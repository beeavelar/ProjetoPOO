namespace Oficina.UI
{
    partial class Form_ManageSchedule
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
            this.tb_time = new System.Windows.Forms.MaskedTextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.dtp_alertDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_alertDate = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.cb_vehicle = new System.Windows.Forms.ComboBox();
            this.lbl_vehicle = new System.Windows.Forms.Label();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.cb_mechanic = new System.Windows.Forms.ComboBox();
            this.cb_repair = new System.Windows.Forms.ComboBox();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_repair = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lbl_mechanic = new System.Windows.Forms.Label();
            this.lbl_client = new System.Windows.Forms.Label();
            this.lbl_schedulesForm = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clearData = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_schedules = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gb_byStartDate = new System.Windows.Forms.GroupBox();
            this.lbl_upTo = new System.Windows.Forms.Label();
            this.dtp_endDateSearch = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_startDateSearch = new System.Windows.Forms.DateTimePicker();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_between = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).BeginInit();
            this.gb_byStartDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_email);
            this.panel2.Controls.Add(this.tb_time);
            this.panel2.Controls.Add(this.lbl_email);
            this.panel2.Controls.Add(this.dtp_alertDate);
            this.panel2.Controls.Add(this.lbl_alertDate);
            this.panel2.Controls.Add(this.lbl_time);
            this.panel2.Controls.Add(this.dtp_endDate);
            this.panel2.Controls.Add(this.cb_vehicle);
            this.panel2.Controls.Add(this.lbl_vehicle);
            this.panel2.Controls.Add(this.dtp_startDate);
            this.panel2.Controls.Add(this.lbl_endDate);
            this.panel2.Controls.Add(this.cb_client);
            this.panel2.Controls.Add(this.cb_mechanic);
            this.panel2.Controls.Add(this.cb_repair);
            this.panel2.Controls.Add(this.lbl_startDate);
            this.panel2.Controls.Add(this.lbl_repair);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.tb_id);
            this.panel2.Controls.Add(this.lbl_mechanic);
            this.panel2.Controls.Add(this.lbl_client);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(18, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 199);
            this.panel2.TabIndex = 46;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(84, 148);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(547, 28);
            this.tb_email.TabIndex = 72;
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(772, 148);
            this.tb_time.Mask = "00:00";
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(125, 28);
            this.tb_time.TabIndex = 71;
            this.tb_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_email
            // 
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(3, 147);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(76, 33);
            this.lbl_email.TabIndex = 69;
            this.lbl_email.Text = "E-mail:";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_alertDate
            // 
            this.dtp_alertDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_alertDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_alertDate.Location = new System.Drawing.Point(771, 104);
            this.dtp_alertDate.Name = "dtp_alertDate";
            this.dtp_alertDate.Size = new System.Drawing.Size(126, 26);
            this.dtp_alertDate.TabIndex = 66;
            // 
            // lbl_alertDate
            // 
            this.lbl_alertDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alertDate.ForeColor = System.Drawing.Color.White;
            this.lbl_alertDate.Location = new System.Drawing.Point(637, 104);
            this.lbl_alertDate.Name = "lbl_alertDate";
            this.lbl_alertDate.Size = new System.Drawing.Size(128, 30);
            this.lbl_alertDate.TabIndex = 67;
            this.lbl_alertDate.Text = "ALERT DATE:";
            this.lbl_alertDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_time
            // 
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(703, 145);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(62, 30);
            this.lbl_time.TabIndex = 65;
            this.lbl_time.Text = "TIME:";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_endDate.Location = new System.Drawing.Point(771, 61);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(126, 26);
            this.dtp_endDate.TabIndex = 7;
            // 
            // cb_vehicle
            // 
            this.cb_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_vehicle.FormattingEnabled = true;
            this.cb_vehicle.Items.AddRange(new object[] {
            "-------"});
            this.cb_vehicle.Location = new System.Drawing.Point(84, 59);
            this.cb_vehicle.Name = "cb_vehicle";
            this.cb_vehicle.Size = new System.Drawing.Size(129, 28);
            this.cb_vehicle.TabIndex = 2;
            this.cb_vehicle.SelectedIndexChanged += new System.EventHandler(this.cb_vehicle_SelectedIndexChanged);
            // 
            // lbl_vehicle
            // 
            this.lbl_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicle.ForeColor = System.Drawing.Color.White;
            this.lbl_vehicle.Location = new System.Drawing.Point(-4, 57);
            this.lbl_vehicle.Name = "lbl_vehicle";
            this.lbl_vehicle.Size = new System.Drawing.Size(82, 30);
            this.lbl_vehicle.TabIndex = 10;
            this.lbl_vehicle.Text = "Vehicle:";
            this.lbl_vehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_startDate.Location = new System.Drawing.Point(771, 18);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(126, 26);
            this.dtp_startDate.TabIndex = 6;
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endDate.ForeColor = System.Drawing.Color.White;
            this.lbl_endDate.Location = new System.Drawing.Point(660, 61);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(105, 30);
            this.lbl_endDate.TabIndex = 61;
            this.lbl_endDate.Text = "END DATE:";
            this.lbl_endDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_client
            // 
            this.cb_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(84, 104);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(547, 28);
            this.cb_client.TabIndex = 4;
            this.cb_client.SelectedIndexChanged += new System.EventHandler(this.cb_client_SelectedIndexChanged);
            // 
            // cb_mechanic
            // 
            this.cb_mechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mechanic.FormattingEnabled = true;
            this.cb_mechanic.Location = new System.Drawing.Point(330, 59);
            this.cb_mechanic.Name = "cb_mechanic";
            this.cb_mechanic.Size = new System.Drawing.Size(301, 28);
            this.cb_mechanic.TabIndex = 5;
            // 
            // cb_repair
            // 
            this.cb_repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_repair.FormattingEnabled = true;
            this.cb_repair.Location = new System.Drawing.Point(231, 12);
            this.cb_repair.Name = "cb_repair";
            this.cb_repair.Size = new System.Drawing.Size(400, 28);
            this.cb_repair.TabIndex = 3;
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_startDate.ForeColor = System.Drawing.Color.White;
            this.lbl_startDate.Location = new System.Drawing.Point(640, 18);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(125, 30);
            this.lbl_startDate.TabIndex = 36;
            this.lbl_startDate.Text = "START DATE:";
            this.lbl_startDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_repair
            // 
            this.lbl_repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repair.ForeColor = System.Drawing.Color.White;
            this.lbl_repair.Location = new System.Drawing.Point(162, 10);
            this.lbl_repair.Name = "lbl_repair";
            this.lbl_repair.Size = new System.Drawing.Size(63, 30);
            this.lbl_repair.TabIndex = 34;
            this.lbl_repair.Text = "Repair:";
            this.lbl_repair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(-40, 13);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(115, 33);
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
            this.tb_id.Location = new System.Drawing.Point(84, 16);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(56, 26);
            this.tb_id.TabIndex = 28;
            // 
            // lbl_mechanic
            // 
            this.lbl_mechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mechanic.ForeColor = System.Drawing.Color.White;
            this.lbl_mechanic.Location = new System.Drawing.Point(225, 58);
            this.lbl_mechanic.Name = "lbl_mechanic";
            this.lbl_mechanic.Size = new System.Drawing.Size(99, 32);
            this.lbl_mechanic.TabIndex = 24;
            this.lbl_mechanic.Text = "Mechanic:";
            this.lbl_mechanic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_client
            // 
            this.lbl_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_client.ForeColor = System.Drawing.Color.White;
            this.lbl_client.Location = new System.Drawing.Point(-43, 101);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(118, 33);
            this.lbl_client.TabIndex = 9;
            this.lbl_client.Text = "Client:";
            this.lbl_client.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_schedulesForm
            // 
            this.lbl_schedulesForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_schedulesForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_schedulesForm.Location = new System.Drawing.Point(12, 19);
            this.lbl_schedulesForm.Name = "lbl_schedulesForm";
            this.lbl_schedulesForm.Size = new System.Drawing.Size(453, 41);
            this.lbl_schedulesForm.TabIndex = 45;
            this.lbl_schedulesForm.Text = "SCHEDULE´S FORM";
            this.lbl_schedulesForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::Oficina.Properties.Resources.bin__2_;
            this.btn_delete.Location = new System.Drawing.Point(945, 629);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(52, 52);
            this.btn_delete.TabIndex = 12;
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
            this.btn_clearData.Location = new System.Drawing.Point(945, 114);
            this.btn_clearData.Name = "btn_clearData";
            this.btn_clearData.Size = new System.Drawing.Size(52, 52);
            this.btn_clearData.TabIndex = 8;
            this.btn_clearData.UseVisualStyleBackColor = true;
            this.btn_clearData.Click += new System.EventHandler(this.btn_clearData_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::Oficina.Properties.Resources.salve_;
            this.btn_save.Location = new System.Drawing.Point(945, 54);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(52, 52);
            this.btn_save.TabIndex = 7;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_schedules
            // 
            this.dgv_schedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_schedules.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_schedules.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgv_schedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_schedules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_schedules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_schedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_schedules.ColumnHeadersHeight = 27;
            this.dgv_schedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_schedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_schedules.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_schedules.EnableHeadersVisualStyles = false;
            this.dgv_schedules.GridColor = System.Drawing.Color.White;
            this.dgv_schedules.Location = new System.Drawing.Point(18, 399);
            this.dgv_schedules.Name = "dgv_schedules";
            this.dgv_schedules.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_schedules.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_schedules.RowHeadersVisible = false;
            this.dgv_schedules.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_schedules.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_schedules.RowTemplate.Height = 28;
            this.dgv_schedules.Size = new System.Drawing.Size(917, 282);
            this.dgv_schedules.TabIndex = 96;
            this.dgv_schedules.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_schedules_CellDoubleClick_1);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 82;
            // 
            // gb_byStartDate
            // 
            this.gb_byStartDate.Controls.Add(this.lbl_upTo);
            this.gb_byStartDate.Controls.Add(this.dtp_endDateSearch);
            this.gb_byStartDate.Controls.Add(this.btn_search);
            this.gb_byStartDate.Controls.Add(this.dtp_startDateSearch);
            this.gb_byStartDate.Controls.Add(this.btn_update);
            this.gb_byStartDate.Controls.Add(this.lbl_between);
            this.gb_byStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_byStartDate.ForeColor = System.Drawing.Color.White;
            this.gb_byStartDate.Location = new System.Drawing.Point(18, 304);
            this.gb_byStartDate.Name = "gb_byStartDate";
            this.gb_byStartDate.Size = new System.Drawing.Size(917, 75);
            this.gb_byStartDate.TabIndex = 95;
            this.gb_byStartDate.TabStop = false;
            this.gb_byStartDate.Text = "Searh by Start Date";
            // 
            // lbl_upTo
            // 
            this.lbl_upTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upTo.ForeColor = System.Drawing.Color.White;
            this.lbl_upTo.Location = new System.Drawing.Point(423, 29);
            this.lbl_upTo.Name = "lbl_upTo";
            this.lbl_upTo.Size = new System.Drawing.Size(46, 33);
            this.lbl_upTo.TabIndex = 72;
            this.lbl_upTo.Text = "To:";
            this.lbl_upTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_endDateSearch
            // 
            this.dtp_endDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_endDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_endDateSearch.Location = new System.Drawing.Point(475, 29);
            this.dtp_endDateSearch.Name = "dtp_endDateSearch";
            this.dtp_endDateSearch.Size = new System.Drawing.Size(165, 26);
            this.dtp_endDateSearch.TabIndex = 67;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Aqua;
            this.btn_search.Image = global::Oficina.Properties.Resources.lupa__3_1;
            this.btn_search.Location = new System.Drawing.Point(646, 20);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 42);
            this.btn_search.TabIndex = 10;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // dtp_startDateSearch
            // 
            this.dtp_startDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_startDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startDateSearch.Location = new System.Drawing.Point(252, 29);
            this.dtp_startDateSearch.Name = "dtp_startDateSearch";
            this.dtp_startDateSearch.Size = new System.Drawing.Size(165, 26);
            this.dtp_startDateSearch.TabIndex = 65;
            // 
            // btn_update
            // 
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Aqua;
            this.btn_update.Image = global::Oficina.Properties.Resources.setas_circulares;
            this.btn_update.Location = new System.Drawing.Point(695, 20);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(43, 42);
            this.btn_update.TabIndex = 51;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // lbl_between
            // 
            this.lbl_between.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_between.ForeColor = System.Drawing.Color.White;
            this.lbl_between.Location = new System.Drawing.Point(179, 29);
            this.lbl_between.Name = "lbl_between";
            this.lbl_between.Size = new System.Drawing.Size(67, 33);
            this.lbl_between.TabIndex = 73;
            this.lbl_between.Text = "From:";
            this.lbl_between.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_ManageSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1009, 702);
            this.Controls.Add(this.dgv_schedules);
            this.Controls.Add(this.gb_byStartDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clearData);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_schedulesForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ManageSchedule";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Manage Schedule";
            this.Load += new System.EventHandler(this.Form_ManageSchedule_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).EndInit();
            this.gb_byStartDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.Label lbl_repair;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lbl_mechanic;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.Label lbl_vehicle;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clearData;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_schedulesForm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cb_repair;
        private System.Windows.Forms.ComboBox cb_mechanic;
        private System.Windows.Forms.ComboBox cb_vehicle;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.DateTimePicker dtp_alertDate;
        private System.Windows.Forms.Label lbl_alertDate;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.MaskedTextBox tb_time;
        private System.Windows.Forms.DataGridView dgv_schedules;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox gb_byStartDate;
        private System.Windows.Forms.Label lbl_upTo;
        private System.Windows.Forms.DateTimePicker dtp_endDateSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dtp_startDateSearch;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_between;
        private System.Windows.Forms.TextBox tb_email;
    }
}