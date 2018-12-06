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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangXe));
            this.lblTenHangXe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTenHangXe = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblChiPhi = new System.Windows.Forms.Label();
            this.imglThongTinXe = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaHangXe = new System.Windows.Forms.Label();
            this.txtMaHangXe = new System.Windows.Forms.TextBox();
            this.txtChiPhiThueBai = new System.Windows.Forms.TextBox();
            this.txtSoLuongXe = new System.Windows.Forms.TextBox();
            this.gbLuaChon = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.gbLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenHangXe
            // 
            this.lblTenHangXe.AutoSize = true;
            this.lblTenHangXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHangXe.ForeColor = System.Drawing.Color.Red;
            this.lblTenHangXe.Location = new System.Drawing.Point(215, 22);
            this.lblTenHangXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenHangXe.Name = "lblTenHangXe";
            this.lblTenHangXe.Size = new System.Drawing.Size(82, 15);
            this.lblTenHangXe.TabIndex = 1;
            this.lblTenHangXe.Text = "Tên Hãng Xe:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(123, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(368, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN CÁC HÃNG XE";
            // 
            // txtTenHangXe
            // 
            this.txtTenHangXe.Location = new System.Drawing.Point(218, 43);
            this.txtTenHangXe.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenHangXe.Name = "txtTenHangXe";
            this.txtTenHangXe.Size = new System.Drawing.Size(166, 26);
            this.txtTenHangXe.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(9, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(793, 244);
            this.dataGridView1.TabIndex = 11;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lblSoLuong.Location = new System.Drawing.Point(414, 22);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(83, 15);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Số Lượng Xe:";
            // 
            // lblChiPhi
            // 
            this.lblChiPhi.AutoSize = true;
            this.lblChiPhi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiPhi.ForeColor = System.Drawing.Color.Red;
            this.lblChiPhi.Location = new System.Drawing.Point(614, 22);
            this.lblChiPhi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChiPhi.Name = "lblChiPhi";
            this.lblChiPhi.Size = new System.Drawing.Size(106, 15);
            this.lblChiPhi.TabIndex = 5;
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageKey = "tải xuống.jpg";
            this.btnAdd.ImageList = this.imglThongTinXe;
            this.btnAdd.Location = new System.Drawing.Point(32, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 33);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageKey = "xoa.png";
            this.btnDelete.ImageList = this.imglThongTinXe;
            this.btnDelete.Location = new System.Drawing.Point(258, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 33);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageKey = "sua.png";
            this.btnUpdate.ImageList = this.imglThongTinXe;
            this.btnUpdate.Location = new System.Drawing.Point(458, 37);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 33);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.ImageKey = "arrow-sign-rotation-icon-reload-button-refresh-vector-12935532.jpg";
            this.btnBack.ImageList = this.imglThongTinXe;
            this.btnBack.Location = new System.Drawing.Point(654, 37);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 33);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
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
            this.gbThongTin.Location = new System.Drawing.Point(11, 43);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(791, 76);
            this.gbThongTin.TabIndex = 16;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin";
            // 
            // lblMaHangXe
            // 
            this.lblMaHangXe.AutoSize = true;
            this.lblMaHangXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHangXe.ForeColor = System.Drawing.Color.Red;
            this.lblMaHangXe.Location = new System.Drawing.Point(5, 22);
            this.lblMaHangXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaHangXe.Name = "lblMaHangXe";
            this.lblMaHangXe.Size = new System.Drawing.Size(82, 15);
            this.lblMaHangXe.TabIndex = 1;
            this.lblMaHangXe.Text = "Tên Hãng Xe:";
            // 
            // txtMaHangXe
            // 
            this.txtMaHangXe.Location = new System.Drawing.Point(5, 43);
            this.txtMaHangXe.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHangXe.Name = "txtMaHangXe";
            this.txtMaHangXe.Size = new System.Drawing.Size(166, 26);
            this.txtMaHangXe.TabIndex = 2;
            // 
            // txtChiPhiThueBai
            // 
            this.txtChiPhiThueBai.Location = new System.Drawing.Point(617, 45);
            this.txtChiPhiThueBai.Margin = new System.Windows.Forms.Padding(2);
            this.txtChiPhiThueBai.Name = "txtChiPhiThueBai";
            this.txtChiPhiThueBai.Size = new System.Drawing.Size(166, 26);
            this.txtChiPhiThueBai.TabIndex = 2;
            // 
            // txtSoLuongXe
            // 
            this.txtSoLuongXe.Location = new System.Drawing.Point(417, 45);
            this.txtSoLuongXe.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuongXe.Name = "txtSoLuongXe";
            this.txtSoLuongXe.Size = new System.Drawing.Size(166, 26);
            this.txtSoLuongXe.TabIndex = 2;
            // 
            // gbLuaChon
            // 
            this.gbLuaChon.Controls.Add(this.btnAdd);
            this.gbLuaChon.Controls.Add(this.btnDelete);
            this.gbLuaChon.Controls.Add(this.btnBack);
            this.gbLuaChon.Controls.Add(this.btnUpdate);
            this.gbLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuaChon.ForeColor = System.Drawing.Color.Red;
            this.gbLuaChon.Location = new System.Drawing.Point(12, 125);
            this.gbLuaChon.Name = "gbLuaChon";
            this.gbLuaChon.Size = new System.Drawing.Size(790, 76);
            this.gbLuaChon.TabIndex = 17;
            this.gbLuaChon.TabStop = false;
            this.gbLuaChon.Text = "Lựa Chọn";
            // 
            // frmHangXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 461);
            this.ControlBox = false;
            this.Controls.Add(this.gbLuaChon);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHangXe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông TIn Hãng Xe";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmHangXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblChiPhi;
        private System.Windows.Forms.ImageList imglThongTinXe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox gbLuaChon;
        private System.Windows.Forms.Label lblMaHangXe;
        private System.Windows.Forms.TextBox txtMaHangXe;
        private System.Windows.Forms.TextBox txtChiPhiThueBai;
        private System.Windows.Forms.TextBox txtSoLuongXe;
    }
}