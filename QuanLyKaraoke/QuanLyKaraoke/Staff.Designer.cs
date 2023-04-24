namespace QuanLyKaraoke
{
    partial class Staff
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
            this.dgvDSDV = new System.Windows.Forms.DataGridView();
            this.gbDSDV = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.cbSearchVDV = new System.Windows.Forms.ComboBox();
            this.nudCSL = new System.Windows.Forms.NumericUpDown();
            this.btnAllDV = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSearchKDV = new System.Windows.Forms.ComboBox();
            this.gbCTHD = new System.Windows.Forms.GroupBox();
            this.btnAllCTHD = new System.Windows.Forms.Button();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.nudSSL = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaPTP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDSPTP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangePW = new System.Windows.Forms.Button();
            this.btnDV = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).BeginInit();
            this.gbDSDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCSL)).BeginInit();
            this.gbCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPTP)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSDV
            // 
            this.dgvDSDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDV.Location = new System.Drawing.Point(6, 72);
            this.dgvDSDV.Name = "dgvDSDV";
            this.dgvDSDV.RowHeadersWidth = 51;
            this.dgvDSDV.RowTemplate.Height = 24;
            this.dgvDSDV.Size = new System.Drawing.Size(382, 344);
            this.dgvDSDV.TabIndex = 0;
            this.dgvDSDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDV_CellContentClick);
            // 
            // gbDSDV
            // 
            this.gbDSDV.Controls.Add(this.label22);
            this.gbDSDV.Controls.Add(this.btnAdd);
            this.gbDSDV.Controls.Add(this.txtTenDV);
            this.gbDSDV.Controls.Add(this.dgvDSDV);
            this.gbDSDV.Controls.Add(this.cbSearchVDV);
            this.gbDSDV.Controls.Add(this.nudCSL);
            this.gbDSDV.Controls.Add(this.btnAllDV);
            this.gbDSDV.Controls.Add(this.label23);
            this.gbDSDV.Controls.Add(this.label2);
            this.gbDSDV.Controls.Add(this.cbSearchKDV);
            this.gbDSDV.Enabled = false;
            this.gbDSDV.Location = new System.Drawing.Point(15, 371);
            this.gbDSDV.Name = "gbDSDV";
            this.gbDSDV.Size = new System.Drawing.Size(394, 461);
            this.gbDSDV.TabIndex = 10;
            this.gbDSDV.TabStop = false;
            this.gbDSDV.Text = "Danh sách dịch vụ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(163, 37);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(10, 16);
            this.label22.TabIndex = 37;
            this.label22.Text = ":";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(322, 422);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(72, 423);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.ReadOnly = true;
            this.txtTenDV.Size = new System.Drawing.Size(100, 22);
            this.txtTenDV.TabIndex = 5;
            // 
            // cbSearchVDV
            // 
            this.cbSearchVDV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSearchVDV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearchVDV.FormattingEnabled = true;
            this.cbSearchVDV.Location = new System.Drawing.Point(174, 30);
            this.cbSearchVDV.Name = "cbSearchVDV";
            this.cbSearchVDV.Size = new System.Drawing.Size(99, 24);
            this.cbSearchVDV.TabIndex = 35;
            this.cbSearchVDV.SelectedIndexChanged += new System.EventHandler(this.cbSearchVDV_SelectedIndexChanged);
            // 
            // nudCSL
            // 
            this.nudCSL.Enabled = false;
            this.nudCSL.Location = new System.Drawing.Point(244, 426);
            this.nudCSL.Name = "nudCSL";
            this.nudCSL.Size = new System.Drawing.Size(61, 22);
            this.nudCSL.TabIndex = 2;
            // 
            // btnAllDV
            // 
            this.btnAllDV.Location = new System.Drawing.Point(301, 28);
            this.btnAllDV.Name = "btnAllDV";
            this.btnAllDV.Size = new System.Drawing.Size(87, 25);
            this.btnAllDV.TabIndex = 33;
            this.btnAllDV.Text = "Tất cả";
            this.btnAllDV.UseVisualStyleBackColor = true;
            this.btnAllDV.Click += new System.EventHandler(this.btnAllDV_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 37);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 16);
            this.label23.TabIndex = 36;
            this.label23.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng";
            // 
            // cbSearchKDV
            // 
            this.cbSearchKDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchKDV.FormattingEnabled = true;
            this.cbSearchKDV.Location = new System.Drawing.Point(85, 30);
            this.cbSearchKDV.Name = "cbSearchKDV";
            this.cbSearchKDV.Size = new System.Drawing.Size(72, 24);
            this.cbSearchKDV.TabIndex = 34;
            this.cbSearchKDV.SelectedIndexChanged += new System.EventHandler(this.cbSearchDV_SelectedIndexChanged);
            // 
            // gbCTHD
            // 
            this.gbCTHD.Controls.Add(this.btnAllCTHD);
            this.gbCTHD.Controls.Add(this.txtMaDV);
            this.gbCTHD.Controls.Add(this.btnEdit);
            this.gbCTHD.Controls.Add(this.nudSSL);
            this.gbCTHD.Controls.Add(this.label1);
            this.gbCTHD.Controls.Add(this.btnDel);
            this.gbCTHD.Controls.Add(this.dgvCTHD);
            this.gbCTHD.Enabled = false;
            this.gbCTHD.Location = new System.Drawing.Point(415, 371);
            this.gbCTHD.Name = "gbCTHD";
            this.gbCTHD.Size = new System.Drawing.Size(395, 461);
            this.gbCTHD.TabIndex = 20;
            this.gbCTHD.TabStop = false;
            this.gbCTHD.Text = "Danh sách dịch vụ đã thêm";
            // 
            // btnAllCTHD
            // 
            this.btnAllCTHD.Location = new System.Drawing.Point(314, 30);
            this.btnAllCTHD.Name = "btnAllCTHD";
            this.btnAllCTHD.Size = new System.Drawing.Size(75, 23);
            this.btnAllCTHD.TabIndex = 41;
            this.btnAllCTHD.Text = "Tất cả";
            this.btnAllCTHD.UseVisualStyleBackColor = true;
            this.btnAllCTHD.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(48, 427);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(100, 22);
            this.txtMaDV.TabIndex = 40;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(298, 426);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nudSSL
            // 
            this.nudSSL.Location = new System.Drawing.Point(220, 426);
            this.nudSSL.Name = "nudSSL";
            this.nudSSL.Size = new System.Drawing.Size(61, 22);
            this.nudSSL.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Số lượng";
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(233, 30);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(6, 72);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(383, 348);
            this.dgvCTHD.TabIndex = 0;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaPTP);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(15, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(801, 353);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu đặt phòng";
            // 
            // txtMaPTP
            // 
            this.txtMaPTP.Location = new System.Drawing.Point(661, 319);
            this.txtMaPTP.Name = "txtMaPTP";
            this.txtMaPTP.ReadOnly = true;
            this.txtMaPTP.Size = new System.Drawing.Size(137, 22);
            this.txtMaPTP.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Phiếu đặt phòng đã chọn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDSPTP);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(789, 292);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phiếu đặt phòng";
            // 
            // dgvDSPTP
            // 
            this.dgvDSPTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPTP.Location = new System.Drawing.Point(6, 21);
            this.dgvDSPTP.Name = "dgvDSPTP";
            this.dgvDSPTP.RowHeadersWidth = 51;
            this.dgvDSPTP.RowTemplate.Height = 24;
            this.dgvDSPTP.Size = new System.Drawing.Size(777, 260);
            this.dgvDSPTP.TabIndex = 0;
            this.dgvDSPTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPTP_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.gbCTHD);
            this.panel1.Controls.Add(this.gbDSDV);
            this.panel1.Location = new System.Drawing.Point(222, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 493);
            this.panel1.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangePW);
            this.groupBox1.Controls.Add(this.btnDV);
            this.groupBox1.Controls.Add(this.btnLogOut);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 522);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnChangePW
            // 
            this.btnChangePW.Location = new System.Drawing.Point(6, 426);
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.Size = new System.Drawing.Size(192, 42);
            this.btnChangePW.TabIndex = 11;
            this.btnChangePW.Text = "Đổi mật khẩu";
            this.btnChangePW.UseVisualStyleBackColor = true;
            this.btnChangePW.Click += new System.EventHandler(this.btnChangePW_Click);
            // 
            // btnDV
            // 
            this.btnDV.Location = new System.Drawing.Point(6, 21);
            this.btnDV.Name = "btnDV";
            this.btnDV.Size = new System.Drawing.Size(192, 57);
            this.btnDV.TabIndex = 3;
            this.btnDV.Text = "Đặt dịch vụ";
            this.btnDV.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(6, 474);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(192, 42);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).EndInit();
            this.gbDSDV.ResumeLayout(false);
            this.gbDSDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCSL)).EndInit();
            this.gbCTHD.ResumeLayout(false);
            this.gbCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPTP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSDV;
        private System.Windows.Forms.GroupBox gbDSDV;
        private System.Windows.Forms.GroupBox gbCTHD;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudCSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbSearchVDV;
        private System.Windows.Forms.Button btnAllDV;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbSearchKDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaPTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDSPTP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.NumericUpDown nudSSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllCTHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangePW;
        private System.Windows.Forms.Button btnDV;
        private System.Windows.Forms.Button btnLogOut;
    }
}