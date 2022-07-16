namespace Oficina
{
    partial class Form_Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.lbl_schedule = new System.Windows.Forms.Label();
            this.lbl_services = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_services = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_sales = new System.Windows.Forms.Button();
            this.lbl_sales = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_products = new System.Windows.Forms.Button();
            this.lbl_products = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btn_schedule);
            this.panel1.Controls.Add(this.lbl_schedule);
            this.panel1.Location = new System.Drawing.Point(307, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 202);
            this.panel1.TabIndex = 5;
            // 
            // btn_schedule
            // 
            this.btn_schedule.FlatAppearance.BorderSize = 0;
            this.btn_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_schedule.Image = global::Oficina.Properties.Resources.calendar__2_;
            this.btn_schedule.Location = new System.Drawing.Point(34, 77);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(133, 99);
            this.btn_schedule.TabIndex = 1;
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // lbl_schedule
            // 
            this.lbl_schedule.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_schedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_schedule.Location = new System.Drawing.Point(34, 13);
            this.lbl_schedule.Name = "lbl_schedule";
            this.lbl_schedule.Size = new System.Drawing.Size(133, 44);
            this.lbl_schedule.TabIndex = 0;
            this.lbl_schedule.Text = "SCHEDULES";
            this.lbl_schedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_services
            // 
            this.lbl_services.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_services.Location = new System.Drawing.Point(34, 19);
            this.lbl_services.Name = "lbl_services";
            this.lbl_services.Size = new System.Drawing.Size(133, 35);
            this.lbl_services.TabIndex = 0;
            this.lbl_services.Text = "SERVICES";
            this.lbl_services.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.btn_services);
            this.panel2.Controls.Add(this.lbl_services);
            this.panel2.Location = new System.Drawing.Point(565, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 202);
            this.panel2.TabIndex = 6;
            // 
            // btn_services
            // 
            this.btn_services.FlatAppearance.BorderSize = 0;
            this.btn_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_services.Image = global::Oficina.Properties.Resources.mecanico__3_;
            this.btn_services.Location = new System.Drawing.Point(34, 77);
            this.btn_services.Name = "btn_services";
            this.btn_services.Size = new System.Drawing.Size(133, 99);
            this.btn_services.TabIndex = 1;
            this.btn_services.UseVisualStyleBackColor = true;
            this.btn_services.Click += new System.EventHandler(this.btn_services_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.btn_sales);
            this.panel3.Controls.Add(this.lbl_sales);
            this.panel3.Location = new System.Drawing.Point(565, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 202);
            this.panel3.TabIndex = 7;
            // 
            // btn_sales
            // 
            this.btn_sales.FlatAppearance.BorderSize = 0;
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales.Image = global::Oficina.Properties.Resources.sale_tag;
            this.btn_sales.Location = new System.Drawing.Point(34, 77);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(133, 99);
            this.btn_sales.TabIndex = 1;
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // lbl_sales
            // 
            this.lbl_sales.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_sales.Location = new System.Drawing.Point(34, 19);
            this.lbl_sales.Name = "lbl_sales";
            this.lbl_sales.Size = new System.Drawing.Size(133, 35);
            this.lbl_sales.TabIndex = 0;
            this.lbl_sales.Text = "SALES";
            this.lbl_sales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel4.Controls.Add(this.btn_products);
            this.panel4.Controls.Add(this.lbl_products);
            this.panel4.Location = new System.Drawing.Point(307, 390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 202);
            this.panel4.TabIndex = 8;
            // 
            // btn_products
            // 
            this.btn_products.FlatAppearance.BorderSize = 0;
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Image = global::Oficina.Properties.Resources.carrinho_de_compras;
            this.btn_products.Location = new System.Drawing.Point(34, 77);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(133, 99);
            this.btn_products.TabIndex = 1;
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // lbl_products
            // 
            this.lbl_products.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_products.Location = new System.Drawing.Point(34, 19);
            this.lbl_products.Name = "lbl_products";
            this.lbl_products.Size = new System.Drawing.Size(133, 35);
            this.lbl_products.TabIndex = 0;
            this.lbl_products.Text = "PRODUCTS";
            this.lbl_products.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Oficina.Properties.Resources.cancelll7;
            this.btn_close.Location = new System.Drawing.Point(1001, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 37);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1048, 728);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Home";
            this.Text = "Home";
           
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_schedule;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Label lbl_services;
        private System.Windows.Forms.Button btn_services;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_sales;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Label lbl_products;
        private System.Windows.Forms.Button btn_sales;
    }
}