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

    public partial class UserControl_MuonSAch : UserControl
    {
        private string stage;
        public UserControl_MuonSAch()
        {
            InitializeComponent();
        }
        QUANLYTHUVIENEntities db = new QUANLYTHUVIENEntities();
        private void LoadDanhSach()
        {
            dgv_danhsachphieumuon.DataSource = (from x in db.PhieuMuons
                                                join y in db.CT_PhieuMuon on x.MaPhieu equals y.MaPhieu
                                                join z in db.Saches on y.MaSach equals z.MaSach
                                                join a in db.DocGias on x.MaDG equals a.MaDG
                                                join b in db.NhanViens on x.MaNV equals b.MaNV
                                                select new
                                                {
                                                    x.MaPhieu,
                                                    a.MaDG,
                                                    a.HoTenDG,
                                                    a.NgaySinhDG,
                                                    b.HoTenNV,
                                                    b.MaNV,
                                                    z.TenSach,
                                                    z.MaSach,
                                                    y.HanTra,
                                                    x.Ngaymuon
                                                }).ToList();
            //gọi store procedure
            //dùng thủ tục show thông tin mượn sách
            //dgv_danhsachphieumuon.DataSource = db.Saches.ToList()
            ; btn_trasach.Enabled = false;
        }

        private void UserControl_MuonSAch_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            //dgv_danhsachphieumuon.Columns[0].HeaderText = "Mã SV";
            //dgv_danhsachphieumuon.Columns[1].HeaderText = "Tên SV";
            //dgv_danhsachphieumuon.Columns[2].HeaderText = "Ngày Sinh";
            //dgv_danhsachphieumuon.Columns[3].HeaderText = "Người Cho Mượn";
            //dgv_danhsachphieumuon.Columns[4].HeaderText = "Mã NV";
            //dgv_danhsachphieumuon.Columns[5].HeaderText = "Tên Sách";
            //dgv_danhsachphieumuon.Columns[6].HeaderText = "Mã Sách";
            //dgv_danhsachphieumuon.Columns[7].HeaderText = "Hạn trả";
            //dgv_danhsachphieumuon.Columns[8].HeaderText = "Ngày Mượn";
            btnSave.Enabled = false;
        }

        //CLICK NÚT THÊM
        private void btnAdd_Click(object sender, EventArgs e)
        {
            stage = "add";
            btnSave.Enabled = true;
        }
        //SAVE
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (stage == "add")
            {
                try
                {
                    if (txt_madocgia.Text == "" || txt_maphieu.Text == "" || txt_masach.Text == "" || txt_maphieu.Text == "")
                    {
                        MessageBox.Show("Nhập đầy đủ thông tin");
                    }
                    else
                    {
                        string masach = txt_masach.Text;
                        string madg = txt_madocgia.Text;
                        int maphieu = int.Parse(txt_maphieu.Text);
                        //lay quyen sach có mã sach
                        var s = db.Saches.SingleOrDefault(n => n.MaSach == masach);

                        //con sach moi cho muon
                        if (s.SoLuong > 0)
                        {
                            CT_PhieuMuon ct = new CT_PhieuMuon();
                            var p = db.PhieuMuons.SingleOrDefault(n => n.MaDG == madg);
                            //kiểm tra sách được mượn chưa
                            if (db.CT_PhieuMuon.SingleOrDefault(x => x.MaPhieu == maphieu && x.MaSach == masach) != null) { MessageBox.Show("Mỗi sách chỉ được mượn 1 quyển"); }
                            else
                            {
                                //doc gia da co phieu muon
                                if (p != null)
                                {
                                    if (p.MaPhieu != maphieu) { MessageBox.Show("nhập sai mã phiếu"); }
                                    else
                                    {
                                        ct.MaPhieu = p.MaPhieu;
                                        ct.MaSach = masach;
                                        ct.HanTra = dtp_ngaytra.Value;
                                        db.CT_PhieuMuon.Add(ct);
                                        //giam so luong sach;
                                        db.Saches.SingleOrDefault(x => x.MaSach == masach).SoLuong--;
                                        db.SaveChanges();

                                        LoadDanhSach();
                                        MessageBox.Show("thành công");
                                    }
                                }
                                else
                                {
                                    //them vao bang phieu muon truoc
                                    PhieuMuon phieu = new PhieuMuon();
                                    phieu.MaPhieu = int.Parse(txt_maphieu.Text);
                                    phieu.MaDG = txt_madocgia.Text;
                                    phieu.MaNV = txt_manv.Text;
                                    phieu.Ngaymuon = dtp_ngaymuon.Value;
                                    db.PhieuMuons.Add(phieu);
                                    //them vao bang ct_phieumuon sau
                                    ct.MaPhieu = int.Parse(txt_maphieu.Text);
                                    ct.MaSach = masach;
                                    ct.HanTra = dtp_ngaytra.Value;
                                    db.CT_PhieuMuon.Add(ct);
                                    db.Saches.SingleOrDefault(x => x.MaSach == masach).SoLuong--;
                                    db.SaveChanges();
                                    LoadDanhSach();
                                    MessageBox.Show("thành công");
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Sách đã hết");
                        }


                    }

                    LoadDanhSach();


                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
            btnSave.Enabled = false;
        }

        //TÌM KIẾM THEO TÊN NGƯỜI MƯỢN
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                lbl_search.Visible = true;
            }
            else
            {
                lbl_search.Hide();
            }
            dgv_danhsachphieumuon.DataSource = db.SP_timkiemnguoimuon(txtSearch.Text);
        }
        //CLICK NÚT TRẢ SÁCH
        private void btn_trasach_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn muốn trả sách", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    //xóa trong bảng chi tiết trước
                    int maphieu = int.Parse(txt_maphieu.Text);

                    string masach = (txt_masach.Text);
                    var ct_phieu = db.CT_PhieuMuon.SingleOrDefault(x => x.MaPhieu == maphieu && x.MaSach == masach);
                    db.CT_PhieuMuon.Remove(ct_phieu);
                    //trả lại sách  thì số lượng sách tăng lên một
                    db.Saches.SingleOrDefault(x => x.MaSach == masach).SoLuong++;
                    db.SaveChanges();
                    //kiểm tra đk nếu không có chi tiết với mã phiếu tương ứng thì xóa bản ghi có mã phiếu tương ứng trong bảng phiếu mượn
                    if (db.CT_PhieuMuon.SingleOrDefault(x => x.MaPhieu == maphieu) == null)
                    {
                        var phieumuon = db.PhieuMuons.SingleOrDefault(x => x.MaPhieu == maphieu);
                        db.PhieuMuons.Remove(phieumuon);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Thành công!");
                    LoadDanhSach();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //CLICK VÀO CÁC CELL TRÊN DATAGRIDVIEW
        private void dgv_danhsachphieumuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_trasach.Enabled = true;
            txt_manv.Text = dgv_danhsachphieumuon.CurrentRow.Cells[5].Value.ToString();
            txt_madocgia.Text = dgv_danhsachphieumuon.CurrentRow.Cells[1].Value.ToString();
            txt_masach.Text = dgv_danhsachphieumuon.CurrentRow.Cells[7].Value.ToString();
            txt_maphieu.Text = dgv_danhsachphieumuon.CurrentRow.Cells[0].Value.ToString();
            dtp_ngaymuon.Text = dgv_danhsachphieumuon.CurrentRow.Cells[9].Value.ToString();
            dtp_ngaytra.Text = dgv_danhsachphieumuon.CurrentRow.Cells[8].Value.ToString();

        }
    }
}
