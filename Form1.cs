using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chsarp_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "admin" && txtmatkhau.Text == "5743") 
            {
                this.Hide();
                FrmMain frmMain = new FrmMain(); 
                frmMain.ShowDialog();
                this.Close();
            } 
           else
            {
                MessageBox.Show("vui lòng nhập mât khẩu và tài khoản", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.None);
            }    
        }
    }
}
