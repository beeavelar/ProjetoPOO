namespace Oficina
{
    partial class Form_Dashboard
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_settingSubpanel = new System.Windows.Forms.Panel();
            this.btn_newUser = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_communication = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.btn_repair = new System.Windows.Forms.Button();
            this.btn_mechanic = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.btn_vehicle = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_user = new System.Windows.Forms.Panel();
            this.lbl_permission = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.lbl_hours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_repairShop = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_menu.SuspendLayout();
            this.panel_settingSubpanel.SuspendLayout();
            this.panel_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.AutoScroll = true;
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel_menu.Controls.Add(this.panel_settingSubpanel);
            this.panel_menu.Controls.Add(this.btn_settings);
            this.panel_menu.Controls.Add(this.btn_communication);
            this.panel_menu.Controls.Add(this.btn_about);
            this.panel_menu.Controls.Add(this.btn_invoice);
            this.panel_menu.Controls.Add(this.btn_schedule);
            this.panel_menu.Controls.Add(this.btn_repair);
            this.panel_menu.Controls.Add(this.btn_mechanic);
            this.panel_menu.Controls.Add(this.btn_client);
            this.panel_menu.Controls.Add(this.btn_vehicle);
            this.panel_menu.Controls.Add(this.btn_home);
            this.panel_menu.Controls.Add(this.panel_user);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(230, 773);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_settingSubpanel
            // 
            this.panel_settingSubpanel.Controls.Add(this.btn_newUser);
            this.panel_settingSubpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_settingSubpanel.Location = new System.Drawing.Point(0, 602);
            this.panel_settingSubpanel.Name = "panel_settingSubpanel";
            this.panel_settingSubpanel.Size = new System.Drawing.Size(230, 54);
            this.panel_settingSubpanel.TabIndex = 10;
            // 
            // btn_newUser
            // 
            this.btn_newUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_newUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_newUser.FlatAppearance.BorderSize = 0;
            this.btn_newUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newUser.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_newUser.Location = new System.Drawing.Point(0, 0);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_newUser.Size = new System.Drawing.Size(230, 45);
            this.btn_newUser.TabIndex = 11;
            this.btn_newUser.Text = "New user";
            this.btn_newUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_newUser.UseVisualStyleBackColor = false;
            this.btn_newUser.Click += new System.EventHandler(this.btn_newUser_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.btn_settings.Image = global::Oficina.Properties.Resources.settings__1_;
            this.btn_settings.Location = new System.Drawing.Point(0, 557);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_settings.Size = new System.Drawing.Size(230, 45);
            this.btn_settings.TabIndex = 10;
            this.btn_settings.Text = "SETTINGS           ";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_communication
            // 
            this.btn_communication.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_communication.FlatAppearance.BorderSize = 0;
            this.btn_communication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_communication.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_communication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.btn_communication.Location = new System.Drawing.Point(0, 512);
            this.btn_communication.Name = "btn_communication";
            this.btn_communication.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_communication.Size = new System.Drawing.Size(230, 45);
            this.btn_communication.TabIndex = 10;
            this.btn_communication.Text = "COMMUNICATION";
            this.btn_communication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_communication.UseVisualStyleBackColor = true;
            this.btn_communication.Click += new System.EventHandler(this.btn_communication_Click);
            // 
            // btn_about
            // 
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.btn_about.Image = global::Oficina.Properties.Resources.info__2_;
            this.btn_about.Location = new System.Drawing.Point(0, 728);
            this.btn_about.Name = "btn_about";
            this.btn_about.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_about.Size = new System.Drawing.Size(230, 45);
            this.btn_about.TabIndex = 9;
            this.btn_about.Text = "ABOUT               ";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_invoice
            // 
            this.btn_invoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_invoice.FlatAppearance.BorderSize = 0;
            this.btn_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_invoice.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.btn_invoice.Location = new System.Drawing.Point(0, 467);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_invoice.Size = new System.Drawing.Size(230, 45);
            this.btn_invoice.TabIndex = 7;
            this.btn_invoice.Text = "INVOICE";
            this.btn_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_invoice.UseVisualStyleBackColor = true;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // btn_schedule
            // 
            this.btn_schedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_schedule.FlatAppearance.BorderSize = 0;
            this.btn_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_schedule.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_schedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.btn_schedule.Location = new System.Drawing.Point(0, 422);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_schedule.Size = new System.Drawing.Size(230, 45);
            this.btn_schedule.TabIndex = 6;
            this.btn_schedule.Text = "SCHEDULE        ";
            this.btn_schedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_schedule.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // btn_repair
            // 
            this.btn_repair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_repair.FlatAppearance.BorderSize = 0;
            this.btn_repair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repair.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.btn_repair.Location = new System.Drawing.Point(0, 377);
            this.btn_repair.Name = "btn_repair";
            this.btn_repair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_repair.Size = new System.Drawing.Size(230, 45);
            this.btn_repair.TabIndex = 5;
            this.btn_repair.Text = "REPAIR                  ";
            this.btn_repair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_repair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_repair.UseVisualStyleBackColor = true;
            this.btn_repair.Click += new System.EventHandler(this.btn_repair_Click);
            // 
            // btn_mechanic
            // 
            this.btn_mechanic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_mechanic.FlatAppearance.BorderSize = 0;
            this.btn_mechanic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mechanic.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mechanic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.btn_mechanic.Location = new System.Drawing.Point(0, 332);
            this.btn_mechanic.Name = "btn_mechanic";
            this.btn_mechanic.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_mechanic.Size = new System.Drawing.Size(230, 45);
            this.btn_mechanic.TabIndex = 4;
            this.btn_mechanic.Text = "MECHANIC           ";
            this.btn_mechanic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mechanic.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_mechanic.UseVisualStyleBackColor = true;
            this.btn_mechanic.Click += new System.EventHandler(this.btn_mechanic_Click);
            // 
            // btn_client
            // 
            this.btn_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_client.FlatAppearance.BorderSize = 0;
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.btn_client.Location = new System.Drawing.Point(0, 287);
            this.btn_client.Name = "btn_client";
            this.btn_client.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_client.Size = new System.Drawing.Size(230, 45);
            this.btn_client.TabIndex = 3;
            this.btn_client.Text = "CLIENT                  ";
            this.btn_client.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_client.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_vehicle
            // 
            this.btn_vehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_vehicle.FlatAppearance.BorderSize = 0;
            this.btn_vehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.btn_vehicle.Location = new System.Drawing.Point(0, 242);
            this.btn_vehicle.Name = "btn_vehicle";
            this.btn_vehicle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_vehicle.Size = new System.Drawing.Size(230, 45);
            this.btn_vehicle.TabIndex = 2;
            this.btn_vehicle.Text = "VEHICLE               ";
            this.btn_vehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_vehicle.UseVisualStyleBackColor = true;
            this.btn_vehicle.Click += new System.EventHandler(this.btn_vehicle_Click);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.btn_home.Image = global::Oficina.Properties.Resources.home__2_;
            this.btn_home.Location = new System.Drawing.Point(0, 197);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(230, 45);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "HOME                ";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_user
            // 
            this.panel_user.Controls.Add(this.lbl_permission);
            this.panel_user.Controls.Add(this.lbl_name);
            this.panel_user.Controls.Add(this.pictureBox2);
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user.Location = new System.Drawing.Point(0, 0);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(230, 197);
            this.panel_user.TabIndex = 0;
            // 
            // lbl_permission
            // 
            this.lbl_permission.Font = new System.Drawing.Font("Arial Narrow", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_permission.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_permission.Location = new System.Drawing.Point(39, 134);
            this.lbl_permission.Name = "lbl_permission";
            this.lbl_permission.Size = new System.Drawing.Size(156, 31);
            this.lbl_permission.TabIndex = 6;
            this.lbl_permission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_name.Location = new System.Drawing.Point(35, 108);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(160, 29);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Oficina.Properties.Resources.userr;
            this.pictureBox2.Location = new System.Drawing.Point(68, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel_principal
            // 
            this.panel_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel_principal.Controls.Add(this.lbl_hours);
            this.panel_principal.Controls.Add(this.label1);
            this.panel_principal.Controls.Add(this.lbl_repairShop);
            this.panel_principal.Controls.Add(this.btn_logout);
            this.panel_principal.Controls.Add(this.pictureBox1);
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(230, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(1068, 773);
            this.panel_principal.TabIndex = 1;
            // 
            // lbl_hours
            // 
            this.lbl_hours.ForeColor = System.Drawing.Color.White;
            this.lbl_hours.Location = new System.Drawing.Point(693, 682);
            this.lbl_hours.Name = "lbl_hours";
            this.lbl_hours.Size = new System.Drawing.Size(331, 38);
            this.lbl_hours.TabIndex = 17;
            this.lbl_hours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(529, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 94);
            this.label1.TabIndex = 14;
            this.label1.Text = "SHOP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_repairShop
            // 
            this.lbl_repairShop.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repairShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_repairShop.Location = new System.Drawing.Point(234, 432);
            this.lbl_repairShop.Name = "lbl_repairShop";
            this.lbl_repairShop.Size = new System.Drawing.Size(325, 94);
            this.lbl_repairShop.TabIndex = 13;
            this.lbl_repairShop.Text = "REPAIR";
            this.lbl_repairShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_logout.Image = global::Oficina.Properties.Resources.power_button__2_;
            this.btn_logout.Location = new System.Drawing.Point(1001, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(55, 57);
            this.btn_logout.TabIndex = 12;
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Oficina.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(385, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 773);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.form_Dashboard_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_settingSubpanel.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_vehicle;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Label lbl_permission;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_mechanic;
        private System.Windows.Forms.Button btn_repair;
        private System.Windows.Forms.Button btn_invoice;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Label lbl_repairShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Panel panel_settingSubpanel;
        private System.Windows.Forms.Button btn_newUser;
        private System.Windows.Forms.Label lbl_hours;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_communication;
    }
}

