namespace WindowsFormsApp_Login.User.View
{
    partial class HomeUser
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
            this.FullName = new RJCodeAdvance.RJControls.RJButton();
            this.ketQua = new System.Windows.Forms.Label();
            this.vaoThi = new System.Windows.Forms.Label();
            this.trangChu = new System.Windows.Forms.Label();
            this.rjDropdownMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.vàoThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.FullName);
            this.panel1.Controls.Add(this.ketQua);
            this.panel1.Controls.Add(this.vaoThi);
            this.panel1.Controls.Add(this.trangChu);
            this.panel1.Location = new System.Drawing.Point(-7, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 101);
            this.panel1.TabIndex = 2;
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
            this.trangChu.Location = new System.Drawing.Point(232, 38);
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
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click_1);
            // 
            // HomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1183, 666);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rjDropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ketQua;
        private System.Windows.Forms.Label vaoThi;
        private System.Windows.Forms.Label trangChu;
        private RJCodeAdvance.RJControls.RJButton FullName;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem vàoThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}