namespace Oficina.UI
{
    partial class Form_Communication
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_emailAlert = new System.Windows.Forms.Button();
            this.lbl_emailAlert = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_emailDayOff = new System.Windows.Forms.Button();
            this.lbl_emailDatOff = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_emailHolydays = new System.Windows.Forms.Button();
            this.lbl_emailHolydays = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btn_emailAlert);
            this.panel1.Controls.Add(this.lbl_emailAlert);
            this.panel1.Location = new System.Drawing.Point(195, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 202);
            this.panel1.TabIndex = 8;
            // 
            // btn_emailAlert
            // 
            this.btn_emailAlert.FlatAppearance.BorderSize = 0;
            this.btn_emailAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emailAlert.Image = global::Oficina.Properties.Resources.mail__1_;
            this.btn_emailAlert.Location = new System.Drawing.Point(34, 87);
            this.btn_emailAlert.Name = "btn_emailAlert";
            this.btn_emailAlert.Size = new System.Drawing.Size(133, 99);
            this.btn_emailAlert.TabIndex = 1;
            this.btn_emailAlert.UseVisualStyleBackColor = true;
            this.btn_emailAlert.Click += new System.EventHandler(this.btn_emailAlert_Click);
            // 
            // lbl_emailAlert
            // 
            this.lbl_emailAlert.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_emailAlert.Location = new System.Drawing.Point(29, 13);
            this.lbl_emailAlert.Name = "lbl_emailAlert";
            this.lbl_emailAlert.Size = new System.Drawing.Size(150, 61);
            this.lbl_emailAlert.TabIndex = 0;
            this.lbl_emailAlert.Text = "E-MAIL ALERT";
            this.lbl_emailAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.btn_emailDayOff);
            this.panel2.Controls.Add(this.lbl_emailDatOff);
            this.panel2.Location = new System.Drawing.Point(436, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 202);
            this.panel2.TabIndex = 9;
            // 
            // btn_emailDayOff
            // 
            this.btn_emailDayOff.FlatAppearance.BorderSize = 0;
            this.btn_emailDayOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emailDayOff.Image = global::Oficina.Properties.Resources.mail__1_1;
            this.btn_emailDayOff.Location = new System.Drawing.Point(34, 87);
            this.btn_emailDayOff.Name = "btn_emailDayOff";
            this.btn_emailDayOff.Size = new System.Drawing.Size(133, 99);
            this.btn_emailDayOff.TabIndex = 1;
            this.btn_emailDayOff.UseVisualStyleBackColor = true;
            this.btn_emailDayOff.Click += new System.EventHandler(this.btn_emailDayOff_Click);
            // 
            // lbl_emailDatOff
            // 
            this.lbl_emailDatOff.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailDatOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_emailDatOff.Location = new System.Drawing.Point(34, 13);
            this.lbl_emailDatOff.Name = "lbl_emailDatOff";
            this.lbl_emailDatOff.Size = new System.Drawing.Size(133, 61);
            this.lbl_emailDatOff.TabIndex = 0;
            this.lbl_emailDatOff.Text = "E-MAIL DAY OFF";
            this.lbl_emailDatOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.btn_emailHolydays);
            this.panel3.Controls.Add(this.lbl_emailHolydays);
            this.panel3.Location = new System.Drawing.Point(677, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 202);
            this.panel3.TabIndex = 10;
            // 
            // btn_emailHolydays
            // 
            this.btn_emailHolydays.FlatAppearance.BorderSize = 0;
            this.btn_emailHolydays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emailHolydays.Image = global::Oficina.Properties.Resources.mail__1_2;
            this.btn_emailHolydays.Location = new System.Drawing.Point(34, 87);
            this.btn_emailHolydays.Name = "btn_emailHolydays";
            this.btn_emailHolydays.Size = new System.Drawing.Size(133, 99);
            this.btn_emailHolydays.TabIndex = 1;
            this.btn_emailHolydays.UseVisualStyleBackColor = true;
            this.btn_emailHolydays.Click += new System.EventHandler(this.btn_emailHolydays_Click);
            // 
            // lbl_emailHolydays
            // 
            this.lbl_emailHolydays.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailHolydays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_emailHolydays.Location = new System.Drawing.Point(34, 13);
            this.lbl_emailHolydays.Name = "lbl_emailHolydays";
            this.lbl_emailHolydays.Size = new System.Drawing.Size(133, 61);
            this.lbl_emailHolydays.TabIndex = 0;
            this.lbl_emailHolydays.Text = "E-MAIL HOLYDAYS";
            this.lbl_emailHolydays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Oficina.Properties.Resources.cancelll10;
            this.btn_close.Location = new System.Drawing.Point(982, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 37);
            this.btn_close.TabIndex = 7;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form_Communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1026, 672);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Communication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coomunication";
            this.Load += new System.EventHandler(this.Form_Communication_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_emailAlert;
        private System.Windows.Forms.Label lbl_emailAlert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_emailDayOff;
        private System.Windows.Forms.Label lbl_emailDatOff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_emailHolydays;
        private System.Windows.Forms.Label lbl_emailHolydays;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}