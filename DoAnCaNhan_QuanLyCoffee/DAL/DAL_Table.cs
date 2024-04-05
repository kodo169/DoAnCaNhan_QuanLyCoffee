using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DoAnCaNhan_QuanLyCoffee.DAL
{
    internal class DAL_Table
    {
        provider provider = new provider();

        public int load_numberTable()
        {
            String sqlSoLuongBan = "select count(*) from informationTable";
            return (int)provider.Scalar(sqlSoLuongBan);
        }
        public String get_nameTable(int id)
        {
            String sqlNameTable = $"select nameTable from informationTable where idTable ='{id}'";
            return (String)provider.Scalar(sqlNameTable);
        }
        public int get_statusTable(int idtable)
        {
            String sqlCheckStatus = $"Select status from informationTable where idTable='{idtable}'";
            return (int)provider.Scalar(sqlCheckStatus);
        }
        public DataTable load_category()
        {
            String sqlCategory = $"select * from category";
            return (DataTable)provider.loadData(sqlCategory);
        }
        public int get_IdBill(int idTable)
        {
            String sqlGetIDBill = $"select idBill from bill where idTable = '{idTable}' and status =1";
            return (int)provider.Scalar(sqlGetIDBill);
        }
        public DataTable getInforBill(int idBill)
        {
            String sqlGetInforBill = $"select food.nameFood, infoBill.count,food.moneyFood from infoBill,food where infoBill.idBill ='{idBill}'and infoBill.idFood =food.idFood";
            return (DataTable)provider.loadData(sqlGetInforBill);
        }
        public String getNameFood(int idFood)
        {
            String sqlGetNameFood = $"select nameFood from food where idFood = '{idFood}'";
            return (String)provider.Scalar(sqlGetNameFood);
        }
        public int get_StatusTable(int idtable)
        {
            String getStatus = $"select informationTable.status from informationTable, bill  where idTable ='{idtable}' and bill.status = informationTable.status and bill.status = 0";
            return (int)provider.ExecuteNonQuery(getStatus);
        }

        public void updateStatusTable_1(int idTable)
        {
            String sqlUpdateStatus_1 = $"update informationTable set status = 1 where idTable='{idTable}'";
            provider.ExecuteNonQuery(sqlUpdateStatus_1);
        }
        public void updateStatusBill_1(int idTable)
        {
            String sqlUpdateStatus_1 = $"update bill set status = 1 where idTable='{idTable}'";
            provider.ExecuteNonQuery(sqlUpdateStatus_1);
        }

        public DataTable loadFood(int category)
        {
            String sqlFood = $"select * from food where category ='{category}'";
            return (DataTable)provider.loadData(sqlFood);
        }
    }
}
