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

namespace DoAnCaNhan_QuanLyCoffee
{
    public partial class billThanhToan : Form
    {
        BLL_HistoryBill historyBill;
        public billThanhToan()
        {
            historyBill = new BLL_HistoryBill(this);
            InitializeComponent();
            load_numberBill();
            load_Bill();
        }
        public void load_numberBill()
        {
            historyBill.load_numberBill();
        }
        public void load_Bill()
        {
            listView_hoadon.Items.Clear();
            int tongTien =  historyBill.load_Bill();
            tb_Tongtien.Text = tongTien.ToString();
        }

        private void cb_SoHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_Bill();
        }
    }
}
