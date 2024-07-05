namespace WindowsFormsApp_Login.Admin.View
{
    partial class AddOption
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
            this.backbtn = new System.Windows.Forms.Button();
            this.btn_thucong = new RJCodeAdvance.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Image = global::WindowsFormsApp_Login.Properties.Resources.left_arrow_circle_solid_24;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbtn.Location = new System.Drawing.Point(16, 15);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(133, 54);
            this.backbtn.TabIndex = 42;
            this.backbtn.Text = "Quay lại";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // btn_thucong
            // 
            this.btn_thucong.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_thucong.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_thucong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_thucong.BorderRadius = 0;
            this.btn_thucong.BorderSize = 0;
            this.btn_thucong.FlatAppearance.BorderSize = 0;
            this.btn_thucong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thucong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thucong.ForeColor = System.Drawing.Color.White;
            this.btn_thucong.Location = new System.Drawing.Point(174, 154);
            this.btn_thucong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thucong.Name = "btn_thucong";
            this.btn_thucong.Size = new System.Drawing.Size(200, 49);
            this.btn_thucong.TabIndex = 43;
            this.btn_thucong.Text = "THỦ CÔNG";
            this.btn_thucong.TextColor = System.Drawing.Color.White;
            this.btn_thucong.UseVisualStyleBackColor = false;
            this.btn_thucong.Click += new System.EventHandler(this.btn_thucong_Click);
            // 
            // AddOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(561, 391);
            this.Controls.Add(this.btn_thucong);
            this.Controls.Add(this.backbtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOption";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private RJCodeAdvance.RJControls.RJButton btn_thucong;
    }
}