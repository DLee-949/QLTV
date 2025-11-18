using DevExpress.XtraRichEdit.Import.Html;
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
    public partial class frmQLTacGia : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string str, sql;
        Boolean addnewflag = false;
        DataGridView luoiDangChon = null;
        public frmQLTacGia()
        {
            InitializeComponent();
        }
        private DataTable LayDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private void RunSQL(string sql)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thực hiện thành công!");
                frmQLTacGia_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void NapCT()
        {
            if (luoiDangChon == null || luoiDangChon.CurrentRow == null || luoiDangChon.CurrentRow.Index < 0) return;

            try
            {
                DataGridViewRow row = luoiDangChon.CurrentRow;

                if (luoiDangChon == dgvTacGia)
                {
                    txtMaTacGia.Text = row.Cells["MaTacGia"].Value?.ToString();
                    txtTacGia.Text = row.Cells["TenTacGia"].Value?.ToString();
                }
                else if (luoiDangChon == dgvTaiLieu)
                {
                    txtMaTaiLieu.Text = row.Cells["MaTaiLieu"].Value?.ToString();
                    txtTaiLieu.Text = row.Cells["TenTaiLieu"].Value?.ToString();
                }
                else if (luoiDangChon == dgvTaiLieu_TacGia)
                {
                    txtMaTaiLieu.Text = row.Cells["MaTaiLieu"].Value?.ToString();
                    txtMaTacGia.Text = row.Cells["MaTacGia"].Value?.ToString();
                }
            }
            catch (Exception)
            {
            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQLTacGia_Load(object sender, EventArgs e)
        {
            str = "Data Source=HEHE;Initial Catalog=QLTV;Integrated Security=True;Encrypt=False";
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            // -------------------------

            conn.ConnectionString = str;

            try
            {
                conn.Open();

                dgvTacGia.AutoGenerateColumns = false;
                dgvTaiLieu.AutoGenerateColumns = false;
                dgvTaiLieu_TacGia.AutoGenerateColumns = false;


                if (dgvTacGia.Columns.Count >= 2)
                {
                    dgvTacGia.Columns[0].DataPropertyName = "MaTacGia"; // Tên cột trong SQL
                    dgvTacGia.Columns[1].DataPropertyName = "TenTacGia"; // Tên cột trong SQL
                }

                if (dgvTaiLieu.Columns.Count >= 2)
                {
                    dgvTaiLieu.Columns[0].DataPropertyName = "MaTaiLieu";
                    dgvTaiLieu.Columns[1].DataPropertyName = "TenTaiLieu";
                }

                if (dgvTaiLieu_TacGia.Columns.Count >= 1)
                {
                    dgvTaiLieu_TacGia.Columns[0].DataPropertyName = "MaTaiLieu";
                }

                dgvTacGia.DataSource = LayDuLieu("SELECT MaTacGia, TenTacGia FROM TacGia");
                dgvTaiLieu.DataSource = LayDuLieu("SELECT MaTaiLieu, TenTaiLieu FROM TaiLieu");
                dgvTaiLieu_TacGia.DataSource = LayDuLieu("SELECT * FROM TaiLieu_TacGia");

                luoiDangChon = dgvTacGia;
                NapCT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvTacGia_Enter(object sender, EventArgs e)
        {
            luoiDangChon = dgvTacGia;
            NapCT();
        }

        private void dgvTaiLieu_Enter(object sender, EventArgs e)
        {
            luoiDangChon = dgvTaiLieu;
            NapCT();
        }
        private bool KiemTraTrungMa(string tenBang, string tenCotMa, string maKiemTra)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();

                string sql = $"SELECT COUNT(*) FROM {tenBang} WHERE {tenCotMa} = '{maKiemTra}'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                int ketQua = (int)cmd.ExecuteScalar();

                return ketQua > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (luoiDangChon == dgvTacGia)
            {
                string maTG = "", tenTG = "", maTL = "";

                while (true)
                {
                    frmNhapLieu frm = new frmNhapLieu("Mã tác giả", "Tên tác giả", 2, maTG, tenTG, maTL);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        maTG = frm.KetQuaMaTacGia;
                        tenTG = frm.KetQuaTenTacGia;
                        maTL = frm.KetQuaMaTaiLieu;

                        if (KiemTraTrungMa("TacGia", "MaTacGia", maTG))
                        {
                            MessageBox.Show($"Mã tác giả '{maTG}' đã tồn tại! Vui lòng nhập mã khác.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }

                        string sql1 = $"INSERT INTO TacGia (MaTacGia, TenTacGia) VALUES ('{maTG}', N'{tenTG}')";
                        RunSQL(sql1);

                        if (!string.IsNullOrEmpty(maTL))
                        {
                            string sqlCheckLink = $"SELECT COUNT(*) FROM TaiLieu_TacGia WHERE MaTacGia='{maTG}' AND MaTaiLieu='{maTL}'";
                            SqlCommand cmdCheck = new SqlCommand(sqlCheckLink, conn);
                            if ((int)cmdCheck.ExecuteScalar() == 0)
                            {
                                string sql2 = $"INSERT INTO TaiLieu_TacGia (MaTacGia, MaTaiLieu) VALUES ('{maTG}', '{maTL}')";
                                try
                                {
                                    SqlCommand cmd = new SqlCommand(sql2, conn);
                                    cmd.ExecuteNonQuery();
                                    frmQLTacGia_Load(null, null);
                                }
                                catch { }
                            }
                        }
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (luoiDangChon == dgvTaiLieu)
            {
                frmNhapLieu frm = new frmNhapLieu("Mã tài liệu", "Tên tài liệu", 0);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (KiemTraTrungMa("TaiLieu", "MaTaiLieu", frm.KetQuaMaTacGia))
                    {
                        MessageBox.Show($"Mã tài liệu '{frm.KetQuaMaTacGia}' đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sql = $"INSERT INTO TaiLieu (MaTaiLieu, TenTaiLieu) VALUES ('{frm.KetQuaMaTacGia}', N'{frm.KetQuaTenTacGia}')";
                    RunSQL(sql);
                }
            }
            else if (luoiDangChon == dgvTaiLieu_TacGia)
            {
                frmNhapLieu frm = new frmNhapLieu("Chọn Tác giả", "Chọn Tài liệu", 1);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string sql = $"INSERT INTO TaiLieu_TacGia (MaTacGia, MaTaiLieu) VALUES ('{frm.KetQuaMaTacGia}', '{frm.KetQuaTenTacGia}')";
                    RunSQL(sql);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bảng cần thêm!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (luoiDangChon == null || luoiDangChon.CurrentRow == null || luoiDangChon.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            // Nếu đang chọn bảng Tác giả
            if (luoiDangChon == dgvTacGia)
            {
                DataGridViewRow row = luoiDangChon.CurrentRow;
                string maTG_cu = row.Cells["MaTacGia"].Value?.ToString();
                string tenTG_cu = row.Cells["TenTacGia"].Value?.ToString();

                // Lấy mã tài liệu hiện tại của tác giả đó (để hiển thị lên combobox)
                string maTL_hienTai = "";
                DataTable dtTGTL = LayDuLieu($"SELECT MaTaiLieu FROM TaiLieu_TacGia WHERE MaTacGia = '{maTG_cu}'");
                if (dtTGTL.Rows.Count > 0)
                {
                    maTL_hienTai = dtTGTL.Rows[0]["MaTaiLieu"].ToString();
                }

                // Gọi form chuyên biệt cho tác giả (ở chế độ sửa)
                frmNhapLieu frm = new frmNhapLieu ("Tác giả", "Tài liệu", 1, maTG_cu, tenTG_cu, maTL_hienTai);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string tenTG_moi = frm.KetQuaTenTacGia;
                    string maTL_moi = frm.KetQuaMaTaiLieu;

                    // Bước 1: Cập nhật Tên Tác giả
                    string sql1 = $"UPDATE TacGia SET TenTacGia = N'{tenTG_moi}' WHERE MaTacGia = '{maTG_cu}'";
                    RunSQL(sql1); // RunSQL sẽ tự động Load lại form chính

                    // Bước 2: Cập nhật liên kết Tài liệu (có thể phức tạp hơn)
                    if (!string.IsNullOrEmpty(maTL_moi))
                    {
                        // Xóa liên kết cũ (nếu có) và thêm mới
                        string sqlXoaCu = $"DELETE FROM TaiLieu_TacGia WHERE MaTacGia = '{maTG_cu}'";
                        string sqlThemMoi = $"INSERT INTO TaiLieu_TacGia (MaTacGia, MaTaiLieu) VALUES ('{maTG_cu}', '{maTL_moi}')";

                        try
                        {
                            if (conn.State != ConnectionState.Open) conn.Open();
                            SqlCommand cmd = new SqlCommand(sqlXoaCu, conn);
                            cmd.ExecuteNonQuery(); // Xóa cũ

                            cmd.CommandText = sqlThemMoi;
                            cmd.ExecuteNonQuery(); // Thêm mới
                            frmQLTacGia_Load(null, null);
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("PRIMARY KEY"))
                                MessageBox.Show("Lỗi: Tác giả này đã có tài liệu này rồi!");
                            else
                                MessageBox.Show("Lỗi cập nhật liên kết: " + ex.Message);
                        }
                    }
                    else
                    {
                        // Nếu người dùng không chọn tài liệu nào, thì xóa liên kết tài liệu cũ (nếu có)
                        try
                        {
                            if (conn.State != ConnectionState.Open) conn.Open();
                            SqlCommand cmd = new SqlCommand($"DELETE FROM TaiLieu_TacGia WHERE MaTacGia = '{maTG_cu}'", conn);
                            cmd.ExecuteNonQuery();
                            frmQLTacGia_Load(null, null);
                        }
                        catch (Exception ex) { /* Bỏ qua nếu không có gì để xóa */ }
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            string sql = "";

            if (luoiDangChon == dgvTacGia)
            {
                sql = "DELETE FROM TacGia WHERE MaTacGia = '" + txtMaTacGia.Text.Trim() + "'";
            }
            else if (luoiDangChon == dgvTaiLieu)
            {
                sql = "DELETE FROM TaiLieu WHERE MaTaiLieu = '" + txtMaTaiLieu.Text.Trim() + "'";
            }
            else if (luoiDangChon == dgvTaiLieu_TacGia)
            {
                sql = "DELETE FROM TaiLieu_TacGia WHERE MaTacGia = '" + txtMaTacGia.Text.Trim() + "' AND MaTaiLieu = '" + txtMaTaiLieu.Text.Trim() + "'";
            }

            RunSQL(sql);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlTG = "SELECT MaTacGia, TenTacGia FROM TacGia WHERE 1=1";
                if (txtMaTacGia.Text != "") sqlTG += " AND MaTacGia LIKE '%" + txtMaTacGia.Text.Trim() + "%'";
                if (txtTacGia.Text != "") sqlTG += " AND TenTacGia LIKE N'%" + txtTacGia.Text.Trim() + "%'";
                dgvTacGia.DataSource = LayDuLieu(sqlTG);

                string sqlTL = "SELECT MaTaiLieu, TenTaiLieu FROM TaiLieu WHERE 1=1";
                if (txtMaTaiLieu.Text != "") sqlTL += " AND MaTaiLieu LIKE '%" + txtMaTaiLieu.Text.Trim() + "%'";
                if (txtTaiLieu.Text != "") sqlTL += " AND TenTaiLieu LIKE N'%" + txtTaiLieu.Text.Trim() + "%'";
                dgvTaiLieu.DataSource = LayDuLieu(sqlTL);

                string sqlLK = "SELECT MaTaiLieu, MaTacGia FROM TaiLieu_TacGia WHERE 1=1";
                if (txtMaTacGia.Text != "") sqlLK += " AND MaTacGia LIKE '%" + txtMaTacGia.Text.Trim() + "%'";
                if (txtMaTaiLieu.Text != "") sqlLK += " AND MaTaiLieu LIKE '%" + txtMaTaiLieu.Text.Trim() + "%'";
                dgvTaiLieu_TacGia.DataSource = LayDuLieu(sqlLK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaTacGia.Text = "";
            txtTacGia.Text = "";
            txtMaTaiLieu.Text = "";
            txtTaiLieu.Text = "";
            frmQLTacGia_Load(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            luoiDangChon = dgvTacGia;
            NapCT();
        }

        private void dgvTaiLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            luoiDangChon = dgvTaiLieu;
            NapCT();
        }

        private void dgvTaiLieu_TacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            luoiDangChon = dgvTaiLieu_TacGia;
            NapCT();
        }

        private void txtMaTacGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTaiLieu_TacGia_Enter(object sender, EventArgs e)
        {
            luoiDangChon = dgvTaiLieu_TacGia;
            NapCT();
        }
    }
}

