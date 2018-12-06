namespace BusStation
{
    partial class frmLoaiNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.imglLoaiNhanVien = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.lblTenLoaiNhanVien = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTenLoaiNV = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numLuongCoBan = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.gbLuaChon = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuongCoBan)).BeginInit();
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
            this.btnBack.ImageList = this.imglLoaiNhanVien;
            this.btnBack.Location = new System.Drawing.Point(467, 42);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imglLoaiNhanVien
            // 
            this.imglLoaiNhanVien.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglLoaiNhanVien.ImageStream")));
            this.imglLoaiNhanVien.TransparentColor = System.Drawing.Color.Transparent;
            this.imglLoaiNhanVien.Images.SetKeyName(0, "addmins.jpg");
            this.imglLoaiNhanVien.Images.SetKeyName(1, "admin.jpg");
            this.imglLoaiNhanVien.Images.SetKeyName(2, "arrow-sign-rotation-icon-reload-button-refresh-vector-12935532.jpg");
            this.imglLoaiNhanVien.Images.SetKeyName(3, "dangNhap.jpg");
            this.imglLoaiNhanVien.Images.SetKeyName(4, "dangXuat.jpg");
            this.imglLoaiNhanVien.Images.SetKeyName(5, "dangXuat.png");
            this.imglLoaiNhanVien.Images.SetKeyName(6, "dauTich.png");
            this.imglLoaiNhanVien.Images.SetKeyName(7, "DauX.png");
            this.imglLoaiNhanVien.Images.SetKeyName(8, "flat-delete-icon-circle-remove-sign-button-vector-13229630.jpg");
            this.imglLoaiNhanVien.Images.SetKeyName(9, "luachon.png");
            this.imglLoaiNhanVien.Images.SetKeyName(10, "sua.jpg");
            this.imglLoaiNhanVien.Images.SetKeyName(11, "sua.png");
            this.imglLoaiNhanVien.Images.SetKeyName(12, "tải xuống.jpg");
            this.imglLoaiNhanVien.Images.SetKeyName(13, "them.jpg");
            this.imglLoaiNhanVien.Images.SetKeyName(14, "timKiem.png");
            this.imglLoaiNhanVien.Images.SetKeyName(15, "tinhTien.png");
            this.imglLoaiNhanVien.Images.SetKeyName(16, "ungDung.jpg");
            this.imglLoaiNhanVien.Images.SetKeyName(17, "user.jpg");
            this.imglLoaiNhanVien.Images.SetKeyName(18, "xoa.png");
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageKey = "tải xuống.jpg";
            this.btnAdd.ImageList = this.imglLoaiNhanVien;
            this.btnAdd.Location = new System.Drawing.Point(28, 42);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageKey = "flat-delete-icon-circle-remove-sign-button-vector-13229630.jpg";
            this.btnDelete.ImageList = this.imglLoaiNhanVien;
            this.btnDelete.Location = new System.Drawing.Point(174, 42);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Location = new System.Drawing.Point(343, 26);
            this.lblLuongCoBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(114, 19);
            this.lblLuongCoBan.TabIndex = 3;
            this.lblLuongCoBan.Text = "Lương Cơ Bản:";
            // 
            // lblTenLoaiNhanVien
            // 
            this.lblTenLoaiNhanVien.AutoSize = true;
            this.lblTenLoaiNhanVien.Location = new System.Drawing.Point(80, 26);
            this.lblTenLoaiNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenLoaiNhanVien.Name = "lblTenLoaiNhanVien";
            this.lblTenLoaiNhanVien.Size = new System.Drawing.Size(100, 19);
            this.lblTenLoaiNhanVien.TabIndex = 1;
            this.lblTenLoaiNhanVien.Text = "Tên Loại NV:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(103, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(412, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH LOẠI NHÂN VIÊN";
            // 
            // txtTenLoaiNV
            // 
            this.txtTenLoaiNV.Location = new System.Drawing.Point(84, 47);
            this.txtTenLoaiNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLoaiNV.Name = "txtTenLoaiNV";
            this.txtTenLoaiNV.Size = new System.Drawing.Size(166, 26);
            this.txtTenLoaiNV.TabIndex = 2;
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
            this.dataGridView1.Location = new System.Drawing.Point(9, 267);
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
            this.dataGridView1.Size = new System.Drawing.Size(593, 183);
            this.dataGridView1.TabIndex = 9;
            // 
            // numLuongCoBan
            // 
            this.numLuongCoBan.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLuongCoBan.Location = new System.Drawing.Point(346, 47);
            this.numLuongCoBan.Margin = new System.Windows.Forms.Padding(2);
            this.numLuongCoBan.Name = "numLuongCoBan";
            this.numLuongCoBan.Size = new System.Drawing.Size(165, 26);
            this.numLuongCoBan.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageKey = "sua.png";
            this.btnUpdate.ImageList = this.imglLoaiNhanVien;
            this.btnUpdate.Location = new System.Drawing.Point(325, 42);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 36);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.lblTenLoaiNhanVien);
            this.gbThongTin.Controls.Add(this.numLuongCoBan);
            this.gbThongTin.Controls.Add(this.txtTenLoaiNV);
            this.gbThongTin.Controls.Add(this.lblLuongCoBan);
            this.gbThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.Red;
            this.gbThongTin.Location = new System.Drawing.Point(13, 47);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(589, 87);
            this.gbThongTin.TabIndex = 10;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin";
            // 
            // gbLuaChon
            // 
            this.gbLuaChon.Controls.Add(this.btnAdd);
            this.gbLuaChon.Controls.Add(this.btnDelete);
            this.gbLuaChon.Controls.Add(this.btnBack);
            this.gbLuaChon.Controls.Add(this.btnUpdate);
            this.gbLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuaChon.ForeColor = System.Drawing.Color.Red;
            this.gbLuaChon.Location = new System.Drawing.Point(13, 155);
            this.gbLuaChon.Name = "gbLuaChon";
            this.gbLuaChon.Size = new System.Drawing.Size(589, 100);
            this.gbLuaChon.TabIndex = 11;
            this.gbLuaChon.TabStop = false;
            this.gbLuaChon.Text = "Lựa Chọn";
            // 
            // frmLoaiNhanVien
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(614, 461);
            this.ControlBox = false;
            this.Controls.Add(this.gbLuaChon);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLoaiNhanVien";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Loại Nhân Viên";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLoaiNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuongCoBan)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbLuaChon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.Label lblTenLoaiNhanVien;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTenLoaiNV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numLuongCoBan;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox gbLuaChon;
        private System.Windows.Forms.ImageList imglLoaiNhanVien;
    }
}