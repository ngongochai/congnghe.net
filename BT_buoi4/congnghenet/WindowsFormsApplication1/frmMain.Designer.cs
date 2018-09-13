namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.quảnLýNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguoiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themNguoiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phanquyenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNgườiDùngToolStripMenuItem,
            this.nhânSựToolStripMenuItem,
            this.chấmCôngToolStripMenuItem,
            this.tínhLươngToolStripMenuItem,
            this.phanquyenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            this.quảnLýNgườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguoiDungToolStripMenuItem,
            this.themNguoiDungToolStripMenuItem});
            this.quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            this.quảnLýNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý người dùng";
            // 
            // nguoiDungToolStripMenuItem
            // 
            this.nguoiDungToolStripMenuItem.Name = "nguoiDungToolStripMenuItem";
            this.nguoiDungToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nguoiDungToolStripMenuItem.Text = "Nguoi Dung";
            this.nguoiDungToolStripMenuItem.Click += new System.EventHandler(this.nguoiDungToolStripMenuItem_Click);
            // 
            // themNguoiDungToolStripMenuItem
            // 
            this.themNguoiDungToolStripMenuItem.Name = "themNguoiDungToolStripMenuItem";
            this.themNguoiDungToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.themNguoiDungToolStripMenuItem.Text = "Them Nguoi Dung";
            this.themNguoiDungToolStripMenuItem.Click += new System.EventHandler(this.themNguoiDungToolStripMenuItem_Click);
            // 
            // nhânSựToolStripMenuItem
            // 
            this.nhânSựToolStripMenuItem.Name = "nhânSựToolStripMenuItem";
            this.nhânSựToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.nhânSựToolStripMenuItem.Text = "Nhân sự";
            // 
            // chấmCôngToolStripMenuItem
            // 
            this.chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            this.chấmCôngToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.chấmCôngToolStripMenuItem.Text = "Chấm công";
            // 
            // tínhLươngToolStripMenuItem
            // 
            this.tínhLươngToolStripMenuItem.Name = "tínhLươngToolStripMenuItem";
            this.tínhLươngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.tínhLươngToolStripMenuItem.Text = "Tính lương";
            // 
            // phanquyenToolStripMenuItem
            // 
            this.phanquyenToolStripMenuItem.Name = "phanquyenToolStripMenuItem";
            this.phanquyenToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.phanquyenToolStripMenuItem.Text = "Phân Quyền";
            this.phanquyenToolStripMenuItem.Click += new System.EventHandler(this.phanquyenToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 300);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguoiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themNguoiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phanquyenToolStripMenuItem;
    }
}