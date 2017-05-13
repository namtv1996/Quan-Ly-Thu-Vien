using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UserControl_Huongdna : UserControl
    {
        public UserControl_Huongdna()
        {
            InitializeComponent();
            webBrowser2.Navigate(@"C:\Users\namtv1996\Desktop\Thuc Tap Nhom\Thuc Tap Nhom - Quan Ly Thu Vien Cua Hoc Vien Ki Thuat Quan Su\Quan-Ly-Thu-Vien\QuanLyThuVien\QuanLyThuVien\Resources\Huongdan.htm");
        }

        private void UserControl_Huongdna_Load(object sender, EventArgs e)
        {

        }
    }
}
