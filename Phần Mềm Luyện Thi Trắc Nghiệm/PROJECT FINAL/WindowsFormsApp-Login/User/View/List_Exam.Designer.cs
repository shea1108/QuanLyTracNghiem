namespace WindowsFormsApp_Login.User.View
{
    partial class List_Exam
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
            this.title = new System.Windows.Forms.Label();
            this.listExam = new System.Windows.Forms.FlowLayoutPanel();
            this.backHome = new RJCodeAdvance.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(16, 112);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 31);
            this.title.TabIndex = 0;
            // 
            // listExam
            // 
            this.listExam.Location = new System.Drawing.Point(16, 172);
            this.listExam.Margin = new System.Windows.Forms.Padding(4);
            this.listExam.Name = "listExam";
            this.listExam.Size = new System.Drawing.Size(1131, 479);
            this.listExam.TabIndex = 2;
            // 
            // backHome
            // 
            this.backHome.BackColor = System.Drawing.Color.White;
            this.backHome.BackgroundColor = System.Drawing.Color.White;
            this.backHome.BorderColor = System.Drawing.Color.Transparent;
            this.backHome.BorderRadius = 20;
            this.backHome.BorderSize = 2;
            this.backHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backHome.FlatAppearance.BorderSize = 0;
            this.backHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.backHome.Image = global::WindowsFormsApp_Login.Properties.Resources.left_arrow_circle_solid_24;
            this.backHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backHome.Location = new System.Drawing.Point(16, 15);
            this.backHome.Margin = new System.Windows.Forms.Padding(4);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(133, 50);
            this.backHome.TabIndex = 4;
            this.backHome.Text = "  Quay lại";
            this.backHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backHome.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.backHome.UseVisualStyleBackColor = false;
            this.backHome.Click += new System.EventHandler(this.backHome_Click);
            // 
            // List_Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1163, 666);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.listExam);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "List_Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel listExam;
        private RJCodeAdvance.RJControls.RJButton backHome;
    }
}