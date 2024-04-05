using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan_QuanLyCoffee.BLL
{
    internal class BLL_ThemMon
    {
        DAL.DAL_themMon ThemMon = new DAL.DAL_themMon();
        mainFormManager mainFormManager;
        public BLL_ThemMon(mainFormManager x) 
        {
            mainFormManager = x;
        }
        public void themMon(int idTable)
        {
            int idBill = 1;
            int checkStatusTable = ThemMon.get_statusTable(idTable);
            if (checkStatusTable == 0)
            {
                ThemMon.updateStatusTable(idTable);
                ThemMon.addBill(mainFormManager.dateTimePicker1.Text, idTable);
                idBill = ThemMon.getIdBill(idTable);
            }
            
            idBill = ThemMon.getIDBill(idTable);
            ThemMon.updateFoodToBill(idBill,(int) mainFormManager.cb_Food.SelectedValue, (int)mainFormManager.numericUpDown_them.Value);
        }
    }
}
