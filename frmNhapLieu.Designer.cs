namespace QLTV
{
    partial class frmNhapLieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaTacGia = new System.Windows.Forms.Label();
            this.lblTenTacGia = new System.Windows.Forms.Label();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.lblChonTaiLieu = new System.Windows.Forms.Label();
            this.cboTaiLieu = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblMaTaiLieu = new System.Windows.Forms.Label();
            this.txtMaTaiLieu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT TÁC GIẢ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMaTacGia
            // 
            this.lblMaTacGia.AutoSize = true;
            this.lblMaTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTacGia.Location = new System.Drawing.Point(32, 121);
            this.lblMaTacGia.Name = "lblMaTacGia";
            this.lblMaTacGia.Size = new System.Drawing.Size(92, 20);
            this.lblMaTacGia.TabIndex = 1;
            this.lblMaTacGia.Text = "Mã tác giả";
            // 
            // lblTenTacGia
            // 
            this.lblTenTacGia.AutoSize = true;
            this.lblTenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTacGia.Location = new System.Drawing.Point(32, 169);
            this.lblTenTacGia.Name = "lblTenTacGia";
            this.lblTenTacGia.Size = new System.Drawing.Size(98, 20);
            this.lblTenTacGia.TabIndex = 2;
            this.lblTenTacGia.Text = "Tên tác giả";
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTacGia.Location = new System.Drawing.Point(148, 118);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(220, 26);
            this.txtMaTacGia.TabIndex = 3;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTacGia.Location = new System.Drawing.Point(148, 163);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(220, 26);
            this.txtTenTacGia.TabIndex = 4;
            // 
            // lblChonTaiLieu
            // 
            this.lblChonTaiLieu.AutoSize = true;
            this.lblChonTaiLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonTaiLieu.Location = new System.Drawing.Point(407, 169);
            this.lblChonTaiLieu.Name = "lblChonTaiLieu";
            this.lblChonTaiLieu.Size = new System.Drawing.Size(109, 20);
            this.lblChonTaiLieu.TabIndex = 5;
            this.lblChonTaiLieu.Text = "Chọn tài liệu";
            this.lblChonTaiLieu.Click += new System.EventHandler(this.lblChonTaiLieu_Click);
            // 
            // cboTaiLieu
            // 
            this.cboTaiLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTaiLieu.FormattingEnabled = true;
            this.cboTaiLieu.Location = new System.Drawing.Point(532, 166);
            this.cboTaiLieu.Name = "cboTaiLieu";
            this.cboTaiLieu.Size = new System.Drawing.Size(269, 28);
            this.cboTaiLieu.TabIndex = 6;
            this.cboTaiLieu.SelectedIndexChanged += new System.EventHandler(this.cboTaiLieu_SelectedIndexChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLuu.Location = new System.Drawing.Point(595, 359);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 32);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnHuy.Location = new System.Drawing.Point(704, 359);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 32);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblMaTaiLieu
            // 
            this.lblMaTaiLieu.AutoSize = true;
            this.lblMaTaiLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTaiLieu.Location = new System.Drawing.Point(407, 121);
            this.lblMaTaiLieu.Name = "lblMaTaiLieu";
            this.lblMaTaiLieu.Size = new System.Drawing.Size(91, 20);
            this.lblMaTaiLieu.TabIndex = 9;
            this.lblMaTaiLieu.Text = "Mã tài liệu";
            this.lblMaTaiLieu.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMaTaiLieu
            // 
            this.txtMaTaiLieu.Enabled = false;
            this.txtMaTaiLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTaiLieu.Location = new System.Drawing.Point(532, 115);
            this.txtMaTaiLieu.Name = "txtMaTaiLieu";
            this.txtMaTaiLieu.ReadOnly = true;
            this.txtMaTaiLieu.Size = new System.Drawing.Size(269, 26);
            this.txtMaTaiLieu.TabIndex = 10;
            this.txtMaTaiLieu.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // frmNhapLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 436);
            this.Controls.Add(this.txtMaTaiLieu);
            this.Controls.Add(this.lblMaTaiLieu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboTaiLieu);
            this.Controls.Add(this.lblChonTaiLieu);
            this.Controls.Add(this.txtTenTacGia);
            this.Controls.Add(this.txtMaTacGia);
            this.Controls.Add(this.lblTenTacGia);
            this.Controls.Add(this.lblMaTacGia);
            this.Controls.Add(this.label1);
            this.Name = "frmNhapLieu";
            this.Text = "frmNhapLieu";
            this.Load += new System.EventHandler(this.frmNhapLieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaTacGia;
        private System.Windows.Forms.Label lblTenTacGia;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.Label lblChonTaiLieu;
        private System.Windows.Forms.ComboBox cboTaiLieu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblMaTaiLieu;
        private System.Windows.Forms.TextBox txtMaTaiLieu;
    }
}