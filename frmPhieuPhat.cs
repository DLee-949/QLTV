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
    public partial class frmPhieuPhat : Form
    {
        string strConn = "Data Source=HEHE;Initial Catalog=QLTV;Integrated Security=True;Encrypt=False";
        SqlConnection conn = null;

        public frmPhieuPhat()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
        }
        private void frmPhieuPhat_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData(string query = "")
        {
            if (string.IsNullOrEmpty(query))
            {
                // Câu lệnh mặc định: Lấy hết và JOIN với bảng DocGia để lấy Tên cho đẹp
                query = @"SELECT PP.MaPhieuPhat, PP.MaPhieuMuon, PP.MaDocGia, DG.TenDocGia, PP.PhiPhat, PP.NgayPhat, PP.LyDo 
                          FROM PhieuPhat PP 
                          LEFT JOIN DocGia DG ON PP.MaDocGia = DG.MaDocGia";
            }

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPhieuPhat.DataSource = dt;

                // Cấu hình hiển thị cột (Tùy chọn)
                if (dgvPhieuPhat.Columns["TenDocGia"] != null) dgvPhieuPhat.Columns["TenDocGia"].HeaderText = "Tên Độc Giả";
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách: " + ex.Message); }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT PP.*, DG.TenDocGia FROM PhieuPhat PP LEFT JOIN DocGia DG ON PP.MaDocGia = DG.MaDocGia WHERE 1=1";

            // Tìm theo các ô trên GroupBox
            if (txtMaPhieuPhat.Text != "") sql += $" AND PP.MaPhieuPhat LIKE '%{txtMaPhieuPhat.Text}%'";
            if (txtMaPhieuMuon.Text != "") sql += $" AND PP.MaPhieuMuon LIKE '%{txtMaPhieuMuon.Text}%'";
            if (txtMaDocGia.Text != "") sql += $" AND PP.MaDocGia LIKE '%{txtMaDocGia.Text}%'";

            LoadData(sql);
        }

        private void dgvPhieuPhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhieuPhat.CurrentRow != null)
            {
                DataGridViewRow row = dgvPhieuPhat.CurrentRow;
                txtMaPhieuPhat.Text = row.Cells["MaPhieuPhat"].Value.ToString();
                txtMaPhieuMuon.Text = row.Cells["MaPhieuMuon"].Value.ToString();
                txtMaDocGia.Text = row.Cells["MaDocGia"].Value.ToString();
                txtPhiPhat.Text = row.Cells["PhiPhat"].Value.ToString();
                txtLyDo.Text = row.Cells["LyDo"].Value.ToString();
                if (row.Cells["NgayPhat"].Value != DBNull.Value)
                    dtpNgayPhat.Value = Convert.ToDateTime(row.Cells["NgayPhat"].Value);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCapNhatPhieuPhat frm = new frmCapNhatPhieuPhat("");

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData(); // Tải lại danh sách nếu thêm thành công
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPhieuPhat.CurrentRow == null || dgvPhieuPhat.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu phạt cần sửa!");
                return;
            }

            // Lấy Mã từ dòng đang chọn (Cột đầu tiên hoặc cột tên MaPhieuPhat)
            string maPP = dgvPhieuPhat.CurrentRow.Cells["MaPhieuPhat"].Value.ToString();

            frmCapNhatPhieuPhat frm = new frmCapNhatPhieuPhat(maPP);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData(); // Tải lại danh sách nếu sửa thành công
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuPhat.CurrentRow == null) return;

            string maPP = dgvPhieuPhat.CurrentRow.Cells["MaPhieuPhat"].Value.ToString();

            if (MessageBox.Show($"Bạn chắc chắn muốn xóa Phiếu phạt {maPP}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    SqlCommand cmd = new SqlCommand($"DELETE FROM PhieuPhat WHERE MaPhieuPhat = '{maPP}'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa!");
                    LoadData();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaPhieuPhat.Text = "";
            txtMaPhieuMuon.Text = "";
            txtMaDocGia.Text = "";
            txtPhiPhat.Text = "";
            txtLyDo.Text = "";
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
