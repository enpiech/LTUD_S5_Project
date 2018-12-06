namespace BusStation
{
    partial class frmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            this.lblTenBang = new System.Windows.Forms.Label();
            this.cboTenBang = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.imglQuanLy = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblTenBang
            // 
            this.lblTenBang.AutoSize = true;
            this.lblTenBang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBang.ForeColor = System.Drawing.Color.Red;
            this.lblTenBang.Location = new System.Drawing.Point(21, 114);
            this.lblTenBang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenBang.Name = "lblTenBang";
            this.lblTenBang.Size = new System.Drawing.Size(147, 22);
            this.lblTenBang.TabIndex = 1;
            this.lblTenBang.Text = "Tên bảng dữ liệu";
            this.lblTenBang.Click += new System.EventHandler(this.lblTenBang_Click);
            // 
            // cboTenBang
            // 
            this.cboTenBang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenBang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenBang.FormattingEnabled = true;
            this.cboTenBang.Items.AddRange(new object[] {
            "Loại Xe",
            "Hãng Xe",
            "Xe",
            "Khách Hàng",
            "Loại Nhân Viên",
            "Nhân Viên",
            "Tài Khoản Nhân Viên"});
            this.cboTenBang.Location = new System.Drawing.Point(172, 111);
            this.cboTenBang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTenBang.Name = "cboTenBang";
            this.cboTenBang.Size = new System.Drawing.Size(197, 30);
            this.cboTenBang.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(68, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Vui Lòng Chọn Bảng Dữ Liệu";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Red;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.ImageKey = "dauTich.png";
            this.btnSelect.ImageList = this.imglQuanLy;
            this.btnSelect.Location = new System.Drawing.Point(388, 106);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(101, 38);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.ImageKey = "dangXuat.jpg";
            this.btnThoat.ImageList = this.imglQuanLy;
            this.btnThoat.Location = new System.Drawing.Point(198, 188);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 30);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // imglQuanLy
            // 
            this.imglQuanLy.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglQuanLy.ImageStream")));
            this.imglQuanLy.TransparentColor = System.Drawing.Color.Transparent;
            this.imglQuanLy.Images.SetKeyName(0, "addmins.jpg");
            this.imglQuanLy.Images.SetKeyName(1, "admin.jpg");
            this.imglQuanLy.Images.SetKeyName(2, "arrow-sign-rotation-icon-reload-button-refresh-vector-12935532.jpg");
            this.imglQuanLy.Images.SetKeyName(3, "dangNhap.jpg");
            this.imglQuanLy.Images.SetKeyName(4, "dangXuat.jpg");
            this.imglQuanLy.Images.SetKeyName(5, "dangXuat.png");
            this.imglQuanLy.Images.SetKeyName(6, "dauTich.png");
            this.imglQuanLy.Images.SetKeyName(7, "DauX.png");
            this.imglQuanLy.Images.SetKeyName(8, "flat-delete-icon-circle-remove-sign-button-vector-13229630.jpg");
            this.imglQuanLy.Images.SetKeyName(9, "luachon.png");
            this.imglQuanLy.Images.SetKeyName(10, "sua.jpg");
            this.imglQuanLy.Images.SetKeyName(11, "sua.png");
            this.imglQuanLy.Images.SetKeyName(12, "tải xuống.jpg");
            this.imglQuanLy.Images.SetKeyName(13, "them.jpg");
            this.imglQuanLy.Images.SetKeyName(14, "timKiem.png");
            this.imglQuanLy.Images.SetKeyName(15, "tinhTien.png");
            this.imglQuanLy.Images.SetKeyName(16, "ungDung.jpg");
            this.imglQuanLy.Images.SetKeyName(17, "user.jpg");
            this.imglQuanLy.Images.SetKeyName(18, "xoa.png");
            // 
            // frmQuanLy
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(500, 274);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cboTenBang);
            this.Controls.Add(this.lblTenBang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLy_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenBang;
        private System.Windows.Forms.ComboBox cboTenBang;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ImageList imglQuanLy;
    }
}