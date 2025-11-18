using DevExpress.CodeParser;
using DevExpress.XtraReports.UI;
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
    public partial class frmDMDG : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string str, sql;
        Boolean addnewflag = false;
        public frmDMDG()
        {
            InitializeComponent();
        }

        public void NapCT()
        {
            try
            {
                int i = grdDMDG.CurrentRow.Index;
                txtMaDG.Text = grdDMDG.Rows[i].Cells["MaDocGia"].Value.ToString();
                txtTenDG.Text = grdDMDG.Rows[i].Cells["TenDocGia"].Value.ToString();
                txtEmail.Text = grdDMDG.Rows[i].Cells["Email"].Value.ToString();
                txtSdt.Text = grdDMDG.Rows[i].Cells["SDT"].Value.ToString();
            }
            catch (Exception )
            {

            }
        }

        private void btnAddDG_Click(object sender, EventArgs e)
        {
            grdDMDG.CurrentCell = grdDMDG[0, grdDMDG.RowCount - 1];
            MessageBox.Show("Nhập thông tin và bấm <Cập nhật> để hoàn tất");
            txtMaDG.Focus();
            addnewflag = true;
            btnUpdateDG.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLocDMDG_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                sql = "select MaDocGia, TenDocGia, Email, SDT from DocGia" +
                    " where " + comTruongDMDG.Text + "= N'" + txtGTDMDG.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                grdDMDG.DataSource = dt;
                NapCT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Lammoi()
        {
            try
            {
                dt.Clear();
                sql = "select MaDocGia, TenDocGia, Email, SDT from DocGia";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                grdDMDG.DataSource = dt;
                NapCT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnRefreshDMDG_Click(object sender, EventArgs e)
        {
            Lammoi();
        }

        private void btnXuatDMDG_Click(object sender, EventArgs e)
        {
            rptDMDG rpt = new rptDMDG();
            rpt.lblNgayIn.Text = string.Format("Hà Nội, ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            rpt.ShowPreview();
        }

        private void grdDMDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnEditDG_Click(object sender, EventArgs e)
        {
            btnUpdateDG.Enabled = true;
            MessageBox.Show("Sửa trực tiếp trên lưới dữ liệu. Bấm <Cập nhật> để hoàn tất");
        }

        private void btnDeleteDG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xoá độc giả này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete from DocGia where MaDocGia= N'" + txtMaDG.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                int i = grdDMDG.CurrentRow.Index;
                grdDMDG.Rows.RemoveAt(i);
                NapCT();
                MessageBox.Show("Đã xoá thành công");
            }
        }

        private void comTruongDMDG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateDG_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                sql = "Insert into DocGia(MaDocGia, TenDocGia, Email, SDT) " +
                    "Values(N'" + txtMaDG.Text + "', N'" + txtTenDG.Text + "', N'" + txtEmail.Text + "',N'" + txtSdt.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Lammoi();
                addnewflag = false;
            }
            else
            {
                int n = grdDMDG.RowCount;
                for (int i = 0; i < n - 1; i++)
                {
                    string tmadg = grdDMDG.Rows[i].Cells["MaDocGia"].Value.ToString();
                    string ttendg = grdDMDG.Rows[i].Cells["TenDocGia"].Value.ToString();
                    string temail = grdDMDG.Rows[i].Cells["Email"].Value.ToString();
                    string tsdt = grdDMDG.Rows[i].Cells["SDT"].Value.ToString();
                    sql = "Update DocGia set TenDocGia = N'" + ttendg + "', Email = N'" + temail + "', SDT =N' " + tsdt + "'" +
                        "where MaDocGia = N'" + tmadg + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Đã cập nhật thành công");
            btnUpdateDG.Enabled = false;
        }

        private void txtGTDMDG_TextChanged(object sender, EventArgs e)
        {
            if (comTruongDMDG.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                string column = comTruongDMDG.SelectedItem.ToString();
                string keyword = txtGTDMDG.Text.Replace("'", "''");
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"{column} LIKE '%{keyword}%'";
            }
            NapCT();
        }

        private void frmDMDG_Load(object sender, EventArgs e)
        {
            str = "Data Source = PING; Initial Catalog = QLTV1; Integrated Security = True;";
            conn.ConnectionString = str;
            conn.Open();
            sql = "select MaDocGia, TenDocGia, Email, SDT from DocGia";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdDMDG.DataSource = dt;
            NapCT();
        }

        }

        
    }

