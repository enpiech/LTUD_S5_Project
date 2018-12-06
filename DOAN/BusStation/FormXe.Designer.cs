namespace BusStation
{
    partial class frmXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.imglXe = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblHanhTrinh = new System.Windows.Forms.Label();
            this.lblLoaiXe = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblHangXe = new System.Windows.Forms.Label();
            this.lblSoXe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSoXe = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboHangXe = new System.Windows.Forms.ComboBox();
            this.cboLoaiXe = new System.Windows.Forms.ComboBox();
            this.txtHanhTrinh = new System.Windows.Forms.TextBox();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.dtpGioXuatPhat = new System.Windows.Forms.DateTimePicker();
            this.lblGioXuatPhat = new System.Windows.Forms.Label();
            this.numSoLuongGhe = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongGhe = new System.Windows.Forms.Label();
            this.numSoLuongKhachHang = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongKhachHang = new System.Windows.Forms.Label();
            this.lblNhanVienLaiXe = new System.Windows.Forms.Label();
            this.cboNVLaiXe = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongGhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongKhachHang)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.ImageKey = "dangXuat.jpg";
            this.btnBack.ImageList = this.imglXe;
            this.btnBack.Location = new System.Drawing.Point(758, 440);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 36);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imglXe
            // 
            this.imglXe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglXe.ImageStream")));
            this.imglXe.TransparentColor = System.Drawing.Color.Transparent;
            this.imglXe.Images.SetKeyName(0, "addmins.jpg");
            this.imglXe.Images.SetKeyName(1, "admin.jpg");
            this.imglXe.Images.SetKeyName(2, "arrow-sign-rotation-icon-reload-button-refresh-vector-12935532.jpg");
            this.imglXe.Images.SetKeyName(3, "dangNhap.jpg");
            this.imglXe.Images.SetKeyName(4, "dangXuat.jpg");
            this.imglXe.Images.SetKeyName(5, "dangXuat.png");
            this.imglXe.Images.SetKeyName(6, "dauTich.png");
            this.imglXe.Images.SetKeyName(7, "DauX.png");
            this.imglXe.Images.SetKeyName(8, "export.png");
            this.imglXe.Images.SetKeyName(9, "flat-delete-icon-circle-remove-sign-button-vector-13229630.jpg");
            this.imglXe.Images.SetKeyName(10, "iconsave.png");
            this.imglXe.Images.SetKeyName(11, "images.jpg");
            this.imglXe.Images.SetKeyName(12, "luachon.png");
            this.imglXe.Images.SetKeyName(13, "sua.jpg");
            this.imglXe.Images.SetKeyName(14, "sua.png");
            this.imglXe.Images.SetKeyName(15, "tải xuống.jpg");
            this.imglXe.Images.SetKeyName(16, "them.jpg");
            this.imglXe.Images.SetKeyName(17, "timKiem.png");
            this.imglXe.Images.SetKeyName(18, "tinhTien.png");
            this.imglXe.Images.SetKeyName(19, "ungDung.jpg");
            this.imglXe.Images.SetKeyName(20, "user.jpg");
            this.imglXe.Images.SetKeyName(21, "xoa.png");
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageKey = "tải xuống.jpg";
            this.btnAdd.ImageList = this.imglXe;
            this.btnAdd.Location = new System.Drawing.Point(72, 440);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 36);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(5, 188);
            this.lblGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(38, 19);
            this.lblGia.TabIndex = 16;
            this.lblGia.Text = "Giá:";
            // 
            // lblHanhTrinh
            // 
            this.lblHanhTrinh.AutoSize = true;
            this.lblHanhTrinh.Location = new System.Drawing.Point(5, 146);
            this.lblHanhTrinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHanhTrinh.Name = "lblHanhTrinh";
            this.lblHanhTrinh.Size = new System.Drawing.Size(89, 19);
            this.lblHanhTrinh.TabIndex = 12;
            this.lblHanhTrinh.Text = "Hành Trình:";
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.AutoSize = true;
            this.lblLoaiXe.Location = new System.Drawing.Point(5, 108);
            this.lblLoaiXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(64, 19);
            this.lblLoaiXe.TabIndex = 8;
            this.lblLoaiXe.Text = "Loại xe:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageKey = "flat-delete-icon-circle-remove-sign-button-vector-13229630.jpg";
            this.btnDelete.ImageList = this.imglXe;
            this.btnDelete.Location = new System.Drawing.Point(297, 440);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 36);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblHangXe
            // 
            this.lblHangXe.AutoSize = true;
            this.lblHangXe.Location = new System.Drawing.Point(5, 68);
            this.lblHangXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHangXe.Name = "lblHangXe";
            this.lblHangXe.Size = new System.Drawing.Size(68, 19);
            this.lblHangXe.TabIndex = 4;
            this.lblHangXe.Text = "Hãng Xe";
            // 
            // lblSoXe
            // 
            this.lblSoXe.AutoSize = true;
            this.lblSoXe.Location = new System.Drawing.Point(5, 31);
            this.lblSoXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoXe.Name = "lblSoXe";
            this.lblSoXe.Size = new System.Drawing.Size(54, 19);
            this.lblSoXe.TabIndex = 1;
            this.lblSoXe.Text = "Số Xe:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(371, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN XE";
            // 
            // txtSoXe
            // 
            this.txtSoXe.Location = new System.Drawing.Point(119, 28);
            this.txtSoXe.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoXe.Name = "txtSoXe";
            this.txtSoXe.Size = new System.Drawing.Size(166, 26);
            this.txtSoXe.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(344, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(599, 362);
            this.dataGridView1.TabIndex = 22;
            // 
            // cboHangXe
            // 
            this.cboHangXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHangXe.FormattingEnabled = true;
            this.cboHangXe.Location = new System.Drawing.Point(118, 65);
            this.cboHangXe.Margin = new System.Windows.Forms.Padding(2);
            this.cboHangXe.Name = "cboHangXe";
            this.cboHangXe.Size = new System.Drawing.Size(166, 27);
            this.cboHangXe.TabIndex = 5;
            // 
            // cboLoaiXe
            // 
            this.cboLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiXe.FormattingEnabled = true;
            this.cboLoaiXe.Location = new System.Drawing.Point(118, 105);
            this.cboLoaiXe.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoaiXe.Name = "cboLoaiXe";
            this.cboLoaiXe.Size = new System.Drawing.Size(166, 27);
            this.cboLoaiXe.TabIndex = 9;
            // 
            // txtHanhTrinh
            // 
            this.txtHanhTrinh.Location = new System.Drawing.Point(119, 143);
            this.txtHanhTrinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtHanhTrinh.Name = "txtHanhTrinh";
            this.txtHanhTrinh.Size = new System.Drawing.Size(166, 26);
            this.txtHanhTrinh.TabIndex = 13;
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(118, 186);
            this.numGia.Margin = new System.Windows.Forms.Padding(2);
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(165, 26);
            this.numGia.TabIndex = 17;
            // 
            // dtpGioXuatPhat
            // 
            this.dtpGioXuatPhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGioXuatPhat.Location = new System.Drawing.Point(119, 224);
            this.dtpGioXuatPhat.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGioXuatPhat.Name = "dtpGioXuatPhat";
            this.dtpGioXuatPhat.Size = new System.Drawing.Size(166, 26);
            this.dtpGioXuatPhat.TabIndex = 41;
            // 
            // lblGioXuatPhat
            // 
            this.lblGioXuatPhat.AutoSize = true;
            this.lblGioXuatPhat.Location = new System.Drawing.Point(5, 230);
            this.lblGioXuatPhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioXuatPhat.Name = "lblGioXuatPhat";
            this.lblGioXuatPhat.Size = new System.Drawing.Size(109, 19);
            this.lblGioXuatPhat.TabIndex = 3;
            this.lblGioXuatPhat.Text = "Giờ Xuất Phát:";
            // 
            // numSoLuongGhe
            // 
            this.numSoLuongGhe.Location = new System.Drawing.Point(120, 264);
            this.numSoLuongGhe.Margin = new System.Windows.Forms.Padding(2);
            this.numSoLuongGhe.Name = "numSoLuongGhe";
            this.numSoLuongGhe.Size = new System.Drawing.Size(165, 26);
            this.numSoLuongGhe.TabIndex = 7;
            // 
            // lblSoLuongGhe
            // 
            this.lblSoLuongGhe.AutoSize = true;
            this.lblSoLuongGhe.Location = new System.Drawing.Point(5, 266);
            this.lblSoLuongGhe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongGhe.Name = "lblSoLuongGhe";
            this.lblSoLuongGhe.Size = new System.Drawing.Size(112, 19);
            this.lblSoLuongGhe.TabIndex = 6;
            this.lblSoLuongGhe.Text = "Số Lượng Ghế:";
            // 
            // numSoLuongKhachHang
            // 
            this.numSoLuongKhachHang.Location = new System.Drawing.Point(120, 304);
            this.numSoLuongKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.numSoLuongKhachHang.Name = "numSoLuongKhachHang";
            this.numSoLuongKhachHang.Size = new System.Drawing.Size(165, 26);
            this.numSoLuongKhachHang.TabIndex = 11;
            // 
            // lblSoLuongKhachHang
            // 
            this.lblSoLuongKhachHang.AutoSize = true;
            this.lblSoLuongKhachHang.Location = new System.Drawing.Point(6, 306);
            this.lblSoLuongKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongKhachHang.Name = "lblSoLuongKhachHang";
            this.lblSoLuongKhachHang.Size = new System.Drawing.Size(108, 19);
            this.lblSoLuongKhachHang.TabIndex = 10;
            this.lblSoLuongKhachHang.Text = "Số Lượng KH:";
            // 
            // lblNhanVienLaiXe
            // 
            this.lblNhanVienLaiXe.AutoSize = true;
            this.lblNhanVienLaiXe.Location = new System.Drawing.Point(8, 347);
            this.lblNhanVienLaiXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhanVienLaiXe.Name = "lblNhanVienLaiXe";
            this.lblNhanVienLaiXe.Size = new System.Drawing.Size(86, 19);
            this.lblNhanVienLaiXe.TabIndex = 14;
            this.lblNhanVienLaiXe.Text = "NV Lái Xe:";
            // 
            // cboNVLaiXe
            // 
            this.cboNVLaiXe.FormattingEnabled = true;
            this.cboNVLaiXe.Location = new System.Drawing.Point(120, 344);
            this.cboNVLaiXe.Margin = new System.Windows.Forms.Padding(2);
            this.cboNVLaiXe.Name = "cboNVLaiXe";
            this.cboNVLaiXe.Size = new System.Drawing.Size(166, 27);
            this.cboNVLaiXe.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageKey = "sua.png";
            this.btnUpdate.ImageList = this.imglXe;
            this.btnUpdate.Location = new System.Drawing.Point(554, 440);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 36);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.lblSoXe);
            this.gbThongTin.Controls.Add(this.cboNVLaiXe);
            this.gbThongTin.Controls.Add(this.txtSoXe);
            this.gbThongTin.Controls.Add(this.lblHangXe);
            this.gbThongTin.Controls.Add(this.cboHangXe);
            this.gbThongTin.Controls.Add(this.lblNhanVienLaiXe);
            this.gbThongTin.Controls.Add(this.lblLoaiXe);
            this.gbThongTin.Controls.Add(this.cboLoaiXe);
            this.gbThongTin.Controls.Add(this.lblHanhTrinh);
            this.gbThongTin.Controls.Add(this.lblSoLuongKhachHang);
            this.gbThongTin.Controls.Add(this.txtHanhTrinh);
            this.gbThongTin.Controls.Add(this.numSoLuongKhachHang);
            this.gbThongTin.Controls.Add(this.lblGia);
            this.gbThongTin.Controls.Add(this.lblSoLuongGhe);
            this.gbThongTin.Controls.Add(this.numGia);
            this.gbThongTin.Controls.Add(this.lblGioXuatPhat);
            this.gbThongTin.Controls.Add(this.numSoLuongGhe);
            this.gbThongTin.Controls.Add(this.dtpGioXuatPhat);
            this.gbThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.Red;
            this.gbThongTin.Location = new System.Drawing.Point(12, 48);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(327, 378);
            this.gbThongTin.TabIndex = 42;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin";
            // 
            // frmXe
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.ControlBox = false;
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmXe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Xe";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongGhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongKhachHang)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblHanhTrinh;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHangXe;
        private System.Windows.Forms.Label lblSoXe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSoXe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboHangXe;
        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.TextBox txtHanhTrinh;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.DateTimePicker dtpGioXuatPhat;
        private System.Windows.Forms.Label lblGioXuatPhat;
        private System.Windows.Forms.NumericUpDown numSoLuongGhe;
        private System.Windows.Forms.Label lblSoLuongGhe;
        private System.Windows.Forms.NumericUpDown numSoLuongKhachHang;
        private System.Windows.Forms.Label lblSoLuongKhachHang;
        private System.Windows.Forms.Label lblNhanVienLaiXe;
        private System.Windows.Forms.ComboBox cboNVLaiXe;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.ImageList imglXe;
    }
}