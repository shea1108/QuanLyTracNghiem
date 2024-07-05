namespace WindowsFormsApp_Login.Admin.View
{
    partial class QuanLyMonHoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listSj_table = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.xoa_btn = new RJCodeAdvance.RJControls.RJButton();
            this.them_btn = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.listSj_table)).BeginInit();
            this.SuspendLayout();
            // 
            // listSj_table
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listSj_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listSj_table.BackgroundColor = System.Drawing.Color.White;
            this.listSj_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSj_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listSj_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listSj_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSj_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listSj_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.listSj_table.DoubleBuffered = true;
            this.listSj_table.EnableHeadersVisualStyles = false;
            this.listSj_table.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.listSj_table.HeaderForeColor = System.Drawing.Color.White;
            this.listSj_table.Location = new System.Drawing.Point(172, 251);
            this.listSj_table.Margin = new System.Windows.Forms.Padding(4);
            this.listSj_table.Name = "listSj_table";
            this.listSj_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listSj_table.RowHeadersWidth = 51;
            this.listSj_table.Size = new System.Drawing.Size(723, 409);
            this.listSj_table.TabIndex = 65;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Môn học";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 39);
            this.label1.TabIndex = 64;
            this.label1.Text = "THÔNG TIN MÔN HỌC";
            // 
            // xoa_btn
            // 
            this.xoa_btn.BackColor = System.Drawing.Color.IndianRed;
            this.xoa_btn.BackgroundColor = System.Drawing.Color.IndianRed;
            this.xoa_btn.BorderColor = System.Drawing.Color.Transparent;
            this.xoa_btn.BorderRadius = 10;
            this.xoa_btn.BorderSize = 2;
            this.xoa_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xoa_btn.FlatAppearance.BorderSize = 0;
            this.xoa_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.ForeColor = System.Drawing.Color.White;
            this.xoa_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_btn.Location = new System.Drawing.Point(697, 191);
            this.xoa_btn.Margin = new System.Windows.Forms.Padding(4);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.xoa_btn.Size = new System.Drawing.Size(197, 39);
            this.xoa_btn.TabIndex = 69;
            this.xoa_btn.Text = "Xóa môn học";
            this.xoa_btn.TextColor = System.Drawing.Color.White;
            this.xoa_btn.UseVisualStyleBackColor = false;
            this.xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            // 
            // them_btn
            // 
            this.them_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(185)))), ((int)(((byte)(142)))));
            this.them_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(185)))), ((int)(((byte)(142)))));
            this.them_btn.BorderColor = System.Drawing.Color.Transparent;
            this.them_btn.BorderRadius = 10;
            this.them_btn.BorderSize = 2;
            this.them_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.them_btn.FlatAppearance.BorderSize = 0;
            this.them_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.ForeColor = System.Drawing.Color.White;
            this.them_btn.Location = new System.Drawing.Point(172, 191);
            this.them_btn.Margin = new System.Windows.Forms.Padding(4);
            this.them_btn.Name = "them_btn";
            this.them_btn.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.them_btn.Size = new System.Drawing.Size(215, 39);
            this.them_btn.TabIndex = 68;
            this.them_btn.Text = "Thêm môn học";
            this.them_btn.TextColor = System.Drawing.Color.White;
            this.them_btn.UseVisualStyleBackColor = false;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.listSj_table);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyMonHoc";
            this.Size = new System.Drawing.Size(1067, 735);
            ((System.ComponentModel.ISupportInitialize)(this.listSj_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid listSj_table;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton xoa_btn;
        private RJCodeAdvance.RJControls.RJButton them_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
