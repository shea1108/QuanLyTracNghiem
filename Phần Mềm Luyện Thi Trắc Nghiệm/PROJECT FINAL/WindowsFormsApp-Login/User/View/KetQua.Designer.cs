namespace WindowsFormsApp_Login.User.View
{
    partial class KetQua
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FullName = new RJCodeAdvance.RJControls.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.vaoThi = new System.Windows.Forms.Label();
            this.trangChu = new System.Windows.Forms.Label();
            this.KetQuaTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHocOption = new CustomBox.RJControls.RJComboBox();
            this.timkiem_btn = new RJCodeAdvance.RJControls.RJButton();
            this.rjDropdownMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.vàoThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaTable)).BeginInit();
            this.rjDropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.FullName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.vaoThi);
            this.panel1.Controls.Add(this.trangChu);
            this.panel1.Location = new System.Drawing.Point(-15, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 101);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.panel2.Location = new System.Drawing.Point(497, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 4);
            this.panel2.TabIndex = 16;
            // 
            // FullName
            // 
            this.FullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.FullName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.FullName.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.FullName.BorderRadius = 0;
            this.FullName.BorderSize = 0;
            this.FullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullName.FlatAppearance.BorderSize = 0;
            this.FullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.ForeColor = System.Drawing.Color.White;
            this.FullName.Location = new System.Drawing.Point(777, 31);
            this.FullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(264, 44);
            this.FullName.TabIndex = 5;
            this.FullName.Text = "Nguyễn Hoàng Thắng";
            this.FullName.TextColor = System.Drawing.Color.White;
            this.FullName.UseVisualStyleBackColor = false;
            this.FullName.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(495, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kết quả";
            this.label5.Click += new System.EventHandler(this.ketQua_Click);
            // 
            // vaoThi
            // 
            this.vaoThi.AutoSize = true;
            this.vaoThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vaoThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaoThi.ForeColor = System.Drawing.Color.White;
            this.vaoThi.Location = new System.Drawing.Point(381, 38);
            this.vaoThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vaoThi.Name = "vaoThi";
            this.vaoThi.Size = new System.Drawing.Size(80, 25);
            this.vaoThi.TabIndex = 2;
            this.vaoThi.Text = "Vào thi";
            this.vaoThi.Click += new System.EventHandler(this.vaoThi_Click);
            // 
            // trangChu
            // 
            this.trangChu.AutoSize = true;
            this.trangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChu.ForeColor = System.Drawing.Color.White;
            this.trangChu.Location = new System.Drawing.Point(233, 38);
            this.trangChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trangChu.Name = "trangChu";
            this.trangChu.Size = new System.Drawing.Size(110, 25);
            this.trangChu.TabIndex = 1;
            this.trangChu.Text = "Trang chủ";
            this.trangChu.Click += new System.EventHandler(this.trangChu_Click);
            // 
            // KetQuaTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KetQuaTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.KetQuaTable.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.KetQuaTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KetQuaTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KetQuaTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.KetQuaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KetQuaTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KetQuaTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.KetQuaTable.DoubleBuffered = true;
            this.KetQuaTable.EnableHeadersVisualStyles = false;
            this.KetQuaTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.KetQuaTable.HeaderForeColor = System.Drawing.Color.White;
            this.KetQuaTable.Location = new System.Drawing.Point(45, 185);
            this.KetQuaTable.Margin = new System.Windows.Forms.Padding(4);
            this.KetQuaTable.Name = "KetQuaTable";
            this.KetQuaTable.ReadOnly = true;
            this.KetQuaTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KetQuaTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.KetQuaTable.RowHeadersWidth = 51;
            this.KetQuaTable.Size = new System.Drawing.Size(1075, 466);
            this.KetQuaTable.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ID";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column10.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id_User";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id_Exam";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Môn thi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đề số";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Điểm";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Thời gian hoàn thành";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 175;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ngày hoàn thành";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Kết quả";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // MonHocOption
            // 
            this.MonHocOption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MonHocOption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.MonHocOption.BorderSize = 1;
            this.MonHocOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.MonHocOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonHocOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.MonHocOption.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.MonHocOption.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.MonHocOption.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.MonHocOption.Location = new System.Drawing.Point(288, 126);
            this.MonHocOption.Margin = new System.Windows.Forms.Padding(4);
            this.MonHocOption.MinimumSize = new System.Drawing.Size(267, 37);
            this.MonHocOption.Name = "MonHocOption";
            this.MonHocOption.Padding = new System.Windows.Forms.Padding(1);
            this.MonHocOption.Size = new System.Drawing.Size(387, 37);
            this.MonHocOption.TabIndex = 8;
            this.MonHocOption.Texts = "Chọn môn học";
            this.MonHocOption.OnSelectedIndexChanged += new System.EventHandler(this.MonHocOption_OnSelectedIndexChanged);
            // 
            // timkiem_btn
            // 
            this.timkiem_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.timkiem_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.timkiem_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.timkiem_btn.BorderRadius = 16;
            this.timkiem_btn.BorderSize = 0;
            this.timkiem_btn.FlatAppearance.BorderSize = 0;
            this.timkiem_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timkiem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem_btn.ForeColor = System.Drawing.Color.White;
            this.timkiem_btn.Location = new System.Drawing.Point(745, 126);
            this.timkiem_btn.Margin = new System.Windows.Forms.Padding(4);
            this.timkiem_btn.Name = "timkiem_btn";
            this.timkiem_btn.Size = new System.Drawing.Size(131, 37);
            this.timkiem_btn.TabIndex = 9;
            this.timkiem_btn.Text = "Tra cứu";
            this.timkiem_btn.TextColor = System.Drawing.Color.White;
            this.timkiem_btn.UseVisualStyleBackColor = false;
            this.timkiem_btn.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu1.IsMainMenu = true;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vàoThiToolStripMenuItem,
            this.thayĐổiThôngTinToolStripMenuItem,
            this.thayĐổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.rjDropdownMenu1.Size = new System.Drawing.Size(215, 92);
            // 
            // vàoThiToolStripMenuItem
            // 
            this.vàoThiToolStripMenuItem.Name = "vàoThiToolStripMenuItem";
            this.vàoThiToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.vàoThiToolStripMenuItem.Text = "Vào thi";
            this.vàoThiToolStripMenuItem.Click += new System.EventHandler(this.vàoThiToolStripMenuItem_Click);
            // 
            // thayĐổiThôngTinToolStripMenuItem
            // 
            this.thayĐổiThôngTinToolStripMenuItem.Name = "thayĐổiThôngTinToolStripMenuItem";
            this.thayĐổiThôngTinToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.thayĐổiThôngTinToolStripMenuItem.Text = "Thay đổi thông tin";
            this.thayĐổiThôngTinToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiThôngTinToolStripMenuItem_Click);
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Thay đổi mật khẩu";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // KetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1163, 716);
            this.Controls.Add(this.timkiem_btn);
            this.Controls.Add(this.MonHocOption);
            this.Controls.Add(this.KetQuaTable);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KetQua";
            this.Load += new System.EventHandler(this.KetQua_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaTable)).EndInit();
            this.rjDropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton FullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label vaoThi;
        private System.Windows.Forms.Label trangChu;
        private Bunifu.Framework.UI.BunifuCustomDataGrid KetQuaTable;
        private CustomBox.RJControls.RJComboBox MonHocOption;
        private RJCodeAdvance.RJControls.RJButton timkiem_btn;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem vàoThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}