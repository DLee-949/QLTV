namespace QLTV
{
    partial class frmPhieuPhat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpNgayPhat = new System.Windows.Forms.DateTimePicker();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.txtPhiPhat = new System.Windows.Forms.TextBox();
            this.lblPhiPhat = new System.Windows.Forms.Label();
            this.lblNgayPhat = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.lblMaPhieuMuon = new System.Windows.Forms.Label();
            this.txtMaPhieuPhat = new System.Windows.Forms.TextBox();
            this.lblMaPhieuPhat = new System.Windows.Forms.Label();
            this.dgvPhieuPhat = new System.Windows.Forms.DataGridView();
            this.btnInPhieuPhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.MaPhieuPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(576, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH PHIẾU PHẠT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPhieuMuon);
            this.groupBox1.Controls.Add(this.txtMaDocGia);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtpNgayPhat);
            this.groupBox1.Controls.Add(this.txtLyDo);
            this.groupBox1.Controls.Add(this.lblLyDo);
            this.groupBox1.Controls.Add(this.txtPhiPhat);
            this.groupBox1.Controls.Add(this.lblPhiPhat);
            this.groupBox1.Controls.Add(this.lblNgayPhat);
            this.groupBox1.Controls.Add(this.lblMaDocGia);
            this.groupBox1.Controls.Add(this.lblMaPhieuMuon);
            this.groupBox1.Controls.Add(this.txtMaPhieuPhat);
            this.groupBox1.Controls.Add(this.lblMaPhieuPhat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1421, 171);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu phạt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(317, 75);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(204, 30);
            this.txtMaPhieuMuon.TabIndex = 16;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDocGia.Location = new System.Drawing.Point(317, 126);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(204, 30);
            this.txtMaDocGia.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(1218, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(1084, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpNgayPhat
            // 
            this.dtpNgayPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayPhat.Location = new System.Drawing.Point(750, 30);
            this.dtpNgayPhat.Name = "dtpNgayPhat";
            this.dtpNgayPhat.Size = new System.Drawing.Size(246, 30);
            this.dtpNgayPhat.TabIndex = 12;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.Location = new System.Drawing.Point(748, 126);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(248, 30);
            this.txtLyDo.TabIndex = 11;
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyDo.Location = new System.Drawing.Point(623, 129);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(65, 25);
            this.lblLyDo.TabIndex = 10;
            this.lblLyDo.Text = "Lý do";
            // 
            // txtPhiPhat
            // 
            this.txtPhiPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhiPhat.Location = new System.Drawing.Point(750, 75);
            this.txtPhiPhat.Name = "txtPhiPhat";
            this.txtPhiPhat.Size = new System.Drawing.Size(248, 30);
            this.txtPhiPhat.TabIndex = 9;
            // 
            // lblPhiPhat
            // 
            this.lblPhiPhat.AutoSize = true;
            this.lblPhiPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhiPhat.Location = new System.Drawing.Point(623, 76);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(91, 25);
            this.lblPhiPhat.TabIndex = 8;
            this.lblPhiPhat.Text = "Phí phạt";
            // 
            // lblNgayPhat
            // 
            this.lblNgayPhat.AutoSize = true;
            this.lblNgayPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayPhat.Location = new System.Drawing.Point(623, 28);
            this.lblNgayPhat.Name = "lblNgayPhat";
            this.lblNgayPhat.Size = new System.Drawing.Size(110, 25);
            this.lblNgayPhat.TabIndex = 6;
            this.lblNgayPhat.Text = "Ngày phạt";
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDocGia.Location = new System.Drawing.Point(150, 131);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(118, 25);
            this.lblMaDocGia.TabIndex = 4;
            this.lblMaDocGia.Text = "Mã độc giả";
            // 
            // lblMaPhieuMuon
            // 
            this.lblMaPhieuMuon.AutoSize = true;
            this.lblMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuMuon.Location = new System.Drawing.Point(150, 78);
            this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
            this.lblMaPhieuMuon.Size = new System.Drawing.Size(160, 25);
            this.lblMaPhieuMuon.TabIndex = 2;
            this.lblMaPhieuMuon.Text = "Mã phiếu mượn";
            // 
            // txtMaPhieuPhat
            // 
            this.txtMaPhieuPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuPhat.Location = new System.Drawing.Point(317, 23);
            this.txtMaPhieuPhat.Name = "txtMaPhieuPhat";
            this.txtMaPhieuPhat.Size = new System.Drawing.Size(204, 30);
            this.txtMaPhieuPhat.TabIndex = 1;
            // 
            // lblMaPhieuPhat
            // 
            this.lblMaPhieuPhat.AutoSize = true;
            this.lblMaPhieuPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuPhat.Location = new System.Drawing.Point(150, 28);
            this.lblMaPhieuPhat.Name = "lblMaPhieuPhat";
            this.lblMaPhieuPhat.Size = new System.Drawing.Size(149, 25);
            this.lblMaPhieuPhat.TabIndex = 0;
            this.lblMaPhieuPhat.Text = "Mã phiếu phạt";
            // 
            // dgvPhieuPhat
            // 
            this.dgvPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuPhat,
            this.MaPhieuMuon,
            this.MaDocGia,
            this.TenDocGia,
            this.PhiPhat,
            this.NgayPhat,
            this.LyDo});
            this.dgvPhieuPhat.Location = new System.Drawing.Point(44, 225);
            this.dgvPhieuPhat.Name = "dgvPhieuPhat";
            this.dgvPhieuPhat.RowHeadersWidth = 51;
            this.dgvPhieuPhat.RowTemplate.Height = 24;
            this.dgvPhieuPhat.Size = new System.Drawing.Size(1421, 478);
            this.dgvPhieuPhat.TabIndex = 4;
            this.dgvPhieuPhat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuPhat_CellContentClick);
            // 
            // btnInPhieuPhat
            // 
            this.btnInPhieuPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieuPhat.Location = new System.Drawing.Point(44, 720);
            this.btnInPhieuPhat.Name = "btnInPhieuPhat";
            this.btnInPhieuPhat.Size = new System.Drawing.Size(151, 50);
            this.btnInPhieuPhat.TabIndex = 5;
            this.btnInPhieuPhat.Text = "In phiếu phạt";
            this.btnInPhieuPhat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThem.Location = new System.Drawing.Point(870, 720);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 50);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSua.Location = new System.Drawing.Point(1024, 720);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 50);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnXoa.Location = new System.Drawing.Point(1177, 720);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 50);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1368, 720);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 50);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MaPhieuPhat
            // 
            this.MaPhieuPhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhieuPhat.DataPropertyName = "MaPhieuPhat";
            this.MaPhieuPhat.HeaderText = "Mã phiếu phạt";
            this.MaPhieuPhat.MinimumWidth = 6;
            this.MaPhieuPhat.Name = "MaPhieuPhat";
            this.MaPhieuPhat.ReadOnly = true;
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.MaPhieuMuon.HeaderText = "Mã phiếu mượn";
            this.MaPhieuMuon.MinimumWidth = 6;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            this.MaPhieuMuon.ReadOnly = true;
            // 
            // MaDocGia
            // 
            this.MaDocGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            // 
            // TenDocGia
            // 
            this.TenDocGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên độc giả";
            this.TenDocGia.MinimumWidth = 6;
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.ReadOnly = true;
            // 
            // PhiPhat
            // 
            this.PhiPhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhiPhat.DataPropertyName = "PhiPhat";
            this.PhiPhat.HeaderText = "Phí phạt";
            this.PhiPhat.MinimumWidth = 6;
            this.PhiPhat.Name = "PhiPhat";
            this.PhiPhat.ReadOnly = true;
            // 
            // NgayPhat
            // 
            this.NgayPhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayPhat.DataPropertyName = "NgayPhat";
            this.NgayPhat.HeaderText = "Ngày phạt";
            this.NgayPhat.MinimumWidth = 6;
            this.NgayPhat.Name = "NgayPhat";
            this.NgayPhat.ReadOnly = true;
            // 
            // LyDo
            // 
            this.LyDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            // 
            // frmPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 801);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnInPhieuPhat);
            this.Controls.Add(this.dgvPhieuPhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuPhat";
            this.Text = "frmPhieuPhat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaPhieuPhat;
        private System.Windows.Forms.Label lblMaPhieuPhat;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label lblMaPhieuMuon;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtPhiPhat;
        private System.Windows.Forms.Label lblPhiPhat;
        private System.Windows.Forms.Label lblNgayPhat;
        private System.Windows.Forms.DateTimePicker dtpNgayPhat;
        private System.Windows.Forms.DataGridView dgvPhieuPhat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInPhieuPhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
    }
}