namespace Oficina
{
    partial class Form_Mechanic
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
            this.lbl_mechanicList = new System.Windows.Forms.Label();
            this.lbl_mechanicSearch = new System.Windows.Forms.Label();
            this.tb_nameToSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_addManageMechanic = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.dgv_mechanics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mechanics)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mechanicList
            // 
            this.lbl_mechanicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mechanicList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.lbl_mechanicList.Location = new System.Drawing.Point(48, 12);
            this.lbl_mechanicList.Name = "lbl_mechanicList";
            this.lbl_mechanicList.Size = new System.Drawing.Size(267, 41);
            this.lbl_mechanicList.TabIndex = 48;
            this.lbl_mechanicList.Text = "MECHANICS LIST";
            this.lbl_mechanicList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mechanicSearch
            // 
            this.lbl_mechanicSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mechanicSearch.ForeColor = System.Drawing.Color.White;
            this.lbl_mechanicSearch.Location = new System.Drawing.Point(-15, 109);
            this.lbl_mechanicSearch.Name = "lbl_mechanicSearch";
            this.lbl_mechanicSearch.Size = new System.Drawing.Size(265, 33);
            this.lbl_mechanicSearch.TabIndex = 46;
            this.lbl_mechanicSearch.Text = "Search by mechanic name:";
            this.lbl_mechanicSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_nameToSearch
            // 
            this.tb_nameToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nameToSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tb_nameToSearch.Location = new System.Drawing.Point(256, 112);
            this.tb_nameToSearch.Name = "tb_nameToSearch";
            this.tb_nameToSearch.Size = new System.Drawing.Size(252, 26);
            this.tb_nameToSearch.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Aqua;
            this.btn_update.Image = global::Oficina.Properties.Resources.setas_circulares;
            this.btn_update.Location = new System.Drawing.Point(583, 103);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(43, 42);
            this.btn_update.TabIndex = 3;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_addManageMechanic
            // 
            this.btn_addManageMechanic.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_addManageMechanic.FlatAppearance.BorderSize = 0;
            this.btn_addManageMechanic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addManageMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addManageMechanic.ForeColor = System.Drawing.Color.White;
            this.btn_addManageMechanic.Image = global::Oficina.Properties.Resources.mechanic41;
            this.btn_addManageMechanic.Location = new System.Drawing.Point(906, 98);
            this.btn_addManageMechanic.Name = "btn_addManageMechanic";
            this.btn_addManageMechanic.Size = new System.Drawing.Size(57, 50);
            this.btn_addManageMechanic.TabIndex = 4;
            this.btn_addManageMechanic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addManageMechanic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addManageMechanic.UseVisualStyleBackColor = true;
            this.btn_addManageMechanic.Click += new System.EventHandler(this.btn_addManageMechanic_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Aqua;
            this.btn_search.Image = global::Oficina.Properties.Resources.lupa__3_;
            this.btn_search.Location = new System.Drawing.Point(523, 104);
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
            // dgv_mechanics
            // 
            this.dgv_mechanics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_mechanics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_mechanics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgv_mechanics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_mechanics.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_mechanics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_mechanics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_mechanics.ColumnHeadersHeight = 27;
            this.dgv_mechanics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_mechanics.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_mechanics.EnableHeadersVisualStyles = false;
            this.dgv_mechanics.GridColor = System.Drawing.Color.White;
            this.dgv_mechanics.Location = new System.Drawing.Point(54, 172);
            this.dgv_mechanics.Name = "dgv_mechanics";
            this.dgv_mechanics.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_mechanics.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_mechanics.RowHeadersVisible = false;
            this.dgv_mechanics.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_mechanics.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_mechanics.RowTemplate.Height = 28;
            this.dgv_mechanics.Size = new System.Drawing.Size(909, 488);
            this.dgv_mechanics.TabIndex = 75;
            // 
            // Form_Mechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1026, 672);
            this.Controls.Add(this.dgv_mechanics);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_addManageMechanic);
            this.Controls.Add(this.lbl_mechanicList);
            this.Controls.Add(this.lbl_mechanicSearch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_nameToSearch);
            this.Controls.Add(this.btn_close);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Mechanic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mechanic";
            this.Load += new System.EventHandler(this.Form_Mechanic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mechanics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_addManageMechanic;
        private System.Windows.Forms.Label lbl_mechanicList;
        private System.Windows.Forms.Label lbl_mechanicSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_nameToSearch;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgv_mechanics;
    }
}