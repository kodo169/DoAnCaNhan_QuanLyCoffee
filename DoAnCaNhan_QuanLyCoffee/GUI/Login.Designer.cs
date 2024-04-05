namespace DoAnCaNhan_QuanLyCoffee
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.panel_Login = new System.Windows.Forms.Panel();
            this.link_formDK = new System.Windows.Forms.LinkLabel();
            this.tb_capcha = new System.Windows.Forms.TextBox();
            this.lb_capcha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_nameAcc = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.lb_NameAccount = new System.Windows.Forms.Label();
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panel_Login.Controls.Add(this.link_formDK);
            this.panel_Login.Controls.Add(this.tb_capcha);
            this.panel_Login.Controls.Add(this.lb_capcha);
            this.panel_Login.Controls.Add(this.pictureBox1);
            this.panel_Login.Controls.Add(this.btn_Exit);
            this.panel_Login.Controls.Add(this.btn_login);
            this.panel_Login.Controls.Add(this.tb_password);
            this.panel_Login.Controls.Add(this.tb_nameAcc);
            this.panel_Login.Controls.Add(this.label_password);
            this.panel_Login.Controls.Add(this.lb_NameAccount);
            this.panel_Login.Location = new System.Drawing.Point(0, 0);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(795, 450);
            this.panel_Login.TabIndex = 0;
            // 
            // link_formDK
            // 
            this.link_formDK.AutoSize = true;
            this.link_formDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_formDK.LinkColor = System.Drawing.Color.Black;
            this.link_formDK.Location = new System.Drawing.Point(182, 328);
            this.link_formDK.Name = "link_formDK";
            this.link_formDK.Size = new System.Drawing.Size(396, 29);
            this.link_formDK.TabIndex = 7;
            this.link_formDK.TabStop = true;
            this.link_formDK.Text = "Nếu chưa có tài khoản nhấp vào đây";
            this.link_formDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_formDK_LinkClicked);
            // 
            // tb_capcha
            // 
            this.tb_capcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_capcha.Location = new System.Drawing.Point(226, 187);
            this.tb_capcha.Multiline = true;
            this.tb_capcha.Name = "tb_capcha";
            this.tb_capcha.Size = new System.Drawing.Size(146, 36);
            this.tb_capcha.TabIndex = 6;
            // 
            // lb_capcha
            // 
            this.lb_capcha.AutoSize = true;
            this.lb_capcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_capcha.Location = new System.Drawing.Point(73, 194);
            this.lb_capcha.Name = "lb_capcha";
            this.lb_capcha.Size = new System.Drawing.Size(101, 29);
            this.lb_capcha.TabIndex = 5;
            this.lb_capcha.Text = "Capcha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(394, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(598, 261);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(151, 49);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "THOÁT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(313, 261);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(151, 49);
            this.btn_login.TabIndex = 0;
            this.btn_login.Tag = "0";
            this.btn_login.Text = "Đăng Nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(226, 112);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(523, 36);
            this.tb_password.TabIndex = 1;
            this.tb_password.Text = "Kodo@169";
            // 
            // tb_nameAcc
            // 
            this.tb_nameAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nameAcc.Location = new System.Drawing.Point(226, 55);
            this.tb_nameAcc.Name = "tb_nameAcc";
            this.tb_nameAcc.Size = new System.Drawing.Size(523, 34);
            this.tb_nameAcc.TabIndex = 0;
            this.tb_nameAcc.TabStop = false;
            this.tb_nameAcc.Text = "Kodokuna";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(73, 119);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(121, 29);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Mật Khẩu";
            // 
            // lb_NameAccount
            // 
            this.lb_NameAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameAccount.Location = new System.Drawing.Point(73, 55);
            this.lb_NameAccount.Name = "lb_NameAccount";
            this.lb_NameAccount.Size = new System.Drawing.Size(153, 44);
            this.lb_NameAccount.TabIndex = 0;
            this.lb_NameAccount.Text = "Tài Khoản";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Login);
            this.Name = "Form_Login";
            this.Text = " ";
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Login;
        public System.Windows.Forms.TextBox tb_password;
        public System.Windows.Forms.TextBox tb_nameAcc;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label lb_NameAccount;
        private System.Windows.Forms.Label lb_capcha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_capcha;
        private System.Windows.Forms.LinkLabel link_formDK;
    }
}

