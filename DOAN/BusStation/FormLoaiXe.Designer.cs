namespace BusStation
{
    partial class frmLoaiXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiXe));
            this.dgvLoaiXe = new System.Windows.Forms.DataGridView();
            this.txtTenLoaiXe = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenLoaiXe = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.imglLoaiXe = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaLoaiXe = new System.Windows.Forms.Label();
            this.txtMaLoaiXe = new System.Windows.Forms.TextBox();
            this.gbLuaChon = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiXe)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.gbLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoaiXe
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiXe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiXe.Location = new System.Drawing.Point(11, 278);
            this.dgvLoaiXe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLoaiXe.Name = "dgvLoaiXe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiXe.RowTemplate.Height = 24;
            this.dgvLoaiXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiXe.Size = new System.Drawing.Size(592, 172);
            this.dgvLoaiXe.TabIndex = 7;
            this.dgvLoaiXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgLoaiXe_CellClick);
            // 
            // txtTenLoaiXe
            // 
            this.txtTenLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiXe.Location = new System.Drawing.Point(309, 43);
            this.txtTenLoaiXe.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLoaiXe.Name = "txtTenLoaiXe";
            this.txtTenLoaiXe.Size = new System.Drawing.Size(188, 26);
            this.txtTenLoaiXe.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(126, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(355, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN CÁC LOẠI XE";
            // 
            // lblTenLoaiXe
            // 
            this.lblTenLoaiXe.AutoSize = true;
            this.lblTenLoaiXe.Location = new System.Drawing.Point(305, 22);
            this.lblTenLoaiXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenLoaiXe.Name = "lblTenLoaiXe";
            this.lblTenLoaiXe.Size = new System.Drawing.Size(97, 19);
            this.lblTenLoaiXe.TabIndex = 1;
            this.lblTenLoaiXe.Text = "Tên Loại Xe:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageKey = "flat-delete-icon-circle-remove-sign-button-vector-13229630.jpg";
            this.btnXoa.ImageList = this.imglLoaiXe;
            this.btnXoa.Location = new System.Drawing.Point(168, 38);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 36);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // imglLoaiXe
            // 
            this.imglLoaiXe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglLoaiXe.ImageStream")));
            this.imglLoaiXe.TransparentColor = System.Drawing.Color.Transparent;
            this.imglLoaiXe.Images.SetKeyName(0, "addmins.jpg");
            this.imglLoaiXe.Images.SetKeyName(1, "admin.jpg");
            this.imglLoaiXe.Images.SetKeyName(2, "arrow-sign-rotation-icon-reload-button-refresh-vector-12935532.jpg");
            this.imglLoaiXe.Images.SetKeyName(3, "dangNhap.jpg");
            this.imglLoaiXe.Images.SetKeyName(4, "dangXuat.jpg");
            this.imglLoaiXe.Images.SetKeyName(5, "dangXuat.png");
            this.imglLoaiXe.Images.SetKeyName(6, "dauTich.png");
            this.imglLoaiXe.Images.SetKeyName(7, "DauX.png");
            this.imglLoaiXe.Images.SetKeyName(8, "flat-delete-icon-circle-remove-sign-button-vector-13229630.jpg");
            this.imglLoaiXe.Images.SetKeyName(9, "luachon.png");
            this.imglLoaiXe.Images.SetKeyName(10, "sua.jpg");
            this.imglLoaiXe.Images.SetKeyName(11, "sua.png");
            this.imglLoaiXe.Images.SetKeyName(12, "tải xuống.jpg");
            this.imglLoaiXe.Images.SetKeyName(13, "them.jpg");
            this.imglLoaiXe.Images.SetKeyName(14, "timKiem.png");
            this.imglLoaiXe.Images.SetKeyName(15, "tinhTien.png");
            this.imglLoaiXe.Images.SetKeyName(16, "ungDung.jpg");
            this.imglLoaiXe.Images.SetKeyName(17, "user.jpg");
            this.imglLoaiXe.Images.SetKeyName(18, "xoa.png");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.ImageKey = "dangXuat.jpg";
            this.btnBack.ImageList = this.imglLoaiXe;
            this.btnBack.Location = new System.Drawing.Point(450, 38);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageKey = "tải xuống.jpg";
            this.btnThem.ImageList = this.imglLoaiXe;
            this.btnThem.Location = new System.Drawing.Point(27, 38);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 36);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageKey = "sua.png";
            this.btnSua.ImageList = this.imglLoaiXe;
            this.btnSua.Location = new System.Drawing.Point(309, 38);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 36);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // gbThongTin
            // 
            this.gbThongTin.BackColor = System.Drawing.SystemColors.Control;
            this.gbThongTin.Controls.Add(this.lblMaLoaiXe);
            this.gbThongTin.Controls.Add(this.txtMaLoaiXe);
            this.gbThongTin.Controls.Add(this.lblTenLoaiXe);
            this.gbThongTin.Controls.Add(this.txtTenLoaiXe);
            this.gbThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.Red;
            this.gbThongTin.Location = new System.Drawing.Point(21, 43);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(581, 77);
            this.gbThongTin.TabIndex = 8;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin";
            // 
            // lblMaLoaiXe
            // 
            this.lblMaLoaiXe.AutoSize = true;
            this.lblMaLoaiXe.Location = new System.Drawing.Point(53, 22);
            this.lblMaLoaiXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaLoaiXe.Name = "lblMaLoaiXe";
            this.lblMaLoaiXe.Size = new System.Drawing.Size(95, 19);
            this.lblMaLoaiXe.TabIndex = 1;
            this.lblMaLoaiXe.Text = "Mã Loại Xe:";
            // 
            // txtMaLoaiXe
            // 
            this.txtMaLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiXe.Location = new System.Drawing.Point(57, 43);
            this.txtMaLoaiXe.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLoaiXe.Name = "txtMaLoaiXe";
            this.txtMaLoaiXe.Size = new System.Drawing.Size(188, 26);
            this.txtMaLoaiXe.TabIndex = 2;
            // 
            // gbLuaChon
            // 
            this.gbLuaChon.BackColor = System.Drawing.SystemColors.Control;
            this.gbLuaChon.Controls.Add(this.btnThem);
            this.gbLuaChon.Controls.Add(this.btnXoa);
            this.gbLuaChon.Controls.Add(this.btnBack);
            this.gbLuaChon.Controls.Add(this.btnSua);
            this.gbLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuaChon.ForeColor = System.Drawing.Color.Red;
            this.gbLuaChon.Location = new System.Drawing.Point(21, 146);
            this.gbLuaChon.Name = "gbLuaChon";
            this.gbLuaChon.Size = new System.Drawing.Size(581, 100);
            this.gbLuaChon.TabIndex = 9;
            this.gbLuaChon.TabStop = false;
            this.gbLuaChon.Text = "Lựa Chọn";
            // 
            // frmLoaiXe
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(614, 461);
            this.ControlBox = false;
            this.Controls.Add(this.gbLuaChon);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvLoaiXe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLoaiXe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Loại Xe";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLoaiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiXe)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbLuaChon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiXe;
        private System.Windows.Forms.TextBox txtTenLoaiXe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenLoaiXe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox gbLuaChon;
        private System.Windows.Forms.ImageList imglLoaiXe;
        private System.Windows.Forms.Label lblMaLoaiXe;
        private System.Windows.Forms.TextBox txtMaLoaiXe;
    }
}