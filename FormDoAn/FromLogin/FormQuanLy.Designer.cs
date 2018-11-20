namespace FromLogin
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
            this.lblTenBang = new System.Windows.Forms.Label();
            this.cboTenBang = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenBang
            // 
            this.lblTenBang.AutoSize = true;
            this.lblTenBang.Location = new System.Drawing.Point(28, 58);
            this.lblTenBang.Name = "lblTenBang";
            this.lblTenBang.Size = new System.Drawing.Size(115, 17);
            this.lblTenBang.TabIndex = 0;
            this.lblTenBang.Text = "Tên bảng dữ liệu";
            // 
            // cboTenBang
            // 
            this.cboTenBang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenBang.FormattingEnabled = true;
            this.cboTenBang.Items.AddRange(new object[] {
            "Loại Xe",
            "Hãng Xe",
            "Xe",
            "Khách Hàng",
            "Loại Nhân Viên",
            "Nhân Viên",
            "Tài Khoản Nhân Viên"});
            this.cboTenBang.Location = new System.Drawing.Point(149, 55);
            this.cboTenBang.Name = "cboTenBang";
            this.cboTenBang.Size = new System.Drawing.Size(198, 24);
            this.cboTenBang.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(74, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 29);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Vui Lòng Chọn Bảng Dữ Liệu";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(353, 50);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(72, 32);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Location = new System.Drawing.Point(184, 129);
            this.btnLogout.Name = "btnDangXuat";
            this.btnLogout.Size = new System.Drawing.Size(104, 32);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // frmQuanLy
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(494, 209);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cboTenBang);
            this.Controls.Add(this.lblTenBang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLy_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenBang;
        private System.Windows.Forms.ComboBox cboTenBang;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnLogout;
    }
}