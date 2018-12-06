namespace BusStation
{
    partial class frmBanVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanVe));
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblHangXe = new System.Windows.Forms.Label();
            this.lblLoaiXe = new System.Windows.Forms.Label();
            this.lblSoGhe = new System.Windows.Forms.Label();
            this.btnMuaVe = new System.Windows.Forms.Button();
            this.imglBanVe = new System.Windows.Forms.ImageList(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.cboHangXe = new System.Windows.Forms.ComboBox();
            this.cboLoaiXe = new System.Windows.Forms.ComboBox();
            this.cboGhe = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.lblUngDungMuaVe = new System.Windows.Forms.Label();
            this.gbLuaChon = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.gbLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.ForeColor = System.Drawing.Color.Red;
            this.lblTenKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTenKH.Location = new System.Drawing.Point(3, 23);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(98, 15);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // lblCmnd
            // 
            this.lblCmnd.AutoSize = true;
            this.lblCmnd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmnd.ForeColor = System.Drawing.Color.Red;
            this.lblCmnd.Location = new System.Drawing.Point(215, 23);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(45, 15);
            this.lblCmnd.TabIndex = 2;
            this.lblCmnd.Text = "CMND";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.Red;
            this.lblSoDienThoai.Location = new System.Drawing.Point(423, 23);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(84, 15);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số Điện Thoại";
            // 
            // lblHangXe
            // 
            this.lblHangXe.AutoSize = true;
            this.lblHangXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangXe.ForeColor = System.Drawing.Color.Red;
            this.lblHangXe.Location = new System.Drawing.Point(10, 104);
            this.lblHangXe.Name = "lblHangXe";
            this.lblHangXe.Size = new System.Drawing.Size(54, 15);
            this.lblHangXe.TabIndex = 6;
            this.lblHangXe.Text = "Hãng Xe";
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.AutoSize = true;
            this.lblLoaiXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiXe.ForeColor = System.Drawing.Color.Red;
            this.lblLoaiXe.Location = new System.Drawing.Point(215, 104);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(49, 15);
            this.lblLoaiXe.TabIndex = 8;
            this.lblLoaiXe.Text = "Loại Xe";
            // 
            // lblSoGhe
            // 
            this.lblSoGhe.AutoSize = true;
            this.lblSoGhe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoGhe.ForeColor = System.Drawing.Color.Red;
            this.lblSoGhe.Location = new System.Drawing.Point(427, 104);
            this.lblSoGhe.Name = "lblSoGhe";
            this.lblSoGhe.Size = new System.Drawing.Size(46, 15);
            this.lblSoGhe.TabIndex = 10;
            this.lblSoGhe.Text = "Số Ghế";
            // 
            // btnMuaVe
            // 
            this.btnMuaVe.BackColor = System.Drawing.Color.White;
            this.btnMuaVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaVe.ForeColor = System.Drawing.Color.Red;
            this.btnMuaVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuaVe.ImageKey = "tinhTien.png";
            this.btnMuaVe.ImageList = this.imglBanVe;
            this.btnMuaVe.Location = new System.Drawing.Point(102, 23);
            this.btnMuaVe.Name = "btnMuaVe";
            this.btnMuaVe.Size = new System.Drawing.Size(110, 54);
            this.btnMuaVe.TabIndex = 12;
            this.btnMuaVe.Text = "Mua Vé";
            this.btnMuaVe.UseVisualStyleBackColor = false;
            this.btnMuaVe.Click += new System.EventHandler(this.btnMuaVe_Click);
            // 
            // imglBanVe
            // 
            this.imglBanVe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglBanVe.ImageStream")));
            this.imglBanVe.TransparentColor = System.Drawing.Color.Transparent;
            this.imglBanVe.Images.SetKeyName(0, "addmins.jpg");
            this.imglBanVe.Images.SetKeyName(1, "admin.jpg");
            this.imglBanVe.Images.SetKeyName(2, "arrow-sign-rotation-icon-reload-button-refresh-vector-12935532.jpg");
            this.imglBanVe.Images.SetKeyName(3, "dangNhap.jpg");
            this.imglBanVe.Images.SetKeyName(4, "dangXuat.jpg");
            this.imglBanVe.Images.SetKeyName(5, "dangXuat.png");
            this.imglBanVe.Images.SetKeyName(6, "dauTich.png");
            this.imglBanVe.Images.SetKeyName(7, "DauX.png");
            this.imglBanVe.Images.SetKeyName(8, "flat-delete-icon-circle-remove-sign-button-vector-13229630.jpg");
            this.imglBanVe.Images.SetKeyName(9, "luachon.png");
            this.imglBanVe.Images.SetKeyName(10, "sua.jpg");
            this.imglBanVe.Images.SetKeyName(11, "sua.png");
            this.imglBanVe.Images.SetKeyName(12, "tải xuống.jpg");
            this.imglBanVe.Images.SetKeyName(13, "them.jpg");
            this.imglBanVe.Images.SetKeyName(14, "timKiem.png");
            this.imglBanVe.Images.SetKeyName(15, "tinhTien.png");
            this.imglBanVe.Images.SetKeyName(16, "ungDung.jpg");
            this.imglBanVe.Images.SetKeyName(17, "user.jpg");
            this.imglBanVe.Images.SetKeyName(18, "xoa.png");
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.ImageKey = "dangXuat.jpg";
            this.btnThoat.ImageList = this.imglBanVe;
            this.btnThoat.Location = new System.Drawing.Point(102, 91);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 58);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(6, 41);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(157, 27);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(214, 41);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(157, 27);
            this.txtCMND.TabIndex = 3;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(426, 41);
            this.txtSoDienThoai.Multiline = true;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(157, 27);
            this.txtSoDienThoai.TabIndex = 5;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
            // 
            // cboHangXe
            // 
            this.cboHangXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHangXe.FormattingEnabled = true;
            this.cboHangXe.Items.AddRange(new object[] {
            "Phương Trang",
            "Mai Linh",
            "Ngọc Thành",
            "Hoàng Tuấn",
            "Phan Huy"});
            this.cboHangXe.Location = new System.Drawing.Point(10, 122);
            this.cboHangXe.Name = "cboHangXe";
            this.cboHangXe.Size = new System.Drawing.Size(157, 27);
            this.cboHangXe.TabIndex = 7;
            // 
            // cboLoaiXe
            // 
            this.cboLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiXe.FormattingEnabled = true;
            this.cboLoaiXe.Items.AddRange(new object[] {
            "Xe Ngồi",
            "Xe Nằm"});
            this.cboLoaiXe.Location = new System.Drawing.Point(218, 122);
            this.cboLoaiXe.Name = "cboLoaiXe";
            this.cboLoaiXe.Size = new System.Drawing.Size(157, 27);
            this.cboLoaiXe.TabIndex = 9;
            // 
            // cboGhe
            // 
            this.cboGhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGhe.FormattingEnabled = true;
            this.cboGhe.Items.AddRange(new object[] {
            "1a",
            "2a",
            "3a",
            "4a",
            "5a",
            "6a",
            "7a",
            "8a",
            "9a",
            "10a",
            "11a",
            "12a",
            "13a",
            "14a",
            "15a",
            "1b",
            "2b",
            "3b",
            "4b",
            "5b",
            "6b",
            "7b",
            "8b",
            "9b",
            "10b",
            "11b",
            "12b",
            "13b",
            "14b",
            "15b"});
            this.cboGhe.Location = new System.Drawing.Point(430, 122);
            this.cboGhe.Name = "cboGhe";
            this.cboGhe.Size = new System.Drawing.Size(157, 27);
            this.cboGhe.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(995, 250);
            this.dataGridView1.TabIndex = 14;
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.lblTenKH);
            this.gbThongTin.Controls.Add(this.txtTenKH);
            this.gbThongTin.Controls.Add(this.lblCmnd);
            this.gbThongTin.Controls.Add(this.cboGhe);
            this.gbThongTin.Controls.Add(this.txtCMND);
            this.gbThongTin.Controls.Add(this.cboLoaiXe);
            this.gbThongTin.Controls.Add(this.lblSoDienThoai);
            this.gbThongTin.Controls.Add(this.cboHangXe);
            this.gbThongTin.Controls.Add(this.lblSoGhe);
            this.gbThongTin.Controls.Add(this.txtSoDienThoai);
            this.gbThongTin.Controls.Add(this.lblHangXe);
            this.gbThongTin.Controls.Add(this.lblLoaiXe);
            this.gbThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.Red;
            this.gbThongTin.Location = new System.Drawing.Point(13, 43);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(623, 162);
            this.gbThongTin.TabIndex = 15;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin";
            // 
            // lblUngDungMuaVe
            // 
            this.lblUngDungMuaVe.AutoSize = true;
            this.lblUngDungMuaVe.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUngDungMuaVe.ForeColor = System.Drawing.Color.Red;
            this.lblUngDungMuaVe.Location = new System.Drawing.Point(186, 9);
            this.lblUngDungMuaVe.Name = "lblUngDungMuaVe";
            this.lblUngDungMuaVe.Size = new System.Drawing.Size(232, 31);
            this.lblUngDungMuaVe.TabIndex = 16;
            this.lblUngDungMuaVe.Text = "Ứng Dụng Mua Vé";
            // 
            // gbLuaChon
            // 
            this.gbLuaChon.Controls.Add(this.btnThoat);
            this.gbLuaChon.Controls.Add(this.btnMuaVe);
            this.gbLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuaChon.ForeColor = System.Drawing.Color.Red;
            this.gbLuaChon.Location = new System.Drawing.Point(666, 43);
            this.gbLuaChon.Name = "gbLuaChon";
            this.gbLuaChon.Size = new System.Drawing.Size(307, 162);
            this.gbLuaChon.TabIndex = 17;
            this.gbLuaChon.TabStop = false;
            this.gbLuaChon.Text = "Lựa Chọn";
            // 
            // frmBanVe
            // 
            this.AcceptButton = this.btnMuaVe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(995, 461);
            this.ControlBox = false;
            this.Controls.Add(this.gbLuaChon);
            this.Controls.Add(this.lblUngDungMuaVe);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBanVe";
            this.Text = "Mua Vé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MuaVe_FormClosing);
            this.Load += new System.EventHandler(this.frmBanVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbLuaChon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblHangXe;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.Label lblSoGhe;
        private System.Windows.Forms.Button btnMuaVe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.ComboBox cboHangXe;
        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.ComboBox cboGhe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUngDungMuaVe;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox gbLuaChon;
        private System.Windows.Forms.ImageList imglBanVe;
    }
}