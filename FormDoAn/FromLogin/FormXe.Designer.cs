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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongGhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(681, 212);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 44);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(387, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 44);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(12, 173);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(34, 17);
            this.lblGia.TabIndex = 30;
            this.lblGia.Text = "Giá:";
            // 
            // lblHanhTrinh
            // 
            this.lblHanhTrinh.AutoSize = true;
            this.lblHanhTrinh.Location = new System.Drawing.Point(12, 145);
            this.lblHanhTrinh.Name = "lblHanhTrinh";
            this.lblHanhTrinh.Size = new System.Drawing.Size(83, 17);
            this.lblHanhTrinh.TabIndex = 31;
            this.lblHanhTrinh.Text = "Hành Trình:";
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.AutoSize = true;
            this.lblLoaiXe.Location = new System.Drawing.Point(12, 115);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(57, 17);
            this.lblLoaiXe.TabIndex = 32;
            this.lblLoaiXe.Text = "Loại xe:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(485, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 44);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblHangXe
            // 
            this.lblHangXe.AutoSize = true;
            this.lblHangXe.Location = new System.Drawing.Point(12, 85);
            this.lblHangXe.Name = "lblHangXe";
            this.lblHangXe.Size = new System.Drawing.Size(63, 17);
            this.lblHangXe.TabIndex = 33;
            this.lblHangXe.Text = "Hãng Xe";
            // 
            // lblSoXe
            // 
            this.lblSoXe.AutoSize = true;
            this.lblSoXe.Location = new System.Drawing.Point(12, 57);
            this.lblSoXe.Name = "lblSoXe";
            this.lblSoXe.Size = new System.Drawing.Size(50, 17);
            this.lblSoXe.TabIndex = 34;
            this.lblSoXe.Text = "Số Xe:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(300, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 25);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "THÔNG TIN XE";
            // 
            // txtSoXe
            // 
            this.txtSoXe.Location = new System.Drawing.Point(135, 54);
            this.txtSoXe.Name = "txtSoXe";
            this.txtSoXe.Size = new System.Drawing.Size(220, 22);
            this.txtSoXe.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(758, 258);
            this.dataGridView1.TabIndex = 24;
            // 
            // cboHangXe
            // 
            this.cboHangXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHangXe.FormattingEnabled = true;
            this.cboHangXe.Location = new System.Drawing.Point(135, 82);
            this.cboHangXe.Name = "cboHangXe";
            this.cboHangXe.Size = new System.Drawing.Size(220, 24);
            this.cboHangXe.TabIndex = 38;
            // 
            // cboLoaiXe
            // 
            this.cboLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiXe.FormattingEnabled = true;
            this.cboLoaiXe.Location = new System.Drawing.Point(135, 112);
            this.cboLoaiXe.Name = "cboLoaiXe";
            this.cboLoaiXe.Size = new System.Drawing.Size(220, 24);
            this.cboLoaiXe.TabIndex = 38;
            // 
            // txtHanhTrinh
            // 
            this.txtHanhTrinh.Location = new System.Drawing.Point(135, 142);
            this.txtHanhTrinh.Name = "txtHanhTrinh";
            this.txtHanhTrinh.Size = new System.Drawing.Size(220, 22);
            this.txtHanhTrinh.TabIndex = 39;
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(135, 171);
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(220, 22);
            this.numGia.TabIndex = 40;
            // 
            // dtpGioXuatPhat
            // 
            this.dtpGioXuatPhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGioXuatPhat.Location = new System.Drawing.Point(550, 54);
            this.dtpGioXuatPhat.Name = "dtpGioXuatPhat";
            this.dtpGioXuatPhat.Size = new System.Drawing.Size(220, 22);
            this.dtpGioXuatPhat.TabIndex = 41;
            // 
            // lblGioXuatPhat
            // 
            this.lblGioXuatPhat.AutoSize = true;
            this.lblGioXuatPhat.Location = new System.Drawing.Point(427, 57);
            this.lblGioXuatPhat.Name = "lblGioXuatPhat";
            this.lblGioXuatPhat.Size = new System.Drawing.Size(100, 17);
            this.lblGioXuatPhat.TabIndex = 42;
            this.lblGioXuatPhat.Text = "Giờ Xuất Phát:";
            // 
            // numSoLuongGhe
            // 
            this.numSoLuongGhe.Location = new System.Drawing.Point(550, 82);
            this.numSoLuongGhe.Name = "numSoLuongGhe";
            this.numSoLuongGhe.Size = new System.Drawing.Size(220, 22);
            this.numSoLuongGhe.TabIndex = 43;
            // 
            // lblSoLuongGhe
            // 
            this.lblSoLuongGhe.AutoSize = true;
            this.lblSoLuongGhe.Location = new System.Drawing.Point(427, 85);
            this.lblSoLuongGhe.Name = "lblSoLuongGhe";
            this.lblSoLuongGhe.Size = new System.Drawing.Size(104, 17);
            this.lblSoLuongGhe.TabIndex = 44;
            this.lblSoLuongGhe.Text = "Số Lượng Ghế:";
            // 
            // numSoLuongKhachHang
            // 
            this.numSoLuongKhachHang.Location = new System.Drawing.Point(550, 112);
            this.numSoLuongKhachHang.Name = "numSoLuongKhachHang";
            this.numSoLuongKhachHang.Size = new System.Drawing.Size(220, 22);
            this.numSoLuongKhachHang.TabIndex = 43;
            // 
            // lblSoLuongKhachHang
            // 
            this.lblSoLuongKhachHang.AutoSize = true;
            this.lblSoLuongKhachHang.Location = new System.Drawing.Point(427, 115);
            this.lblSoLuongKhachHang.Name = "lblSoLuongKhachHang";
            this.lblSoLuongKhachHang.Size = new System.Drawing.Size(96, 17);
            this.lblSoLuongKhachHang.TabIndex = 44;
            this.lblSoLuongKhachHang.Text = "Số Lượng KH:";
            // 
            // lblNhanVienLaiXe
            // 
            this.lblNhanVienLaiXe.AutoSize = true;
            this.lblNhanVienLaiXe.Location = new System.Drawing.Point(427, 145);
            this.lblNhanVienLaiXe.Name = "lblNhanVienLaiXe";
            this.lblNhanVienLaiXe.Size = new System.Drawing.Size(75, 17);
            this.lblNhanVienLaiXe.TabIndex = 44;
            this.lblNhanVienLaiXe.Text = "NV Lái Xe:";
            // 
            // cboNVLaiXe
            // 
            this.cboNVLaiXe.FormattingEnabled = true;
            this.cboNVLaiXe.Location = new System.Drawing.Point(550, 142);
            this.cboNVLaiXe.Name = "cboNVLaiXe";
            this.cboNVLaiXe.Size = new System.Drawing.Size(220, 24);
            this.cboNVLaiXe.TabIndex = 45;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(583, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 44);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmXe
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.cboNVLaiXe);
            this.Controls.Add(this.lblNhanVienLaiXe);
            this.Controls.Add(this.lblSoLuongKhachHang);
            this.Controls.Add(this.lblSoLuongGhe);
            this.Controls.Add(this.numSoLuongKhachHang);
            this.Controls.Add(this.numSoLuongGhe);
            this.Controls.Add(this.lblGioXuatPhat);
            this.Controls.Add(this.dtpGioXuatPhat);
            this.Controls.Add(this.numGia);
            this.Controls.Add(this.txtHanhTrinh);
            this.Controls.Add(this.cboLoaiXe);
            this.Controls.Add(this.cboHangXe);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblHanhTrinh);
            this.Controls.Add(this.lblLoaiXe);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblHangXe);
            this.Controls.Add(this.lblSoXe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSoXe);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmXe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Xe";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongGhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongKhachHang)).EndInit();
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
    }
}