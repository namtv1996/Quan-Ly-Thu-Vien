namespace QuanLyThuVien
{
    partial class UserControl_Sach
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
            this.dgv_danhsachsach = new System.Windows.Forms.DataGridView();
            this.grb_thongtin = new System.Windows.Forms.GroupBox();
            this.lbl_tacgia = new System.Windows.Forms.Label();
            this.cbb_tacgia = new System.Windows.Forms.ComboBox();
            this.lbl_nhaxuatban = new System.Windows.Forms.Label();
            this.cbb_nhaxuatban = new System.Windows.Forms.ComboBox();
            this.lbl_theloai = new System.Windows.Forms.Label();
            this.cbb_theloai = new System.Windows.Forms.ComboBox();
            this.lbl_tinhtrang = new System.Windows.Forms.Label();
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.lbl_ngaynhap = new System.Windows.Forms.Label();
            this.dtp_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.lbl_giatien = new System.Windows.Forms.Label();
            this.txt_giatien = new System.Windows.Forms.TextBox();
            this.lbl_sotrang = new System.Windows.Forms.Label();
            this.txt_sotrang = new System.Windows.Forms.TextBox();
            this.lbl_noidungtt = new System.Windows.Forms.Label();
            this.txt_noidungtt = new System.Windows.Forms.TextBox();
            this.lbl_tensach = new System.Windows.Forms.Label();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.lbl_masach = new System.Windows.Forms.Label();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbl_diachi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsach)).BeginInit();
            this.grb_thongtin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.Controls.Add(this.dgv_danhsachsach);
            this.lbl_diachi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_diachi.Location = new System.Drawing.Point(0, 264);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(615, 233);
            this.lbl_diachi.TabIndex = 7;
            this.lbl_diachi.TabStop = false;
            this.lbl_diachi.Text = "Danh Sách";
            // 
            // dgv_danhsachsach
            // 
            this.dgv_danhsachsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_danhsachsach.Location = new System.Drawing.Point(3, 19);
            this.dgv_danhsachsach.Name = "dgv_danhsachsach";
            this.dgv_danhsachsach.Size = new System.Drawing.Size(609, 211);
            this.dgv_danhsachsach.TabIndex = 0;
            this.dgv_danhsachsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachsach_CellClick);
            // 
            // grb_thongtin
            // 
            this.grb_thongtin.Controls.Add(this.lbl_tacgia);
            this.grb_thongtin.Controls.Add(this.cbb_tacgia);
            this.grb_thongtin.Controls.Add(this.lbl_nhaxuatban);
            this.grb_thongtin.Controls.Add(this.cbb_nhaxuatban);
            this.grb_thongtin.Controls.Add(this.lbl_theloai);
            this.grb_thongtin.Controls.Add(this.cbb_theloai);
            this.grb_thongtin.Controls.Add(this.lbl_tinhtrang);
            this.grb_thongtin.Controls.Add(this.txt_tinhtrang);
            this.grb_thongtin.Controls.Add(this.lbl_soluong);
            this.grb_thongtin.Controls.Add(this.txt_soluong);
            this.grb_thongtin.Controls.Add(this.lbl_ngaynhap);
            this.grb_thongtin.Controls.Add(this.dtp_ngaynhap);
            this.grb_thongtin.Controls.Add(this.lbl_giatien);
            this.grb_thongtin.Controls.Add(this.txt_giatien);
            this.grb_thongtin.Controls.Add(this.lbl_sotrang);
            this.grb_thongtin.Controls.Add(this.txt_sotrang);
            this.grb_thongtin.Controls.Add(this.lbl_noidungtt);
            this.grb_thongtin.Controls.Add(this.txt_noidungtt);
            this.grb_thongtin.Controls.Add(this.lbl_tensach);
            this.grb_thongtin.Controls.Add(this.txt_tensach);
            this.grb_thongtin.Controls.Add(this.lbl_masach);
            this.grb_thongtin.Controls.Add(this.txt_masach);
            this.grb_thongtin.Location = new System.Drawing.Point(0, 0);
            this.grb_thongtin.Name = "grb_thongtin";
            this.grb_thongtin.Size = new System.Drawing.Size(612, 182);
            this.grb_thongtin.TabIndex = 6;
            this.grb_thongtin.TabStop = false;
            this.grb_thongtin.Text = "Thông Tin Sách";
            // 
            // lbl_tacgia
            // 
            this.lbl_tacgia.AutoSize = true;
            this.lbl_tacgia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tacgia.Location = new System.Drawing.Point(315, 120);
            this.lbl_tacgia.Name = "lbl_tacgia";
            this.lbl_tacgia.Size = new System.Drawing.Size(58, 16);
            this.lbl_tacgia.TabIndex = 31;
            this.lbl_tacgia.Text = "Tác Giả";
            // 
            // cbb_tacgia
            // 
            this.cbb_tacgia.FormattingEnabled = true;
            this.cbb_tacgia.Location = new System.Drawing.Point(420, 119);
            this.cbb_tacgia.Name = "cbb_tacgia";
            this.cbb_tacgia.Size = new System.Drawing.Size(150, 21);
            this.cbb_tacgia.TabIndex = 30;
            // 
            // lbl_nhaxuatban
            // 
            this.lbl_nhaxuatban.AutoSize = true;
            this.lbl_nhaxuatban.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhaxuatban.Location = new System.Drawing.Point(315, 89);
            this.lbl_nhaxuatban.Name = "lbl_nhaxuatban";
            this.lbl_nhaxuatban.Size = new System.Drawing.Size(98, 16);
            this.lbl_nhaxuatban.TabIndex = 29;
            this.lbl_nhaxuatban.Text = "Nhà Xuất Bản";
            // 
            // cbb_nhaxuatban
            // 
            this.cbb_nhaxuatban.FormattingEnabled = true;
            this.cbb_nhaxuatban.Location = new System.Drawing.Point(420, 88);
            this.cbb_nhaxuatban.Name = "cbb_nhaxuatban";
            this.cbb_nhaxuatban.Size = new System.Drawing.Size(150, 21);
            this.cbb_nhaxuatban.TabIndex = 28;
            // 
            // lbl_theloai
            // 
            this.lbl_theloai.AutoSize = true;
            this.lbl_theloai.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_theloai.Location = new System.Drawing.Point(315, 58);
            this.lbl_theloai.Name = "lbl_theloai";
            this.lbl_theloai.Size = new System.Drawing.Size(64, 16);
            this.lbl_theloai.TabIndex = 27;
            this.lbl_theloai.Text = "Thể Loại";
            // 
            // cbb_theloai
            // 
            this.cbb_theloai.FormattingEnabled = true;
            this.cbb_theloai.Location = new System.Drawing.Point(420, 57);
            this.cbb_theloai.Name = "cbb_theloai";
            this.cbb_theloai.Size = new System.Drawing.Size(150, 21);
            this.cbb_theloai.TabIndex = 26;
            // 
            // lbl_tinhtrang
            // 
            this.lbl_tinhtrang.AutoSize = true;
            this.lbl_tinhtrang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tinhtrang.Location = new System.Drawing.Point(315, 26);
            this.lbl_tinhtrang.Name = "lbl_tinhtrang";
            this.lbl_tinhtrang.Size = new System.Drawing.Size(79, 16);
            this.lbl_tinhtrang.TabIndex = 25;
            this.lbl_tinhtrang.Text = "Tình Trạng";
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Location = new System.Drawing.Point(420, 25);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(150, 20);
            this.txt_tinhtrang.TabIndex = 24;
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soluong.Location = new System.Drawing.Point(20, 154);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(70, 16);
            this.lbl_soluong.TabIndex = 23;
            this.lbl_soluong.Text = "Số Lượng";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(110, 153);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(165, 20);
            this.txt_soluong.TabIndex = 9;
            // 
            // lbl_ngaynhap
            // 
            this.lbl_ngaynhap.AutoSize = true;
            this.lbl_ngaynhap.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaynhap.Location = new System.Drawing.Point(315, 154);
            this.lbl_ngaynhap.Name = "lbl_ngaynhap";
            this.lbl_ngaynhap.Size = new System.Drawing.Size(79, 16);
            this.lbl_ngaynhap.TabIndex = 17;
            this.lbl_ngaynhap.Text = "Ngày Nhập";
            // 
            // dtp_ngaynhap
            // 
            this.dtp_ngaynhap.Location = new System.Drawing.Point(420, 150);
            this.dtp_ngaynhap.Name = "dtp_ngaynhap";
            this.dtp_ngaynhap.Size = new System.Drawing.Size(150, 20);
            this.dtp_ngaynhap.TabIndex = 30;
            // 
            // lbl_giatien
            // 
            this.lbl_giatien.AutoSize = true;
            this.lbl_giatien.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giatien.Location = new System.Drawing.Point(20, 130);
            this.lbl_giatien.Name = "lbl_giatien";
            this.lbl_giatien.Size = new System.Drawing.Size(61, 16);
            this.lbl_giatien.TabIndex = 9;
            this.lbl_giatien.Text = "Giá Tiền";
            // 
            // txt_giatien
            // 
            this.txt_giatien.Location = new System.Drawing.Point(110, 127);
            this.txt_giatien.Name = "txt_giatien";
            this.txt_giatien.Size = new System.Drawing.Size(165, 20);
            this.txt_giatien.TabIndex = 8;
            // 
            // lbl_sotrang
            // 
            this.lbl_sotrang.AutoSize = true;
            this.lbl_sotrang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sotrang.Location = new System.Drawing.Point(20, 104);
            this.lbl_sotrang.Name = "lbl_sotrang";
            this.lbl_sotrang.Size = new System.Drawing.Size(68, 16);
            this.lbl_sotrang.TabIndex = 7;
            this.lbl_sotrang.Text = "Số Trang";
            // 
            // txt_sotrang
            // 
            this.txt_sotrang.Location = new System.Drawing.Point(110, 101);
            this.txt_sotrang.Name = "txt_sotrang";
            this.txt_sotrang.Size = new System.Drawing.Size(165, 20);
            this.txt_sotrang.TabIndex = 6;
            // 
            // lbl_noidungtt
            // 
            this.lbl_noidungtt.AutoSize = true;
            this.lbl_noidungtt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noidungtt.Location = new System.Drawing.Point(20, 76);
            this.lbl_noidungtt.Name = "lbl_noidungtt";
            this.lbl_noidungtt.Size = new System.Drawing.Size(89, 16);
            this.lbl_noidungtt.TabIndex = 5;
            this.lbl_noidungtt.Text = "Nội Dung TT";
            // 
            // txt_noidungtt
            // 
            this.txt_noidungtt.Location = new System.Drawing.Point(110, 75);
            this.txt_noidungtt.Name = "txt_noidungtt";
            this.txt_noidungtt.Size = new System.Drawing.Size(165, 20);
            this.txt_noidungtt.TabIndex = 4;
            // 
            // lbl_tensach
            // 
            this.lbl_tensach.AutoSize = true;
            this.lbl_tensach.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tensach.Location = new System.Drawing.Point(20, 52);
            this.lbl_tensach.Name = "lbl_tensach";
            this.lbl_tensach.Size = new System.Drawing.Size(71, 16);
            this.lbl_tensach.TabIndex = 3;
            this.lbl_tensach.Text = "Tên Sách";
            // 
            // txt_tensach
            // 
            this.txt_tensach.Location = new System.Drawing.Point(110, 49);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(165, 20);
            this.txt_tensach.TabIndex = 2;
            // 
            // lbl_masach
            // 
            this.lbl_masach.AutoSize = true;
            this.lbl_masach.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masach.Location = new System.Drawing.Point(20, 26);
            this.lbl_masach.Name = "lbl_masach";
            this.lbl_masach.Size = new System.Drawing.Size(65, 16);
            this.lbl_masach.TabIndex = 1;
            this.lbl_masach.Text = "Mã Sách";
            // 
            // txt_masach
            // 
            this.txt_masach.Location = new System.Drawing.Point(110, 23);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(165, 20);
            this.txt_masach.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::QuanLyThuVien.Properties.Resources._1473536478_Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(7, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 23);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::QuanLyThuVien.Properties.Resources._1473536520_Edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(79, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 23);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(0, 188);
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
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_search.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_search.Location = new System.Drawing.Point(109, 20);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(104, 16);
            this.lbl_search.TabIndex = 30;
            this.lbl_search.Text = "Nhập tên sách";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 21);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::QuanLyThuVien.Properties.Resources._1473536499_Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(223, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::QuanLyThuVien.Properties.Resources.ẽit;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(295, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 23);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::QuanLyThuVien.Properties.Resources.trash_delete_16x16;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(151, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 23);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UserControl_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_diachi);
            this.Controls.Add(this.grb_thongtin);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_Sach";
            this.Size = new System.Drawing.Size(615, 497);
            this.Load += new System.EventHandler(this.UserControl_Sach_Load);
            this.lbl_diachi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsach)).EndInit();
            this.grb_thongtin.ResumeLayout(false);
            this.grb_thongtin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lbl_diachi;
        private System.Windows.Forms.DataGridView dgv_danhsachsach;
        private System.Windows.Forms.GroupBox grb_thongtin;
        private System.Windows.Forms.Label lbl_ngaynhap;
        private System.Windows.Forms.DateTimePicker dtp_ngaynhap;
        private System.Windows.Forms.Label lbl_giatien;
        private System.Windows.Forms.TextBox txt_giatien;
        private System.Windows.Forms.Label lbl_sotrang;
        private System.Windows.Forms.TextBox txt_sotrang;
        private System.Windows.Forms.Label lbl_noidungtt;
        private System.Windows.Forms.TextBox txt_noidungtt;
        private System.Windows.Forms.Label lbl_tensach;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.Label lbl_masach;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbl_soluong;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label lbl_tinhtrang;
        private System.Windows.Forms.TextBox txt_tinhtrang;
        private System.Windows.Forms.Label lbl_tacgia;
        private System.Windows.Forms.ComboBox cbb_tacgia;
        private System.Windows.Forms.Label lbl_nhaxuatban;
        private System.Windows.Forms.ComboBox cbb_nhaxuatban;
        private System.Windows.Forms.Label lbl_theloai;
        private System.Windows.Forms.ComboBox cbb_theloai;
        private System.Windows.Forms.Label lbl_search;
    }
}
