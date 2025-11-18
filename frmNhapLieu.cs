using DevExpress.XtraRichEdit.Import.Doc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmNhapLieu : Form
    {
        public string KetQuaMaTacGia = "";
        public string KetQuaTenTacGia = "";
        public string KetQuaMaTaiLieu = "";

        string strConn = "Data Source=HEHE;Initial Catalog=QLTV;Integrated Security=True;Encrypt=False";

        private bool isEditMode = false;
        public frmNhapLieu(string tieuDeMa, string tieuDeTen, int modeInput, string maCu = "", string tenCu = "", string maTL = "")
        {
            InitializeComponent();
            this.Text = "CẬP NHẬT TÁC GIẢ";

            LoadCboTaiLieu();

            if (!string.IsNullOrEmpty(maCu))
            {
                txtMaTacGia.Text = maCu;
                txtTenTacGia.Text = tenCu;

                if (modeInput == 2)
                {
                    txtMaTacGia.Enabled = true;
                }
                else
                {
                    txtMaTacGia.Enabled = false;
                }
            }
            else
            {
                txtMaTacGia.Text = "";
                txtTenTacGia.Text = "";
                txtMaTacGia.Enabled = true;
            }

            if (!string.IsNullOrEmpty(maTL))
            {
                cboTaiLieu.SelectedValue = maTL;
            }

            txtMaTaiLieu.ReadOnly = true;
        }
        private void LoadCboTaiLieu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MaTaiLieu, TenTaiLieu FROM TaiLieu", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboTaiLieu.DataSource = dt;
                    cboTaiLieu.DisplayMember = "TenTaiLieu";
                    cboTaiLieu.ValueMember = "MaTaiLieu";
                    cboTaiLieu.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tài liệu: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {

        }

        private void lblChonTaiLieu_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboTaiLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTaiLieu.SelectedValue != null)
            {
                txtMaTaiLieu.Text = cboTaiLieu.SelectedValue.ToString();
            }
            else
            {
                txtMaTaiLieu.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaTacGia.Text.Trim() == "" || txtTenTacGia.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên Tác Giả!");
                return;
            }

            KetQuaMaTacGia = txtMaTacGia.Text.Trim();
            KetQuaTenTacGia = txtTenTacGia.Text.Trim();

            if (cboTaiLieu.SelectedValue != null)
            {
                KetQuaMaTaiLieu = cboTaiLieu.SelectedValue.ToString();
            }
            else
            {
                KetQuaMaTaiLieu = "";
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
