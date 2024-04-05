using DoAnCaNhan_QuanLyCoffee.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan_QuanLyCoffee.BLL
{
    internal class BLL_HistoryBill
    {
        DAL.DAL_HistoryBill historyBill = new DAL.DAL_HistoryBill();
        billThanhToan billThanhToan;
        public BLL_HistoryBill(billThanhToan x) 
        {
            billThanhToan = x;
        }

        public void load_numberBill()
        {
            DataTable data = historyBill.getNumberBill();
            billThanhToan.cb_SoHoaDon.DisplayMember = "idBill";
            billThanhToan.cb_SoHoaDon.ValueMember = "idBill";
            billThanhToan.cb_SoHoaDon.DataSource = data;
        }

        public int load_Bill()
        {
            int idTable = historyBill.getIDtable((int)billThanhToan.cb_SoHoaDon.SelectedValue);
            DataTable datainfo = historyBill.getInfoBill(idTable);
            foreach (DataRow row in datainfo.Rows)
            {
                String nameFood = (String)row["nameTable"];
                billThanhToan.tb_ban.Text = nameFood;
                String dateCheckIn = (String)row["dateCheckIn"].ToString();
                billThanhToan.tb_checkin.Text = dateCheckIn;
                String dateCheckOut = (String)row["dateCheckout"].ToString();
                billThanhToan.tb_checkout.Text = dateCheckOut;
            }

            DAL.DAL_Table dAL_Table = new DAL.DAL_Table();
            int tongtien = 0;
            billThanhToan.listView_hoadon.Items.Clear();
            DataTable data = dAL_Table.getInforBill((int)billThanhToan.cb_SoHoaDon.SelectedValue);
            foreach (DataRow row in data.Rows)
            {
                String nameFood = (String)row["nameFood"];
                int count = (int)row["count"];
                int money = (int)row["moneyFood"];
                int thanhTien = money * count;
                tongtien += thanhTien;
                ListViewItem item = new ListViewItem(nameFood);
                item.SubItems.Add(row["count"].ToString());
                item.SubItems.Add(money.ToString());
                item.SubItems.Add(thanhTien.ToString());
                billThanhToan.listView_hoadon.Items.Add(item);
            }
            return tongtien;
        }
    }
}
