using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        //phuong thuc load form len control
        public void Showcontrols(System.Windows.Forms.Control cs)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(cs);
            cs.Dock = DockStyle.Fill;
        }

        private void tre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if (e.Node.Name == "docgia")
            {
                Docgia dg = new Docgia();
                Showcontrols(dg);
            }
            else
            if (e.Node.Name == "sach")
            {
                UserControl_Sach sach = new UserControl_Sach();
                Showcontrols(sach);
            }
            else
                if (e.Node.Name == "muonsach")
            {
                UserControl_MuonSAch muon = new UserControl_MuonSAch();
                Showcontrols(muon);
            }
            else
                if (e.Node.Name == "huongdan")
            {
                UserControl_Huongdna huong = new UserControl_Huongdna();
                Showcontrols(huong);
            }
         
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
