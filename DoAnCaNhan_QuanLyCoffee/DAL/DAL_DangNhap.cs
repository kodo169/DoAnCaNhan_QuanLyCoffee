using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCaNhan_QuanLyCoffee.DAL
{
    internal class DAL_DangNhap
    {
        provider provider = new provider();
        public int DAL_Login(String nameAcc, String password)
        {
            String sqlLogin = $"select count(*) from dataLogin where account = '{nameAcc}' and password='{password}'";
            return (int)provider.Scalar(sqlLogin);
        }
        public int Check_DAL_login(String nameAcc)
        {
            String sqlCheck = $"select checkLogin from dataLogin where account = '{nameAcc}'";
            return (int)provider.Scalar(sqlCheck);
        }

        public void updateCheck(String nameAcc)
        {
            String sqlreturnCheckLogin = $"update dataLogin set checkLogin = 4 where account ='{nameAcc}'";
            provider.ExecuteNonQuery(sqlreturnCheckLogin);
        }

        public void reduceCheck(String nameAcc)
        {
            String sqlUpdateCheckLogin = $"Update dataLogin set checkLogin = checkLogin-1 where account ='{nameAcc}'";
            provider.ExecuteNonQuery(sqlUpdateCheckLogin);
        }

    }
}
