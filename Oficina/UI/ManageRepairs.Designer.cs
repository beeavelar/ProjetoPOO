namespace Oficina
{
    partial class Form_ManageRepairs
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
            this.lbl_repairsForm = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_repairSearch = new System.Windows.Forms.Label();
            this.tb_repairSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_laborPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_laborPrice = new System.Windows.Forms.Label();
            this.lbl_repairCode = new System.Windows.Forms.Label();
            this.tb_repairCode = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lbl_repairPrice = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clearData = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_repairs = new System.Windows.Forms.DataGridView();
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_repairs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_repairsForm
            // 
            this.lbl_repairsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repairsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_repairsForm.Location = new System.Drawing.Point(62, 21);
            this.lbl_repairsForm.Name = "lbl_repairsForm";
            this.lbl_repairsForm.Size = new System.Drawing.Size(375, 41);
            this.lbl_repairsForm.TabIndex = 34;
            this.lbl_repairsForm.Text = "REPAIR´S FORM";
            this.lbl_repairsForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_repairSearch
            // 
            this.lbl_repairSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repairSearch.ForeColor = System.Drawing.Color.White;
            this.lbl_repairSearch.Location = new System.Drawing.Point(130, 304);
            this.lbl_repairSearch.Name = "lbl_repairSearch";
            this.lbl_repairSearch.Size = new System.Drawing.Size(268, 33);
            this.lbl_repairSearch.TabIndex = 41;
            this.lbl_repairSearch.Text = "Search by repair description:";
            this.lbl_repairSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_repairSearch
            // 
            this.tb_repairSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_repairSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_repairSearch.Location = new System.Drawing.Point(404, 307);
            this.tb_repairSearch.Name = "tb_repairSearch";
            this.tb_repairSearch.Size = new System.Drawing.Size(252, 26);
            this.tb_repairSearch.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_laborPrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_laborPrice);
            this.panel2.Controls.Add(this.lbl_repairCode);
            this.panel2.Controls.Add(this.tb_repairCode);
            this.panel2.Controls.Add(this.lbl_description);
            this.panel2.Controls.Add(this.tb_description);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tb_price);
            this.panel2.Controls.Add(this.lbl_repairPrice);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.tb_id);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(68, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 194);
            this.panel2.TabIndex = 36;
            // 
            // tb_laborPrice
            // 
            this.tb_laborPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_laborPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_laborPrice.Location = new System.Drawing.Point(628, 67);
            this.tb_laborPrice.Name = "tb_laborPrice";
            this.tb_laborPrice.Size = new System.Drawing.Size(102, 26);
            this.tb_laborPrice.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(736, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 30);
            this.label2.TabIndex = 45;
            this.label2.Text = "€";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_laborPrice
            // 
            this.lbl_laborPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laborPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_laborPrice.Location = new System.Drawing.Point(526, 65);
            this.lbl_laborPrice.Name = "lbl_laborPrice";
            this.lbl_laborPrice.Size = new System.Drawing.Size(100, 30);
            this.lbl_laborPrice.TabIndex = 44;
            this.lbl_laborPrice.Text = "Labor price:";
            this.lbl_laborPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_repairCode
            // 
            this.lbl_repairCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repairCode.ForeColor = System.Drawing.Color.White;
            this.lbl_repairCode.Location = new System.Drawing.Point(50, 68);
            this.lbl_repairCode.Name = "lbl_repairCode";
            this.lbl_repairCode.Size = new System.Drawing.Size(114, 30);
            this.lbl_repairCode.TabIndex = 42;
            this.lbl_repairCode.Text = "Repair code:";
            this.lbl_repairCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_repairCode
            // 
            this.tb_repairCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_repairCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_repairCode.Location = new System.Drawing.Point(170, 68);
            this.tb_repairCode.Name = "tb_repairCode";
            this.tb_repairCode.Size = new System.Drawing.Size(99, 26);
            this.tb_repairCode.TabIndex = 1;
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(50, 110);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(114, 30);
            this.lbl_description.TabIndex = 40;
            this.lbl_description.Text = "Description:";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_description.Location = new System.Drawing.Point(170, 110);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(588, 55);
            this.tb_description.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(490, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "€";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_price.Location = new System.Drawing.Point(382, 69);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(102, 26);
            this.tb_price.TabIndex = 2;
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // lbl_repairPrice
            // 
            this.lbl_repairPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repairPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_repairPrice.Location = new System.Drawing.Point(276, 67);
            this.lbl_repairPrice.Name = "lbl_repairPrice";
            this.lbl_repairPrice.Size = new System.Drawing.Size(100, 30);
            this.lbl_repairPrice.TabIndex = 31;
            this.lbl_repairPrice.Text = "Repair price:";
            this.lbl_repairPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(49, 21);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(115, 33);
            this.lbl_id.TabIndex = 29;
            this.lbl_id.Text = "Id:";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_id
            // 
            this.tb_id.AcceptsReturn = true;
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_id.Location = new System.Drawing.Point(170, 21);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(56, 26);
            this.tb_id.TabIndex = 28;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Aqua;
            this.btn_search.Image = global::Oficina.Properties.Resources.lupa__3_1;
            this.btn_search.Location = new System.Drawing.Point(671, 298);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 42);
            this.btn_search.TabIndex = 8;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::Oficina.Properties.Resources.bin__2_;
            this.btn_delete.Location = new System.Drawing.Point(933, 594);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(52, 52);
            this.btn_delete.TabIndex = 9;
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
            this.btn_clearData.Location = new System.Drawing.Point(933, 126);
            this.btn_clearData.Name = "btn_clearData";
            this.btn_clearData.Size = new System.Drawing.Size(52, 52);
            this.btn_clearData.TabIndex = 6;
            this.btn_clearData.UseVisualStyleBackColor = true;
            this.btn_clearData.Click += new System.EventHandler(this.btn_clearData_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::Oficina.Properties.Resources.salve_;
            this.btn_save.Location = new System.Drawing.Point(933, 65);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(52, 52);
            this.btn_save.TabIndex = 5;
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
            this.btn_update.Location = new System.Drawing.Point(720, 299);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(43, 42);
            this.btn_update.TabIndex = 42;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_repairs
            // 
            this.dgv_repairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_repairs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_repairs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgv_repairs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_repairs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_repairs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_repairs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_repairs.ColumnHeadersHeight = 27;
            this.dgv_repairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_repairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_repairs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_repairs.EnableHeadersVisualStyles = false;
            this.dgv_repairs.GridColor = System.Drawing.Color.White;
            this.dgv_repairs.Location = new System.Drawing.Point(68, 363);
            this.dgv_repairs.Name = "dgv_repairs";
            this.dgv_repairs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_repairs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_repairs.RowHeadersVisible = false;
            this.dgv_repairs.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_repairs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_repairs.RowTemplate.Height = 28;
            this.dgv_repairs.Size = new System.Drawing.Size(843, 283);
            this.dgv_repairs.TabIndex = 75;
            this.dgv_repairs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_repairs_CellDoubleClick_1);
            // 
            // chkSelect
            // 
            this.chkSelect.HeaderText = "Select";
            this.chkSelect.MinimumWidth = 8;
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Width = 82;
            // 
            // Form_ManageRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(997, 672);
            this.Controls.Add(this.dgv_repairs);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_repairSearch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_repairSearch);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clearData);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_repairsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ManageRepairs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Manage Repairs";
            this.Load += new System.EventHandler(this.Form_ManageRepairs_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_repairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clearData;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_repairsForm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_repairSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_repairSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lbl_repairCode;
        private System.Windows.Forms.TextBox tb_repairCode;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label lbl_repairPrice;
        private System.Windows.Forms.DataGridView dgv_repairs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
        private System.Windows.Forms.TextBox tb_laborPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_laborPrice;
    }
}