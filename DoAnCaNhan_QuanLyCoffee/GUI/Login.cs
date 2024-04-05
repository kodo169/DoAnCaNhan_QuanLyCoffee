using DoAnCaNhan_QuanLyCoffee.BLL;
using DoAnCaNhan_QuanLyCoffee.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan_QuanLyCoffee
{
    public partial class Form_Login : Form
    {
        BLL.BLL_DangNhap login ;
        public Form_Login()
        {
            login = new BLL_DangNhap(this);
            InitializeComponent();
            load_Capcha();
        }
        string valueCapcha;
        public void load_Capcha()
        {
            valueCapcha = RandomString(5); 
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height); 
            var font = new Font("yuki.jpg", 25, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel); 
            var graphics = Graphics.FromImage(image); 
            graphics.DrawString(valueCapcha.ToString(), font, Brushes.Black, new PointF(0, 0)); 
            Pen p = new Pen(Brushes.Orange, 3.5f); 
            Random r1 = new Random();
            int count = 0;
            while (count < 20)
            {
                graphics.DrawLine(new Pen(Color.LightPink), r1.Next(0, image.Width), r1.Next(0, image.Height), r1.Next(0, image.Width), r1.Next(0, image.Height));
                count++;
            }
            p.Dispose(); 
            graphics.SmoothingMode = SmoothingMode.AntiAlias; 
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias; 
            this.pictureBox1.Image = image; 
        }

        public string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void link_formDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            dangKy x = new dangKy();
            x.ShowDialog();
            this.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (valueCapcha != tb_capcha.Text)
            {
                MessageBox.Show("Đăng nhập không thành công");
                load_Capcha();
                return;
            }
            if(login.BLL_Login() == true)
            {
                this.Hide();
                mainFormManager x = new mainFormManager();
                x.ShowDialog();
                this.Show();
            }
        }
    }
}
