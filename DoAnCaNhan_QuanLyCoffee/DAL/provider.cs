using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCaNhan_QuanLyCoffee
{
    internal class provider
    {
        String chuoiketnoi = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\vuhuy\\source\\repos\\DoAnCaNhan_QuanLyCoffee\\DoAnCaNhan_QuanLyCoffee\\db_QuanLyQuanCoffee_DoAnCaNhan.mdf";
        SqlConnection connection;
        public provider()
        {
            connection = new SqlConnection(chuoiketnoi);
        }
        public DataTable loadData(String codeSql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(codeSql, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public int ExecuteNonQuery(String codeSql)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(codeSql, connection);
            int ketqua = cmd.ExecuteNonQuery();
            connection.Close();
            return ketqua;
        }
        public Object Scalar(String codeSql)
        {
            SqlCommand sqlCommand = new SqlCommand(codeSql, connection);
            connection.Open();
            object ketqua = sqlCommand.ExecuteScalar();
            connection.Close();
            return ketqua;
        }
    }
}
