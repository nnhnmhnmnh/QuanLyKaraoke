namespace QuanLyKaraoke
{
    partial class Login
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
            this.txtUN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.llbSignUp = new System.Windows.Forms.LinkLabel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkbShowPW = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(128, 26);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(279, 22);
            this.txtUN.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên đăng nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mật khẩu";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(128, 60);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(279, 22);
            this.txtPW.TabIndex = 3;
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // llbSignUp
            // 
            this.llbSignUp.AutoSize = true;
            this.llbSignUp.Location = new System.Drawing.Point(195, 199);
            this.llbSignUp.Name = "llbSignUp";
            this.llbSignUp.Size = new System.Drawing.Size(56, 16);
            this.llbSignUp.TabIndex = 5;
            this.llbSignUp.TabStop = true;
            this.llbSignUp.Text = "Đăng ký";
            this.llbSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignUp_LinkClicked);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(113, 139);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(110, 37);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(229, 139);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkbShowPW
            // 
            this.chkbShowPW.AutoSize = true;
            this.chkbShowPW.Location = new System.Drawing.Point(128, 88);
            this.chkbShowPW.Name = "chkbShowPW";
            this.chkbShowPW.Size = new System.Drawing.Size(114, 20);
            this.chkbShowPW.TabIndex = 8;
            this.chkbShowPW.Text = "Hiện mật khẩu";
            this.chkbShowPW.UseVisualStyleBackColor = true;
            this.chkbShowPW.CheckedChanged += new System.EventHandler(this.chkbShowPW_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(448, 240);
            this.Controls.Add(this.chkbShowPW);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.llbSignUp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.LinkLabel llbSignUp;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkbShowPW;
    }
}

