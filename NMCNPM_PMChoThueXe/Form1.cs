using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_PMChoThueXe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenTaiKhoan.Text;
            string password = txtMatKhau.Text;
            if (username == "dongluu" && password == "nhom7")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

            }
            else
            {
                // neu dang nhap dong dung thi xoa txt de nhap lai
                txtTenTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
