using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCaNhan_QuanLyCoffee.DAL
{
    internal class DAL_ThanhToan
    {
        provider provider = new provider();

        public void updateStatusBill_0(int idTable, String dateCheckOut)
        {
            String sqlUpdateStatusThanhToan = $"update bill set status = 0, dateCheckout ='{dateCheckOut}' where idTable = '{idTable}'  and status = 1";
            provider.ExecuteNonQuery(sqlUpdateStatusThanhToan);
        }

        public void updateStatusTable_0(int idTable)
        {
            String sqlUpdateStatusTable = $"update informationTable set status = 0 where idTable = '{idTable}'";
            provider.ExecuteNonQuery(sqlUpdateStatusTable);
        }
    }
}
