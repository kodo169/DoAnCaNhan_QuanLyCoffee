using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan_QuanLyCoffee.BLL
{
    internal class BLL_ThanhToan
    {
        DAL.DAL_ThanhToan thanhToan = new DAL.DAL_ThanhToan();
        mainFormManager mainFormManager;
        public BLL_ThanhToan(mainFormManager x) 
        {
            mainFormManager = x;
        }

        public void updateStatus(int idTable)
        {
            mainFormManager.listView_hoaDon.Items.Clear();
            thanhToan.updateStatusBill_0(idTable,mainFormManager.dateTimePicker1.Text);
            thanhToan.updateStatusTable_0(idTable);
            mainFormManager.flp_table.Controls.Clear();
            mainFormManager.tb_TongTien.Text = "0";
        }
    }
}
