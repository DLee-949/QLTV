namespace QLTV
{
    partial class frmMain
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rbnHT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpTK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnSach = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpSearch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnMuon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnDocgia = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnTacgia = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnRpt = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.rbpBackup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDMTL = new DevExpress.XtraBars.BarButtonItem();
            this.rbpFn = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnAddTL = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteTL = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditTL = new DevExpress.XtraBars.BarButtonItem();
            this.btnMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnCTMuon = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnSL = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnCTPhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDMDocgia = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnAddDocgia = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteDocgia = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditDocgia = new DevExpress.XtraBars.BarButtonItem();
            this.btnTacgia = new DevExpress.XtraBars.BarButtonItem();
            this.btnRptNewDocgia = new DevExpress.XtraBars.BarButtonItem();
            this.btnRptPhat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnRptSLMuon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnLogin,
            this.btnLogout,
            this.btnDMTL,
            this.btnAddTL,
            this.btnDeleteTL,
            this.btnEditTL,
            this.btnMuon,
            this.btnCTMuon,
            this.btnSL,
            this.btnPhat,
            this.btnCTPhat,
            this.btnDMDocgia,
            this.btnAddDocgia,
            this.btnDeleteDocgia,
            this.btnEditDocgia,
            this.btnTacgia,
            this.btnRptNewDocgia,
            this.btnRptPhat,
            this.btnRptSLMuon,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 22;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbnHT,
            this.rbnSach,
            this.rbnMuon,
            this.rbnDocgia,
            this.rbnTacgia,
            this.rbnRpt});
            this.ribbon.Size = new System.Drawing.Size(1089, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // rbnHT
            // 
            this.rbnHT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpTK,
            this.rbpBackup});
            this.rbnHT.Name = "rbnHT";
            this.rbnHT.Text = "Hệ thống";
            // 
            // rbpTK
            // 
            this.rbpTK.ItemLinks.Add(this.btnLogin);
            this.rbpTK.ItemLinks.Add(this.btnLogout);
            this.rbpTK.Name = "rbpTK";
            this.rbpTK.Text = "Tài khoản";
            // 
            // rbnSach
            // 
            this.rbnSach.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpSearch,
            this.rbpFn,
            this.ribbonPageGroup2});
            this.rbnSach.Name = "rbnSach";
            this.rbnSach.Text = "Quản lý sách";
            // 
            // rbpSearch
            // 
            this.rbpSearch.ItemLinks.Add(this.btnDMTL);
            this.rbpSearch.Name = "rbpSearch";
            this.rbpSearch.Text = "Tra cứu";
            // 
            // rbnMuon
            // 
            this.rbnMuon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup1});
            this.rbnMuon.Name = "rbnMuon";
            this.rbnMuon.Text = "Quản lý mượn trả";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMuon);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCTMuon);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Phiếu mượn";
            // 
            // rbnDocgia
            // 
            this.rbnDocgia.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup7});
            this.rbnDocgia.Name = "rbnDocgia";
            this.rbnDocgia.Text = "Quản lý độc giả";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDMDocgia);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Tra cứu";
            // 
            // rbnTacgia
            // 
            this.rbnTacgia.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.rbnTacgia.Name = "rbnTacgia";
            this.rbnTacgia.Text = "Quản lý tác giả";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTacgia);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tác giả";
            // 
            // rbnRpt
            // 
            this.rbnRpt.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup9});
            this.rbnRpt.Name = "rbnRpt";
            this.rbnRpt.Text = "Báo cáo thống kê";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnRptNewDocgia);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnRptPhat);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Độc giả";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 646);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1089, 30);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.Name = "btnLogin";
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 2;
            this.btnLogout.Name = "btnLogout";
            // 
            // rbpBackup
            // 
            this.rbpBackup.Name = "rbpBackup";
            this.rbpBackup.Text = "Sao lưu & khôi phục";
            // 
            // btnDMTL
            // 
            this.btnDMTL.Caption = "Danh mục tài liệu";
            this.btnDMTL.Id = 3;
            this.btnDMTL.Name = "btnDMTL";
            // 
            // rbpFn
            // 
            this.rbpFn.AllowTextClipping = false;
            this.rbpFn.ItemLinks.Add(this.btnAddTL);
            this.rbpFn.ItemLinks.Add(this.btnDeleteTL);
            this.rbpFn.ItemLinks.Add(this.btnEditTL);
            this.rbpFn.Name = "rbpFn";
            this.rbpFn.Text = "Thêm, sửa & xoá tài liệu";
            // 
            // btnAddTL
            // 
            this.btnAddTL.Caption = "Thêm tài liệu";
            this.btnAddTL.Id = 4;
            this.btnAddTL.Name = "btnAddTL";
            // 
            // btnDeleteTL
            // 
            this.btnDeleteTL.Caption = "Xoá tài liệu";
            this.btnDeleteTL.Id = 5;
            this.btnDeleteTL.Name = "btnDeleteTL";
            // 
            // btnEditTL
            // 
            this.btnEditTL.Caption = "Sửa tài liệu";
            this.btnEditTL.Id = 6;
            this.btnEditTL.Name = "btnEditTL";
            // 
            // btnMuon
            // 
            this.btnMuon.Caption = "Lập phiếu mượn";
            this.btnMuon.Id = 8;
            this.btnMuon.Name = "btnMuon";
            // 
            // btnCTMuon
            // 
            this.btnCTMuon.Caption = "Chi tiết phiếu mượn";
            this.btnCTMuon.Id = 9;
            this.btnCTMuon.Name = "btnCTMuon";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCTPhat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Phiếu phạt";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSL);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tồn kho";
            // 
            // btnSL
            // 
            this.btnSL.Caption = "Tồn kho";
            this.btnSL.Id = 10;
            this.btnSL.Name = "btnSL";
            // 
            // btnPhat
            // 
            this.btnPhat.Caption = "Lập phiếu phạt";
            this.btnPhat.Id = 11;
            this.btnPhat.Name = "btnPhat";
            // 
            // btnCTPhat
            // 
            this.btnCTPhat.Caption = "Chi tiết phiếu phạt";
            this.btnCTPhat.Id = 12;
            this.btnCTPhat.Name = "btnCTPhat";
            // 
            // btnDMDocgia
            // 
            this.btnDMDocgia.Caption = "Danh mục độc giả";
            this.btnDMDocgia.Id = 13;
            this.btnDMDocgia.Name = "btnDMDocgia";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnAddDocgia);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDeleteDocgia);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnEditDocgia);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Thêm, sửa & xoá độc giả";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.ItemLinks.Add(this.btnAddTL);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnDeleteTL);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnEditTL);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Thêm, sửa & xoá tài liệu";
            // 
            // btnAddDocgia
            // 
            this.btnAddDocgia.Caption = "Thêm độc giả";
            this.btnAddDocgia.Id = 14;
            this.btnAddDocgia.Name = "btnAddDocgia";
            // 
            // btnDeleteDocgia
            // 
            this.btnDeleteDocgia.Caption = "Xoá độc giả";
            this.btnDeleteDocgia.Id = 15;
            this.btnDeleteDocgia.Name = "btnDeleteDocgia";
            // 
            // btnEditDocgia
            // 
            this.btnEditDocgia.Caption = "Sửa độc giả";
            this.btnEditDocgia.Id = 16;
            this.btnEditDocgia.Name = "btnEditDocgia";
            // 
            // btnTacgia
            // 
            this.btnTacgia.Caption = "Tra cứu sách theo tên tác giả";
            this.btnTacgia.Id = 17;
            this.btnTacgia.Name = "btnTacgia";
            // 
            // btnRptNewDocgia
            // 
            this.btnRptNewDocgia.Caption = "Thống kê độc giả mới";
            this.btnRptNewDocgia.Id = 18;
            this.btnRptNewDocgia.Name = "btnRptNewDocgia";
            // 
            // btnRptPhat
            // 
            this.btnRptPhat.Caption = "Thống kê độc giả vi phạm";
            this.btnRptPhat.Id = 19;
            this.btnRptPhat.Name = "btnRptPhat";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnRptSLMuon);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Tài liệu";
            // 
            // btnRptSLMuon
            // 
            this.btnRptSLMuon.Caption = "Thống kê số sách mượn theo đầu sách";
            this.btnRptSLMuon.Id = 20;
            this.btnRptSLMuon.Name = "btnRptSLMuon";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Báo cáo số lượng sách tồn kho";
            this.barButtonItem1.Id = 21;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 676);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnHT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpTK;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnMuon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnDocgia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnTacgia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnRpt;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpBackup;
        private DevExpress.XtraBars.BarButtonItem btnDMTL;
        private DevExpress.XtraBars.BarButtonItem btnAddTL;
        private DevExpress.XtraBars.BarButtonItem btnDeleteTL;
        private DevExpress.XtraBars.BarButtonItem btnEditTL;
        private DevExpress.XtraBars.BarButtonItem btnMuon;
        private DevExpress.XtraBars.BarButtonItem btnCTMuon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpFn;
        private DevExpress.XtraBars.BarButtonItem btnSL;
        private DevExpress.XtraBars.BarButtonItem btnPhat;
        private DevExpress.XtraBars.BarButtonItem btnCTPhat;
        private DevExpress.XtraBars.BarButtonItem btnDMDocgia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnAddDocgia;
        private DevExpress.XtraBars.BarButtonItem btnDeleteDocgia;
        private DevExpress.XtraBars.BarButtonItem btnEditDocgia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnTacgia;
        private DevExpress.XtraBars.BarButtonItem btnRptNewDocgia;
        private DevExpress.XtraBars.BarButtonItem btnRptPhat;
        private DevExpress.XtraBars.BarButtonItem btnRptSLMuon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
    }
}