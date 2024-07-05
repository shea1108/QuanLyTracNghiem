namespace WindowsFormsApp_Login.Admin.View
{
    partial class HomeAdmin
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rjCircularBox1 = new CustomBox.RJControls.RJCircularBox();
            this.dangXuat_btn = new RJCodeAdvance.RJControls.RJButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.butQuanLyDeThi = new System.Windows.Forms.Button();
            this.butQuanLyNguoiDung = new System.Windows.Forms.Button();
            this.butQuanLyMonHoc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.butQuanLyMonHoc);
            this.panel1.Controls.Add(this.butQuanLyNguoiDung);
            this.panel1.Controls.Add(this.butQuanLyDeThi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rjCircularBox1);
            this.panel1.Controls.Add(this.dangXuat_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 790);
            this.panel1.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(140, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "admin@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(139, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Admin";
            // 
            // rjCircularBox1
            // 
            this.rjCircularBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularBox1.BorderSize = 2;
            this.rjCircularBox1.GradientAngle = 50F;
            this.rjCircularBox1.Image = global::WindowsFormsApp_Login.Properties.Resources.tải_xuống;
            this.rjCircularBox1.Location = new System.Drawing.Point(29, 26);
            this.rjCircularBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjCircularBox1.Name = "rjCircularBox1";
            this.rjCircularBox1.Size = new System.Drawing.Size(88, 88);
            this.rjCircularBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularBox1.TabIndex = 5;
            this.rjCircularBox1.TabStop = false;
            // 
            // dangXuat_btn
            // 
            this.dangXuat_btn.BackColor = System.Drawing.Color.Black;
            this.dangXuat_btn.BackgroundColor = System.Drawing.Color.Black;
            this.dangXuat_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dangXuat_btn.BorderRadius = 22;
            this.dangXuat_btn.BorderSize = 0;
            this.dangXuat_btn.FlatAppearance.BorderSize = 0;
            this.dangXuat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangXuat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangXuat_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dangXuat_btn.Image = global::WindowsFormsApp_Login.Properties.Resources.log_out_circle_regular_24;
            this.dangXuat_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dangXuat_btn.Location = new System.Drawing.Point(13, 719);
            this.dangXuat_btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dangXuat_btn.Name = "dangXuat_btn";
            this.dangXuat_btn.Size = new System.Drawing.Size(324, 57);
            this.dangXuat_btn.TabIndex = 4;
            this.dangXuat_btn.Text = "Đăng xuất";
            this.dangXuat_btn.TextColor = System.Drawing.SystemColors.Highlight;
            this.dangXuat_btn.UseVisualStyleBackColor = false;
            this.dangXuat_btn.Click += new System.EventHandler(this.dangXuat_btn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(352, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1067, 790);
            this.panelContainer.TabIndex = 65;
            // 
            // butQuanLyDeThi
            // 
            this.butQuanLyDeThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQuanLyDeThi.Location = new System.Drawing.Point(0, 274);
            this.butQuanLyDeThi.Name = "butQuanLyDeThi";
            this.butQuanLyDeThi.Size = new System.Drawing.Size(352, 42);
            this.butQuanLyDeThi.TabIndex = 11;
            this.butQuanLyDeThi.Text = "Quản lý đề thi";
            this.butQuanLyDeThi.UseVisualStyleBackColor = true;
            this.butQuanLyDeThi.Click += new System.EventHandler(this.butQuanLyDeThi_Click);
            // 
            // butQuanLyNguoiDung
            // 
            this.butQuanLyNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQuanLyNguoiDung.Location = new System.Drawing.Point(0, 349);
            this.butQuanLyNguoiDung.Name = "butQuanLyNguoiDung";
            this.butQuanLyNguoiDung.Size = new System.Drawing.Size(352, 42);
            this.butQuanLyNguoiDung.TabIndex = 12;
            this.butQuanLyNguoiDung.Text = "Quản lý người dùng";
            this.butQuanLyNguoiDung.UseVisualStyleBackColor = true;
            this.butQuanLyNguoiDung.Click += new System.EventHandler(this.butQuanLyNguoiDung_Click);
            // 
            // butQuanLyMonHoc
            // 
            this.butQuanLyMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQuanLyMonHoc.Location = new System.Drawing.Point(0, 424);
            this.butQuanLyMonHoc.Name = "butQuanLyMonHoc";
            this.butQuanLyMonHoc.Size = new System.Drawing.Size(352, 42);
            this.butQuanLyMonHoc.TabIndex = 13;
            this.butQuanLyMonHoc.Text = "Quản lý môn học";
            this.butQuanLyMonHoc.UseVisualStyleBackColor = true;
            this.butQuanLyMonHoc.Click += new System.EventHandler(this.butQuanLyMonHoc_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 790);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CustomBox.RJControls.RJCircularBox rjCircularBox1;
        private RJCodeAdvance.RJControls.RJButton dangXuat_btn;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button butQuanLyMonHoc;
        private System.Windows.Forms.Button butQuanLyNguoiDung;
        private System.Windows.Forms.Button butQuanLyDeThi;
    }
}