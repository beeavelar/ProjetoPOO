namespace Oficina
{
    partial class Form_Repairs
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
            this.lbl_repairList = new System.Windows.Forms.Label();
            this.lbl_repairSearch = new System.Windows.Forms.Label();
            this.tb_repairSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_addManageRepair = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.dgv_repairs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_repairs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_repairList
            // 
            this.lbl_repairList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repairList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_repairList.Location = new System.Drawing.Point(119, 12);
            this.lbl_repairList.Name = "lbl_repairList";
            this.lbl_repairList.Size = new System.Drawing.Size(277, 41);
            this.lbl_repairList.TabIndex = 40;
            this.lbl_repairList.Text = "REPAIRS LIST";
            this.lbl_repairList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_repairSearch
            // 
            this.lbl_repairSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repairSearch.ForeColor = System.Drawing.Color.White;
            this.lbl_repairSearch.Location = new System.Drawing.Point(80, 139);
            this.lbl_repairSearch.Name = "lbl_repairSearch";
            this.lbl_repairSearch.Size = new System.Drawing.Size(250, 33);
            this.lbl_repairSearch.TabIndex = 38;
            this.lbl_repairSearch.Text = "Search by repair description:";
            this.lbl_repairSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_repairSearch
            // 
            this.tb_repairSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_repairSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_repairSearch.Location = new System.Drawing.Point(336, 142);
            this.tb_repairSearch.Name = "tb_repairSearch";
            this.tb_repairSearch.Size = new System.Drawing.Size(252, 26);
            this.tb_repairSearch.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Aqua;
            this.btn_update.Image = global::Oficina.Properties.Resources.setas_circulares;
            this.btn_update.Location = new System.Drawing.Point(652, 133);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(43, 42);
            this.btn_update.TabIndex = 3;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_addManageRepair
            // 
            this.btn_addManageRepair.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_addManageRepair.FlatAppearance.BorderSize = 0;
            this.btn_addManageRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addManageRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addManageRepair.ForeColor = System.Drawing.Color.White;
            this.btn_addManageRepair.Image = global::Oficina.Properties.Resources.reparo_de_carro__1_2;
            this.btn_addManageRepair.Location = new System.Drawing.Point(869, 125);
            this.btn_addManageRepair.Name = "btn_addManageRepair";
            this.btn_addManageRepair.Size = new System.Drawing.Size(57, 50);
            this.btn_addManageRepair.TabIndex = 4;
            this.btn_addManageRepair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addManageRepair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addManageRepair.UseVisualStyleBackColor = true;
            this.btn_addManageRepair.Click += new System.EventHandler(this.btn_addManageRepair_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Aqua;
            this.btn_search.Image = global::Oficina.Properties.Resources.lupa__3_1;
            this.btn_search.Location = new System.Drawing.Point(603, 133);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 42);
            this.btn_search.TabIndex = 2;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::Oficina.Properties.Resources.cancelll10;
            this.btn_close.Location = new System.Drawing.Point(979, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 37);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            this.dgv_repairs.Location = new System.Drawing.Point(125, 204);
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
            this.dgv_repairs.Size = new System.Drawing.Size(801, 445);
            this.dgv_repairs.TabIndex = 76;
            // 
            // Form_Repairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1026, 672);
            this.Controls.Add(this.dgv_repairs);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_addManageRepair);
            this.Controls.Add(this.lbl_repairList);
            this.Controls.Add(this.lbl_repairSearch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_repairSearch);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Repairs";
            this.Text = "Repair";
            this.Load += new System.EventHandler(this.Form_Repairs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_repairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_addManageRepair;
        private System.Windows.Forms.Label lbl_repairList;
        private System.Windows.Forms.Label lbl_repairSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_repairSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgv_repairs;
    }
}