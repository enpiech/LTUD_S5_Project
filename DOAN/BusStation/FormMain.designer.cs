namespace BusStation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuTuyChon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanVe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTinhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.imglMain = new System.Windows.Forms.ImageList(this.components);
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTuyChon,
            this.mnuBanVe,
            this.mnuTinhLuong,
            this.mnuQuanLy});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1005, 30);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "MainMenu";
            // 
            // mnuTuyChon
            // 
            this.mnuTuyChon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnuThoat});
            this.mnuTuyChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTuyChon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mnuTuyChon.Image = ((System.Drawing.Image)(resources.GetObject("mnuTuyChon.Image")));
            this.mnuTuyChon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mnuTuyChon.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuTuyChon.Name = "mnuTuyChon";
            this.mnuTuyChon.Size = new System.Drawing.Size(119, 26);
            this.mnuTuyChon.Text = "Tùy Chọn";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mnuDangXuat.Image")));
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(167, 26);
            this.mnuDangXuat.Text = "Đăng Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(167, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuBanVe
            // 
            this.mnuBanVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBanVe.Image = ((System.Drawing.Image)(resources.GetObject("mnuBanVe.Image")));
            this.mnuBanVe.Name = "mnuBanVe";
            this.mnuBanVe.Size = new System.Drawing.Size(100, 26);
            this.mnuBanVe.Text = "Bán Vé";
            this.mnuBanVe.Click += new System.EventHandler(this.mnuBanVe_Click);
            // 
            // mnuTinhLuong
            // 
            this.mnuTinhLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTinhLuong.Image = ((System.Drawing.Image)(resources.GetObject("mnuTinhLuong.Image")));
            this.mnuTinhLuong.Name = "mnuTinhLuong";
            this.mnuTinhLuong.Size = new System.Drawing.Size(134, 26);
            this.mnuTinhLuong.Text = "Tính Lương";
            this.mnuTinhLuong.Click += new System.EventHandler(this.mnuTinhLuong_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("mnuQuanLy.Image")));
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(109, 26);
            this.mnuQuanLy.Text = "Quản Lý";
            this.mnuQuanLy.Click += new System.EventHandler(this.mnuQuanLy_Click);
            // 
            // imglMain
            // 
            this.imglMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglMain.ImageStream")));
            this.imglMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imglMain.Images.SetKeyName(0, "addmins.jpg");
            this.imglMain.Images.SetKeyName(1, "admin.jpg");
            this.imglMain.Images.SetKeyName(2, "dangNhap.jpg");
            this.imglMain.Images.SetKeyName(3, "dangXuat.png");
            this.imglMain.Images.SetKeyName(4, "dauTich.png");
            this.imglMain.Images.SetKeyName(5, "DauX.png");
            this.imglMain.Images.SetKeyName(6, "luachon.png");
            this.imglMain.Images.SetKeyName(7, "timKiem.png");
            this.imglMain.Images.SetKeyName(8, "user.jpg");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuBanVe;
        private System.Windows.Forms.ToolStripMenuItem mnuTinhLuong;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuTuyChon;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ImageList imglMain;
    }
}