namespace Oficina
{
    partial class Form_Invoice
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addManageInvoice = new System.Windows.Forms.Button();
            this.lbl_invoiceList = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_invoices = new System.Windows.Forms.DataGridView();
            this.dtp_issueDateSearch = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_invoiceSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Oficina.Properties.Resources.cancelll6;
            this.btn_close.Location = new System.Drawing.Point(979, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 37);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addManageInvoice
            // 
            this.btn_addManageInvoice.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_addManageInvoice.FlatAppearance.BorderSize = 0;
            this.btn_addManageInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addManageInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addManageInvoice.ForeColor = System.Drawing.Color.White;
            this.btn_addManageInvoice.Image = global::Oficina.Properties.Resources.invoice;
            this.btn_addManageInvoice.Location = new System.Drawing.Point(885, 87);
            this.btn_addManageInvoice.Name = "btn_addManageInvoice";
            this.btn_addManageInvoice.Size = new System.Drawing.Size(57, 50);
            this.btn_addManageInvoice.TabIndex = 4;
            this.btn_addManageInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addManageInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addManageInvoice.UseVisualStyleBackColor = true;
            this.btn_addManageInvoice.Click += new System.EventHandler(this.btn_addManageInvoice_Click);
            // 
            // lbl_invoiceList
            // 
            this.lbl_invoiceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoiceList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_invoiceList.Location = new System.Drawing.Point(87, 9);
            this.lbl_invoiceList.Name = "lbl_invoiceList";
            this.lbl_invoiceList.Size = new System.Drawing.Size(277, 41);
            this.lbl_invoiceList.TabIndex = 47;
            this.lbl_invoiceList.Text = "INVOICE LIST";
            this.lbl_invoiceList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_invoices
            // 
            this.dgv_invoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_invoices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_invoices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgv_invoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_invoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_invoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_invoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_invoices.ColumnHeadersHeight = 27;
            this.dgv_invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_invoices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_invoices.EnableHeadersVisualStyles = false;
            this.dgv_invoices.GridColor = System.Drawing.Color.White;
            this.dgv_invoices.Location = new System.Drawing.Point(93, 177);
            this.dgv_invoices.Name = "dgv_invoices";
            this.dgv_invoices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_invoices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_invoices.RowHeadersVisible = false;
            this.dgv_invoices.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_invoices.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_invoices.RowTemplate.Height = 28;
            this.dgv_invoices.Size = new System.Drawing.Size(849, 483);
            this.dgv_invoices.TabIndex = 75;
            // 
            // dtp_issueDateSearch
            // 
            this.dtp_issueDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_issueDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_issueDateSearch.Location = new System.Drawing.Point(265, 105);
            this.dtp_issueDateSearch.Name = "dtp_issueDateSearch";
            this.dtp_issueDateSearch.Size = new System.Drawing.Size(165, 26);
            this.dtp_issueDateSearch.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Aqua;
            this.btn_search.Image = global::Oficina.Properties.Resources.lupa__3_1;
            this.btn_search.Location = new System.Drawing.Point(439, 99);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 42);
            this.btn_search.TabIndex = 2;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Aqua;
            this.btn_update.Image = global::Oficina.Properties.Resources.setas_circulares;
            this.btn_update.Location = new System.Drawing.Point(503, 99);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(43, 42);
            this.btn_update.TabIndex = 3;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_invoiceSearch
            // 
            this.lbl_invoiceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoiceSearch.ForeColor = System.Drawing.Color.White;
            this.lbl_invoiceSearch.Location = new System.Drawing.Point(68, 104);
            this.lbl_invoiceSearch.Name = "lbl_invoiceSearch";
            this.lbl_invoiceSearch.Size = new System.Drawing.Size(188, 33);
            this.lbl_invoiceSearch.TabIndex = 79;
            this.lbl_invoiceSearch.Text = "Search by issue date:";
            this.lbl_invoiceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1026, 672);
            this.Controls.Add(this.dtp_issueDateSearch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_invoiceSearch);
            this.Controls.Add(this.dgv_invoices);
            this.Controls.Add(this.btn_addManageInvoice);
            this.Controls.Add(this.lbl_invoiceList);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Form_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_addManageInvoice;
        private System.Windows.Forms.Label lbl_invoiceList;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgv_invoices;
        private System.Windows.Forms.DateTimePicker dtp_issueDateSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_invoiceSearch;
    }
}