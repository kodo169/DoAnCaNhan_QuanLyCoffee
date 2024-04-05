using DoAnCaNhan_QuanLyCoffee.DAL;
using DoAnCaNhan_QuanLyCoffee.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan_QuanLyCoffee.BLL
{
    internal class BLL_table
    {
        DAL.DAL_Table DAL_Table = new DAL.DAL_Table();
        mainFormManager mainFormManager;
        public BLL_table(mainFormManager x) 
        {
            mainFormManager = x;
        }
        public int load_Numbertable()
        {
            return DAL_Table.load_numberTable();
        }
        public String get_nameTable(int id)
        {
            return DAL_Table.get_nameTable(id);
        }

        public int get_statustable(int id) 
        {
            return DAL_Table.get_statusTable(id);
        }

        public void load_food()
        {
            mainFormManager.cb_Food.DisplayMember = "nameFood";
            mainFormManager.cb_Food.ValueMember = "idFood";
            mainFormManager.cb_Food.DataSource = DAL_Table.loadFood((int)mainFormManager.cb_category.SelectedValue);
        }
        public void load_category()
        {
            mainFormManager.cb_category.DisplayMember = "nameCategory";
            mainFormManager.cb_category.ValueMember = "maFoodCategory";
            mainFormManager.cb_category.DataSource = DAL_Table.load_category();
        }
        public bool checkStatus(int idTable)
        {
            if(DAL_Table.get_statusTable(idTable) == 0)
            {
                return false;
            }
            return true;
        }
        public int load_BillTable(int idTable)
        {
            int tongTien = 0;
            mainFormManager.listView_hoaDon.Items.Clear();
            int idBill = DAL_Table.get_IdBill(idTable);
            DataTable data = DAL_Table.getInforBill(idBill);
            foreach (DataRow row in data.Rows)
            {
                String nameFood = (String)row["nameFood"];
                int count = (int)row["count"];
                int money = (int)row["moneyFood"];
                int thanhTien = money * count;
                tongTien += thanhTien;
                ListViewItem item = new ListViewItem(nameFood);
                item.SubItems.Add(row["count"].ToString());
                item.SubItems.Add(money.ToString());
                item.SubItems.Add(thanhTien.ToString());
                mainFormManager.listView_hoaDon.Items.Add(item);
            }
            return tongTien;
        }
        
    }
}
