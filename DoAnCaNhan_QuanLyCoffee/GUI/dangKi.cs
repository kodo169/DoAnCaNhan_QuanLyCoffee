using DoAnCaNhan_QuanLyCoffee.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan_QuanLyCoffee.GUI
{
    public partial class dangKy : Form
    {
        public dangKy()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            BLL_DangKy x = new BLL_DangKy(this);
            x.fuc_dangky();
        }
    }
}
