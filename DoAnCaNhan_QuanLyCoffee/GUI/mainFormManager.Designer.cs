namespace DoAnCaNhan_QuanLyCoffee
{
    partial class mainFormManager
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
            this.panel_manager = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TongTien = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_them = new System.Windows.Forms.NumericUpDown();
            this.btn_themmon = new System.Windows.Forms.Button();
            this.cb_Food = new System.Windows.Forms.ComboBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.listView_hoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flp_table = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xemLịchSửHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_manager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_them)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_manager
            // 
            this.panel_manager.Controls.Add(this.label1);
            this.panel_manager.Controls.Add(this.tb_TongTien);
            this.panel_manager.Controls.Add(this.dateTimePicker1);
            this.panel_manager.Controls.Add(this.numericUpDown_them);
            this.panel_manager.Controls.Add(this.btn_themmon);
            this.panel_manager.Controls.Add(this.cb_Food);
            this.panel_manager.Controls.Add(this.cb_category);
            this.panel_manager.Controls.Add(this.btn_thanhtoan);
            this.panel_manager.Controls.Add(this.listView_hoaDon);
            this.panel_manager.Controls.Add(this.flp_table);
            this.panel_manager.Controls.Add(this.menuStrip1);
            this.panel_manager.Location = new System.Drawing.Point(-4, -2);
            this.panel_manager.Name = "panel_manager";
            this.panel_manager.Size = new System.Drawing.Size(1023, 450);
            this.panel_manager.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(765, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng Tiền";
            // 
            // tb_TongTien
            // 
            this.tb_TongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TongTien.Location = new System.Drawing.Point(730, 403);
            this.tb_TongTien.Multiline = true;
            this.tb_TongTien.Name = "tb_TongTien";
            this.tb_TongTien.ReadOnly = true;
            this.tb_TongTien.Size = new System.Drawing.Size(144, 33);
            this.tb_TongTien.TabIndex = 8;
            this.tb_TongTien.Text = "0";
            this.tb_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy   hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(496, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // numericUpDown_them
            // 
            this.numericUpDown_them.Location = new System.Drawing.Point(962, 55);
            this.numericUpDown_them.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_them.Name = "numericUpDown_them";
            this.numericUpDown_them.Size = new System.Drawing.Size(50, 22);
            this.numericUpDown_them.TabIndex = 6;
            this.numericUpDown_them.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_themmon
            // 
            this.btn_themmon.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themmon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_themmon.Location = new System.Drawing.Point(880, 41);
            this.btn_themmon.Name = "btn_themmon";
            this.btn_themmon.Size = new System.Drawing.Size(75, 54);
            this.btn_themmon.TabIndex = 5;
            this.btn_themmon.Text = "Thêm Món";
            this.btn_themmon.UseVisualStyleBackColor = true;
            this.btn_themmon.Click += new System.EventHandler(this.btn_themmon_Click);
            // 
            // cb_Food
            // 
            this.cb_Food.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Food.FormattingEnabled = true;
            this.cb_Food.Location = new System.Drawing.Point(704, 71);
            this.cb_Food.Name = "cb_Food";
            this.cb_Food.Size = new System.Drawing.Size(170, 24);
            this.cb_Food.TabIndex = 4;
            // 
            // cb_category
            // 
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(704, 41);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(170, 24);
            this.cb_category.TabIndex = 3;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_thanhtoan.Location = new System.Drawing.Point(880, 381);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(132, 58);
            this.btn_thanhtoan.TabIndex = 2;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // listView_hoaDon
            // 
            this.listView_hoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_hoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_hoaDon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView_hoaDon.HideSelection = false;
            this.listView_hoaDon.Location = new System.Drawing.Point(496, 101);
            this.listView_hoaDon.Name = "listView_hoaDon";
            this.listView_hoaDon.Size = new System.Drawing.Size(516, 274);
            this.listView_hoaDon.TabIndex = 1;
            this.listView_hoaDon.UseCompatibleStateImageBehavior = false;
            this.listView_hoaDon.View = System.Windows.Forms.View.Details;
            this.listView_hoaDon.SelectedIndexChanged += new System.EventHandler(this.listView_hoaDon_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 140;
            // 
            // flp_table
            // 
            this.flp_table.AllowDrop = true;
            this.flp_table.AutoScroll = true;
            this.flp_table.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_table.ForeColor = System.Drawing.SystemColors.WindowText;
            this.flp_table.Location = new System.Drawing.Point(3, 41);
            this.flp_table.Name = "flp_table";
            this.flp_table.Size = new System.Drawing.Size(487, 399);
            this.flp_table.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemLịchSửHóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1023, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xemLịchSửHóaĐơnToolStripMenuItem
            // 
            this.xemLịchSửHóaĐơnToolStripMenuItem.Name = "xemLịchSửHóaĐơnToolStripMenuItem";
            this.xemLịchSửHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.xemLịchSửHóaĐơnToolStripMenuItem.Text = "Xem Lịch sử Hóa Đơn";
            this.xemLịchSửHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xemLịchSửHóaĐơnToolStripMenuItem_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Xóa";
            // 
            // mainFormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.panel_manager);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainFormManager";
            this.Text = "mainFormManager";
            this.panel_manager.ResumeLayout(false);
            this.panel_manager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_them)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_manager;
        private System.Windows.Forms.Button btn_thanhtoan;
        public System.Windows.Forms.ListView listView_hoaDon;
        public System.Windows.Forms.FlowLayoutPanel flp_table;
        public System.Windows.Forms.NumericUpDown numericUpDown_them;
        private System.Windows.Forms.Button btn_themmon;
        public System.Windows.Forms.ComboBox cb_Food;
        public System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox tb_TongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemLịchSửHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}