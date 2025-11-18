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
            this.txtGTPM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comTruongPM = new System.Windows.Forms.ComboBox();
            this.cTPhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenDGPM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDGPM = new System.Windows.Forms.TextBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCTPM = new System.Windows.Forms.Button();
            this.btnAddPM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuMuonBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(390, 29);
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
            this.grdPhieuMuon.Size = new System.Drawing.Size(454, 555);
            this.grdPhieuMuon.TabIndex = 3;
            this.grdPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPhieuMuon_CellContentClick);
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
            this.groupBox1.Size = new System.Drawing.Size(492, 657);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu mượn";
            // 
            // txtGTPM
            // 
            this.txtGTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTPM.Location = new System.Drawing.Point(182, 31);
            this.txtGTPM.Name = "txtGTPM";
            this.txtGTPM.Size = new System.Drawing.Size(288, 30);
            this.txtGTPM.TabIndex = 16;
            this.txtGTPM.TextChanged += new System.EventHandler(this.txtGTPM_TextChanged);
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
            // cTPhieuMuonBindingSource
            // 
            this.cTPhieuMuonBindingSource.DataMember = "CTPhieuMuon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tên độc giả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mã độc giả";
            // 
            // txtTenDGPM
            // 
            this.txtTenDGPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDGPM.Location = new System.Drawing.Point(166, 135);
            this.txtTenDGPM.Name = "txtTenDGPM";
            this.txtTenDGPM.Size = new System.Drawing.Size(283, 27);
            this.txtTenDGPM.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // txtMaDGPM
            // 
            this.txtMaDGPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDGPM.Location = new System.Drawing.Point(166, 86);
            this.txtMaDGPM.Name = "txtMaDGPM";
            this.txtMaDGPM.Size = new System.Drawing.Size(283, 27);
            this.txtMaDGPM.TabIndex = 8;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPM.Location = new System.Drawing.Point(166, 37);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(283, 27);
            this.txtMaPM.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaPM);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMaDGPM);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTenDGPM);
            this.groupBox2.Location = new System.Drawing.Point(529, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 211);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnCTPM
            // 
            this.btnCTPM.Location = new System.Drawing.Point(529, 349);
            this.btnCTPM.Name = "btnCTPM";
            this.btnCTPM.Size = new System.Drawing.Size(203, 52);
            this.btnCTPM.TabIndex = 14;
            this.btnCTPM.Text = "Chi tiết phiếu mượn";
            this.btnCTPM.UseVisualStyleBackColor = true;
            this.btnCTPM.Click += new System.EventHandler(this.btnCTPM_Click);
            // 
            // btnAddPM
            // 
            this.btnAddPM.Location = new System.Drawing.Point(529, 416);
            this.btnAddPM.Name = "btnAddPM";
            this.btnAddPM.Size = new System.Drawing.Size(203, 52);
            this.btnAddPM.TabIndex = 14;
            this.btnAddPM.Text = "Lập phiếu mượn";
            this.btnAddPM.UseVisualStyleBackColor = true;
            // 
            // frmMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 789);
            this.Controls.Add(this.btnAddPM);
            this.Controls.Add(this.btnCTPM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMuon";
            this.Text = "frmMuon";
            this.Load += new System.EventHandler(this.frmMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuMuonBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPhieuMuon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource cTPhieuMuonBindingSource;
        private System.Windows.Forms.TextBox txtGTPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comTruongPM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenDGPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDGPM;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCTPM;
        private System.Windows.Forms.Button btnAddPM;
    }
}