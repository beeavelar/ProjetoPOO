namespace Oficina
{
    partial class Form_Vehicles
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
            this.lbl_vehicleSearch = new System.Windows.Forms.Label();
            this.tb_licenseToSearch = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addManageVehicle = new System.Windows.Forms.Button();
            this.lbl_vehiclesList = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_vehicles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_vehicleSearch
            // 
            this.lbl_vehicleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicleSearch.ForeColor = System.Drawing.Color.White;
            this.lbl_vehicleSearch.Location = new System.Drawing.Point(41, 95);
            this.lbl_vehicleSearch.Name = "lbl_vehicleSearch";
            this.lbl_vehicleSearch.Size = new System.Drawing.Size(265, 33);
            this.lbl_vehicleSearch.TabIndex = 38;
            this.lbl_vehicleSearch.Text = "Search by vehicle license plate:";
            this.lbl_vehicleSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_licenseToSearch
            // 
            this.tb_licenseToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_licenseToSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_licenseToSearch.Location = new System.Drawing.Point(312, 98);
            this.tb_licenseToSearch.MaxLength = 8;
            this.tb_licenseToSearch.Name = "tb_licenseToSearch";
            this.tb_licenseToSearch.Size = new System.Drawing.Size(178, 26);
            this.tb_licenseToSearch.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Aqua;
            this.btn_search.Image = global::Oficina.Properties.Resources.lupa__3_;
            this.btn_search.Location = new System.Drawing.Point(496, 89);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 42);
            this.btn_search.TabIndex = 2;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Oficina.Properties.Resources.cancelll;
            this.btn_close.Location = new System.Drawing.Point(972, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(42, 41);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addManageVehicle
            // 
            this.btn_addManageVehicle.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_addManageVehicle.FlatAppearance.BorderSize = 0;
            this.btn_addManageVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addManageVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addManageVehicle.ForeColor = System.Drawing.Color.White;
            this.btn_addManageVehicle.Image = global::Oficina.Properties.Resources.engarrafamento;
            this.btn_addManageVehicle.Location = new System.Drawing.Point(880, 84);
            this.btn_addManageVehicle.Name = "btn_addManageVehicle";
            this.btn_addManageVehicle.Size = new System.Drawing.Size(57, 50);
            this.btn_addManageVehicle.TabIndex = 4;
            this.btn_addManageVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addManageVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addManageVehicle.UseVisualStyleBackColor = true;
            this.btn_addManageVehicle.Click += new System.EventHandler(this.btn_addManageVehicle_Click);
            // 
            // lbl_vehiclesList
            // 
            this.lbl_vehiclesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehiclesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_vehiclesList.Location = new System.Drawing.Point(75, 12);
            this.lbl_vehiclesList.Name = "lbl_vehiclesList";
            this.lbl_vehiclesList.Size = new System.Drawing.Size(244, 41);
            this.lbl_vehiclesList.TabIndex = 40;
            this.lbl_vehiclesList.Text = "VEHICLES LIST";
            this.lbl_vehiclesList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_update
            // 
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Aqua;
            this.btn_update.Image = global::Oficina.Properties.Resources.setas_circulares;
            this.btn_update.Location = new System.Drawing.Point(554, 89);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(43, 42);
            this.btn_update.TabIndex = 3;
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
            this.dgv_vehicles.Location = new System.Drawing.Point(81, 153);
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
            this.dgv_vehicles.Size = new System.Drawing.Size(856, 507);
            this.dgv_vehicles.TabIndex = 75;
            // 
            // Form_Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1026, 672);
            this.Controls.Add(this.dgv_vehicles);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_addManageVehicle);
            this.Controls.Add(this.lbl_vehiclesList);
            this.Controls.Add(this.lbl_vehicleSearch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_licenseToSearch);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Form_Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_vehicleSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_licenseToSearch;
        private System.Windows.Forms.Button btn_addManageVehicle;
        private System.Windows.Forms.Label lbl_vehiclesList;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgv_vehicles;
    }
}