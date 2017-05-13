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
    public partial class UserControl_Sach : UserControl
    {
        //biến trạng thái
        private string stage;
        //khởi tạo 1 đối tượng QUANLYTHUVIENEntities;
        QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities();
        public UserControl_Sach()
        {
            InitializeComponent();
        }
        //Load lại danh sách
        private void Load_danhsach()
        {
            //dgv_danhsachsach.DataSource = (from x in db.Saches
            //                               join y in db.NhaXuatBans on x.MaNXB equals y.MaNXB
            //                               join z in db.TacGias on x.MaTG equals z.MaTG
            //                               join t in db.TheLoais on x.MaTL equals t.MaTL
            //                               select new
            //                               {
            //                                   x.MaSach,
            //                                   x.TenSach,
            //                                   x.NoiDungTT,
            //                                   x.SoTrang,
            //                                   x.GiaTien,
            //                                   x.SoLuong,
            //                                   x.NgayNhap,
            //                                   x.TinhTrang,
            //                                   y.TenNXB,
            //                                   z.HoTenTG,
            //                                   t.TenTL
            //                               }).ToList();
            dgv_danhsachsach.DataSource = db.SP_showthongtinsach();
        }
        //load combobox
        private void Load_combobox()
        {

            cbb_nhaxuatban.DataSource = (from x in db.NhaXuatBans select x).ToList();
            cbb_nhaxuatban.DisplayMember = "TenNXB";
            cbb_nhaxuatban.ValueMember = "MaNXB";

            cbb_theloai.DataSource = (from x in db.TheLoais select x).ToList();
            cbb_theloai.DisplayMember = "TenTL";
            cbb_theloai.ValueMember = "MaTL";

            cbb_tacgia.DataSource = (from x in db.TacGias select x).ToList();
            cbb_tacgia.DisplayMember = "HoTenTG";
            cbb_tacgia.ValueMember = "MaTG";
        }
        //LOAD USER CONTROLL
        private void UserControl_Sach_Load(object sender, EventArgs e)
        {
            //gán dữ liệu cho datagridview
            // dgv_danhsachsach.DataSource = db.Saches.Select(n => n).ToList();
            Load_danhsach();
            //đổi tên
            dgv_danhsachsach.Columns[0].HeaderText = "Mã Sách";
            dgv_danhsachsach.Columns[1].HeaderText = "Tên Sách";
            dgv_danhsachsach.Columns[2].HeaderText = "Nội Dung TT";
            dgv_danhsachsach.Columns[3].HeaderText = "Số Trang";
            dgv_danhsachsach.Columns[4].HeaderText = "Giá Tiền";
            dgv_danhsachsach.Columns[5].HeaderText = "Số Lượng";
            dgv_danhsachsach.Columns[6].HeaderText = "Ngày Nhập";
            dgv_danhsachsach.Columns[7].HeaderText = "Tình Trạng";
            dgv_danhsachsach.Columns[8].HeaderText = "Nhà Xuất Bản";
            dgv_danhsachsach.Columns[9].HeaderText = "Tác Giả";
            dgv_danhsachsach.Columns[10].HeaderText = "Thể Loại";
            //khóa nút Lưu
            btnSave.Enabled = false;
            //không cho thay đổi mã
            txt_masach.Enabled = false;
            //dgv_danhsachsach.Columns[11].Visible = false;
            //dgv_danhsachsach.Columns[12].Visible = false;
            //dgv_danhsachsach.Columns[13].Visible = false;
            //dgv_danhsachsach.Columns[14].Visible = false;
            //dgv_danhsachsach.Columns[15].Visible = false;
            //thêm các phần tử vào source của txtsearch
            //foreach (DataGridViewRow item in dgv_danhsachsach.Rows)
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

        private void dgv_danhsachsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masach.Text = dgv_danhsachsach.CurrentRow.Cells[0].Value.ToString();
            txt_tensach.Text = dgv_danhsachsach.CurrentRow.Cells[1].Value.ToString();
            txt_noidungtt.Text = dgv_danhsachsach.CurrentRow.Cells[2].Value.ToString();
            txt_sotrang.Text = dgv_danhsachsach.CurrentRow.Cells[3].Value.ToString();
            txt_giatien.Text = dgv_danhsachsach.CurrentRow.Cells[4].Value.ToString();
            txt_soluong.Text = dgv_danhsachsach.CurrentRow.Cells[5].Value.ToString();
            txt_tinhtrang.Text = dgv_danhsachsach.CurrentRow.Cells[7].Value.ToString();
            dtp_ngaynhap.Value = DateTime.Parse(dgv_danhsachsach.CurrentRow.Cells[6].Value.ToString());
            Load_combobox();
        }

        //THÊM
        private void btnAdd_Click(object sender, EventArgs e)
        {
            stage = "add";
            //khóa nút
            btnDelete.Enabled = false;
            //btnSearch.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            //clear text
            txt_masach.ResetText();
            txt_tensach.ResetText();
            txt_noidungtt.ResetText();
            txt_sotrang.ResetText();
            txt_giatien.ResetText();
            txt_soluong.ResetText();
            txt_tinhtrang.ResetText();
            //đặt ngày về hiện tại
            dtp_ngaynhap.Value = DateTime.Now;
            //load lại combobox
            Load_combobox();
            //mở khóa textbox mã sách
            txt_masach.Enabled = true;
        }
        //SỬA 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txt_masach.Text == "") { MessageBox.Show("Chọn Sách để sửa!"); }
            else
            {
                stage = "edit";
                //khóa nút
                btnDelete.Enabled = false;
                //btnSearch.Enabled = false;
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
          
            }
       
        }
        //XÓA
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var sach = db.Saches.SingleOrDefault(n => n.MaSach == txt_masach.Text);
            if (MessageBox.Show("Xóa bản ghi?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    db.Saches.Remove(sach);
                    db.SaveChanges();
                    MessageBox.Show("Thành công!");
                    Load_danhsach();

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
            Sach s = new Sach();
            if (stage == "add")
            {

                try
                {
                    if (txt_masach.Text == "") { MessageBox.Show("Nhập vào mã sách !"); return; }
                    else
                        //gán thông tin cho độc giả
                        s.MaSach = txt_masach.Text;
                    s.TenSach = txt_tensach.Text;
                    s.NoiDungTT = txt_noidungtt.Text;
                    if (txt_sotrang.Text == "") { s.SoTrang = 0; }
                    else { s.SoTrang = int.Parse(txt_sotrang.Text); }
                    if (txt_giatien.Text == "") { s.GiaTien = 0; }
                    else { s.GiaTien = long.Parse(txt_giatien.Text); }
                    if (txt_soluong.Text == "") { s.SoLuong = 0; }
                    else { s.SoLuong = int.Parse(txt_soluong.Text); }
                    s.TinhTrang = txt_tinhtrang.Text;
                    s.NgayNhap = DateTime.Parse(dtp_ngaynhap.Value.ToString());
                    s.MaNXB = cbb_nhaxuatban.SelectedValue.ToString();
                    s.MaTG = cbb_tacgia.SelectedValue.ToString();
                    s.MaTL = cbb_theloai.SelectedValue.ToString();
                    //Thêm đốc giả vào bảng
                    db.Saches.Add(s);
                    //Lưu thay đổi
                    db.SaveChanges();
                    MessageBox.Show("Thành công!");
                    //load lại danh sách
                    dgv_danhsachsach.DataSource = (from x in db.Saches
                                                   join y in db.NhaXuatBans on x.MaNXB equals y.MaNXB
                                                   join z in db.TacGias on x.MaTG equals z.MaTG
                                                   join t in db.TheLoais on x.MaTL equals t.MaTL
                                                   select new
                                                   {
                                                       x.MaSach,
                                                       x.TenSach,
                                                       x.NoiDungTT,
                                                       x.SoTrang,
                                                       x.GiaTien,
                                                       x.SoLuong,
                                                       x.NgayNhap,
                                                       x.TinhTrang,
                                                       y.TenNXB,
                                                       z.HoTenTG,
                                                       t.TenTL
                                                   }).ToList();

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
                    
               
                        s = db.Saches.SingleOrDefault(n => n.MaSach == txt_masach.Text);
                        //gán thông tin cho độc giả
                        s.TenSach = txt_tensach.Text;
                        s.NoiDungTT = txt_noidungtt.Text;
                        if (txt_sotrang.Text == "") { s.SoTrang = 0; }
                        else { s.SoTrang = int.Parse(txt_sotrang.Text); }
                        if (txt_giatien.Text == "") { s.GiaTien = 0; }
                        else { s.GiaTien = long.Parse(txt_giatien.Text); }
                        if (txt_soluong.Text == "") { s.SoLuong = 0; }
                        else { s.SoLuong = int.Parse(txt_soluong.Text); }
                        s.TinhTrang = txt_tinhtrang.Text;
                        s.NgayNhap = DateTime.Parse(dtp_ngaynhap.Value.ToString());
                        s.MaNXB = cbb_nhaxuatban.SelectedValue.ToString();
                        s.MaTG = cbb_tacgia.SelectedValue.ToString();
                        s.MaTL = cbb_theloai.SelectedValue.ToString();
 
                        //Lưu thay đổi
                        db.SaveChanges();
                        MessageBox.Show("Thành công!");
                        //load lại danh sách
                        Load_danhsach();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            stage = "refresh";
            Load_danhsach();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            txt_masach.Enabled = false;
        }
        //  TÌM KIẾM
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                lbl_search.Visible =true;
            }
            else
            {
                lbl_search.Hide();
            }
           
            dgv_danhsachsach.DataSource = db.SP_timkiemsach(txtSearch.Text);
        }
    }

}

