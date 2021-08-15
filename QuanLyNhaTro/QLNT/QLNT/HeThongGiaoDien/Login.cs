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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool BatLoi()
        {
            if ((txt_DangNhap.Text == "") && (txt_MatKhau.Text == ""))
            {
                MessageBox.Show("Không được phép bỏ trống tên đăng nhập và mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MatKhau.Focus();
                txt_DangNhap.Focus();
                return false;
            }
            else if (txt_DangNhap.Text == "")
            {
                MessageBox.Show("Không được phép bỏ trống tên đăng nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DangNhap.Focus();
                return false;
            }
            else if (txt_MatKhau.Text == "")
            {
                MessageBox.Show("Không được phép bỏ trống mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MatKhau.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(BatLoi() == true)
            {
                // xu ly dang nhap
                // MessageBox.Show("Đăng nhập thành công.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                Main f2 = new Main();
                f2.ShowDialog();
            }    
        }
    }
}
