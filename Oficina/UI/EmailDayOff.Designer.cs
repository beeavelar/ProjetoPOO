namespace Oficina.UI
{
    partial class Form_EmaiDayOff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_email = new System.Windows.Forms.GroupBox();
            this.line_cc = new System.Windows.Forms.Panel();
            this.lbl_to = new System.Windows.Forms.Label();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.gb_searchEmails = new System.Windows.Forms.GroupBox();
            this.dtp_startDateSearch = new System.Windows.Forms.DateTimePicker();
            this.lbl_upTo = new System.Windows.Forms.Label();
            this.dtp_endDateSearch = new System.Windows.Forms.DateTimePicker();
            this.lbl_between = new System.Windows.Forms.Label();
            this.btn_searchDate = new System.Windows.Forms.Button();
            this.dgv_schedules = new System.Windows.Forms.DataGridView();
            this.lbl_emailDayOff = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_send = new System.Windows.Forms.Button();
            this.gb_email.SuspendLayout();
            this.gb_searchEmails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_email
            // 
            this.gb_email.Controls.Add(this.line_cc);
            this.gb_email.Controls.Add(this.lbl_to);
            this.gb_email.Controls.Add(this.tb_to);
            this.gb_email.ForeColor = System.Drawing.Color.White;
            this.gb_email.Location = new System.Drawing.Point(114, 504);
            this.gb_email.Name = "gb_email";
            this.gb_email.Size = new System.Drawing.Size(608, 94);
            this.gb_email.TabIndex = 116;
            this.gb_email.TabStop = false;
            this.gb_email.Text = "E-mail";
            // 
            // line_cc
            // 
            this.line_cc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.line_cc.Location = new System.Drawing.Point(38, 72);
            this.line_cc.Name = "line_cc";
            this.line_cc.Size = new System.Drawing.Size(530, 3);
            this.line_cc.TabIndex = 6;
            // 
            // lbl_to
            // 
            this.lbl_to.ForeColor = System.Drawing.Color.White;
            this.lbl_to.Location = new System.Drawing.Point(41, 37);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(37, 26);
            this.lbl_to.TabIndex = 7;
            this.lbl_to.Text = "To:";
            this.lbl_to.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_to
            // 
            this.tb_to.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_to.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_to.ForeColor = System.Drawing.Color.White;
            this.tb_to.Location = new System.Drawing.Point(93, 40);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(466, 19);
            this.tb_to.TabIndex = 5;
            // 
            // gb_searchEmails
            // 
            this.gb_searchEmails.Controls.Add(this.dtp_startDateSearch);
            this.gb_searchEmails.Controls.Add(this.lbl_upTo);
            this.gb_searchEmails.Controls.Add(this.dtp_endDateSearch);
            this.gb_searchEmails.Controls.Add(this.lbl_between);
            this.gb_searchEmails.Controls.Add(this.btn_searchDate);
            this.gb_searchEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_searchEmails.ForeColor = System.Drawing.Color.White;
            this.gb_searchEmails.Location = new System.Drawing.Point(114, 90);
            this.gb_searchEmails.Name = "gb_searchEmails";
            this.gb_searchEmails.Size = new System.Drawing.Size(608, 77);
            this.gb_searchEmails.TabIndex = 114;
            this.gb_searchEmails.TabStop = false;
            this.gb_searchEmails.Text = "Search the  e-mails by";
            // 
            // dtp_startDateSearch
            // 
            this.dtp_startDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_startDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startDateSearch.Location = new System.Drawing.Point(158, 31);
            this.dtp_startDateSearch.Name = "dtp_startDateSearch";
            this.dtp_startDateSearch.Size = new System.Drawing.Size(142, 26);
            this.dtp_startDateSearch.TabIndex = 110;
            // 
            // lbl_upTo
            // 
            this.lbl_upTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upTo.ForeColor = System.Drawing.Color.White;
            this.lbl_upTo.Location = new System.Drawing.Point(306, 29);
            this.lbl_upTo.Name = "lbl_upTo";
            this.lbl_upTo.Size = new System.Drawing.Size(46, 33);
            this.lbl_upTo.TabIndex = 112;
            this.lbl_upTo.Text = "To:";
            this.lbl_upTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_endDateSearch
            // 
            this.dtp_endDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_endDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_endDateSearch.Location = new System.Drawing.Point(358, 31);
            this.dtp_endDateSearch.Name = "dtp_endDateSearch";
            this.dtp_endDateSearch.Size = new System.Drawing.Size(142, 26);
            this.dtp_endDateSearch.TabIndex = 111;
            // 
            // lbl_between
            // 
            this.lbl_between.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_between.ForeColor = System.Drawing.Color.White;
            this.lbl_between.Location = new System.Drawing.Point(85, 29);
            this.lbl_between.Name = "lbl_between";
            this.lbl_between.Size = new System.Drawing.Size(67, 33);
            this.lbl_between.TabIndex = 113;
            this.lbl_between.Text = "From:";
            this.lbl_between.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_searchDate
            // 
            this.btn_searchDate.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_searchDate.FlatAppearance.BorderSize = 0;
            this.btn_searchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchDate.ForeColor = System.Drawing.Color.Aqua;
            this.btn_searchDate.Image = global::Oficina.Properties.Resources.lupa__3_1;
            this.btn_searchDate.Location = new System.Drawing.Point(508, 23);
            this.btn_searchDate.Name = "btn_searchDate";
            this.btn_searchDate.Size = new System.Drawing.Size(43, 42);
            this.btn_searchDate.TabIndex = 109;
            this.btn_searchDate.UseVisualStyleBackColor = true;
            this.btn_searchDate.Click += new System.EventHandler(this.btn_searchDate_Click);
            // 
            // dgv_schedules
            // 
            this.dgv_schedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_schedules.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_schedules.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgv_schedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_schedules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_schedules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_schedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_schedules.ColumnHeadersHeight = 27;
            this.dgv_schedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_schedules.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_schedules.EnableHeadersVisualStyles = false;
            this.dgv_schedules.GridColor = System.Drawing.Color.White;
            this.dgv_schedules.Location = new System.Drawing.Point(114, 186);
            this.dgv_schedules.Name = "dgv_schedules";
            this.dgv_schedules.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_schedules.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_schedules.RowHeadersVisible = false;
            this.dgv_schedules.RowHeadersWidth = 62;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_schedules.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_schedules.RowTemplate.Height = 28;
            this.dgv_schedules.Size = new System.Drawing.Size(608, 273);
            this.dgv_schedules.TabIndex = 113;
            // 
            // lbl_emailDayOff
            // 
            this.lbl_emailDayOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailDayOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_emailDayOff.Location = new System.Drawing.Point(69, 19);
            this.lbl_emailDayOff.Name = "lbl_emailDayOff";
            this.lbl_emailDayOff.Size = new System.Drawing.Size(282, 41);
            this.lbl_emailDayOff.TabIndex = 112;
            this.lbl_emailDayOff.Text = "E-MAIL DAY OFF";
            this.lbl_emailDayOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_send
            // 
            this.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Image = global::Oficina.Properties.Resources.outbox__1_1;
            this.btn_send.Location = new System.Drawing.Point(649, 608);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(73, 52);
            this.btn_send.TabIndex = 115;
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form_EmaiDayOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(829, 680);
            this.Controls.Add(this.gb_email);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.gb_searchEmails);
            this.Controls.Add(this.dgv_schedules);
            this.Controls.Add(this.lbl_emailDayOff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EmaiDayOff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email day off";
            this.Load += new System.EventHandler(this.Form_EmaiDayOff_Load);
            this.gb_email.ResumeLayout(false);
            this.gb_email.PerformLayout();
            this.gb_searchEmails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_email;
        private System.Windows.Forms.Panel line_cc;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.GroupBox gb_searchEmails;
        private System.Windows.Forms.Button btn_searchDate;
        private System.Windows.Forms.DataGridView dgv_schedules;
        private System.Windows.Forms.Label lbl_emailDayOff;
        private System.Windows.Forms.DateTimePicker dtp_startDateSearch;
        private System.Windows.Forms.Label lbl_upTo;
        private System.Windows.Forms.DateTimePicker dtp_endDateSearch;
        private System.Windows.Forms.Label lbl_between;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}