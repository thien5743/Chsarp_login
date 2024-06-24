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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ltbketqua.Items.Clear();
            int b;
            b= Int32.Parse(txtnhapso.Text);
            for (int i = 1; i <= b; i++)
            {
                if ( b%i==0)
                {
                    ltbketqua.Items.Add(i).ToString();
                }    
            }
            

              
        }
    }
}
