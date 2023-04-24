namespace QuanLyKaraoke
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTTCaNhan = new System.Windows.Forms.Button();
            this.btnChangePW = new System.Windows.Forms.Button();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.btnDatPhongHat = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThue = new System.Windows.Forms.DateTimePicker();
            this.gbQLPH = new System.Windows.Forms.GroupBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dtpLocTo = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpLocFrom = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgvDSPH = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGiaTheoGio = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTra = new System.Windows.Forms.DateTimePicker();
            this.pnDatPhongHat = new System.Windows.Forms.Panel();
            this.gbLichSu = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvLS_DSPTP = new System.Windows.Forms.DataGridView();
            this.gbTTCN = new System.Windows.Forms.GroupBox();
            this.btnTTCN_Edit = new System.Windows.Forms.Button();
            this.btnTTCN_Save = new System.Windows.Forms.Button();
            this.dtpTTCN_NS = new System.Windows.Forms.DateTimePicker();
            this.cbTTCN_Gioi = new System.Windows.Forms.ComboBox();
            this.txtTTCN_Email = new System.Windows.Forms.TextBox();
            this.txtTTCN_SDT = new System.Windows.Forms.TextBox();
            this.txtTTCN_UN = new System.Windows.Forms.TextBox();
            this.txtTTCN_Ten = new System.Windows.Forms.TextBox();
            this.txtTTCN_MaKH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbQLPH.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPH)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pnDatPhongHat.SuspendLayout();
            this.gbLichSu.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLS_DSPTP)).BeginInit();
            this.gbTTCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTTCaNhan);
            this.groupBox1.Controls.Add(this.btnChangePW);
            this.groupBox1.Controls.Add(this.btnLichSu);
            this.groupBox1.Controls.Add(this.btnDatPhongHat);
            this.groupBox1.Controls.Add(this.btnLogOut);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 522);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnTTCaNhan
            // 
            this.btnTTCaNhan.Location = new System.Drawing.Point(6, 147);
            this.btnTTCaNhan.Name = "btnTTCaNhan";
            this.btnTTCaNhan.Size = new System.Drawing.Size(192, 57);
            this.btnTTCaNhan.TabIndex = 10;
            this.btnTTCaNhan.Text = "Quản lý thông tin cá nhân";
            this.btnTTCaNhan.UseVisualStyleBackColor = true;
            this.btnTTCaNhan.Click += new System.EventHandler(this.btnTTCaNhan_Click);
            // 
            // btnChangePW
            // 
            this.btnChangePW.Location = new System.Drawing.Point(6, 426);
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.Size = new System.Drawing.Size(192, 42);
            this.btnChangePW.TabIndex = 9;
            this.btnChangePW.Text = "Đổi mật khẩu";
            this.btnChangePW.UseVisualStyleBackColor = true;
            this.btnChangePW.Click += new System.EventHandler(this.btnChangePW_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.Location = new System.Drawing.Point(6, 84);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(192, 57);
            this.btnLichSu.TabIndex = 6;
            this.btnLichSu.Text = "Xem lịch sử thuê phòng";
            this.btnLichSu.UseVisualStyleBackColor = true;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnDatPhongHat
            // 
            this.btnDatPhongHat.Location = new System.Drawing.Point(6, 21);
            this.btnDatPhongHat.Name = "btnDatPhongHat";
            this.btnDatPhongHat.Size = new System.Drawing.Size(192, 57);
            this.btnDatPhongHat.TabIndex = 8;
            this.btnDatPhongHat.Text = "Đặt phòng hát";
            this.btnDatPhongHat.UseVisualStyleBackColor = true;
            this.btnDatPhongHat.Click += new System.EventHandler(this.btnDatPhongHat_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(6, 474);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(192, 42);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(694, 42);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(124, 39);
            this.btnDatPhong.TabIndex = 11;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thời gian thuê phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thời gian trả phòng";
            // 
            // dtpThue
            // 
            this.dtpThue.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThue.Location = new System.Drawing.Point(468, 22);
            this.dtpThue.Name = "dtpThue";
            this.dtpThue.Size = new System.Drawing.Size(170, 22);
            this.dtpThue.TabIndex = 14;
            this.dtpThue.ValueChanged += new System.EventHandler(this.dtpThue_ValueChanged);
            // 
            // gbQLPH
            // 
            this.gbQLPH.Controls.Add(this.btnAll);
            this.gbQLPH.Controls.Add(this.btnLoc);
            this.gbQLPH.Controls.Add(this.dtpLocTo);
            this.gbQLPH.Controls.Add(this.label16);
            this.gbQLPH.Controls.Add(this.dtpLocFrom);
            this.gbQLPH.Controls.Add(this.label15);
            this.gbQLPH.Controls.Add(this.groupBox8);
            this.gbQLPH.Location = new System.Drawing.Point(0, 0);
            this.gbQLPH.Name = "gbQLPH";
            this.gbQLPH.Size = new System.Drawing.Size(831, 424);
            this.gbQLPH.TabIndex = 19;
            this.gbQLPH.TabStop = false;
            this.gbQLPH.Text = "Xem phòng";
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(717, 59);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(101, 25);
            this.btnAll.TabIndex = 40;
            this.btnAll.Text = "Tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(717, 28);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(101, 25);
            this.btnLoc.TabIndex = 39;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dtpLocTo
            // 
            this.dtpLocTo.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpLocTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLocTo.Location = new System.Drawing.Point(463, 30);
            this.dtpLocTo.Name = "dtpLocTo";
            this.dtpLocTo.Size = new System.Drawing.Size(249, 22);
            this.dtpLocTo.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(409, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "Đến";
            // 
            // dtpLocFrom
            // 
            this.dtpLocFrom.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpLocFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLocFrom.Location = new System.Drawing.Point(190, 31);
            this.dtpLocFrom.Name = "dtpLocFrom";
            this.dtpLocFrom.Size = new System.Drawing.Size(213, 22);
            this.dtpLocFrom.TabIndex = 36;
            this.dtpLocFrom.ValueChanged += new System.EventHandler(this.dtpLocFrom_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 16);
            this.label15.TabIndex = 35;
            this.label15.Text = "Lọc theo phòng trống: Từ";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dgvDSPH);
            this.groupBox8.Location = new System.Drawing.Point(6, 83);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(818, 335);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Danh sách phòng hát";
            // 
            // dgvDSPH
            // 
            this.dgvDSPH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPH.Location = new System.Drawing.Point(6, 21);
            this.dgvDSPH.Name = "dgvDSPH";
            this.dgvDSPH.RowHeadersWidth = 51;
            this.dgvDSPH.RowTemplate.Height = 24;
            this.dgvDSPH.Size = new System.Drawing.Size(806, 307);
            this.dgvDSPH.TabIndex = 0;
            this.dgvDSPH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPH_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGiaTheoGio);
            this.groupBox3.Controls.Add(this.txtMaPhong);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtpTra);
            this.groupBox3.Controls.Add(this.dtpThue);
            this.groupBox3.Controls.Add(this.btnDatPhong);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(0, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(831, 92);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đặt phòng";
            // 
            // txtGiaTheoGio
            // 
            this.txtGiaTheoGio.Location = new System.Drawing.Point(104, 59);
            this.txtGiaTheoGio.Name = "txtGiaTheoGio";
            this.txtGiaTheoGio.ReadOnly = true;
            this.txtGiaTheoGio.Size = new System.Drawing.Size(146, 22);
            this.txtGiaTheoGio.TabIndex = 19;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(104, 21);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(146, 22);
            this.txtMaPhong.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giá theo giờ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã phòng";
            // 
            // dtpTra
            // 
            this.dtpTra.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTra.Location = new System.Drawing.Point(468, 59);
            this.dtpTra.Name = "dtpTra";
            this.dtpTra.Size = new System.Drawing.Size(170, 22);
            this.dtpTra.TabIndex = 15;
            // 
            // pnDatPhongHat
            // 
            this.pnDatPhongHat.Controls.Add(this.groupBox3);
            this.pnDatPhongHat.Controls.Add(this.gbQLPH);
            this.pnDatPhongHat.Location = new System.Drawing.Point(222, 13);
            this.pnDatPhongHat.Name = "pnDatPhongHat";
            this.pnDatPhongHat.Size = new System.Drawing.Size(831, 522);
            this.pnDatPhongHat.TabIndex = 1;
            // 
            // gbLichSu
            // 
            this.gbLichSu.Controls.Add(this.groupBox4);
            this.gbLichSu.Location = new System.Drawing.Point(222, 13);
            this.gbLichSu.Name = "gbLichSu";
            this.gbLichSu.Size = new System.Drawing.Size(831, 519);
            this.gbLichSu.TabIndex = 20;
            this.gbLichSu.TabStop = false;
            this.gbLichSu.Text = "Lịch sử thuê phòng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvLS_DSPTP);
            this.groupBox4.Location = new System.Drawing.Point(6, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(818, 477);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phiếu thuê phòng";
            // 
            // dgvLS_DSPTP
            // 
            this.dgvLS_DSPTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLS_DSPTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLS_DSPTP.Location = new System.Drawing.Point(6, 21);
            this.dgvLS_DSPTP.Name = "dgvLS_DSPTP";
            this.dgvLS_DSPTP.RowHeadersWidth = 51;
            this.dgvLS_DSPTP.RowTemplate.Height = 24;
            this.dgvLS_DSPTP.Size = new System.Drawing.Size(806, 450);
            this.dgvLS_DSPTP.TabIndex = 0;
            // 
            // gbTTCN
            // 
            this.gbTTCN.Controls.Add(this.btnTTCN_Edit);
            this.gbTTCN.Controls.Add(this.btnTTCN_Save);
            this.gbTTCN.Controls.Add(this.dtpTTCN_NS);
            this.gbTTCN.Controls.Add(this.cbTTCN_Gioi);
            this.gbTTCN.Controls.Add(this.txtTTCN_Email);
            this.gbTTCN.Controls.Add(this.txtTTCN_SDT);
            this.gbTTCN.Controls.Add(this.txtTTCN_UN);
            this.gbTTCN.Controls.Add(this.txtTTCN_Ten);
            this.gbTTCN.Controls.Add(this.txtTTCN_MaKH);
            this.gbTTCN.Controls.Add(this.label13);
            this.gbTTCN.Controls.Add(this.label12);
            this.gbTTCN.Controls.Add(this.label11);
            this.gbTTCN.Controls.Add(this.label10);
            this.gbTTCN.Controls.Add(this.label9);
            this.gbTTCN.Controls.Add(this.label8);
            this.gbTTCN.Controls.Add(this.label7);
            this.gbTTCN.Controls.Add(this.pictureBox1);
            this.gbTTCN.Location = new System.Drawing.Point(222, 13);
            this.gbTTCN.Name = "gbTTCN";
            this.gbTTCN.Size = new System.Drawing.Size(831, 516);
            this.gbTTCN.TabIndex = 21;
            this.gbTTCN.TabStop = false;
            this.gbTTCN.Text = "Thông tin cá nhân";
            // 
            // btnTTCN_Edit
            // 
            this.btnTTCN_Edit.Location = new System.Drawing.Point(280, 467);
            this.btnTTCN_Edit.Name = "btnTTCN_Edit";
            this.btnTTCN_Edit.Size = new System.Drawing.Size(110, 40);
            this.btnTTCN_Edit.TabIndex = 8;
            this.btnTTCN_Edit.Text = "Sửa";
            this.btnTTCN_Edit.UseVisualStyleBackColor = true;
            this.btnTTCN_Edit.Click += new System.EventHandler(this.btnTTCN_Edit_Click);
            // 
            // btnTTCN_Save
            // 
            this.btnTTCN_Save.Location = new System.Drawing.Point(164, 467);
            this.btnTTCN_Save.Name = "btnTTCN_Save";
            this.btnTTCN_Save.Size = new System.Drawing.Size(110, 40);
            this.btnTTCN_Save.TabIndex = 9;
            this.btnTTCN_Save.Text = "Lưu";
            this.btnTTCN_Save.UseVisualStyleBackColor = true;
            this.btnTTCN_Save.Click += new System.EventHandler(this.btnTTCN_Save_Click);
            // 
            // dtpTTCN_NS
            // 
            this.dtpTTCN_NS.Enabled = false;
            this.dtpTTCN_NS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTTCN_NS.Location = new System.Drawing.Point(157, 377);
            this.dtpTTCN_NS.Name = "dtpTTCN_NS";
            this.dtpTTCN_NS.Size = new System.Drawing.Size(233, 22);
            this.dtpTTCN_NS.TabIndex = 18;
            // 
            // cbTTCN_Gioi
            // 
            this.cbTTCN_Gioi.Enabled = false;
            this.cbTTCN_Gioi.FormattingEnabled = true;
            this.cbTTCN_Gioi.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbTTCN_Gioi.Location = new System.Drawing.Point(157, 315);
            this.cbTTCN_Gioi.Name = "cbTTCN_Gioi";
            this.cbTTCN_Gioi.Size = new System.Drawing.Size(233, 24);
            this.cbTTCN_Gioi.TabIndex = 17;
            // 
            // txtTTCN_Email
            // 
            this.txtTTCN_Email.Enabled = false;
            this.txtTTCN_Email.Location = new System.Drawing.Point(154, 260);
            this.txtTTCN_Email.Name = "txtTTCN_Email";
            this.txtTTCN_Email.Size = new System.Drawing.Size(236, 22);
            this.txtTTCN_Email.TabIndex = 14;
            // 
            // txtTTCN_SDT
            // 
            this.txtTTCN_SDT.Enabled = false;
            this.txtTTCN_SDT.Location = new System.Drawing.Point(154, 208);
            this.txtTTCN_SDT.Name = "txtTTCN_SDT";
            this.txtTTCN_SDT.Size = new System.Drawing.Size(236, 22);
            this.txtTTCN_SDT.TabIndex = 13;
            // 
            // txtTTCN_UN
            // 
            this.txtTTCN_UN.Location = new System.Drawing.Point(154, 155);
            this.txtTTCN_UN.Name = "txtTTCN_UN";
            this.txtTTCN_UN.ReadOnly = true;
            this.txtTTCN_UN.Size = new System.Drawing.Size(236, 22);
            this.txtTTCN_UN.TabIndex = 12;
            // 
            // txtTTCN_Ten
            // 
            this.txtTTCN_Ten.Enabled = false;
            this.txtTTCN_Ten.Location = new System.Drawing.Point(154, 104);
            this.txtTTCN_Ten.Name = "txtTTCN_Ten";
            this.txtTTCN_Ten.Size = new System.Drawing.Size(236, 22);
            this.txtTTCN_Ten.TabIndex = 11;
            // 
            // txtTTCN_MaKH
            // 
            this.txtTTCN_MaKH.Location = new System.Drawing.Point(154, 55);
            this.txtTTCN_MaKH.Name = "txtTTCN_MaKH";
            this.txtTTCN_MaKH.ReadOnly = true;
            this.txtTTCN_MaKH.Size = new System.Drawing.Size(236, 22);
            this.txtTTCN_MaKH.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Ngày sinh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Giới tính";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Họ tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên đăng nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã khách hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnDatPhongHat);
            this.Controls.Add(this.gbTTCN);
            this.Controls.Add(this.gbLichSu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbQLPH.ResumeLayout(false);
            this.gbQLPH.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnDatPhongHat.ResumeLayout(false);
            this.gbLichSu.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLS_DSPTP)).EndInit();
            this.gbTTCN.ResumeLayout(false);
            this.gbTTCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangePW;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Button btnDatPhongHat;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnTTCaNhan;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThue;
        private System.Windows.Forms.GroupBox gbQLPH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpTra;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dgvDSPH;
        private System.Windows.Forms.TextBox txtGiaTheoGio;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnDatPhongHat;
        private System.Windows.Forms.GroupBox gbLichSu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvLS_DSPTP;
        private System.Windows.Forms.GroupBox gbTTCN;
        private System.Windows.Forms.TextBox txtTTCN_Email;
        private System.Windows.Forms.TextBox txtTTCN_SDT;
        private System.Windows.Forms.TextBox txtTTCN_UN;
        private System.Windows.Forms.TextBox txtTTCN_Ten;
        private System.Windows.Forms.TextBox txtTTCN_MaKH;
        private System.Windows.Forms.Button btnTTCN_Save;
        private System.Windows.Forms.Button btnTTCN_Edit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTTCN_NS;
        private System.Windows.Forms.ComboBox cbTTCN_Gioi;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DateTimePicker dtpLocTo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpLocFrom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}