using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan_QuanLyCoffee.DAL
{
    internal class DAL_themMon
    {
        provider provider = new provider(); 
        public int get_statusTable(int idtable)
        {
            String sqlCheckStatus = $"Select status from informationTable where idTable='{idtable}'";
            return (int)provider.Scalar(sqlCheckStatus);
        }

        public void updateStatusTable(int idTable)
        {
            String sqlSettingStatusBill = $"update informationTable set status = 1 WHERE idTable = '{idTable}'";
            provider.ExecuteNonQuery(sqlSettingStatusBill);
        }

        public void addBill(String date, int idtable)
        {
            String sqlAddBill = $"insert into bill (dateCheckIn,dateCheckout,idTable,status) values ('{date}',NULL,'{idtable}','1')";
            provider.ExecuteNonQuery(sqlAddBill);
        }

        public int getIdBill(int idTable)
        {
            String sqlGetIDBillFromBill = $"select idBill from bill where idTable = '{idTable}' and status = 1";
            return (int)provider.Scalar(sqlGetIDBillFromBill);
        }
        public int getIDBill(int idTable)
        {
            String sqlIDBill = $"select idBill from bill where  idTable= '{idTable}' and status = 1";
            return (int)provider.Scalar(sqlIDBill);
        }
        public void updateFoodToBill(int idBill, int idFood, int count)
        {
            String sqlAddFoodTable = $"insert into infoBill (idBill,idFood,count) values ('{idBill}','{idFood}','{count}')";
            provider.ExecuteNonQuery(sqlAddFoodTable);
        }
    }
}
