namespace QuanLyKaraoke
{
    partial class ChangePW
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
            this.chkbShowPWC = new System.Windows.Forms.CheckBox();
            this.chkbShowNPW = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmPW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNPW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.chkbShowPW = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkbShowPWC
            // 
            this.chkbShowPWC.AutoSize = true;
            this.chkbShowPWC.Location = new System.Drawing.Point(137, 192);
            this.chkbShowPWC.Name = "chkbShowPWC";
            this.chkbShowPWC.Size = new System.Drawing.Size(114, 20);
            this.chkbShowPWC.TabIndex = 28;
            this.chkbShowPWC.Text = "Hiện mật khẩu";
            this.chkbShowPWC.UseVisualStyleBackColor = true;
            this.chkbShowPWC.CheckedChanged += new System.EventHandler(this.chkbShowPWC_CheckedChanged);
            // 
            // chkbShowNPW
            // 
            this.chkbShowNPW.AutoSize = true;
            this.chkbShowNPW.Location = new System.Drawing.Point(137, 138);
            this.chkbShowNPW.Name = "chkbShowNPW";
            this.chkbShowNPW.Size = new System.Drawing.Size(114, 20);
            this.chkbShowNPW.TabIndex = 27;
            this.chkbShowNPW.Text = "Hiện mật khẩu";
            this.chkbShowNPW.UseVisualStyleBackColor = true;
            this.chkbShowNPW.CheckedChanged += new System.EventHandler(this.chkbShowNPW_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Xác nhận mật khẩu";
            // 
            // txtConfirmPW
            // 
            this.txtConfirmPW.Location = new System.Drawing.Point(137, 164);
            this.txtConfirmPW.Name = "txtConfirmPW";
            this.txtConfirmPW.Size = new System.Drawing.Size(279, 22);
            this.txtConfirmPW.TabIndex = 2;
            this.txtConfirmPW.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mật khẩu mới";
            // 
            // txtNPW
            // 
            this.txtNPW.Location = new System.Drawing.Point(137, 110);
            this.txtNPW.Name = "txtNPW";
            this.txtNPW.Size = new System.Drawing.Size(279, 22);
            this.txtNPW.TabIndex = 1;
            this.txtNPW.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tên đăng nhập";
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(137, 11);
            this.txtUN.Name = "txtUN";
            this.txtUN.ReadOnly = true;
            this.txtUN.Size = new System.Drawing.Size(279, 22);
            this.txtUN.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(80, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 40);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 40);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(137, 51);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(279, 22);
            this.txtPW.TabIndex = 0;
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // chkbShowPW
            // 
            this.chkbShowPW.AutoSize = true;
            this.chkbShowPW.Location = new System.Drawing.Point(137, 79);
            this.chkbShowPW.Name = "chkbShowPW";
            this.chkbShowPW.Size = new System.Drawing.Size(114, 20);
            this.chkbShowPW.TabIndex = 10;
            this.chkbShowPW.Text = "Hiện mật khẩu";
            this.chkbShowPW.UseVisualStyleBackColor = true;
            this.chkbShowPW.CheckedChanged += new System.EventHandler(this.chkbShowPW_CheckedChanged);
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 264);
            this.Controls.Add(this.chkbShowPW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkbShowPWC);
            this.Controls.Add(this.chkbShowNPW);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConfirmPW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNPW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangePW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbShowPWC;
        private System.Windows.Forms.CheckBox chkbShowNPW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConfirmPW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNPW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.CheckBox chkbShowPW;
    }
}