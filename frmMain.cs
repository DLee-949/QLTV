using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string orgLoginCap;
        public frmMain()
        {
            InitializeComponent();
            orgLoginCap = btnLogin.Caption;
        }

        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin f = new frmLogin();
            f.LoginSubmitted += account =>
            {
                if (string.IsNullOrEmpty(account))
                {
                    btnLogin.Caption = orgLoginCap;
                }
                else if (btnLogin.Caption == orgLoginCap)
                {
                    btnLogin.Caption = account;
                }
                else if (btnLogin.Caption == account)
                {
                    btnLogin.Caption = orgLoginCap;
                }
                else
                {
                    btnLogin.Caption = account;
                }
            };
            f.ShowDialog();
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(MessageBox.Show("Đăng xuất?", "Hỏi đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnLogin.Caption = orgLoginCap;
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;

            foreach (Form child in this.MdiChildren)
            {
                if (child is frmDmtl)
                {
                    child.Activate();
                    return;
                }
            }

            var f1 = new frmDmtl();
            f1.MdiParent = this;
            f1.Show();
        }

        private void btnPhieuMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMuon f = new frmMuon();
            f.ShowDialog();
        }

        private void btnPhieuPhat_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnDMDG_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;

            foreach (Form child in this.MdiChildren)
            {
                if (child is frmDMDG)
                {
                    child.Activate();
                    return;
                }
            }

            var f1 = new frmDMDG();
            f1.MdiParent = this;
            f1.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}