using DoAnCaNhan_QuanLyCoffee.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan_QuanLyCoffee.BLL
{
    internal class BLL_DangNhap
    {
        DAL_DangNhap login = new DAL_DangNhap();
        Form_Login fLogin;
        public BLL_DangNhap(Form_Login x)
        {
            fLogin = x;
        }
        public bool BLL_Login()
        {
            int ketqua = login.DAL_Login(fLogin.tb_nameAcc.Text, fLogin.tb_password.Text);
            int check = login.Check_DAL_login(fLogin.tb_nameAcc.Text);
            if (ketqua == 0 && check == 0)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                return false;
            }
            if (check == 1)
            {
                MessageBox.Show("Tài khoản đã bị logal ban!");
                return false;
            }
            if( ketqua > 0)
            {
                login.updateCheck(fLogin.tb_nameAcc.Text);
                return true;
            }
            else
            {
                login.reduceCheck(fLogin.tb_nameAcc.Text);
                MessageBox.Show($"Tài khoản còn {login.Check_DAL_login(fLogin.tb_nameAcc.Text)} đăng nhập");
                return false;
            }
        }
    }
}
