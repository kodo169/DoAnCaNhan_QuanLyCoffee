using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCaNhan_QuanLyCoffee.DAL
{
    internal class DAL_DangKy
    {
        provider provider = new provider();
        public void update_newAcc(String acc, String pass)
        {
            String sqlupdateAcc = $"insert into dataLogin(account,password,checkLogin) values ('{acc}','{pass}',4)";
            provider.ExecuteNonQuery(sqlupdateAcc);
        }
        public int get_acc(String acc) 
        {
            String sqlGetAcc =$"select count(*) from dataLogin where account = '{acc}'";
            return (int)provider.Scalar(sqlGetAcc);
        }
    }
}
