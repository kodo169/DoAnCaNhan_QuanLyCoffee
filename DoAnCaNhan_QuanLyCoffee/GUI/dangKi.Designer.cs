namespace DoAnCaNhan_QuanLyCoffee.GUI
{
    partial class dangKy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Dangky = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_confirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // btn_Dangky
            // 
            this.btn_Dangky.Location = new System.Drawing.Point(249, 247);
            this.btn_Dangky.Name = "btn_Dangky";
            this.btn_Dangky.Size = new System.Drawing.Size(114, 39);
            this.btn_Dangky.TabIndex = 3;
            this.btn_Dangky.Text = "Đăng Ký";
            this.btn_Dangky.UseVisualStyleBackColor = true;
            this.btn_Dangky.Click += new System.EventHandler(this.btn_Dangky_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(421, 247);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(114, 39);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(266, 68);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(269, 22);
            this.tb_account.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(266, 119);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(269, 22);
            this.tb_password.TabIndex = 6;
            // 
            // tb_confirmPassword
            // 
            this.tb_confirmPassword.Location = new System.Drawing.Point(266, 176);
            this.tb_confirmPassword.Name = "tb_confirmPassword";
            this.tb_confirmPassword.Size = new System.Drawing.Size(269, 22);
            this.tb_confirmPassword.TabIndex = 7;
            // 
            // dangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 326);
            this.Controls.Add(this.tb_confirmPassword);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Dangky);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dangKy";
            this.Text = "Đăng Ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Dangky;
        private System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.TextBox tb_account;
        public System.Windows.Forms.TextBox tb_password;
        public System.Windows.Forms.TextBox tb_confirmPassword;
    }
}