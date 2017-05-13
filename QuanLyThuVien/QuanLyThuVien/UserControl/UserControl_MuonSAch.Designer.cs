namespace QuanLyThuVien
{
    partial class UserControl_MuonSAch
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
            this.lbl_diachi = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachphieumuon = new System.Windows.Forms.DataGridView();
            this.grb_thongtin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.lbl_ngaylamthe = new System.Windows.Forms.Label();
            this.dtp_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.dtp_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.lbl_maphieu = new System.Windows.Forms.Label();
            this.txt_maphieu = new System.Windows.Forms.TextBox();
            this.lbl_docgia = new System.Windows.Forms.Label();
            this.txt_madocgia = new System.Windows.Forms.TextBox();
            this.lbl_masach = new System.Windows.Forms.Label();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_trasach = new System.Windows.Forms.Button();
            this.lbl_diachi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachphieumuon)).BeginInit();
            this.grb_thongtin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.Controls.Add(this.dgv_danhsachphieumuon);
            this.lbl_diachi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_diachi.Location = new System.Drawing.Point(0, 224);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(615, 273);
            this.lbl_diachi.TabIndex = 7;
            this.lbl_diachi.TabStop = false;
            this.lbl_diachi.Text = "Danh Sách";
            // 
            // dgv_danhsachphieumuon
            // 
            this.dgv_danhsachphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachphieumuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_danhsachphieumuon.Location = new System.Drawing.Point(3, 19);
            this.dgv_danhsachphieumuon.Name = "dgv_danhsachphieumuon";
            this.dgv_danhsachphieumuon.ReadOnly = true;
            this.dgv_danhsachphieumuon.Size = new System.Drawing.Size(609, 251);
            this.dgv_danhsachphieumuon.TabIndex = 15;
            this.dgv_danhsachphieumuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachphieumuon_CellClick);
           // this.dgv_danhsachphieumuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachphieumuon_CellContentClick);
            // 
            // grb_thongtin
            // 
            this.grb_thongtin.Controls.Add(this.label1);
            this.grb_thongtin.Controls.Add(this.txt_manv);
            this.grb_thongtin.Controls.Add(this.lbl_ngaylamthe);
            this.grb_thongtin.Controls.Add(this.dtp_ngaytra);
            this.grb_thongtin.Controls.Add(this.lbl_ngaysinh);
            this.grb_thongtin.Controls.Add(this.dtp_ngaymuon);
            this.grb_thongtin.Controls.Add(this.lbl_maphieu);
            this.grb_thongtin.Controls.Add(this.txt_maphieu);
            this.grb_thongtin.Controls.Add(this.lbl_docgia);
            this.grb_thongtin.Controls.Add(this.txt_madocgia);
            this.grb_thongtin.Controls.Add(this.lbl_masach);
            this.grb_thongtin.Controls.Add(this.txt_masach);
            this.grb_thongtin.Location = new System.Drawing.Point(0, 0);
            this.grb_thongtin.Name = "grb_thongtin";
            this.grb_thongtin.Size = new System.Drawing.Size(612, 137);
            this.grb_thongtin.TabIndex = 6;
            this.grb_thongtin.TabStop = false;
            this.grb_thongtin.Text = "Thông Tin Mượn Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã NV";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(104, 31);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(165, 20);
            this.txt_manv.TabIndex = 2;
            // 
            // lbl_ngaylamthe
            // 
            this.lbl_ngaylamthe.AutoSize = true;
            this.lbl_ngaylamthe.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaylamthe.Location = new System.Drawing.Point(319, 96);
            this.lbl_ngaylamthe.Name = "lbl_ngaylamthe";
            this.lbl_ngaylamthe.Size = new System.Drawing.Size(65, 16);
            this.lbl_ngaylamthe.TabIndex = 19;
            this.lbl_ngaylamthe.Text = "Ngày trả";
            // 
            // dtp_ngaytra
            // 
            this.dtp_ngaytra.Location = new System.Drawing.Point(432, 96);
            this.dtp_ngaytra.Name = "dtp_ngaytra";
            this.dtp_ngaytra.Size = new System.Drawing.Size(168, 20);
            this.dtp_ngaytra.TabIndex = 7;
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaysinh.Location = new System.Drawing.Point(319, 63);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(82, 16);
            this.lbl_ngaysinh.TabIndex = 15;
            this.lbl_ngaysinh.Text = "Ngày mượn";
            // 
            // dtp_ngaymuon
            // 
            this.dtp_ngaymuon.Location = new System.Drawing.Point(432, 61);
            this.dtp_ngaymuon.Name = "dtp_ngaymuon";
            this.dtp_ngaymuon.Size = new System.Drawing.Size(168, 20);
            this.dtp_ngaymuon.TabIndex = 6;
            // 
            // lbl_maphieu
            // 
            this.lbl_maphieu.AutoSize = true;
            this.lbl_maphieu.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maphieu.Location = new System.Drawing.Point(319, 32);
            this.lbl_maphieu.Name = "lbl_maphieu";
            this.lbl_maphieu.Size = new System.Drawing.Size(67, 16);
            this.lbl_maphieu.TabIndex = 5;
            this.lbl_maphieu.Text = "Mã Phiếu";
            // 
            // txt_maphieu
            // 
            this.txt_maphieu.Location = new System.Drawing.Point(432, 28);
            this.txt_maphieu.Name = "txt_maphieu";
            this.txt_maphieu.Size = new System.Drawing.Size(168, 20);
            this.txt_maphieu.TabIndex = 5;
            // 
            // lbl_docgia
            // 
            this.lbl_docgia.AutoSize = true;
            this.lbl_docgia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docgia.Location = new System.Drawing.Point(20, 99);
            this.lbl_docgia.Name = "lbl_docgia";
            this.lbl_docgia.Size = new System.Drawing.Size(80, 16);
            this.lbl_docgia.TabIndex = 3;
            this.lbl_docgia.Text = "Mã độc giả";
            // 
            // txt_madocgia
            // 
            this.txt_madocgia.Location = new System.Drawing.Point(104, 96);
            this.txt_madocgia.Name = "txt_madocgia";
            this.txt_madocgia.Size = new System.Drawing.Size(165, 20);
            this.txt_madocgia.TabIndex = 4;
            // 
            // lbl_masach
            // 
            this.lbl_masach.AutoSize = true;
            this.lbl_masach.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masach.Location = new System.Drawing.Point(20, 65);
            this.lbl_masach.Name = "lbl_masach";
            this.lbl_masach.Size = new System.Drawing.Size(68, 16);
            this.lbl_masach.TabIndex = 1;
            this.lbl_masach.Text = "Mã sách ";
            // 
            // txt_masach
            // 
            this.txt_masach.Location = new System.Drawing.Point(104, 62);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(165, 20);
            this.txt_masach.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_trasach);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(0, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_search);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(383, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 49);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 21);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::QuanLyThuVien.Properties.Resources._1473536499_Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(134, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::QuanLyThuVien.Properties.Resources._1473536478_Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(37, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_search.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_search.Location = new System.Drawing.Point(93, 21);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(121, 16);
            this.lbl_search.TabIndex = 28;
            this.lbl_search.Text = "Nhập tên độc giả";
            // 
            // btn_trasach
            // 
            this.btn_trasach.BackColor = System.Drawing.Color.White;
            this.btn_trasach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trasach.Image = global::QuanLyThuVien.Properties.Resources.trash_delete_16x16;
            this.btn_trasach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trasach.Location = new System.Drawing.Point(226, 32);
            this.btn_trasach.Name = "btn_trasach";
            this.btn_trasach.Size = new System.Drawing.Size(76, 23);
            this.btn_trasach.TabIndex = 38;
            this.btn_trasach.Text = "Trả sách";
            this.btn_trasach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_trasach.UseVisualStyleBackColor = false;
            this.btn_trasach.Click += new System.EventHandler(this.btn_trasach_Click);
            // 
            // UserControl_MuonSAch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_diachi);
            this.Controls.Add(this.grb_thongtin);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_MuonSAch";
            this.Size = new System.Drawing.Size(615, 497);
            this.Load += new System.EventHandler(this.UserControl_MuonSAch_Load);
            this.lbl_diachi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachphieumuon)).EndInit();
            this.grb_thongtin.ResumeLayout(false);
            this.grb_thongtin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lbl_diachi;
        private System.Windows.Forms.DataGridView dgv_danhsachphieumuon;
        private System.Windows.Forms.GroupBox grb_thongtin;
        private System.Windows.Forms.Label lbl_ngaylamthe;
        private System.Windows.Forms.DateTimePicker dtp_ngaytra;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.DateTimePicker dtp_ngaymuon;
        private System.Windows.Forms.Label lbl_maphieu;
        private System.Windows.Forms.TextBox txt_maphieu;
        private System.Windows.Forms.Label lbl_docgia;
        private System.Windows.Forms.TextBox txt_madocgia;
        private System.Windows.Forms.Label lbl_masach;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_trasach;
    }
}
