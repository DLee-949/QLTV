namespace QLTV
{
    partial class frmMuon
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
            this.label1 = new System.Windows.Forms.Label();
            this.grdPhieuMuon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTTPM = new System.Windows.Forms.TextBox();
            this.txtTenTLPM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHanTraPM = new System.Windows.Forms.TextBox();
            this.txtNgayMuonPM = new System.Windows.Forms.TextBox();
            this.txtMaTLPM = new System.Windows.Forms.TextBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateCTPM = new System.Windows.Forms.Button();
            this.btnEditCTPM = new System.Windows.Forms.Button();
            this.btnDeleteCTPM = new System.Windows.Forms.Button();
            this.btnAddCTPM = new System.Windows.Forms.Button();
            this.grdCTPM = new System.Windows.Forms.DataGridView();
            this.cTPhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtGTCTPM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comTruongCTPM = new System.Windows.Forms.ComboBox();
            this.txtGTPM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comTruongPM = new System.Windows.Forms.ComboBox();
            this.btnXuatCTPM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCTPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuMuonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(596, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU MƯỢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdPhieuMuon
            // 
            this.grdPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPhieuMuon.Location = new System.Drawing.Point(16, 82);
            this.grdPhieuMuon.Name = "grdPhieuMuon";
            this.grdPhieuMuon.RowHeadersWidth = 51;
            this.grdPhieuMuon.RowTemplate.Height = 24;
            this.grdPhieuMuon.Size = new System.Drawing.Size(371, 555);
            this.grdPhieuMuon.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGTPM);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comTruongPM);
            this.groupBox1.Controls.Add(this.grdPhieuMuon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 657);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu mượn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTTPM);
            this.groupBox2.Controls.Add(this.txtTenTLPM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtHanTraPM);
            this.groupBox2.Controls.Add(this.txtNgayMuonPM);
            this.groupBox2.Controls.Add(this.txtMaTLPM);
            this.groupBox2.Controls.Add(this.txtMaPM);
            this.groupBox2.Location = new System.Drawing.Point(437, 627);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(945, 142);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trạng thái";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tên tài liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hạn trả";
            this.label4.Click += new System.EventHandler(this.label9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã tài liệu";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtTTPM
            // 
            this.txtTTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTPM.Location = new System.Drawing.Point(639, 93);
            this.txtTTPM.Name = "txtTTPM";
            this.txtTTPM.Size = new System.Drawing.Size(283, 27);
            this.txtTTPM.TabIndex = 2;
            // 
            // txtTenTLPM
            // 
            this.txtTenTLPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTLPM.Location = new System.Drawing.Point(165, 93);
            this.txtTenTLPM.Name = "txtTenTLPM";
            this.txtTenTLPM.Size = new System.Drawing.Size(283, 27);
            this.txtTenTLPM.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // txtHanTraPM
            // 
            this.txtHanTraPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHanTraPM.Location = new System.Drawing.Point(639, 60);
            this.txtHanTraPM.Name = "txtHanTraPM";
            this.txtHanTraPM.Size = new System.Drawing.Size(283, 27);
            this.txtHanTraPM.TabIndex = 2;
            this.txtHanTraPM.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtNgayMuonPM
            // 
            this.txtNgayMuonPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayMuonPM.Location = new System.Drawing.Point(639, 27);
            this.txtNgayMuonPM.Name = "txtNgayMuonPM";
            this.txtNgayMuonPM.Size = new System.Drawing.Size(283, 27);
            this.txtNgayMuonPM.TabIndex = 2;
            // 
            // txtMaTLPM
            // 
            this.txtMaTLPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTLPM.Location = new System.Drawing.Point(165, 60);
            this.txtMaTLPM.Name = "txtMaTLPM";
            this.txtMaTLPM.Size = new System.Drawing.Size(283, 27);
            this.txtMaTLPM.TabIndex = 2;
            this.txtMaTLPM.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtMaPM
            // 
            this.txtMaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPM.Location = new System.Drawing.Point(165, 27);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(283, 27);
            this.txtMaPM.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGTCTPM);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comTruongCTPM);
            this.groupBox3.Controls.Add(this.btnXuatCTPM);
            this.groupBox3.Controls.Add(this.btnUpdateCTPM);
            this.groupBox3.Controls.Add(this.btnEditCTPM);
            this.groupBox3.Controls.Add(this.btnDeleteCTPM);
            this.groupBox3.Controls.Add(this.btnAddCTPM);
            this.groupBox3.Controls.Add(this.grdCTPM);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(437, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(945, 509);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết phiếu mượn";
            // 
            // btnUpdateCTPM
            // 
            this.btnUpdateCTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCTPM.Location = new System.Drawing.Point(583, 447);
            this.btnUpdateCTPM.Name = "btnUpdateCTPM";
            this.btnUpdateCTPM.Size = new System.Drawing.Size(153, 46);
            this.btnUpdateCTPM.TabIndex = 10;
            this.btnUpdateCTPM.Text = "Cập nhật";
            this.btnUpdateCTPM.UseVisualStyleBackColor = true;
            this.btnUpdateCTPM.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // btnEditCTPM
            // 
            this.btnEditCTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCTPM.Location = new System.Drawing.Point(392, 447);
            this.btnEditCTPM.Name = "btnEditCTPM";
            this.btnEditCTPM.Size = new System.Drawing.Size(153, 46);
            this.btnEditCTPM.TabIndex = 10;
            this.btnEditCTPM.Text = "Sửa";
            this.btnEditCTPM.UseVisualStyleBackColor = true;
            this.btnEditCTPM.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // btnDeleteCTPM
            // 
            this.btnDeleteCTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCTPM.Location = new System.Drawing.Point(207, 447);
            this.btnDeleteCTPM.Name = "btnDeleteCTPM";
            this.btnDeleteCTPM.Size = new System.Drawing.Size(153, 46);
            this.btnDeleteCTPM.TabIndex = 10;
            this.btnDeleteCTPM.Text = "Xoá";
            this.btnDeleteCTPM.UseVisualStyleBackColor = true;
            this.btnDeleteCTPM.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // btnAddCTPM
            // 
            this.btnAddCTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCTPM.Location = new System.Drawing.Point(22, 447);
            this.btnAddCTPM.Name = "btnAddCTPM";
            this.btnAddCTPM.Size = new System.Drawing.Size(153, 46);
            this.btnAddCTPM.TabIndex = 10;
            this.btnAddCTPM.Text = "Thêm";
            this.btnAddCTPM.UseVisualStyleBackColor = true;
            this.btnAddCTPM.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // grdCTPM
            // 
            this.grdCTPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCTPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCTPM.Location = new System.Drawing.Point(22, 82);
            this.grdCTPM.Name = "grdCTPM";
            this.grdCTPM.RowHeadersWidth = 51;
            this.grdCTPM.RowTemplate.Height = 24;
            this.grdCTPM.Size = new System.Drawing.Size(900, 348);
            this.grdCTPM.TabIndex = 5;
            // 
            // cTPhieuMuonBindingSource
            // 
            this.cTPhieuMuonBindingSource.DataMember = "CTPhieuMuon";
            // 
            // txtGTCTPM
            // 
            this.txtGTCTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTCTPM.Location = new System.Drawing.Point(321, 30);
            this.txtGTCTPM.Name = "txtGTCTPM";
            this.txtGTCTPM.Size = new System.Drawing.Size(601, 30);
            this.txtGTCTPM.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(288, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "=";
            // 
            // comTruongCTPM
            // 
            this.comTruongCTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTruongCTPM.FormattingEnabled = true;
            this.comTruongCTPM.Items.AddRange(new object[] {
            "MaPhieuMuon",
            "MaTaiLieu",
            "TenTaiLieu",
            "NgayMuon",
            "TrangThai",
            "HanTra"});
            this.comTruongCTPM.Location = new System.Drawing.Point(22, 31);
            this.comTruongCTPM.Name = "comTruongCTPM";
            this.comTruongCTPM.Size = new System.Drawing.Size(260, 33);
            this.comTruongCTPM.TabIndex = 11;
            // 
            // txtGTPM
            // 
            this.txtGTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTPM.Location = new System.Drawing.Point(182, 31);
            this.txtGTPM.Name = "txtGTPM";
            this.txtGTPM.Size = new System.Drawing.Size(205, 30);
            this.txtGTPM.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(149, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "=";
            // 
            // comTruongPM
            // 
            this.comTruongPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTruongPM.FormattingEnabled = true;
            this.comTruongPM.Items.AddRange(new object[] {
            "MaPhieuMuon",
            "MaDocGia",
            "TenDocGia"});
            this.comTruongPM.Location = new System.Drawing.Point(16, 31);
            this.comTruongPM.Name = "comTruongPM";
            this.comTruongPM.Size = new System.Drawing.Size(127, 33);
            this.comTruongPM.TabIndex = 14;
            // 
            // btnXuatCTPM
            // 
            this.btnXuatCTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatCTPM.Location = new System.Drawing.Point(769, 447);
            this.btnXuatCTPM.Name = "btnXuatCTPM";
            this.btnXuatCTPM.Size = new System.Drawing.Size(153, 46);
            this.btnXuatCTPM.TabIndex = 10;
            this.btnXuatCTPM.Text = "Xuất dữ liệu";
            this.btnXuatCTPM.UseVisualStyleBackColor = true;
            this.btnXuatCTPM.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // frmMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 789);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMuon";
            this.Text = "frmMuon";
            this.Load += new System.EventHandler(this.frmMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCTPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuMuonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPhieuMuon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource cTPhieuMuonBindingSource;
        private System.Windows.Forms.DataGridView grdCTPM;
        private System.Windows.Forms.Button btnAddCTPM;
        private System.Windows.Forms.Button btnUpdateCTPM;
        private System.Windows.Forms.Button btnEditCTPM;
        private System.Windows.Forms.Button btnDeleteCTPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTTPM;
        private System.Windows.Forms.TextBox txtTenTLPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHanTraPM;
        private System.Windows.Forms.TextBox txtNgayMuonPM;
        private System.Windows.Forms.TextBox txtMaTLPM;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.TextBox txtGTPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comTruongPM;
        private System.Windows.Forms.TextBox txtGTCTPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comTruongCTPM;
        private System.Windows.Forms.Button btnXuatCTPM;
    }
}