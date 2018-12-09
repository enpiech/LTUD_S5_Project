namespace BusStation
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.imglThongTinKH = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.txtMaGhe = new System.Windows.Forms.TextBox();
            this.lblMaGhe = new System.Windows.Forms.Label();
            this.cboMaXe = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.gbLuaChon = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.gbLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.ImageKey = "dangXuat.jpg";
            this.btnBack.ImageList = this.imglThongTinKH;
            this.btnBack.Location = new System.Drawing.Point(643, 29);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 32);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // imglThongTinKH
            // 
            this.imglThongTinKH.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglThongTinKH.ImageStream")));
            this.imglThongTinKH.TransparentColor = System.Drawing.Color.Transparent;
            this.imglThongTinKH.Images.SetKeyName(0, "addmins.jpg");
            this.imglThongTinKH.Images.SetKeyName(1, "admin.jpg");
            this.imglThongTinKH.Images.SetKeyName(2, "arrow-sign-rotation-icon-reload-button-refresh-vector-12935532.jpg");
            this.imglThongTinKH.Images.SetKeyName(3, "dangNhap.jpg");
            this.imglThongTinKH.Images.SetKeyName(4, "dangXuat.jpg");
            this.imglThongTinKH.Images.SetKeyName(5, "dangXuat.png");
            this.imglThongTinKH.Images.SetKeyName(6, "dauTich.png");
            this.imglThongTinKH.Images.SetKeyName(7, "DauX.png");
            this.imglThongTinKH.Images.SetKeyName(8, "flat-delete-icon-circle-remove-sign-button-vector-13229630.jpg");
            this.imglThongTinKH.Images.SetKeyName(9, "luachon.png");
            this.imglThongTinKH.Images.SetKeyName(10, "sua.jpg");
            this.imglThongTinKH.Images.SetKeyName(11, "sua.png");
            this.imglThongTinKH.Images.SetKeyName(12, "tải xuống.jpg");
            this.imglThongTinKH.Images.SetKeyName(13, "them.jpg");
            this.imglThongTinKH.Images.SetKeyName(14, "timKiem.png");
            this.imglThongTinKH.Images.SetKeyName(15, "tinhTien.png");
            this.imglThongTinKH.Images.SetKeyName(16, "ungDung.jpg");
            this.imglThongTinKH.Images.SetKeyName(17, "user.jpg");
            this.imglThongTinKH.Images.SetKeyName(18, "xoa.png");
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageKey = "tải xuống.jpg";
            this.btnAdd.ImageList = this.imglThongTinKH;
            this.btnAdd.Location = new System.Drawing.Point(7, 29);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 32);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(554, 83);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(132, 22);
            this.lblSoDienThoai.TabIndex = 11;
            this.lblSoDienThoai.Text = "Số Điện Thoại:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Enabled = false;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageKey = "flat-delete-icon-circle-remove-sign-button-vector-13229630.jpg";
            this.btnDelete.ImageList = this.imglThongTinKH;
            this.btnDelete.Location = new System.Drawing.Point(218, 29);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblCmnd
            // 
            this.lblCmnd.AutoSize = true;
            this.lblCmnd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmnd.Location = new System.Drawing.Point(289, 83);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(75, 22);
            this.lblCmnd.TabIndex = 7;
            this.lblCmnd.Text = "CMND:";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(7, 83);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(154, 22);
            this.lblTenKhachHang.TabIndex = 3;
            this.lblTenKhachHang.Text = "Tên Khách Hàng:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(185, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(8, 107);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(220, 30);
            this.txtTenKhachHang.TabIndex = 4;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 277);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(819, 303);
            this.dgvKhachHang.TabIndex = 17;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(293, 107);
            this.txtCmnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(220, 30);
            this.txtCmnd.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(558, 107);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(220, 30);
            this.txtSoDienThoai.TabIndex = 12;
            // 
            // lblMaXe
            // 
            this.lblMaXe.AutoSize = true;
            this.lblMaXe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaXe.Location = new System.Drawing.Point(289, 26);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(70, 22);
            this.lblMaXe.TabIndex = 5;
            this.lblMaXe.Text = "Mã Xe:";
            // 
            // txtMaGhe
            // 
            this.txtMaGhe.Location = new System.Drawing.Point(558, 51);
            this.txtMaGhe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaGhe.Name = "txtMaGhe";
            this.txtMaGhe.Size = new System.Drawing.Size(220, 30);
            this.txtMaGhe.TabIndex = 10;
            // 
            // lblMaGhe
            // 
            this.lblMaGhe.AutoSize = true;
            this.lblMaGhe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGhe.Location = new System.Drawing.Point(554, 27);
            this.lblMaGhe.Name = "lblMaGhe";
            this.lblMaGhe.Size = new System.Drawing.Size(82, 22);
            this.lblMaGhe.TabIndex = 9;
            this.lblMaGhe.Text = "Mã Ghế:";
            // 
            // cboMaXe
            // 
            this.cboMaXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaXe.FormattingEnabled = true;
            this.cboMaXe.Location = new System.Drawing.Point(293, 50);
            this.cboMaXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaXe.Name = "cboMaXe";
            this.cboMaXe.Size = new System.Drawing.Size(220, 31);
            this.cboMaXe.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageKey = "sua.png";
            this.btnUpdate.ImageList = this.imglThongTinKH;
            this.btnUpdate.Location = new System.Drawing.Point(441, 29);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 32);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.lblTenKhachHang);
            this.gbThongTin.Controls.Add(this.cboMaXe);
            this.gbThongTin.Controls.Add(this.txtMaKhachHang);
            this.gbThongTin.Controls.Add(this.txtTenKhachHang);
            this.gbThongTin.Controls.Add(this.lblCmnd);
            this.gbThongTin.Controls.Add(this.lblMaGhe);
            this.gbThongTin.Controls.Add(this.txtCmnd);
            this.gbThongTin.Controls.Add(this.txtMaGhe);
            this.gbThongTin.Controls.Add(this.lblSoDienThoai);
            this.gbThongTin.Controls.Add(this.txtSoDienThoai);
            this.gbThongTin.Controls.Add(this.lblMaXe);
            this.gbThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.Red;
            this.gbThongTin.Location = new System.Drawing.Point(12, 53);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.gbThongTin.Size = new System.Drawing.Size(785, 143);
            this.gbThongTin.TabIndex = 15;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(7, 50);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(220, 30);
            this.txtMaKhachHang.TabIndex = 2;
            // 
            // gbLuaChon
            // 
            this.gbLuaChon.Controls.Add(this.btnAdd);
            this.gbLuaChon.Controls.Add(this.btnDelete);
            this.gbLuaChon.Controls.Add(this.btnBack);
            this.gbLuaChon.Controls.Add(this.btnUpdate);
            this.gbLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuaChon.ForeColor = System.Drawing.Color.Red;
            this.gbLuaChon.Location = new System.Drawing.Point(13, 204);
            this.gbLuaChon.Margin = new System.Windows.Forms.Padding(4);
            this.gbLuaChon.Name = "gbLuaChon";
            this.gbLuaChon.Padding = new System.Windows.Forms.Padding(4);
            this.gbLuaChon.Size = new System.Drawing.Size(785, 67);
            this.gbLuaChon.TabIndex = 16;
            this.gbLuaChon.TabStop = false;
            this.gbLuaChon.Text = "Lựa Chọn";
            // 
            // frmKhachHang
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(819, 580);
            this.ControlBox = false;
            this.Controls.Add(this.gbLuaChon);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvKhachHang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKhachHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Khách Hàng";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbLuaChon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.TextBox txtMaGhe;
        private System.Windows.Forms.Label lblMaGhe;
        private System.Windows.Forms.ComboBox cboMaXe;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox gbLuaChon;
        private System.Windows.Forms.ImageList imglThongTinKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhachHang;
    }
}