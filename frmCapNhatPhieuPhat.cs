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
    public partial class frmCapNhatPhieuPhat : Form
    {
        // Chuỗi kết nối (Thay đổi cho đúng máy bạn)
        string strConn = "Data Source=HEHE;Initial Catalog=QLTV;Integrated Security=True;Encrypt=False";
        SqlConnection conn = null;

        // Biến lưu mã phiếu phạt (nếu rỗng = Thêm mới, có giá trị = Sửa)
        string _maPP = "";
        public frmCapNhatPhieuPhat(string maPhieuPhat = "")
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            _maPP = maPhieuPhat;

            LoadCboPhieuMuon(); // Nạp danh sách phiếu mượn vào ComboBox

            if (string.IsNullOrEmpty(_maPP))
            {
                // --- CHẾ ĐỘ THÊM MỚI ---
                this.Text = "THÊM PHIẾU PHẠT MỚI";
                txtMaPhieuPhat.Text = "(Tự động)";
                txtMaPhieuPhat.Enabled = false; // Khóa ô mã
                dtpNgayPhat.Value = DateTime.Now;
            }
            else
            {
                // --- CHẾ ĐỘ CẬP NHẬT (SỬA) ---
                this.Text = "CẬP NHẬT PHIẾU PHẠT";
                txtMaPhieuPhat.Text = _maPP;
                txtMaPhieuPhat.Enabled = false; // Khóa ô mã
                LoadDataCu(_maPP); // Lấy dữ liệu cũ điền vào ô
            }
        }

        // 1. Nạp ComboBox Mã Phiếu Mượn
        private void LoadCboPhieuMuon()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaPhieuMuon, MaDocGia FROM MuonTra", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboMaPhieuMuon.DataSource = dt;
                cboMaPhieuMuon.DisplayMember = "MaPhieuMuon";
                cboMaPhieuMuon.ValueMember = "MaDocGia"; // Mẹo: Lưu Mã ĐG vào Value để lấy nhanh
                cboMaPhieuMuon.SelectedIndex = -1;
            }
            catch { }
        }
        private void cboMaPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaPhieuMuon.SelectedValue != null)
            {
                txtMaDocGia.Text = cboMaPhieuMuon.SelectedValue.ToString();
            }
        }
        private void LoadDataCu(string ma)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM PhieuPhat WHERE MaPhieuPhat = '{ma}'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cboMaPhieuMuon.Text = dr["MaPhieuMuon"].ToString();
                    txtMaDocGia.Text = dr["MaDocGia"].ToString();
                    txtPhiPhat.Text = dr["PhiPhat"].ToString();
                    txtLyDo.Text = dr["LyDo"].ToString();
                    if (dr["NgayPhat"] != DBNull.Value)
                        dtpNgayPhat.Value = Convert.ToDateTime(dr["NgayPhat"]);
                }
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu cũ: " + ex.Message); }
        }
        public frmCapNhatPhieuPhat()
        {
            InitializeComponent();
        }

        private void frmCapNhatPhieuPhat_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMaPhieuMuon.Text == "" || txtPhiPhat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin (Phiếu mượn, Phí phạt)!");
                return;
            }

            string sql = "";
            string ngay = dtpNgayPhat.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(_maPP)) // THÊM MỚI
            {
                // Giả sử MaPhieuPhat là tự tăng (IDENTITY) trong SQL
                sql = $"INSERT INTO PhieuPhat (MaPhieuMuon, MaDocGia, PhiPhat, LyDo, NgayPhat) " +
                      $"VALUES ('{cboMaPhieuMuon.Text}', '{txtMaDocGia.Text}', '{txtPhiPhat.Text}', N'{txtLyDo.Text}', '{ngay}')";
            }
            else // CẬP NHẬT
            {
                sql = $"UPDATE PhieuPhat SET MaPhieuMuon='{cboMaPhieuMuon.Text}', MaDocGia='{txtMaDocGia.Text}', " +
                      $"PhiPhat='{txtPhiPhat.Text}', LyDo=N'{txtLyDo.Text}', NgayPhat='{ngay}' " +
                      $"WHERE MaPhieuPhat='{_maPP}'";
            }

            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Lưu thành công!");
                this.DialogResult = DialogResult.OK; // Báo OK cho form cha
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi lưu: " + ex.Message); }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
    }

