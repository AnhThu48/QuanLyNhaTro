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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            // chuyen qua man hinh Login
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
        }

        private void btnPT_Click(object sender, EventArgs e)
        {
            // chuyen qua man hinh PhongTro
            this.Hide();
            PhongTro fPT = new PhongTro();
            fPT.ShowDialog();
        }
    }
}
