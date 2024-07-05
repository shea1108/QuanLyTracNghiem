namespace WindowsFormsApp_Login.Admin.View
{
    partial class QuanLyNguoiDung
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
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listUser = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.xoa_btn = new RJCodeAdvance.RJControls.RJButton();
            this.refresh_btn = new RJCodeAdvance.RJControls.RJButton();
            this.tim_kiemBtn = new RJCodeAdvance.RJControls.RJButton();
            this.capnhat_btn = new RJCodeAdvance.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listUser)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTxt.Location = new System.Drawing.Point(559, 187);
            this.phoneNumberTxt.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberTxt.Multiline = true;
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(264, 30);
            this.phoneNumberTxt.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Số điện thoại :";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(125, 187);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(239, 30);
            this.emailTxt.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Email :";
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTxt.Location = new System.Drawing.Point(559, 124);
            this.fullNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.fullNameTxt.Multiline = true;
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.Size = new System.Drawing.Size(264, 30);
            this.fullNameTxt.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Họ tên :";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(207, 124);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTxt.Multiline = true;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(221, 30);
            this.usernameTxt.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tên đăng nhập :";
            // 
            // listUser
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listUser.BackgroundColor = System.Drawing.Color.White;
            this.listUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.listUser.DoubleBuffered = true;
            this.listUser.EnableHeadersVisualStyles = false;
            this.listUser.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.listUser.HeaderForeColor = System.Drawing.Color.White;
            this.listUser.Location = new System.Drawing.Point(32, 348);
            this.listUser.Margin = new System.Windows.Forms.Padding(4);
            this.listUser.Name = "listUser";
            this.listUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listUser.RowHeadersWidth = 51;
            this.listUser.Size = new System.Drawing.Size(1004, 359);
            this.listUser.TabIndex = 66;
            this.listUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listUser_MouseClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên đăng nhập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Họ tên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số điện thoại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 36);
            this.label1.TabIndex = 65;
            this.label1.Text = "THÔNG TIN NGƯỜI DÙNG";
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
            this.xoa_btn.Location = new System.Drawing.Point(883, 178);
            this.xoa_btn.Margin = new System.Windows.Forms.Padding(4);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.xoa_btn.Size = new System.Drawing.Size(153, 39);
            this.xoa_btn.TabIndex = 80;
            this.xoa_btn.Text = "Xóa ";
            this.xoa_btn.TextColor = System.Drawing.Color.White;
            this.xoa_btn.UseVisualStyleBackColor = false;
            this.xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(185)))), ((int)(((byte)(142)))));
            this.refresh_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(185)))), ((int)(((byte)(142)))));
            this.refresh_btn.BorderColor = System.Drawing.Color.Transparent;
            this.refresh_btn.BorderRadius = 10;
            this.refresh_btn.BorderSize = 2;
            this.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_btn.Location = new System.Drawing.Point(883, 233);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(4);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.refresh_btn.Size = new System.Drawing.Size(153, 39);
            this.refresh_btn.TabIndex = 79;
            this.refresh_btn.Text = "Tải lại";
            this.refresh_btn.TextColor = System.Drawing.Color.White;
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // tim_kiemBtn
            // 
            this.tim_kiemBtn.BackColor = System.Drawing.Color.SlateGray;
            this.tim_kiemBtn.BackgroundColor = System.Drawing.Color.SlateGray;
            this.tim_kiemBtn.BorderColor = System.Drawing.Color.Transparent;
            this.tim_kiemBtn.BorderRadius = 10;
            this.tim_kiemBtn.BorderSize = 2;
            this.tim_kiemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tim_kiemBtn.FlatAppearance.BorderSize = 0;
            this.tim_kiemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tim_kiemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim_kiemBtn.ForeColor = System.Drawing.Color.White;
            this.tim_kiemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tim_kiemBtn.Location = new System.Drawing.Point(883, 124);
            this.tim_kiemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.tim_kiemBtn.Name = "tim_kiemBtn";
            this.tim_kiemBtn.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.tim_kiemBtn.Size = new System.Drawing.Size(153, 39);
            this.tim_kiemBtn.TabIndex = 78;
            this.tim_kiemBtn.Text = "Tìm kiếm";
            this.tim_kiemBtn.TextColor = System.Drawing.Color.White;
            this.tim_kiemBtn.UseVisualStyleBackColor = false;
            this.tim_kiemBtn.Click += new System.EventHandler(this.tim_kiemBtn_Click);
            // 
            // capnhat_btn
            // 
            this.capnhat_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.capnhat_btn.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.capnhat_btn.BorderColor = System.Drawing.Color.Transparent;
            this.capnhat_btn.BorderRadius = 10;
            this.capnhat_btn.BorderSize = 2;
            this.capnhat_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.capnhat_btn.FlatAppearance.BorderSize = 0;
            this.capnhat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capnhat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capnhat_btn.ForeColor = System.Drawing.Color.White;
            this.capnhat_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.capnhat_btn.Location = new System.Drawing.Point(883, 71);
            this.capnhat_btn.Margin = new System.Windows.Forms.Padding(4);
            this.capnhat_btn.Name = "capnhat_btn";
            this.capnhat_btn.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.capnhat_btn.Size = new System.Drawing.Size(153, 39);
            this.capnhat_btn.TabIndex = 77;
            this.capnhat_btn.Text = "Cập nhật";
            this.capnhat_btn.TextColor = System.Drawing.Color.White;
            this.capnhat_btn.UseVisualStyleBackColor = false;
            this.capnhat_btn.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(412, 36);
            this.label6.TabIndex = 81;
            this.label6.Text = "DANH SÁCH NGƯỜI DÙNG";
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.tim_kiemBtn);
            this.Controls.Add(this.capnhat_btn);
            this.Controls.Add(this.phoneNumberTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listUser);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNguoiDung";
            this.Size = new System.Drawing.Size(1067, 735);
            ((System.ComponentModel.ISupportInitialize)(this.listUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid listUser;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton tim_kiemBtn;
        private RJCodeAdvance.RJControls.RJButton capnhat_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private RJCodeAdvance.RJControls.RJButton refresh_btn;
        private RJCodeAdvance.RJControls.RJButton xoa_btn;
        private System.Windows.Forms.Label label6;
    }
}
