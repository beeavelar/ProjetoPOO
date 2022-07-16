namespace Oficina
{
    partial class Form_ManageClients
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_postalCode = new System.Windows.Forms.MaskedTextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_nif = new System.Windows.Forms.TextBox();
            this.lbl_nif = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_postalCode = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.lbl_clientsForm = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tb_nameToSearch = new System.Windows.Forms.TextBox();
            this.lbl_clientSearch = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clearData = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_clients = new System.Windows.Forms.DataGridView();
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_postalCode);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.tb_phone);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.tb_nif);
            this.panel1.Controls.Add(this.lbl_nif);
            this.panel1.Controls.Add(this.tb_address);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.lbl_postalCode);
            this.panel1.Controls.Add(this.lbl_address);
            this.panel1.Controls.Add(this.lbl_phoneNumber);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(57, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 208);
            this.panel1.TabIndex = 22;
            // 
            // tb_postalCode
            // 
            this.tb_postalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_postalCode.Location = new System.Drawing.Point(690, 90);
            this.tb_postalCode.Mask = "0000-999";
            this.tb_postalCode.Name = "tb_postalCode";
            this.tb_postalCode.Size = new System.Drawing.Size(104, 26);
            this.tb_postalCode.TabIndex = 3;
            this.tb_postalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_postalCode_KeyPress);
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(21, 7);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(124, 33);
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
            this.tb_id.Location = new System.Drawing.Point(151, 7);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(56, 26);
            this.tb_id.TabIndex = 28;
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_phone.Location = new System.Drawing.Point(151, 166);
            this.tb_phone.MaxLength = 9;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(186, 26);
            this.tb_phone.TabIndex = 5;
            this.tb_phone.Tag = "";
            this.tb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_phone_KeyPress);
            this.tb_phone.Leave += new System.EventHandler(this.tb_phone_Leave);
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_email.Location = new System.Drawing.Point(151, 128);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(409, 26);
            this.tb_email.TabIndex = 4;
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // lbl_email
            // 
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(21, 122);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(124, 32);
            this.lbl_email.TabIndex = 24;
            this.lbl_email.Text = "E-mail:";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_name
            // 
            this.tb_name.AcceptsReturn = true;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_name.Location = new System.Drawing.Point(151, 52);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(643, 26);
            this.tb_name.TabIndex = 1;
            // 
            // tb_nif
            // 
            this.tb_nif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_nif.Location = new System.Drawing.Point(391, 166);
            this.tb_nif.MaxLength = 9;
            this.tb_nif.Name = "tb_nif";
            this.tb_nif.Size = new System.Drawing.Size(169, 26);
            this.tb_nif.TabIndex = 6;
            this.tb_nif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nif_KeyPress);
            this.tb_nif.Leave += new System.EventHandler(this.tb_nif_Leave);
            // 
            // lbl_nif
            // 
            this.lbl_nif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nif.ForeColor = System.Drawing.Color.White;
            this.lbl_nif.Location = new System.Drawing.Point(333, 166);
            this.lbl_nif.Name = "lbl_nif";
            this.lbl_nif.Size = new System.Drawing.Size(52, 30);
            this.lbl_nif.TabIndex = 21;
            this.lbl_nif.Text = "NIF:";
            this.lbl_nif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_address.Location = new System.Drawing.Point(151, 90);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(409, 26);
            this.tb_address.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(25, 49);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(120, 33);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_postalCode
            // 
            this.lbl_postalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_postalCode.ForeColor = System.Drawing.Color.White;
            this.lbl_postalCode.Location = new System.Drawing.Point(566, 89);
            this.lbl_postalCode.Name = "lbl_postalCode";
            this.lbl_postalCode.Size = new System.Drawing.Size(118, 32);
            this.lbl_postalCode.TabIndex = 13;
            this.lbl_postalCode.Text = "Postal code:";
            this.lbl_postalCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_address
            // 
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.White;
            this.lbl_address.Location = new System.Drawing.Point(15, 89);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(130, 29);
            this.lbl_address.TabIndex = 10;
            this.lbl_address.Text = "Address:";
            this.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phoneNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_phoneNumber.Location = new System.Drawing.Point(7, 165);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(138, 29);
            this.lbl_phoneNumber.TabIndex = 12;
            this.lbl_phoneNumber.Text = "Phone number:";
            this.lbl_phoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_clientsForm
            // 
            this.lbl_clientsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_clientsForm.Location = new System.Drawing.Point(51, 18);
            this.lbl_clientsForm.Name = "lbl_clientsForm";
            this.lbl_clientsForm.Size = new System.Drawing.Size(240, 41);
            this.lbl_clientsForm.TabIndex = 21;
            this.lbl_clientsForm.Text = "CLIENT´S FORM";
            this.lbl_clientsForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_nameToSearch
            // 
            this.tb_nameToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nameToSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_nameToSearch.Location = new System.Drawing.Point(386, 320);
            this.tb_nameToSearch.Name = "tb_nameToSearch";
            this.tb_nameToSearch.Size = new System.Drawing.Size(252, 26);
            this.tb_nameToSearch.TabIndex = 9;
            // 
            // lbl_clientSearch
            // 
            this.lbl_clientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientSearch.ForeColor = System.Drawing.Color.White;
            this.lbl_clientSearch.Location = new System.Drawing.Point(174, 315);
            this.lbl_clientSearch.Name = "lbl_clientSearch";
            this.lbl_clientSearch.Size = new System.Drawing.Size(206, 33);
            this.lbl_clientSearch.TabIndex = 27;
            this.lbl_clientSearch.Text = "Search by client name:";
            this.lbl_clientSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Aqua;
            this.btn_search.Image = global::Oficina.Properties.Resources.lupa__3_1;
            this.btn_search.Location = new System.Drawing.Point(644, 311);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 42);
            this.btn_search.TabIndex = 10;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::Oficina.Properties.Resources.bin__2_;
            this.btn_delete.Location = new System.Drawing.Point(897, 642);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(52, 52);
            this.btn_delete.TabIndex = 11;
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
            this.btn_clearData.Location = new System.Drawing.Point(897, 131);
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
            this.btn_save.Location = new System.Drawing.Point(897, 73);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(52, 52);
            this.btn_save.TabIndex = 7;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Aqua;
            this.btn_update.Image = global::Oficina.Properties.Resources.setas_circulares;
            this.btn_update.Location = new System.Drawing.Point(693, 311);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(43, 42);
            this.btn_update.TabIndex = 29;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_clients
            // 
            this.dgv_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_clients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_clients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgv_clients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_clients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_clients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clients.ColumnHeadersHeight = 27;
            this.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_clients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_clients.EnableHeadersVisualStyles = false;
            this.dgv_clients.GridColor = System.Drawing.Color.White;
            this.dgv_clients.Location = new System.Drawing.Point(69, 370);
            this.dgv_clients.Name = "dgv_clients";
            this.dgv_clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_clients.RowHeadersVisible = false;
            this.dgv_clients.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_clients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_clients.RowTemplate.Height = 28;
            this.dgv_clients.Size = new System.Drawing.Size(813, 324);
            this.dgv_clients.TabIndex = 75;
            this.dgv_clients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clients_CellDoubleClick_1);
            // 
            // chkSelect
            // 
            this.chkSelect.HeaderText = "Select";
            this.chkSelect.MinimumWidth = 8;
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Width = 82;
            // 
            // Form_ManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(961, 728);
            this.Controls.Add(this.dgv_clients);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_clientSearch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_nameToSearch);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clearData);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_clientsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ManageClients";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Manage Clients";
            this.Load += new System.EventHandler(this.Form_ManageClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clearData;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_postalCode;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private System.Windows.Forms.Label lbl_clientsForm;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_nif;
        private System.Windows.Forms.Label lbl_nif;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_nameToSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_clientSearch;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_clients;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
        private System.Windows.Forms.MaskedTextBox tb_postalCode;
    }
}