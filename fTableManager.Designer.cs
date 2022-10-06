namespace QuanLyQuanAn
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnPayout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBill = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbFoods = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbSwitchTable);
            this.panel2.Controls.Add(this.btnSwitchTable);
            this.panel2.Controls.Add(this.nmDiscount);
            this.panel2.Controls.Add(this.btnDiscount);
            this.panel2.Controls.Add(this.btnPayout);
            this.panel2.Location = new System.Drawing.Point(656, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 59);
            this.panel2.TabIndex = 2;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(0, 31);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(110, 24);
            this.cbSwitchTable.TabIndex = 7;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(0, 3);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(110, 27);
            this.btnSwitchTable.TabIndex = 6;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(276, 36);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(110, 22);
            this.nmDiscount.TabIndex = 5;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmDiscount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(276, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(110, 27);
            this.btnDiscount.TabIndex = 4;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnPayout
            // 
            this.btnPayout.Location = new System.Drawing.Point(538, 3);
            this.btnPayout.Name = "btnPayout";
            this.btnPayout.Size = new System.Drawing.Size(110, 53);
            this.btnPayout.TabIndex = 3;
            this.btnPayout.Text = "Thanh toán";
            this.btnPayout.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBill);
            this.panel3.Location = new System.Drawing.Point(656, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 386);
            this.panel3.TabIndex = 3;
            // 
            // listBill
            // 
            this.listBill.HideSelection = false;
            this.listBill.Location = new System.Drawing.Point(0, 3);
            this.listBill.Name = "listBill";
            this.listBill.Size = new System.Drawing.Size(648, 380);
            this.listBill.TabIndex = 0;
            this.listBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.cbFoods);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(659, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(648, 65);
            this.panel4.TabIndex = 4;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(389, 20);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(93, 22);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(263, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(110, 54);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // cbFoods
            // 
            this.cbFoods.FormattingEnabled = true;
            this.cbFoods.Location = new System.Drawing.Point(3, 33);
            this.cbFoods.Name = "cbFoods";
            this.cbFoods.Size = new System.Drawing.Size(254, 24);
            this.cbFoods.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(254, 24);
            this.cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(12, 34);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(638, 519);
            this.flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 565);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán ăn";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbFoods;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnPayout;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
    }
}