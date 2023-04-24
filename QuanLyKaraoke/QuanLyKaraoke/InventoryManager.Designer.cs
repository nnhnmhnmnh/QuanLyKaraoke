namespace QuanLyKaraoke
{
    partial class InventoryManager
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSDV = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnChangePW = new System.Windows.Forms.Button();
            this.btnQLK = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.cbSearchVDV = new System.Windows.Forms.ComboBox();
            this.btnAllDV = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.cbSearchKDV = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Location = new System.Drawing.Point(767, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 70);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(107, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 35);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(199, 21);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 35);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtRem);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(767, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 195);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dịch vụ";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Đồ ăn",
            "Đồ uống"});
            this.cbType.Location = new System.Drawing.Point(117, 36);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(159, 24);
            this.cbType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại dịch vụ";
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(117, 155);
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(159, 22);
            this.txtRem.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(117, 117);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(159, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 22);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tồn kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.cbSearchVDV);
            this.groupBox1.Controls.Add(this.btnAllDV);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.cbSearchKDV);
            this.groupBox1.Controls.Add(this.dgvDSDV);
            this.groupBox1.Location = new System.Drawing.Point(222, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 522);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ";
            // 
            // dgvDSDV
            // 
            this.dgvDSDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDV.Location = new System.Drawing.Point(6, 84);
            this.dgvDSDV.Name = "dgvDSDV";
            this.dgvDSDV.RowHeadersWidth = 51;
            this.dgvDSDV.RowTemplate.Height = 24;
            this.dgvDSDV.Size = new System.Drawing.Size(527, 432);
            this.dgvDSDV.TabIndex = 0;
            this.dgvDSDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDV_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnChangePW);
            this.groupBox4.Controls.Add(this.btnQLK);
            this.groupBox4.Controls.Add(this.btnLogOut);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 522);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
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
            // btnQLK
            // 
            this.btnQLK.Location = new System.Drawing.Point(6, 21);
            this.btnQLK.Name = "btnQLK";
            this.btnQLK.Size = new System.Drawing.Size(192, 57);
            this.btnQLK.TabIndex = 3;
            this.btnQLK.Text = "Quản lý kho";
            this.btnQLK.UseVisualStyleBackColor = true;
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
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(263, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(10, 16);
            this.label22.TabIndex = 42;
            this.label22.Text = ":";
            // 
            // cbSearchVDV
            // 
            this.cbSearchVDV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSearchVDV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearchVDV.FormattingEnabled = true;
            this.cbSearchVDV.Location = new System.Drawing.Point(279, 36);
            this.cbSearchVDV.Name = "cbSearchVDV";
            this.cbSearchVDV.Size = new System.Drawing.Size(147, 24);
            this.cbSearchVDV.TabIndex = 40;
            this.cbSearchVDV.SelectedIndexChanged += new System.EventHandler(this.cbSearchVDV_SelectedIndexChanged);
            // 
            // btnAllDV
            // 
            this.btnAllDV.Location = new System.Drawing.Point(446, 36);
            this.btnAllDV.Name = "btnAllDV";
            this.btnAllDV.Size = new System.Drawing.Size(87, 25);
            this.btnAllDV.TabIndex = 38;
            this.btnAllDV.Text = "Tất cả";
            this.btnAllDV.UseVisualStyleBackColor = true;
            this.btnAllDV.Click += new System.EventHandler(this.btnAllDV_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 44);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 16);
            this.label23.TabIndex = 41;
            this.label23.Text = "Tìm kiếm";
            // 
            // cbSearchKDV
            // 
            this.cbSearchKDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchKDV.FormattingEnabled = true;
            this.cbSearchKDV.Location = new System.Drawing.Point(88, 37);
            this.cbSearchKDV.Name = "cbSearchKDV";
            this.cbSearchKDV.Size = new System.Drawing.Size(169, 24);
            this.cbSearchKDV.TabIndex = 39;
            this.cbSearchKDV.SelectedIndexChanged += new System.EventHandler(this.cbSearchKDV_SelectedIndexChanged);
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 547);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InventoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.InventoryManager_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSDV;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnChangePW;
        private System.Windows.Forms.Button btnQLK;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbSearchVDV;
        private System.Windows.Forms.Button btnAllDV;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbSearchKDV;
    }
}