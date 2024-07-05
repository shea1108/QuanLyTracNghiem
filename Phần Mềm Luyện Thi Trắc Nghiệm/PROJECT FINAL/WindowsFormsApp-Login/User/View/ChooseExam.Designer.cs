namespace WindowsFormsApp_Login.User.View
{
    partial class ChooseExam
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
            this.SubjectTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.listSubject = new RJCodeAdvance.RJControls.RJComboBox();
            this.VaoThi_btn = new CustomBox.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FullName = new RJCodeAdvance.RJControls.RJButton();
            this.ketQua = new System.Windows.Forms.Label();
            this.vaoThi = new System.Windows.Forms.Label();
            this.trangChu = new System.Windows.Forms.Label();
            this.rjDropdownMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.vàoThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubjectTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SubjectTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SubjectTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.SubjectTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SubjectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectTable.DoubleBuffered = true;
            this.SubjectTable.EnableHeadersVisualStyles = false;
            this.SubjectTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.SubjectTable.HeaderForeColor = System.Drawing.Color.White;
            this.SubjectTable.Location = new System.Drawing.Point(92, 255);
            this.SubjectTable.Margin = new System.Windows.Forms.Padding(4);
            this.SubjectTable.Name = "SubjectTable";
            this.SubjectTable.ReadOnly = true;
            this.SubjectTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SubjectTable.RowHeadersWidth = 51;
            this.SubjectTable.Size = new System.Drawing.Size(988, 363);
            this.SubjectTable.TabIndex = 0;
            // 
            // listSubject
            // 
            this.listSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listSubject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.listSubject.BorderSize = 1;
            this.listSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.listSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listSubject.ForeColor = System.Drawing.Color.DimGray;
            this.listSubject.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.listSubject.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.listSubject.ListTextColor = System.Drawing.Color.DimGray;
            this.listSubject.Location = new System.Drawing.Point(400, 176);
            this.listSubject.Margin = new System.Windows.Forms.Padding(4);
            this.listSubject.MinimumSize = new System.Drawing.Size(267, 37);
            this.listSubject.Name = "listSubject";
            this.listSubject.Padding = new System.Windows.Forms.Padding(1);
            this.listSubject.Size = new System.Drawing.Size(473, 37);
            this.listSubject.TabIndex = 1;
            this.listSubject.Tag = "";
            this.listSubject.Texts = "";
            // 
            // VaoThi_btn
            // 
            this.VaoThi_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.VaoThi_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.VaoThi_btn.BorderColor = System.Drawing.Color.Red;
            this.VaoThi_btn.BorderRadius = 0;
            this.VaoThi_btn.BorderSize = 0;
            this.VaoThi_btn.FlatAppearance.BorderSize = 0;
            this.VaoThi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VaoThi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VaoThi_btn.ForeColor = System.Drawing.Color.White;
            this.VaoThi_btn.Location = new System.Drawing.Point(921, 176);
            this.VaoThi_btn.Margin = new System.Windows.Forms.Padding(4);
            this.VaoThi_btn.Name = "VaoThi_btn";
            this.VaoThi_btn.Size = new System.Drawing.Size(159, 37);
            this.VaoThi_btn.TabIndex = 2;
            this.VaoThi_btn.Text = "Vào thi";
            this.VaoThi_btn.TextColor = System.Drawing.Color.White;
            this.VaoThi_btn.UseVisualStyleBackColor = false;
            this.VaoThi_btn.Click += new System.EventHandler(this.RjButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn môn thi cần làm :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.FullName);
            this.panel1.Controls.Add(this.ketQua);
            this.panel1.Controls.Add(this.vaoThi);
            this.panel1.Controls.Add(this.trangChu);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 101);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.panel2.Location = new System.Drawing.Point(389, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 4);
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
            this.FullName.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // ketQua
            // 
            this.ketQua.AutoSize = true;
            this.ketQua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ketQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketQua.ForeColor = System.Drawing.Color.White;
            this.ketQua.Location = new System.Drawing.Point(495, 38);
            this.ketQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ketQua.Name = "ketQua";
            this.ketQua.Size = new System.Drawing.Size(87, 25);
            this.ketQua.TabIndex = 3;
            this.ketQua.Text = "Kết quả";
            this.ketQua.Click += new System.EventHandler(this.ketQua_Click);
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
            // ChooseExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1163, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VaoThi_btn);
            this.Controls.Add(this.listSubject);
            this.Controls.Add(this.SubjectTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChooseExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseExam";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rjDropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid SubjectTable;
        private RJCodeAdvance.RJControls.RJComboBox listSubject;
        private CustomBox.RJControls.RJButton VaoThi_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton FullName;
        private System.Windows.Forms.Label ketQua;
        private System.Windows.Forms.Label vaoThi;
        private System.Windows.Forms.Label trangChu;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem vàoThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}