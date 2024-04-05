namespace DoAnCaNhan_QuanLyCoffee
{
    partial class billThanhToan
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
            this.cb_SoHoaDon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_hoadon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Tongtien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ban = new System.Windows.Forms.TextBox();
            this.tb_checkin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_checkout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_SoHoaDon
            // 
            this.cb_SoHoaDon.DropDownHeight = 100;
            this.cb_SoHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SoHoaDon.FormattingEnabled = true;
            this.cb_SoHoaDon.IntegralHeight = false;
            this.cb_SoHoaDon.Location = new System.Drawing.Point(427, 36);
            this.cb_SoHoaDon.Name = "cb_SoHoaDon";
            this.cb_SoHoaDon.Size = new System.Drawing.Size(185, 24);
            this.cb_SoHoaDon.TabIndex = 0;
            this.cb_SoHoaDon.SelectedIndexChanged += new System.EventHandler(this.cb_SoHoaDon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số Hóa Đơn";
            // 
            // listView_hoadon
            // 
            this.listView_hoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_hoadon.HideSelection = false;
            this.listView_hoadon.Location = new System.Drawing.Point(39, 95);
            this.listView_hoadon.Name = "listView_hoadon";
            this.listView_hoadon.Size = new System.Drawing.Size(754, 280);
            this.listView_hoadon.TabIndex = 2;
            this.listView_hoadon.UseCompatibleStateImageBehavior = false;
            this.listView_hoadon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Món";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 200;
            // 
            // tb_Tongtien
            // 
            this.tb_Tongtien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Tongtien.Location = new System.Drawing.Point(445, 381);
            this.tb_Tongtien.Multiline = true;
            this.tb_Tongtien.Name = "tb_Tongtien";
            this.tb_Tongtien.Size = new System.Drawing.Size(343, 43);
            this.tb_Tongtien.TabIndex = 3;
            this.tb_Tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng Tiền";
            // 
            // tb_ban
            // 
            this.tb_ban.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ban.Location = new System.Drawing.Point(39, 59);
            this.tb_ban.Name = "tb_ban";
            this.tb_ban.Size = new System.Drawing.Size(85, 30);
            this.tb_ban.TabIndex = 5;
            // 
            // tb_checkin
            // 
            this.tb_checkin.Location = new System.Drawing.Point(272, 67);
            this.tb_checkin.Name = "tb_checkin";
            this.tb_checkin.Size = new System.Drawing.Size(176, 22);
            this.tb_checkin.TabIndex = 6;
            this.tb_checkin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thời gian vào";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thời gian ra";
            // 
            // tb_checkout
            // 
            this.tb_checkout.Location = new System.Drawing.Point(593, 67);
            this.tb_checkout.Name = "tb_checkout";
            this.tb_checkout.Size = new System.Drawing.Size(200, 22);
            this.tb_checkout.TabIndex = 8;
            this.tb_checkout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // billThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_checkout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_checkin);
            this.Controls.Add(this.tb_ban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Tongtien);
            this.Controls.Add(this.listView_hoadon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_SoHoaDon);
            this.Name = "billThanhToan";
            this.Text = "billThanhToan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cb_SoHoaDon;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listView_hoadon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tb_Tongtien;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_ban;
        public System.Windows.Forms.TextBox tb_checkin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_checkout;
    }
}