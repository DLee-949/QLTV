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
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnDMTL = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddTL = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteTL = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditTL = new DevExpress.XtraBars.BarButtonItem();
            this.btnMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnCTMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnSL = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnCTPhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDMDocgia = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddDocgia = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteDocgia = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditDocgia = new DevExpress.XtraBars.BarButtonItem();
            this.btnTacgia = new DevExpress.XtraBars.BarButtonItem();
            this.btnRptNewDocgia = new DevExpress.XtraBars.BarButtonItem();
            this.btnRptPhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnRptSLMuon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateTimeOffsetEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuPhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDMDG = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.rbnHT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpTK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBackup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnRpt = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(37);
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
            this.barButtonItem1,
            this.barStaticItem1,
            this.barEditItem1,
            this.barButtonItem2,
            this.barButtonItem4,
            this.btnPhieuMuon,
            this.btnPhieuPhat,
            this.btnDMDG,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbon.MaxItemId = 35;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 412;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbnHT,
            this.rbnRpt});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateTimeOffsetEdit1});
            this.ribbon.Size = new System.Drawing.Size(1089, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            // btnDMTL
            // 
            this.btnDMTL.Caption = "Danh mục tài liệu";
            this.btnDMTL.Id = 3;
            this.btnDMTL.Name = "btnDMTL";
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
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 22;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemDateTimeOffsetEdit1;
            this.barEditItem1.Id = 23;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemDateTimeOffsetEdit1
            // 
            this.repositoryItemDateTimeOffsetEdit1.AutoHeight = false;
            this.repositoryItemDateTimeOffsetEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateTimeOffsetEdit1.Name = "repositoryItemDateTimeOffsetEdit1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Danh mục tài liệu";
            this.barButtonItem2.Id = 25;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Tồn kho";
            this.barButtonItem4.Id = 26;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnPhieuMuon
            // 
            this.btnPhieuMuon.Caption = "Phiếu mượn";
            this.btnPhieuMuon.Id = 27;
            this.btnPhieuMuon.Name = "btnPhieuMuon";
            this.btnPhieuMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuMuon_ItemClick);
            // 
            // btnPhieuPhat
            // 
            this.btnPhieuPhat.Caption = "Phiếu phạt";
            this.btnPhieuPhat.Id = 28;
            this.btnPhieuPhat.Name = "btnPhieuPhat";
            this.btnPhieuPhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuPhat_ItemClick);
            // 
            // btnDMDG
            // 
            this.btnDMDG.Caption = "Danh mục độc giả";
            this.btnDMDG.Id = 29;
            this.btnDMDG.Name = "btnDMDG";
            this.btnDMDG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDMDG_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Thống kê độc giả";
            this.barButtonItem8.Id = 31;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Độc giả vi phạm";
            this.barButtonItem9.Id = 32;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Danh mục tác giả";
            this.barButtonItem10.Id = 34;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // rbnHT
            // 
            this.rbnHT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpTK,
            this.rbpBackup,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11,
            this.ribbonPageGroup12,
            this.ribbonPageGroup13});
            this.rbnHT.Name = "rbnHT";
            this.rbnHT.Text = "Hệ thống";
            // 
            // rbpTK
            // 
            this.rbpTK.ItemLinks.Add(this.btnLogin);
            this.rbpTK.ItemLinks.Add(this.btnLogout);
            this.rbpTK.Name = "rbpTK";
            this.rbpTK.Text = "Hệ thống";
            // 
            // rbpBackup
            // 
            this.rbpBackup.ItemLinks.Add(this.barButtonItem2);
            this.rbpBackup.ItemLinks.Add(this.barButtonItem4);
            this.rbpBackup.Name = "rbpBackup";
            this.rbpBackup.Text = "Quản lý tài liệu";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.AllowTextClipping = false;
            this.ribbonPageGroup10.ItemLinks.Add(this.btnPhieuMuon);
            this.ribbonPageGroup10.ItemLinks.Add(this.btnPhieuPhat);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "Quản lý mượn trả";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnDMDG);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "Quản lý độc giả";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "Quản lý tác giả";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.AllowTextClipping = false;
            this.ribbonPageGroup13.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup13.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            this.ribbonPageGroup13.Text = "Báo cáo thống kê";
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
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnRptSLMuon);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Tài liệu";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barEditItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 646);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1089, 30);
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
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Danh mục tài liệu";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 676);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnHT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpTK;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
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
        private DevExpress.XtraBars.BarButtonItem btnSL;
        private DevExpress.XtraBars.BarButtonItem btnPhat;
        private DevExpress.XtraBars.BarButtonItem btnCTPhat;
        private DevExpress.XtraBars.BarButtonItem btnDMDocgia;
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
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnPhieuMuon;
        private DevExpress.XtraBars.BarButtonItem btnPhieuPhat;
        private DevExpress.XtraBars.BarButtonItem btnDMDG;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
    }
}