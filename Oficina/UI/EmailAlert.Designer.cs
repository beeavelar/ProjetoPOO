namespace Oficina.UI
{
    partial class Form_EmailAlert
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_emailAlert = new System.Windows.Forms.Label();
            this.dgv_schedules = new System.Windows.Forms.DataGridView();
            this.gb_searchEmails = new System.Windows.Forms.GroupBox();
            this.lbl_alertDate = new System.Windows.Forms.Label();
            this.dtp_alertDate = new System.Windows.Forms.DateTimePicker();
            this.gb_email = new System.Windows.Forms.GroupBox();
            this.lbl_scheduleTime = new System.Windows.Forms.Label();
            this.line_cc = new System.Windows.Forms.Panel();
            this.lbl_to = new System.Windows.Forms.Label();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.MaskedTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_searchDateAlert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).BeginInit();
            this.gb_searchEmails.SuspendLayout();
            this.gb_email.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_emailAlert
            // 
            this.lbl_emailAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_emailAlert.Location = new System.Drawing.Point(44, 26);
            this.lbl_emailAlert.Name = "lbl_emailAlert";
            this.lbl_emailAlert.Size = new System.Drawing.Size(233, 41);
            this.lbl_emailAlert.TabIndex = 51;
            this.lbl_emailAlert.Text = "E-MAIL ALERT";
            this.lbl_emailAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dgv_schedules.Location = new System.Drawing.Point(115, 189);
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
            this.dgv_schedules.Size = new System.Drawing.Size(608, 230);
            this.dgv_schedules.TabIndex = 107;
            // 
            // gb_searchEmails
            // 
            this.gb_searchEmails.Controls.Add(this.lbl_alertDate);
            this.gb_searchEmails.Controls.Add(this.dtp_alertDate);
            this.gb_searchEmails.Controls.Add(this.btn_searchDateAlert);
            this.gb_searchEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_searchEmails.ForeColor = System.Drawing.Color.White;
            this.gb_searchEmails.Location = new System.Drawing.Point(115, 93);
            this.gb_searchEmails.Name = "gb_searchEmails";
            this.gb_searchEmails.Size = new System.Drawing.Size(608, 77);
            this.gb_searchEmails.TabIndex = 108;
            this.gb_searchEmails.TabStop = false;
            this.gb_searchEmails.Text = "Search the  e-mails by";
            // 
            // lbl_alertDate
            // 
            this.lbl_alertDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alertDate.ForeColor = System.Drawing.Color.White;
            this.lbl_alertDate.Location = new System.Drawing.Point(158, 25);
            this.lbl_alertDate.Name = "lbl_alertDate";
            this.lbl_alertDate.Size = new System.Drawing.Size(95, 33);
            this.lbl_alertDate.TabIndex = 107;
            this.lbl_alertDate.Text = "Alert date:";
            this.lbl_alertDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_alertDate
            // 
            this.dtp_alertDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_alertDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_alertDate.Location = new System.Drawing.Point(259, 28);
            this.dtp_alertDate.Name = "dtp_alertDate";
            this.dtp_alertDate.Size = new System.Drawing.Size(165, 26);
            this.dtp_alertDate.TabIndex = 108;
            // 
            // gb_email
            // 
            this.gb_email.Controls.Add(this.tb_time);
            this.gb_email.Controls.Add(this.lbl_scheduleTime);
            this.gb_email.Controls.Add(this.line_cc);
            this.gb_email.Controls.Add(this.lbl_to);
            this.gb_email.Controls.Add(this.tb_to);
            this.gb_email.ForeColor = System.Drawing.Color.White;
            this.gb_email.Location = new System.Drawing.Point(115, 447);
            this.gb_email.Name = "gb_email";
            this.gb_email.Size = new System.Drawing.Size(608, 141);
            this.gb_email.TabIndex = 111;
            this.gb_email.TabStop = false;
            this.gb_email.Text = "E-mail";
            // 
            // lbl_scheduleTime
            // 
            this.lbl_scheduleTime.ForeColor = System.Drawing.Color.White;
            this.lbl_scheduleTime.Location = new System.Drawing.Point(34, 93);
            this.lbl_scheduleTime.Name = "lbl_scheduleTime";
            this.lbl_scheduleTime.Size = new System.Drawing.Size(125, 26);
            this.lbl_scheduleTime.TabIndex = 8;
            this.lbl_scheduleTime.Text = "Schedule time:";
            this.lbl_scheduleTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(162, 93);
            this.tb_time.Mask = "00:00";
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(103, 26);
            this.tb_time.TabIndex = 72;
            this.tb_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_send
            // 
            this.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Image = global::Oficina.Properties.Resources.outbox__1_1;
            this.btn_send.Location = new System.Drawing.Point(650, 607);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(73, 52);
            this.btn_send.TabIndex = 110;
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_searchDateAlert
            // 
            this.btn_searchDateAlert.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_searchDateAlert.FlatAppearance.BorderSize = 0;
            this.btn_searchDateAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchDateAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchDateAlert.ForeColor = System.Drawing.Color.Aqua;
            this.btn_searchDateAlert.Image = global::Oficina.Properties.Resources.lupa__3_1;
            this.btn_searchDateAlert.Location = new System.Drawing.Point(430, 21);
            this.btn_searchDateAlert.Name = "btn_searchDateAlert";
            this.btn_searchDateAlert.Size = new System.Drawing.Size(43, 42);
            this.btn_searchDateAlert.TabIndex = 109;
            this.btn_searchDateAlert.UseVisualStyleBackColor = true;
            this.btn_searchDateAlert.Click += new System.EventHandler(this.btn_searchDateAlert_Click_2);
            // 
            // Form_EmailAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(829, 680);
            this.Controls.Add(this.gb_email);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.gb_searchEmails);
            this.Controls.Add(this.dgv_schedules);
            this.Controls.Add(this.lbl_emailAlert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EmailAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email alert";
            this.Load += new System.EventHandler(this.Form_Email_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).EndInit();
            this.gb_searchEmails.ResumeLayout(false);
            this.gb_email.ResumeLayout(false);
            this.gb_email.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_emailAlert;
        private System.Windows.Forms.DataGridView dgv_schedules;
        private System.Windows.Forms.GroupBox gb_searchEmails;
        private System.Windows.Forms.Label lbl_alertDate;
        private System.Windows.Forms.DateTimePicker dtp_alertDate;
        private System.Windows.Forms.Button btn_searchDateAlert;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.GroupBox gb_email;
        private System.Windows.Forms.Panel line_cc;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.Label lbl_scheduleTime;
        private System.Windows.Forms.MaskedTextBox tb_time;
    }
}