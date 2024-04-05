using DoAnCaNhan_QuanLyCoffee.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan_QuanLyCoffee
{
    public partial class mainFormManager : Form
    {
        int idBill = 1;
        int idThanhToan = 1;
        BLL.BLL_table table ;
        public mainFormManager()
        {
            table = new BLL.BLL_table(this);
            InitializeComponent();
            load_Table();
            load_FoodCategory();
        }

        public void load_FoodCategory()
        {
            table.load_category();
            cb_category.SelectedIndexChanged += cb_category_SelectedIndexChanged;
            load_Food();
        }

        public void load_foodBillTable(int idTable)
        {
            int tongtien =table.load_BillTable(idTable);
            tb_TongTien.Text = tongtien.ToString();
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_Food();
        }
        public void load_Food()
        {
            table.load_food();
        }
        int tableAddFood = 0;
        public void load_Table()
        {
            int soLuongBan = table.load_Numbertable();
            for (int i = 1 ; i<= soLuongBan; i++)
            {
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 100;
                btn.Text =table.get_nameTable(i);
                int status = table.get_statustable(i);
                flp_table.Controls.Add(btn);
                if(status == 1 )
                {
                    btn.BackColor = Color.Pink;
                }
                else btn.BackColor = Color.Aquamarine;
                btn.Tag = i;
                btn.Click += (s, e) =>
                {
                    load_FoodCategory();
                    tableAddFood =(int)btn.Tag;
                    if (table.checkStatus(tableAddFood) == false)
                    {
                        listView_hoaDon.Items.Clear();
                        return;
                    }
                    else
                    {
                        load_foodBillTable(tableAddFood);
                    }

                };
            }
            
        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            BLL.BLL_ThemMon themMon = new BLL_ThemMon(this);
            themMon.themMon(tableAddFood);
            flp_table.Controls.Clear();
            load_Table();
            listView_hoaDon.Controls.Clear();
            load_foodBillTable(tableAddFood);
        }
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            BLL_ThanhToan thanhtoan = new BLL_ThanhToan(this);
            thanhtoan.updateStatus(tableAddFood);
            load_Table();
        }

        private void xemLịchSửHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billThanhToan showAllBill = new billThanhToan();
            this.Hide();
            showAllBill.ShowDialog();
            this.Show();
        }

        private void listView_hoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
