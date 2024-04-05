using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCaNhan_QuanLyCoffee.DAL
{
    internal class DAL_HistoryBill
    {
        provider provider = new provider();

        public DataTable getNumberBill()
        {
            String sqlGetNumberBill = $"select * from bill where status = 0";
            return (DataTable)provider.loadData(sqlGetNumberBill);
        }
        public DataTable getInfoBill(int idTable)
        {
            String sqlGetInfoBill = $"select informationTable.nameTable, bill.dateCheckIn, bill.dateCheckout from bill, informationTable where bill.idTable = informationTable.idTable and bill.idTable ='{idTable}'";
            return (DataTable)provider.loadData(sqlGetInfoBill);
        }
        public int getIDtable(int idBill)
        {
            String sqlGetIdTable = $"select idTable from bill where idBill ='{idBill}'";
            return (int)provider.Scalar(sqlGetIdTable);
        }
    }
}
