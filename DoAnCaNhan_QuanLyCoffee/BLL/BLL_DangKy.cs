using DoAnCaNhan_QuanLyCoffee.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan_QuanLyCoffee.BLL
{
    internal class BLL_DangKy
    {
        DAL.DAL_DangKy dal_dangKy = new DAL.DAL_DangKy();
        dangKy dangKy;
        public BLL_DangKy(dangKy x)
        {
            dangKy = x;
        }
        public int check()
        {
            if (dal_dangKy.get_acc(dangKy.tb_account.Text) >= 1)
            {
                return 1;
            }
            if (dangKy.tb_password.Text != dangKy.tb_confirmPassword.Text)
            {
                return 2 ;
            }
            return 0;
        }
        public void fuc_dangky()
        {
            if(check() == 1)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }
            else if(check() == 2)
            {
                MessageBox.Show("Mật khẩu không giống nhau");
                return;
            }
            else
            {
                dal_dangKy.update_newAcc(dangKy.tb_account.Text, dangKy.tb_password.Text);
                MessageBox.Show("Đăng Ký thành công");
            }
        }
    }
}
