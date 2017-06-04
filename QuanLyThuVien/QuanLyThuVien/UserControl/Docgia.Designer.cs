namespace QuanLyThuVien
{
    partial class Docgia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbt_nu = new System.Windows.Forms.RadioButton();
            this.rbt_nam = new System.Windows.Forms.RadioButton();
            this.lbl_ngaylamthe = new System.Windows.Forms.Label();
            this.dtp_ngaylamthe = new System.Windows.Forms.DateTimePicker();
            this.lbl_ngayhethan = new System.Windows.Forms.Label();
            this.dtp_ngayhethan = new System.Windows.Forms.DateTimePicker();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_sdt = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.lbl_madg = new System.Windows.Forms.Label();
            this.txt_madg = new System.Windows.Forms.TextBox();
            this.lbl_diachi = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachDG = new System.Windows.Forms.DataGridView();
            this.grb_thongtin = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.lbl_diachi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachDG)).BeginInit();
            this.grb_thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(0, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 77);
            this.groupBox1.TabIndex = 2;
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
            this.lbl_search.Location = new System.Drawing.Point(140, 20);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(73, 16);
            this.lbl_search.TabIndex = 31;
            this.lbl_search.Text = "Nhập tên ";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
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
            this.btnSave.TabIndex = 10;
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
            this.btnRefresh.TabIndex = 11;
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
            this.btnDelete.Location = new System.Drawing.Point(151, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::QuanLyThuVien.Properties.Resources._1473536520_Edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(79, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
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
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // rbt_nu
            // 
            this.rbt_nu.AutoSize = true;
            this.rbt_nu.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_nu.Location = new System.Drawing.Point(508, 29);
            this.rbt_nu.Name = "rbt_nu";
            this.rbt_nu.Size = new System.Drawing.Size(44, 20);
            this.rbt_nu.TabIndex = 6;
            this.rbt_nu.TabStop = true;
            this.rbt_nu.Text = "Nữ";
            this.rbt_nu.UseVisualStyleBackColor = true;
            // 
            // rbt_nam
            // 
            this.rbt_nam.AutoSize = true;
            this.rbt_nam.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_nam.Location = new System.Drawing.Point(426, 31);
            this.rbt_nam.Name = "rbt_nam";
            this.rbt_nam.Size = new System.Drawing.Size(54, 20);
            this.rbt_nam.TabIndex = 5;
            this.rbt_nam.TabStop = true;
            this.rbt_nam.Text = "Nam";
            this.rbt_nam.UseVisualStyleBackColor = true;
            // 
            // lbl_ngaylamthe
            // 
            this.lbl_ngaylamthe.AutoSize = true;
            this.lbl_ngaylamthe.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaylamthe.Location = new System.Drawing.Point(313, 104);
            this.lbl_ngaylamthe.Name = "lbl_ngaylamthe";
            this.lbl_ngaylamthe.Size = new System.Drawing.Size(102, 16);
            this.lbl_ngaylamthe.TabIndex = 19;
            this.lbl_ngaylamthe.Text = "Ngày Làm Thẻ";
            // 
            // dtp_ngaylamthe
            // 
            this.dtp_ngaylamthe.Location = new System.Drawing.Point(426, 98);
            this.dtp_ngaylamthe.Name = "dtp_ngaylamthe";
            this.dtp_ngaylamthe.Size = new System.Drawing.Size(168, 20);
            this.dtp_ngaylamthe.TabIndex = 8;
            // 
            // lbl_ngayhethan
            // 
            this.lbl_ngayhethan.AutoSize = true;
            this.lbl_ngayhethan.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngayhethan.Location = new System.Drawing.Point(313, 138);
            this.lbl_ngayhethan.Name = "lbl_ngayhethan";
            this.lbl_ngayhethan.Size = new System.Drawing.Size(99, 16);
            this.lbl_ngayhethan.TabIndex = 17;
            this.lbl_ngayhethan.Text = "Ngày Hết Hạn";
            // 
            // dtp_ngayhethan
            // 
            this.dtp_ngayhethan.Location = new System.Drawing.Point(426, 134);
            this.dtp_ngayhethan.Name = "dtp_ngayhethan";
            this.dtp_ngayhethan.Size = new System.Drawing.Size(168, 20);
            this.dtp_ngayhethan.TabIndex = 9;
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaysinh.Location = new System.Drawing.Point(313, 65);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(74, 16);
            this.lbl_ngaysinh.TabIndex = 15;
            this.lbl_ngaysinh.Text = "Ngày Sinh";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(426, 59);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(168, 20);
            this.dtp_ngaysinh.TabIndex = 7;
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh.Location = new System.Drawing.Point(313, 33);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(64, 16);
            this.lbl_gioitinh.TabIndex = 11;
            this.lbl_gioitinh.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa Chỉ";
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sdt.Location = new System.Drawing.Point(20, 111);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(77, 16);
            this.lbl_sdt.TabIndex = 7;
            this.lbl_sdt.Text = "Điện Thoại";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(101, 108);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(165, 20);
            this.txt_sdt.TabIndex = 3;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(101, 134);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(165, 20);
            this.txt_diachi.TabIndex = 4;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(20, 83);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 16);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(101, 82);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(165, 20);
            this.txt_email.TabIndex = 2;
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoten.Location = new System.Drawing.Point(20, 59);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(55, 16);
            this.lbl_hoten.TabIndex = 3;
            this.lbl_hoten.Text = "Họ Tên";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(101, 56);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(165, 20);
            this.txt_hoten.TabIndex = 1;
            // 
            // lbl_madg
            // 
            this.lbl_madg.AutoSize = true;
            this.lbl_madg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_madg.Location = new System.Drawing.Point(20, 33);
            this.lbl_madg.Name = "lbl_madg";
            this.lbl_madg.Size = new System.Drawing.Size(50, 16);
            this.lbl_madg.TabIndex = 1;
            this.lbl_madg.Text = "Mã ĐG";
            // 
            // txt_madg
            // 
            this.txt_madg.Location = new System.Drawing.Point(101, 30);
            this.txt_madg.Name = "txt_madg";
            this.txt_madg.Size = new System.Drawing.Size(165, 20);
            this.txt_madg.TabIndex = 0;
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.Controls.Add(this.dgv_danhsachDG);
            this.lbl_diachi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_diachi.Location = new System.Drawing.Point(0, 264);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(615, 233);
            this.lbl_diachi.TabIndex = 4;
            this.lbl_diachi.TabStop = false;
            this.lbl_diachi.Text = "Danh Sách";
            // 
            // dgv_danhsachDG
            // 
            this.dgv_danhsachDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachDG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_danhsachDG.Location = new System.Drawing.Point(3, 19);
            this.dgv_danhsachDG.Name = "dgv_danhsachDG";
            this.dgv_danhsachDG.ReadOnly = true;
            this.dgv_danhsachDG.Size = new System.Drawing.Size(609, 211);
            this.dgv_danhsachDG.TabIndex = 15;
            this.dgv_danhsachDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachDG_CellClick);
            this.dgv_danhsachDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachDG_CellContentClick);
            // 
            // grb_thongtin
            // 
            this.grb_thongtin.Controls.Add(this.rbt_nu);
            this.grb_thongtin.Controls.Add(this.rbt_nam);
            this.grb_thongtin.Controls.Add(this.lbl_ngaylamthe);
            this.grb_thongtin.Controls.Add(this.dtp_ngaylamthe);
            this.grb_thongtin.Controls.Add(this.lbl_ngayhethan);
            this.grb_thongtin.Controls.Add(this.dtp_ngayhethan);
            this.grb_thongtin.Controls.Add(this.lbl_ngaysinh);
            this.grb_thongtin.Controls.Add(this.dtp_ngaysinh);
            this.grb_thongtin.Controls.Add(this.lbl_gioitinh);
            this.grb_thongtin.Controls.Add(this.label5);
            this.grb_thongtin.Controls.Add(this.txt_diachi);
            this.grb_thongtin.Controls.Add(this.lbl_sdt);
            this.grb_thongtin.Controls.Add(this.txt_sdt);
            this.grb_thongtin.Controls.Add(this.lbl_email);
            this.grb_thongtin.Controls.Add(this.txt_email);
            this.grb_thongtin.Controls.Add(this.lbl_hoten);
            this.grb_thongtin.Controls.Add(this.txt_hoten);
            this.grb_thongtin.Controls.Add(this.lbl_madg);
            this.grb_thongtin.Controls.Add(this.txt_madg);
            this.grb_thongtin.Location = new System.Drawing.Point(0, 0);
            this.grb_thongtin.Name = "grb_thongtin";
            this.grb_thongtin.Size = new System.Drawing.Size(612, 179);
            this.grb_thongtin.TabIndex = 3;
            this.grb_thongtin.TabStop = false;
            this.grb_thongtin.Text = "Thông Tin Độc Giả";
            // 
            // Docgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_diachi);
            this.Controls.Add(this.grb_thongtin);
            this.Name = "Docgia";
            this.Size = new System.Drawing.Size(615, 497);
            this.Load += new System.EventHandler(this.Docgia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.lbl_diachi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachDG)).EndInit();
            this.grb_thongtin.ResumeLayout(false);
            this.grb_thongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbt_nu;
        private System.Windows.Forms.RadioButton rbt_nam;
        private System.Windows.Forms.Label lbl_ngaylamthe;
        private System.Windows.Forms.DateTimePicker dtp_ngaylamthe;
        private System.Windows.Forms.Label lbl_ngayhethan;
        private System.Windows.Forms.DateTimePicker dtp_ngayhethan;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_sdt;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label lbl_madg;
        private System.Windows.Forms.TextBox txt_madg;
        private System.Windows.Forms.GroupBox lbl_diachi;
        private System.Windows.Forms.DataGridView dgv_danhsachDG;
        private System.Windows.Forms.GroupBox grb_thongtin;
        private System.Windows.Forms.Label lbl_search;
    }
}
