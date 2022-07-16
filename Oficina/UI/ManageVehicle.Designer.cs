namespace Oficina
{
    partial class Form_ManageVehicles
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
            this.lbl_vehiclesForm = new System.Windows.Forms.Label();
            this.lbl_idVehicle = new System.Windows.Forms.Label();
            this.lbl_clientName = new System.Windows.Forms.Label();
            this.lbl_licensePlate = new System.Windows.Forms.Label();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_licensePlate = new System.Windows.Forms.MaskedTextBox();
            this.cb_brands = new System.Windows.Forms.ComboBox();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lbl_vehicleSearch = new System.Windows.Forms.Label();
            this.tb_licenseToSearch = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clearData = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_vehicles = new System.Windows.Forms.DataGridView();
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_vehiclesForm
            // 
            this.lbl_vehiclesForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehiclesForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_vehiclesForm.Location = new System.Drawing.Point(60, 25);
            this.lbl_vehiclesForm.Name = "lbl_vehiclesForm";
            this.lbl_vehiclesForm.Size = new System.Drawing.Size(385, 41);
            this.lbl_vehiclesForm.TabIndex = 6;
            this.lbl_vehiclesForm.Text = "VEHICLE´S FORM";
            this.lbl_vehiclesForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_idVehicle
            // 
            this.lbl_idVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idVehicle.ForeColor = System.Drawing.Color.White;
            this.lbl_idVehicle.Location = new System.Drawing.Point(42, 20);
            this.lbl_idVehicle.Name = "lbl_idVehicle";
            this.lbl_idVehicle.Size = new System.Drawing.Size(107, 29);
            this.lbl_idVehicle.TabIndex = 8;
            this.lbl_idVehicle.Text = "Vehicle Id:";
            this.lbl_idVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_clientName
            // 
            this.lbl_clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientName.ForeColor = System.Drawing.Color.White;
            this.lbl_clientName.Location = new System.Drawing.Point(28, 71);
            this.lbl_clientName.Name = "lbl_clientName";
            this.lbl_clientName.Size = new System.Drawing.Size(127, 33);
            this.lbl_clientName.TabIndex = 9;
            this.lbl_clientName.Text = "Client:";
            this.lbl_clientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_licensePlate
            // 
            this.lbl_licensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_licensePlate.ForeColor = System.Drawing.Color.White;
            this.lbl_licensePlate.Location = new System.Drawing.Point(25, 113);
            this.lbl_licensePlate.Name = "lbl_licensePlate";
            this.lbl_licensePlate.Size = new System.Drawing.Size(123, 29);
            this.lbl_licensePlate.TabIndex = 10;
            this.lbl_licensePlate.Text = "License plate:";
            this.lbl_licensePlate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_brand
            // 
            this.lbl_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand.ForeColor = System.Drawing.Color.White;
            this.lbl_brand.Location = new System.Drawing.Point(339, 115);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(73, 28);
            this.lbl_brand.TabIndex = 11;
            this.lbl_brand.Text = "Brand:";
            this.lbl_brand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_model
            // 
            this.lbl_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.ForeColor = System.Drawing.Color.White;
            this.lbl_model.Location = new System.Drawing.Point(73, 157);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(75, 29);
            this.lbl_model.TabIndex = 12;
            this.lbl_model.Text = "Model:";
            this.lbl_model.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_category
            // 
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.Color.White;
            this.lbl_category.Location = new System.Drawing.Point(581, 114);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(100, 32);
            this.lbl_category.TabIndex = 13;
            this.lbl_category.Text = "Category:";
            this.lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_color
            // 
            this.lbl_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.ForeColor = System.Drawing.Color.White;
            this.lbl_color.Location = new System.Drawing.Point(337, 157);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(75, 30);
            this.lbl_color.TabIndex = 14;
            this.lbl_color.Text = "Color:";
            this.lbl_color.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_licensePlate);
            this.panel1.Controls.Add(this.cb_brands);
            this.panel1.Controls.Add(this.cb_client);
            this.panel1.Controls.Add(this.tb_year);
            this.panel1.Controls.Add(this.lbl_year);
            this.panel1.Controls.Add(this.tb_color);
            this.panel1.Controls.Add(this.cb_category);
            this.panel1.Controls.Add(this.tb_model);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.lbl_idVehicle);
            this.panel1.Controls.Add(this.lbl_color);
            this.panel1.Controls.Add(this.lbl_clientName);
            this.panel1.Controls.Add(this.lbl_category);
            this.panel1.Controls.Add(this.lbl_licensePlate);
            this.panel1.Controls.Add(this.lbl_model);
            this.panel1.Controls.Add(this.lbl_brand);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(66, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 204);
            this.panel1.TabIndex = 15;
            // 
            // tb_licensePlate
            // 
            this.tb_licensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_licensePlate.Location = new System.Drawing.Point(160, 113);
            this.tb_licensePlate.Mask = "AA-AA-AA";
            this.tb_licensePlate.Name = "tb_licensePlate";
            this.tb_licensePlate.Size = new System.Drawing.Size(171, 26);
            this.tb_licensePlate.TabIndex = 2;
            // 
            // cb_brands
            // 
            this.cb_brands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_brands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cb_brands.FormattingEnabled = true;
            this.cb_brands.Items.AddRange(new object[] {
            "Abarth",
            "Aixam",
            "Alfa Romeo",
            "Aston Martin",
            "Audi",
            "Austin",
            "Bentley",
            "BMW",
            "Cadillac",
            "Caterham",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Dacia",
            "Daewoo",
            "Daihatsu",
            "Datsun",
            "Dodge",
            "DS",
            "Ferrari",
            "Fiat",
            "Ford",
            "Honda",
            "Hummer",
            "Hyundai",
            "Infiniti"});
            this.cb_brands.Location = new System.Drawing.Point(418, 115);
            this.cb_brands.Name = "cb_brands";
            this.cb_brands.Size = new System.Drawing.Size(170, 28);
            this.cb_brands.TabIndex = 3;
            // 
            // cb_client
            // 
            this.cb_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(161, 71);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(427, 28);
            this.cb_client.TabIndex = 1;
            // 
            // tb_year
            // 
            this.tb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_year.Location = new System.Drawing.Point(687, 157);
            this.tb_year.MaxLength = 4;
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(152, 26);
            this.tb_year.TabIndex = 7;
            this.tb_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_year_KeyPress);
            // 
            // lbl_year
            // 
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.ForeColor = System.Drawing.Color.White;
            this.lbl_year.Location = new System.Drawing.Point(606, 156);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(75, 30);
            this.lbl_year.TabIndex = 21;
            this.lbl_year.Text = "Year:";
            this.lbl_year.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_color
            // 
            this.tb_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_color.Location = new System.Drawing.Point(418, 157);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(170, 26);
            this.tb_color.TabIndex = 6;
            // 
            // cb_category
            // 
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "-----",
            "Car",
            "motorcycle",
            "Truck",
            "Other"});
            this.cb_category.Location = new System.Drawing.Point(687, 114);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(152, 28);
            this.cb_category.TabIndex = 4;
            // 
            // tb_model
            // 
            this.tb_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_model.Location = new System.Drawing.Point(160, 157);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(171, 26);
            this.tb_model.TabIndex = 5;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_id.Location = new System.Drawing.Point(161, 20);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(64, 26);
            this.tb_id.TabIndex = 15;
            // 
            // lbl_vehicleSearch
            // 
            this.lbl_vehicleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicleSearch.ForeColor = System.Drawing.Color.White;
            this.lbl_vehicleSearch.Location = new System.Drawing.Point(181, 312);
            this.lbl_vehicleSearch.Name = "lbl_vehicleSearch";
            this.lbl_vehicleSearch.Size = new System.Drawing.Size(265, 33);
            this.lbl_vehicleSearch.TabIndex = 34;
            this.lbl_vehicleSearch.Text = "Search by vehicle license plate:";
            this.lbl_vehicleSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_licenseToSearch
            // 
            this.tb_licenseToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_licenseToSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_licenseToSearch.Location = new System.Drawing.Point(452, 315);
            this.tb_licenseToSearch.Name = "tb_licenseToSearch";
            this.tb_licenseToSearch.Size = new System.Drawing.Size(252, 26);
            this.tb_licenseToSearch.TabIndex = 10;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Aqua;
            this.btn_search.Image = global::Oficina.Properties.Resources.lupa__3_;
            this.btn_search.Location = new System.Drawing.Point(719, 306);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 42);
            this.btn_search.TabIndex = 11;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::Oficina.Properties.Resources.bin__2_;
            this.btn_delete.Location = new System.Drawing.Point(968, 628);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(52, 52);
            this.btn_delete.TabIndex = 33;
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
            this.btn_clearData.Location = new System.Drawing.Point(968, 134);
            this.btn_clearData.Name = "btn_clearData";
            this.btn_clearData.Size = new System.Drawing.Size(52, 52);
            this.btn_clearData.TabIndex = 9;
            this.btn_clearData.UseVisualStyleBackColor = true;
            this.btn_clearData.Click += new System.EventHandler(this.btn_clearData_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::Oficina.Properties.Resources.salve_;
            this.btn_save.Location = new System.Drawing.Point(968, 69);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(52, 52);
            this.btn_save.TabIndex = 8;
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
            this.btn_update.Location = new System.Drawing.Point(768, 306);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(43, 42);
            this.btn_update.TabIndex = 36;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_vehicles
            // 
            this.dgv_vehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_vehicles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_vehicles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgv_vehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_vehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_vehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vehicles.ColumnHeadersHeight = 27;
            this.dgv_vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_vehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vehicles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_vehicles.EnableHeadersVisualStyles = false;
            this.dgv_vehicles.GridColor = System.Drawing.Color.White;
            this.dgv_vehicles.Location = new System.Drawing.Point(66, 369);
            this.dgv_vehicles.Name = "dgv_vehicles";
            this.dgv_vehicles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_vehicles.RowHeadersVisible = false;
            this.dgv_vehicles.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_vehicles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_vehicles.RowTemplate.Height = 28;
            this.dgv_vehicles.Size = new System.Drawing.Size(881, 311);
            this.dgv_vehicles.TabIndex = 75;
            this.dgv_vehicles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vehicles_CellDoubleClick_1);
            // 
            // chkSelect
            // 
            this.chkSelect.HeaderText = "Select";
            this.chkSelect.MinimumWidth = 8;
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Width = 82;
            // 
            // Form_ManageVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1032, 728);
            this.Controls.Add(this.dgv_vehicles);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_vehicleSearch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_licenseToSearch);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clearData);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_vehiclesForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ManageVehicles";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Manage Vehicle";
            this.Load += new System.EventHandler(this.Form_ManageVehicles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_vehiclesForm;
        private System.Windows.Forms.Label lbl_idVehicle;
        private System.Windows.Forms.Label lbl_clientName;
        private System.Windows.Forms.Label lbl_licensePlate;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.TextBox tb_color;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lbl_vehicleSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_licenseToSearch;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clearData;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cb_brands;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_vehicles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
        private System.Windows.Forms.MaskedTextBox tb_licensePlate;
    }
}