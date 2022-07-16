namespace Oficina
{
    partial class Form_Schedule
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
            this.lbl_schedulesList = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtp_startDateSearch = new System.Windows.Forms.DateTimePicker();
            this.dtp_endDateSearch = new System.Windows.Forms.DateTimePicker();
            this.lbl_upTo = new System.Windows.Forms.Label();
            this.lbl_between = new System.Windows.Forms.Label();
            this.gb_searchByStartDate = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_searchStartDate = new System.Windows.Forms.Button();
            this.dgv_schedules = new System.Windows.Forms.DataGridView();
            this.btn_addManageSchedule = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.gb_searchByStartDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_schedulesList
            // 
            this.lbl_schedulesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_schedulesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_schedulesList.Location = new System.Drawing.Point(135, 21);
            this.lbl_schedulesList.Name = "lbl_schedulesList";
            this.lbl_schedulesList.Size = new System.Drawing.Size(338, 41);
            this.lbl_schedulesList.TabIndex = 47;
            this.lbl_schedulesList.Text = "SEARCH SCHEDULE(S)";
            this.lbl_schedulesList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_startDateSearch
            // 
            this.dtp_startDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_startDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startDateSearch.Location = new System.Drawing.Point(261, 26);
            this.dtp_startDateSearch.Name = "dtp_startDateSearch";
            this.dtp_startDateSearch.Size = new System.Drawing.Size(142, 26);
            this.dtp_startDateSearch.TabIndex = 1;
            // 
            // dtp_endDateSearch
            // 
            this.dtp_endDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_endDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_endDateSearch.Location = new System.Drawing.Point(461, 26);
            this.dtp_endDateSearch.Name = "dtp_endDateSearch";
            this.dtp_endDateSearch.Size = new System.Drawing.Size(142, 26);
            this.dtp_endDateSearch.TabIndex = 2;
            // 
            // lbl_upTo
            // 
            this.lbl_upTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upTo.ForeColor = System.Drawing.Color.White;
            this.lbl_upTo.Location = new System.Drawing.Point(409, 24);
            this.lbl_upTo.Name = "lbl_upTo";
            this.lbl_upTo.Size = new System.Drawing.Size(46, 33);
            this.lbl_upTo.TabIndex = 72;
            this.lbl_upTo.Text = "To:";
            this.lbl_upTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_between
            // 
            this.lbl_between.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_between.ForeColor = System.Drawing.Color.White;
            this.lbl_between.Location = new System.Drawing.Point(188, 25);
            this.lbl_between.Name = "lbl_between";
            this.lbl_between.Size = new System.Drawing.Size(67, 33);
            this.lbl_between.TabIndex = 73;
            this.lbl_between.Text = "From:";
            this.lbl_between.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb_searchByStartDate
            // 
            this.gb_searchByStartDate.Controls.Add(this.btn_update);
            this.gb_searchByStartDate.Controls.Add(this.dtp_startDateSearch);
            this.gb_searchByStartDate.Controls.Add(this.lbl_upTo);
            this.gb_searchByStartDate.Controls.Add(this.btn_searchStartDate);
            this.gb_searchByStartDate.Controls.Add(this.dtp_endDateSearch);
            this.gb_searchByStartDate.Controls.Add(this.lbl_between);
            this.gb_searchByStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_searchByStartDate.ForeColor = System.Drawing.Color.White;
            this.gb_searchByStartDate.Location = new System.Drawing.Point(141, 135);
            this.gb_searchByStartDate.Name = "gb_searchByStartDate";
            this.gb_searchByStartDate.Size = new System.Drawing.Size(845, 72);
            this.gb_searchByStartDate.TabIndex = 88;
            this.gb_searchByStartDate.TabStop = false;
            this.gb_searchByStartDate.Text = "Search by start date";
            // 
            // btn_update
            // 
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Aqua;
            this.btn_update.Image = global::Oficina.Properties.Resources.setas_circulares;
            this.btn_update.Location = new System.Drawing.Point(661, 18);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(43, 42);
            this.btn_update.TabIndex = 74;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_searchStartDate
            // 
            this.btn_searchStartDate.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_searchStartDate.FlatAppearance.BorderSize = 0;
            this.btn_searchStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchStartDate.ForeColor = System.Drawing.Color.Aqua;
            this.btn_searchStartDate.Image = global::Oficina.Properties.Resources.lupa__3_1;
            this.btn_searchStartDate.Location = new System.Drawing.Point(609, 16);
            this.btn_searchStartDate.Name = "btn_searchStartDate";
            this.btn_searchStartDate.Size = new System.Drawing.Size(43, 42);
            this.btn_searchStartDate.TabIndex = 3;
            this.btn_searchStartDate.UseVisualStyleBackColor = true;
            this.btn_searchStartDate.Click += new System.EventHandler(this.btn_searchStartDate_Click);
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
            this.dgv_schedules.Location = new System.Drawing.Point(141, 226);
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
            this.dgv_schedules.Size = new System.Drawing.Size(845, 433);
            this.dgv_schedules.TabIndex = 74;
            // 
            // btn_addManageSchedule
            // 
            this.btn_addManageSchedule.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_addManageSchedule.FlatAppearance.BorderSize = 0;
            this.btn_addManageSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addManageSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addManageSchedule.ForeColor = System.Drawing.Color.White;
            this.btn_addManageSchedule.Image = global::Oficina.Properties.Resources.calendar11;
            this.btn_addManageSchedule.Location = new System.Drawing.Point(929, 79);
            this.btn_addManageSchedule.Name = "btn_addManageSchedule";
            this.btn_addManageSchedule.Size = new System.Drawing.Size(57, 50);
            this.btn_addManageSchedule.TabIndex = 5;
            this.btn_addManageSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addManageSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addManageSchedule.UseVisualStyleBackColor = true;
            this.btn_addManageSchedule.Click += new System.EventHandler(this.btn_addManageSchedule_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Oficina.Properties.Resources.cancelll10;
            this.btn_close.Location = new System.Drawing.Point(1015, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 37);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1062, 700);
            this.Controls.Add(this.dgv_schedules);
            this.Controls.Add(this.gb_searchByStartDate);
            this.Controls.Add(this.btn_addManageSchedule);
            this.Controls.Add(this.lbl_schedulesList);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Schedule";
            this.Text = "lcul";
            this.Load += new System.EventHandler(this.Form_Schedule_Load);
            this.gb_searchByStartDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_addManageSchedule;
        private System.Windows.Forms.Label lbl_schedulesList;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtp_startDateSearch;
        private System.Windows.Forms.DateTimePicker dtp_endDateSearch;
        private System.Windows.Forms.Button btn_searchStartDate;
        private System.Windows.Forms.Label lbl_upTo;
        private System.Windows.Forms.Label lbl_between;
        private System.Windows.Forms.GroupBox gb_searchByStartDate;
        private System.Windows.Forms.DataGridView dgv_schedules;
        private System.Windows.Forms.Button btn_update;
    }
}