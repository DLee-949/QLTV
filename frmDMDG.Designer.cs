namespace QLTV
{
    partial class frmDMDG
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
            this.grdDMDG = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateDG = new System.Windows.Forms.Button();
            this.btnDeleteDG = new System.Windows.Forms.Button();
            this.btnEditDG = new System.Windows.Forms.Button();
            this.btnAddDG = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefreshDMDG = new System.Windows.Forms.Button();
            this.btnXuatDMDG = new System.Windows.Forms.Button();
            this.txtGTDMDG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comTruongDMDG = new System.Windows.Forms.ComboBox();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDMDG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(593, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH MỤC ĐỘC GIẢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdDMDG
            // 
            this.grdDMDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDMDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDMDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDMDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.TenDocGia,
            this.Email,
            this.SDT});
            this.grdDMDG.Location = new System.Drawing.Point(33, 196);
            this.grdDMDG.Name = "grdDMDG";
            this.grdDMDG.RowHeadersWidth = 51;
            this.grdDMDG.RowTemplate.Height = 24;
            this.grdDMDG.Size = new System.Drawing.Size(863, 465);
            this.grdDMDG.TabIndex = 2;
            this.grdDMDG.TabStop = false;
            this.grdDMDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDMDG_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateDG);
            this.groupBox1.Controls.Add(this.btnDeleteDG);
            this.groupBox1.Controls.Add(this.btnEditDG);
            this.groupBox1.Controls.Add(this.btnAddDG);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.txtTenDG);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaDG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(925, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 592);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdateDG
            // 
            this.btnUpdateDG.Enabled = false;
            this.btnUpdateDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDG.Location = new System.Drawing.Point(18, 528);
            this.btnUpdateDG.Name = "btnUpdateDG";
            this.btnUpdateDG.Size = new System.Drawing.Size(448, 46);
            this.btnUpdateDG.TabIndex = 2;
            this.btnUpdateDG.TabStop = false;
            this.btnUpdateDG.Text = "Cập nhật";
            this.btnUpdateDG.UseVisualStyleBackColor = true;
            this.btnUpdateDG.Click += new System.EventHandler(this.btnUpdateDG_Click);
            // 
            // btnDeleteDG
            // 
            this.btnDeleteDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDG.Location = new System.Drawing.Point(18, 457);
            this.btnDeleteDG.Name = "btnDeleteDG";
            this.btnDeleteDG.Size = new System.Drawing.Size(448, 46);
            this.btnDeleteDG.TabIndex = 2;
            this.btnDeleteDG.TabStop = false;
            this.btnDeleteDG.Text = "Xoá";
            this.btnDeleteDG.UseVisualStyleBackColor = true;
            this.btnDeleteDG.Click += new System.EventHandler(this.btnDeleteDG_Click);
            // 
            // btnEditDG
            // 
            this.btnEditDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDG.Location = new System.Drawing.Point(18, 383);
            this.btnEditDG.Name = "btnEditDG";
            this.btnEditDG.Size = new System.Drawing.Size(448, 46);
            this.btnEditDG.TabIndex = 2;
            this.btnEditDG.TabStop = false;
            this.btnEditDG.Text = "Sửa";
            this.btnEditDG.UseVisualStyleBackColor = true;
            this.btnEditDG.Click += new System.EventHandler(this.btnEditDG_Click);
            // 
            // btnAddDG
            // 
            this.btnAddDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDG.Location = new System.Drawing.Point(18, 310);
            this.btnAddDG.Name = "btnAddDG";
            this.btnAddDG.Size = new System.Drawing.Size(448, 46);
            this.btnAddDG.TabIndex = 2;
            this.btnAddDG.TabStop = false;
            this.btnAddDG.Text = "Thêm";
            this.btnAddDG.UseVisualStyleBackColor = true;
            this.btnAddDG.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(161, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 34);
            this.txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(161, 241);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(305, 34);
            this.txtSdt.TabIndex = 4;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDG.Location = new System.Drawing.Point(161, 91);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(305, 34);
            this.txtTenDG.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên độc giả";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(161, 21);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(305, 34);
            this.txtMaDG.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã độc giả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshDMDG);
            this.groupBox2.Controls.Add(this.btnXuatDMDG);
            this.groupBox2.Controls.Add(this.txtGTDMDG);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comTruongDMDG);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(863, 121);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc dữ liệu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnRefreshDMDG
            // 
            this.btnRefreshDMDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDMDG.Location = new System.Drawing.Point(593, 78);
            this.btnRefreshDMDG.Name = "btnRefreshDMDG";
            this.btnRefreshDMDG.Size = new System.Drawing.Size(247, 37);
            this.btnRefreshDMDG.TabIndex = 4;
            this.btnRefreshDMDG.Text = "Làm mới";
            this.btnRefreshDMDG.UseVisualStyleBackColor = true;
            this.btnRefreshDMDG.Click += new System.EventHandler(this.btnRefreshDMDG_Click);
            // 
            // btnXuatDMDG
            // 
            this.btnXuatDMDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatDMDG.Location = new System.Drawing.Point(306, 78);
            this.btnXuatDMDG.Name = "btnXuatDMDG";
            this.btnXuatDMDG.Size = new System.Drawing.Size(247, 37);
            this.btnXuatDMDG.TabIndex = 4;
            this.btnXuatDMDG.Text = "Thống kê độc giả";
            this.btnXuatDMDG.UseVisualStyleBackColor = true;
            this.btnXuatDMDG.Click += new System.EventHandler(this.btnXuatDMDG_Click);
            // 
            // txtGTDMDG
            // 
            this.txtGTDMDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTDMDG.Location = new System.Drawing.Point(274, 35);
            this.txtGTDMDG.Name = "txtGTDMDG";
            this.txtGTDMDG.Size = new System.Drawing.Size(566, 30);
            this.txtGTDMDG.TabIndex = 3;
            this.txtGTDMDG.TextChanged += new System.EventHandler(this.txtGTDMDG_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(241, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "=";
            // 
            // comTruongDMDG
            // 
            this.comTruongDMDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTruongDMDG.FormattingEnabled = true;
            this.comTruongDMDG.Items.AddRange(new object[] {
            "MaDocGia",
            "TenDocGia",
            "Email",
            "SDT"});
            this.comTruongDMDG.Location = new System.Drawing.Point(21, 35);
            this.comTruongDMDG.Name = "comTruongDMDG";
            this.comTruongDMDG.Size = new System.Drawing.Size(214, 33);
            this.comTruongDMDG.TabIndex = 0;
            this.comTruongDMDG.SelectedIndexChanged += new System.EventHandler(this.comTruongDMDG_SelectedIndexChanged);
            // 
            // MaDocGia
            // 
            this.MaDocGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.Width = 103;
            // 
            // TenDocGia
            // 
            this.TenDocGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên độc giả";
            this.TenDocGia.MinimumWidth = 6;
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.Width = 108;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 70;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 114;
            // 
            // frmDMDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 682);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDMDG);
            this.Controls.Add(this.label1);
            this.Name = "frmDMDG";
            this.Text = "frmDMDG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDMDG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDMDG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDMDG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteDG;
        private System.Windows.Forms.Button btnEditDG;
        private System.Windows.Forms.Button btnAddDG;
        private System.Windows.Forms.Button btnUpdateDG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGTDMDG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comTruongDMDG;
        private System.Windows.Forms.Button btnRefreshDMDG;
        private System.Windows.Forms.Button btnXuatDMDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}