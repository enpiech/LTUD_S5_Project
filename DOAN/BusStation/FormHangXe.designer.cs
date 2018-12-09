namespace BusStation
{
    partial class frmHangXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangXe));
            this.lblTenHangXe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTenHangXe = new System.Windows.Forms.TextBox();
            this.dgvhangXe = new System.Windows.Forms.DataGridView();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblChiPhi = new System.Windows.Forms.Label();
            this.imglThongTinXe = new System.Windows.Forms.ImageList(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaHangXe = new System.Windows.Forms.Label();
            this.txtMaHangXe = new System.Windows.Forms.TextBox();
            this.txtChiPhiThueBai = new System.Windows.Forms.TextBox();
            this.txtSoLuongXe = new System.Windows.Forms.TextBox();
            this.gbLuaChon = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhangXe)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.gbLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenHangXe
            // 
            this.lblTenHangXe.AutoSize = true;
            this.lblTenHangXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHangXe.ForeColor = System.Drawing.Color.Red;
            this.lblTenHangXe.Location = new System.Drawing.Point(7, 69);
            this.lblTenHangXe.Name = "lblTenHangXe";
            this.lblTenHangXe.Size = new System.Drawing.Size(109, 19);
            this.lblTenHangXe.TabIndex = 3;
            this.lblTenHangXe.Text = "Tên Hãng Xe:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(211, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(464, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN CÁC HÃNG XE";
            // 
            // txtTenHangXe
            // 
            this.txtTenHangXe.Location = new System.Drawing.Point(122, 63);
            this.txtTenHangXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHangXe.Name = "txtTenHangXe";
            this.txtTenHangXe.Size = new System.Drawing.Size(220, 30);
            this.txtTenHangXe.TabIndex = 4;
            // 
            // dgvhangXe
            // 
            this.dgvhangXe.AllowUserToAddRows = false;
            this.dgvhangXe.AllowUserToDeleteRows = false;
            this.dgvhangXe.AllowUserToOrderColumns = true;
            this.dgvhangXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvhangXe.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhangXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvhangXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhangXe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvhangXe.Location = new System.Drawing.Point(12, 284);
            this.dgvhangXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvhangXe.MultiSelect = false;
            this.dgvhangXe.Name = "dgvhangXe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhangXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvhangXe.RowTemplate.Height = 24;
            this.dgvhangXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhangXe.Size = new System.Drawing.Size(929, 386);
            this.dgvhangXe.TabIndex = 11;
            this.dgvhangXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangXe_CellClick);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lblSoLuong.Location = new System.Drawing.Point(374, 35);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(109, 19);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số Lượng Xe:";
            // 
            // lblChiPhi
            // 
            this.lblChiPhi.AutoSize = true;
            this.lblChiPhi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiPhi.ForeColor = System.Drawing.Color.Red;
            this.lblChiPhi.Location = new System.Drawing.Point(374, 69);
            this.lblChiPhi.Name = "lblChiPhi";
            this.lblChiPhi.Size = new System.Drawing.Size(142, 19);
            this.lblChiPhi.TabIndex = 8;
            this.lblChiPhi.Text = "Chi Phí Thuê Bãi:";
            // 
            // imglThongTinXe
            // 
            this.imglThongTinXe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglThongTinXe.ImageStream")));
            this.imglThongTinXe.TransparentColor = System.Drawing.Color.Transparent;
            this.imglThongTinXe.Images.SetKeyName(0, "addmins.jpg");
            this.imglThongTinXe.Images.SetKeyName(1, "admin.jpg");
            this.imglThongTinXe.Images.SetKeyName(2, "dangNhap.jpg");
            this.imglThongTinXe.Images.SetKeyName(3, "dangXuat.jpg");
            this.imglThongTinXe.Images.SetKeyName(4, "dangXuat.png");
            this.imglThongTinXe.Images.SetKeyName(5, "dauTich.png");
            this.imglThongTinXe.Images.SetKeyName(6, "DauX.png");
            this.imglThongTinXe.Images.SetKeyName(7, "luachon.png");
            this.imglThongTinXe.Images.SetKeyName(8, "timKiem.png");
            this.imglThongTinXe.Images.SetKeyName(9, "tinhTien.png");
            this.imglThongTinXe.Images.SetKeyName(10, "ungDung.jpg");
            this.imglThongTinXe.Images.SetKeyName(11, "user.jpg");
            this.imglThongTinXe.Images.SetKeyName(12, "addmins.jpg");
            this.imglThongTinXe.Images.SetKeyName(13, "admin.jpg");
            this.imglThongTinXe.Images.SetKeyName(14, "dangNhap.jpg");
            this.imglThongTinXe.Images.SetKeyName(15, "dangXuat.jpg");
            this.imglThongTinXe.Images.SetKeyName(16, "dangXuat.png");
            this.imglThongTinXe.Images.SetKeyName(17, "dauTich.png");
            this.imglThongTinXe.Images.SetKeyName(18, "DauX.png");
            this.imglThongTinXe.Images.SetKeyName(19, "luachon.png");
            this.imglThongTinXe.Images.SetKeyName(20, "sua.png");
            this.imglThongTinXe.Images.SetKeyName(21, "them.jpg");
            this.imglThongTinXe.Images.SetKeyName(22, "timKiem.png");
            this.imglThongTinXe.Images.SetKeyName(23, "tinhTien.png");
            this.imglThongTinXe.Images.SetKeyName(24, "ungDung.jpg");
            this.imglThongTinXe.Images.SetKeyName(25, "user.jpg");
            this.imglThongTinXe.Images.SetKeyName(26, "xoa.png");
            this.imglThongTinXe.Images.SetKeyName(27, "addmins.jpg");
            this.imglThongTinXe.Images.SetKeyName(28, "admin.jpg");
            this.imglThongTinXe.Images.SetKeyName(29, "arrow-sign-rotation-icon-reload-button-refresh-vector-12935532.jpg");
            this.imglThongTinXe.Images.SetKeyName(30, "dangNhap.jpg");
            this.imglThongTinXe.Images.SetKeyName(31, "dangXuat.jpg");
            this.imglThongTinXe.Images.SetKeyName(32, "dangXuat.png");
            this.imglThongTinXe.Images.SetKeyName(33, "dauTich.png");
            this.imglThongTinXe.Images.SetKeyName(34, "DauX.png");
            this.imglThongTinXe.Images.SetKeyName(35, "flat-delete-icon-circle-remove-sign-button-vector-13229630.jpg");
            this.imglThongTinXe.Images.SetKeyName(36, "luachon.png");
            this.imglThongTinXe.Images.SetKeyName(37, "sua.jpg");
            this.imglThongTinXe.Images.SetKeyName(38, "sua.png");
            this.imglThongTinXe.Images.SetKeyName(39, "tải xuống.jpg");
            this.imglThongTinXe.Images.SetKeyName(40, "them.jpg");
            this.imglThongTinXe.Images.SetKeyName(41, "timKiem.png");
            this.imglThongTinXe.Images.SetKeyName(42, "tinhTien.png");
            this.imglThongTinXe.Images.SetKeyName(43, "ungDung.jpg");
            this.imglThongTinXe.Images.SetKeyName(44, "user.jpg");
            this.imglThongTinXe.Images.SetKeyName(45, "xoa.png");
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageKey = "tải xuống.jpg";
            this.btnThem.ImageList = this.imglThongTinXe;
            this.btnThem.Location = new System.Drawing.Point(8, 31);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(148, 41);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Enabled = false;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageKey = "xoa.png";
            this.btnXoa.ImageList = this.imglThongTinXe;
            this.btnXoa.Location = new System.Drawing.Point(8, 80);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 41);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Enabled = false;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageKey = "sua.png";
            this.btnSua.ImageList = this.imglThongTinXe;
            this.btnSua.Location = new System.Drawing.Point(8, 129);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(148, 41);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.White;
            this.btnTroVe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTroVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVe.ImageKey = "arrow-sign-rotation-icon-reload-button-refresh-vector-12935532.jpg";
            this.btnTroVe.ImageList = this.imglThongTinXe;
            this.btnTroVe.Location = new System.Drawing.Point(8, 178);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(148, 41);
            this.btnTroVe.TabIndex = 13;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.lblMaHangXe);
            this.gbThongTin.Controls.Add(this.txtMaHangXe);
            this.gbThongTin.Controls.Add(this.txtChiPhiThueBai);
            this.gbThongTin.Controls.Add(this.txtSoLuongXe);
            this.gbThongTin.Controls.Add(this.txtTenHangXe);
            this.gbThongTin.Controls.Add(this.lblSoLuong);
            this.gbThongTin.Controls.Add(this.lblTenHangXe);
            this.gbThongTin.Controls.Add(this.lblChiPhi);
            this.gbThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.Red;
            this.gbThongTin.Location = new System.Drawing.Point(15, 53);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.gbThongTin.Size = new System.Drawing.Size(751, 219);
            this.gbThongTin.TabIndex = 16;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin";
            // 
            // lblMaHangXe
            // 
            this.lblMaHangXe.AutoSize = true;
            this.lblMaHangXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHangXe.ForeColor = System.Drawing.Color.Red;
            this.lblMaHangXe.Location = new System.Drawing.Point(7, 35);
            this.lblMaHangXe.Name = "lblMaHangXe";
            this.lblMaHangXe.Size = new System.Drawing.Size(106, 19);
            this.lblMaHangXe.TabIndex = 1;
            this.lblMaHangXe.Text = "Mã Hãng Xe:";
            // 
            // txtMaHangXe
            // 
            this.txtMaHangXe.Location = new System.Drawing.Point(122, 29);
            this.txtMaHangXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHangXe.Name = "txtMaHangXe";
            this.txtMaHangXe.Size = new System.Drawing.Size(220, 30);
            this.txtMaHangXe.TabIndex = 2;
            // 
            // txtChiPhiThueBai
            // 
            this.txtChiPhiThueBai.Location = new System.Drawing.Point(522, 63);
            this.txtChiPhiThueBai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChiPhiThueBai.Name = "txtChiPhiThueBai";
            this.txtChiPhiThueBai.Size = new System.Drawing.Size(220, 30);
            this.txtChiPhiThueBai.TabIndex = 9;
            this.txtChiPhiThueBai.Leave += new System.EventHandler(this.txtChiPhiThueBai_Leave);
            // 
            // txtSoLuongXe
            // 
            this.txtSoLuongXe.Location = new System.Drawing.Point(522, 29);
            this.txtSoLuongXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongXe.Name = "txtSoLuongXe";
            this.txtSoLuongXe.Size = new System.Drawing.Size(220, 30);
            this.txtSoLuongXe.TabIndex = 7;
            this.txtSoLuongXe.Leave += new System.EventHandler(this.txtSoLuongXe_Leave);
            // 
            // gbLuaChon
            // 
            this.gbLuaChon.Controls.Add(this.btnThem);
            this.gbLuaChon.Controls.Add(this.btnXoa);
            this.gbLuaChon.Controls.Add(this.btnTroVe);
            this.gbLuaChon.Controls.Add(this.btnSua);
            this.gbLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuaChon.ForeColor = System.Drawing.Color.Red;
            this.gbLuaChon.Location = new System.Drawing.Point(783, 53);
            this.gbLuaChon.Margin = new System.Windows.Forms.Padding(4);
            this.gbLuaChon.Name = "gbLuaChon";
            this.gbLuaChon.Padding = new System.Windows.Forms.Padding(4);
            this.gbLuaChon.Size = new System.Drawing.Size(163, 225);
            this.gbLuaChon.TabIndex = 17;
            this.gbLuaChon.TabStop = false;
            this.gbLuaChon.Text = "Lựa Chọn";
            // 
            // frmHangXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTroVe;
            this.ClientSize = new System.Drawing.Size(953, 681);
            this.ControlBox = false;
            this.Controls.Add(this.gbLuaChon);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvhangXe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHangXe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông TIn Hãng Xe";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmHangXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhangXe)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbLuaChon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenHangXe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTenHangXe;
        private System.Windows.Forms.DataGridView dgvhangXe;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblChiPhi;
        private System.Windows.Forms.ImageList imglThongTinXe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox gbLuaChon;
        private System.Windows.Forms.Label lblMaHangXe;
        private System.Windows.Forms.TextBox txtMaHangXe;
        private System.Windows.Forms.TextBox txtChiPhiThueBai;
        private System.Windows.Forms.TextBox txtSoLuongXe;
    }
}