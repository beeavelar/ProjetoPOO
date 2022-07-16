namespace Oficina
{
    partial class Form_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_about = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_system = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_version
            // 
            this.lbl_version.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_version.ForeColor = System.Drawing.Color.White;
            this.lbl_version.Location = new System.Drawing.Point(262, 590);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(504, 80);
            this.lbl_version.TabIndex = 11;
            this.lbl_version.Text = "\r\nVersion: 1.0.0\r\n";
            this.lbl_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_about
            // 
            this.lbl_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_about.ForeColor = System.Drawing.Color.White;
            this.lbl_about.Location = new System.Drawing.Point(26, 179);
            this.lbl_about.Name = "lbl_about";
            this.lbl_about.Size = new System.Drawing.Size(959, 138);
            this.lbl_about.TabIndex = 12;
            this.lbl_about.Text = resources.GetString("lbl_about.Text");
            this.lbl_about.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_author
            // 
            this.lbl_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_author.ForeColor = System.Drawing.Color.White;
            this.lbl_author.Location = new System.Drawing.Point(262, 346);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(504, 58);
            this.lbl_author.TabIndex = 13;
            this.lbl_author.Text = "\r\nDeveloped by: Débora Avelar\r\n\r\n\r\n";
            this.lbl_author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_system
            // 
            this.lbl_system.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_system.ForeColor = System.Drawing.Color.White;
            this.lbl_system.Location = new System.Drawing.Point(262, 423);
            this.lbl_system.Name = "lbl_system";
            this.lbl_system.Size = new System.Drawing.Size(504, 148);
            this.lbl_system.TabIndex = 14;
            this.lbl_system.Text = "\r\nRepair Shop lda\r\n\r\nConstruction date: 24-05-2021\r\n\r\nCopyrights © 2022 Repair Sh" +
    "op. All rights reserved.\r\n\r\n";
            this.lbl_system.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Oficina.Properties.Resources.CINEL_logo2;
            this.pictureBox1.Location = new System.Drawing.Point(448, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Oficina.Properties.Resources.cancelll9;
            this.btn_close.Location = new System.Drawing.Point(1001, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 37);
            this.btn_close.TabIndex = 10;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1048, 728);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_system);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_about);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_about;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_system;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}