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
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(292, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU MƯỢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdPhieuMuon
            // 
            this.grdPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPhieuMuon.Location = new System.Drawing.Point(12, 67);
            this.grdPhieuMuon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdPhieuMuon.Name = "grdPhieuMuon";
            this.grdPhieuMuon.RowHeadersWidth = 51;
            this.grdPhieuMuon.RowTemplate.Height = 24;
            this.grdPhieuMuon.Size = new System.Drawing.Size(340, 451);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(369, 534);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu mượn";
            // 
            // txtGTPM
            // 
            this.txtGTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTPM.Location = new System.Drawing.Point(136, 25);
            this.txtGTPM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGTPM.Name = "txtGTPM";
            this.txtGTPM.Size = new System.Drawing.Size(217, 26);
            this.txtGTPM.TabIndex = 16;
            this.txtGTPM.TextChanged += new System.EventHandler(this.txtGTPM_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(112, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 24);
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
            this.comTruongPM.Location = new System.Drawing.Point(12, 25);
            this.comTruongPM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comTruongPM.Name = "comTruongPM";
            this.comTruongPM.Size = new System.Drawing.Size(96, 28);
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
            this.label10.Location = new System.Drawing.Point(20, 112);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tên độc giả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mã độc giả";
            // 
            // txtTenDGPM
            // 
            this.txtTenDGPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDGPM.Location = new System.Drawing.Point(124, 110);
            this.txtTenDGPM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenDGPM.Name = "txtTenDGPM";
            this.txtTenDGPM.Size = new System.Drawing.Size(213, 23);
            this.txtTenDGPM.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã phiếu mượn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaDGPM
            // 
            this.txtMaDGPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDGPM.Location = new System.Drawing.Point(124, 70);
            this.txtMaDGPM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDGPM.Name = "txtMaDGPM";
            this.txtMaDGPM.Size = new System.Drawing.Size(213, 23);
            this.txtMaDGPM.TabIndex = 8;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPM.Location = new System.Drawing.Point(124, 30);
            this.txtMaPM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(213, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(397, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(367, 171);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
    }
}