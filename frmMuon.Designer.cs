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
            this.phieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddDG = new System.Windows.Forms.Button();
            this.grdCTPM = new System.Windows.Forms.DataGridView();
            this.cTPhieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenTLPM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaTLPM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgayMuonPM = new System.Windows.Forms.TextBox();
            this.txtHanTraPM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTTPM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).BeginInit();
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
            this.grdPhieuMuon.Location = new System.Drawing.Point(16, 97);
            this.grdPhieuMuon.Name = "grdPhieuMuon";
            this.grdPhieuMuon.RowHeadersWidth = 51;
            this.grdPhieuMuon.RowTemplate.Height = 24;
            this.grdPhieuMuon.Size = new System.Drawing.Size(371, 540);
            this.grdPhieuMuon.TabIndex = 3;
            // 
            // phieuMuonBindingSource
            // 
            this.phieuMuonBindingSource.DataMember = "PhieuMuon";
            // 
            // groupBox1
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(437, 588);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(945, 181);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnAddDG);
            this.groupBox3.Controls.Add(this.grdCTPM);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(437, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(945, 453);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết phiếu mượn";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(732, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 46);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cập nhật";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(497, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(258, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // btnAddDG
            // 
            this.btnAddDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDG.Location = new System.Drawing.Point(22, 388);
            this.btnAddDG.Name = "btnAddDG";
            this.btnAddDG.Size = new System.Drawing.Size(190, 46);
            this.btnAddDG.TabIndex = 10;
            this.btnAddDG.Text = "Thêm";
            this.btnAddDG.UseVisualStyleBackColor = true;
            this.btnAddDG.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // grdCTPM
            // 
            this.grdCTPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCTPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCTPM.Location = new System.Drawing.Point(22, 97);
            this.grdCTPM.Name = "grdCTPM";
            this.grdCTPM.RowHeadersWidth = 51;
            this.grdCTPM.RowTemplate.Height = 24;
            this.grdCTPM.Size = new System.Drawing.Size(900, 285);
            this.grdCTPM.TabIndex = 5;
            // 
            // cTPhieuMuonBindingSource
            // 
            this.cTPhieuMuonBindingSource.DataMember = "CTPhieuMuon";
            // 
            // txtTenTLPM
            // 
            this.txtTenTLPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTLPM.Location = new System.Drawing.Point(165, 93);
            this.txtTenTLPM.Name = "txtTenTLPM";
            this.txtTenTLPM.Size = new System.Drawing.Size(255, 27);
            this.txtTenTLPM.TabIndex = 2;
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
            // txtMaTLPM
            // 
            this.txtMaTLPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTLPM.Location = new System.Drawing.Point(165, 60);
            this.txtMaTLPM.Name = "txtMaTLPM";
            this.txtMaTLPM.Size = new System.Drawing.Size(255, 27);
            this.txtMaTLPM.TabIndex = 2;
            this.txtMaTLPM.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
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
            // txtMaPM
            // 
            this.txtMaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPM.Location = new System.Drawing.Point(165, 27);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(255, 27);
            this.txtMaPM.TabIndex = 2;
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
            // txtNgayMuonPM
            // 
            this.txtNgayMuonPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayMuonPM.Location = new System.Drawing.Point(610, 27);
            this.txtNgayMuonPM.Name = "txtNgayMuonPM";
            this.txtNgayMuonPM.Size = new System.Drawing.Size(255, 27);
            this.txtNgayMuonPM.TabIndex = 2;
            // 
            // txtHanTraPM
            // 
            this.txtHanTraPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHanTraPM.Location = new System.Drawing.Point(610, 60);
            this.txtHanTraPM.Name = "txtHanTraPM";
            this.txtHanTraPM.Size = new System.Drawing.Size(255, 27);
            this.txtHanTraPM.TabIndex = 2;
            this.txtHanTraPM.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày mượn";
            // 
            // txtTTPM
            // 
            this.txtTTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTPM.Location = new System.Drawing.Point(610, 93);
            this.txtTTPM.Name = "txtTTPM";
            this.txtTTPM.Size = new System.Drawing.Size(255, 27);
            this.txtTTPM.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hạn trả";
            this.label4.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trạng thái";
            // 
            // frmMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 844);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMuon";
            this.Text = "frmMuon";
            this.Load += new System.EventHandler(this.frmMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.BindingSource phieuMuonBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource cTPhieuMuonBindingSource;
        private System.Windows.Forms.DataGridView grdCTPM;
        private System.Windows.Forms.Button btnAddDG;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
    }
}