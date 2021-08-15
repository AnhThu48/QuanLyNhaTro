using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.HeThongGiaoDien
{
    public partial class PhongTro : Form
    {
        public PhongTro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // chuyen man hinh ve Main
            this.Hide();
            Main f2 = new Main();
            f2.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTinhTrangPhong_Click(object sender, EventArgs e)
        {
            // goi user control len panel winform
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new TinhTrangPhong());
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            // goi user control len panel winform
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new ThuePhong());
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            // goi user control len panel winform
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new TraPhong());
        }
    }
}
