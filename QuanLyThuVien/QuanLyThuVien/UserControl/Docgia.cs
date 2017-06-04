using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{

    public partial class Docgia : UserControl
    {
        // Khởi tạo đối tượng QUANLYTHUVIENEntities
        QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities();
        //Trạng thái chức năng
        private string stage;

        public Docgia()
        {
            InitializeComponent();
            dgv_danhsachDG.DataError += Dgv_danhsachDG_DataError;
        }

        private void Dgv_danhsachDG_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
          //  throw new NotImplementedException();
        }

        //LOAD USER CONTROL ĐỘC GIẢ
        private void Docgia_Load(object sender, EventArgs e)
        {
            //Gán data cho datagridview
            dgv_danhsachDG.DataSource = db.DocGias.ToList();
            //dgv_danhsachDG.DataSource = db.DocGias.SqlQuery("select *from DocGia").ToList();

            //Đổi Tên Columns datagridview
            dgv_danhsachDG.Columns[0].HeaderText = "Mã ĐG";
            dgv_danhsachDG.Columns[1].HeaderText = "Họ Tên";
            dgv_danhsachDG.Columns[2].HeaderText = "Giới Tính";
            dgv_danhsachDG.Columns[3].HeaderText = "Ngày Sinh";
            dgv_danhsachDG.Columns[4].HeaderText = "Địa Chỉ";
            dgv_danhsachDG.Columns[5].HeaderText = "Điện Thoại";
            dgv_danhsachDG.Columns[6].HeaderText = "Email";
            dgv_danhsachDG.Columns[7].HeaderText = "Ngày Làm Thẻ";
            dgv_danhsachDG.Columns[8].HeaderText = "Ngày Hết Hạn";
            //ẩn cột
          dgv_danhsachDG.Columns[9].Visible = false;// = "Mã Phiếu Mượn";
            //Tự Động căn chỉnh kích thước của hàng và cột datagridview
            dgv_danhsachDG.AutoResizeColumns();
            dgv_danhsachDG.AutoResizeRows();
            //khóa nút Lưu
            btnSave.Enabled = false;
            //không cho thay đổi mã
            txt_madg.Enabled = false;
            //thêm các phần tử vào source của txtsearch
            //foreach (DataGridViewRow item in dgv_danhsachDG.Rows)
            //{
            //    for (int i = 0; i < item.Cells.Count - 1; i++)
            //    {
            //        if (item.Cells[i].Value != null)
            //        {
            //            txtSearch.AutoCompleteCustomSource.Add(item.Cells[i].Value.ToString());
            //        }
            //    }
            //}

        }
        //  CLICK TRÊN DATAGRIDVIEW

        private void dgv_danhsachDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load các thông tin độc giả lên group thông tin

            txt_madg.Text = dgv_danhsachDG.CurrentRow.Cells[0].Value.ToString();
            txt_hoten.Text = dgv_danhsachDG.CurrentRow.Cells[1].Value.ToString();
            dtp_ngaysinh.Value = (DateTime)dgv_danhsachDG.CurrentRow.Cells[3].Value;
            txt_diachi.Text = dgv_danhsachDG.CurrentRow.Cells[4].Value.ToString();
            if (dgv_danhsachDG.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                rbt_nam.Checked = true;
            }
            else { rbt_nu.Checked = true; }
            txt_email.Text = dgv_danhsachDG.CurrentRow.Cells[5].Value.ToString();
            txt_sdt.Text = dgv_danhsachDG.CurrentRow.Cells[6].Value.ToString();
            dtp_ngaylamthe.Text = dgv_danhsachDG.CurrentRow.Cells[7].Value.ToString();
            dtp_ngayhethan.Text = dgv_danhsachDG.CurrentRow.Cells[8].Value.ToString();

        }

        //REFRESH
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            stage = "refresh";
            dgv_danhsachDG.DataSource = db.DocGias.SqlQuery("select *from DocGia").ToList();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            txt_madg.Enabled = false;


        }
        //THÊM
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            stage = "add";
            //khóa nút
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            //clear text
            txt_madg.ResetText();
            txt_hoten.ResetText();
            txt_email.ResetText();
            txt_diachi.ResetText();
            txt_sdt.ResetText();
            rbt_nam.Checked = false;
            rbt_nu.Checked = false;
            //đặt ngày về hiện tại
            dtp_ngaysinh.Value = DateTime.Now;
            dtp_ngayhethan.Value = DateTime.Now;
            dtp_ngaylamthe.Value = DateTime.Now;

            //mở khóa textbox mã độc giả
            txt_madg.Enabled = true;
        }

        // SỬA
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (txt_madg.Text == "") { MessageBox.Show("Chọn độc giả để sửa!"); }
            else
            {
                stage = "edit";
                //khóa nút
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
                btnSave.Enabled = true;

            }
           
        }
        //XÓA 
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            var dg = db.DocGias.SingleOrDefault(n => n.MaDG == txt_madg.Text);
            if (MessageBox.Show("Xóa bản ghi?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    db.DocGias.Remove(dg);
                    db.SaveChanges();
                    MessageBox.Show("Thành công!");
                    dgv_danhsachDG.DataSource = db.DocGias.SqlQuery("select *from DocGia").ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //LƯU
        private void btnSave_Click(object sender, EventArgs e)
        {
            //khởi tạo 1 độc giả
            DocGia dg = new DocGia();
            if (stage == "add")
            {
                try
                {
                    if (txt_madg.Text == "") { MessageBox.Show("Nhập vào mã độc giả!"); return; }
                    if((rbt_nam.Checked == false && rbt_nu.Checked == false)) { MessageBox.Show("Chọn giới tính độc giả!"); return; }
                    else
                        //gán thông tin cho độc giả
                        dg.MaDG = txt_madg.Text;
                    dg.HoTenDG = txt_hoten.Text;
                    dg.GioiTinhDG = (rbt_nam.Checked) ? "Nam" : "Nữ";
                    dg.NgaySinhDG = DateTime.Parse(dtp_ngaysinh.Value.ToString());
                    dg.DiaChiDG = txt_diachi.Text;
                    dg.DienThoaiDG = txt_sdt.Text;
                    dg.EmailDG = txt_email.Text;
                    dg.NgayLamThe = DateTime.Parse(dtp_ngaylamthe.Value.ToString());
                    dg.NgayHetHan = DateTime.Parse(dtp_ngayhethan.Value.ToString());
                    //Lưu thay đổi
                    db.DocGias.Add(dg);
                    db.SaveChanges();
                    MessageBox.Show("Thành công!");
                    //load lại danh sách
                    // dgv_danhsachDG.DataSource = db.DocGias.SqlQuery("select *from DocGia").ToList();
                    Docgia_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (stage == "edit")
            {
                try
                {


                    dg = db.DocGias.SingleOrDefault(n => n.MaDG == txt_madg.Text);
                    //gán thông tin cho độc giả
                    dg.MaDG = txt_madg.Text;
                    dg.HoTenDG = txt_hoten.Text;
                    dg.GioiTinhDG = (rbt_nam.Checked) ? "Nam" : "Nữ";
                    dg.NgaySinhDG = DateTime.Parse(dtp_ngaysinh.Value.ToString());
                    dg.DiaChiDG = txt_diachi.Text;
                    dg.DienThoaiDG = txt_sdt.Text;
                    dg.EmailDG = txt_email.Text;
                    dg.NgayLamThe = DateTime.Parse(dtp_ngaylamthe.Value.ToString());
                    dg.NgayHetHan = DateTime.Parse(dtp_ngayhethan.Value.ToString());
                    //Lưu thay đổi
                    db.SaveChanges();
                    MessageBox.Show("Thành công!");
                    //load lại danh sách
                    // dgv_danhsachDG.DataSource = db.DocGias.SqlQuery("select *from DocGia").ToList();
                    Docgia_Load(sender,e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //TÌM KIẾM
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //object[] para = { new SqlParameter("@key",txtSearch.Text)};
            if (txtSearch.Text == "")
            {
                lbl_search.Visible = true;
            }
            else
            {
                lbl_search.Hide();
            }
            dgv_danhsachDG.DataSource = db.SP_timkiemdocgia(txtSearch.Text);
            //dgv_danhsachDG.DataSource = db.DocGias.SqlQuery("select *from docgia where tensach like N'%'"+para+"N'%'").ToList();

        }

        private void dgv_danhsachDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
