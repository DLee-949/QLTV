using System;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraReports.Wizards.Templates;

namespace QLTV
{
    public partial class frmDmtl : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string str, sql;
        Boolean addnewflag = false;
        public frmDmtl()
        {
            InitializeComponent();
        }
        public void NapCT()
        {
            int i = grdDmtl.CurrentCell.RowIndex;
            txtMaTaiLieu.Text = grdDmtl.Rows[i].Cells["MaTaiLieu"].Value.ToString();
            txtTenTaiLieu.Text = grdDmtl.Rows[i].Cells["TenTaiLieu"].Value.ToString();
            txtMaTacGia.Text = grdDmtl.Rows[i].Cells["MaTacGia"].Value.ToString();
            txtLoaiTaiLieu.Text = grdDmtl.Rows[i].Cells["LoaiTaiLieu"].Value.ToString();
            txtSoLuong.Text = grdDmtl.Rows[i].Cells["SoLuong"].Value.ToString();
        }
        private void grdDmtl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NapLai();
        }

        private void NapLai()
        {
            dt.Clear();
            sql = "select MaTaiLieu , TenTaiLieu, MaTacGia , LoaiTaiLieu , SoLuong from TaiLieu";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdDmtl.DataSource = dt;
            NapCT();
        }
        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select distinct " + comTruong.Text + " from TaiLieu";
            da = new SqlDataAdapter(sql, conn);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            comGT.DataSource = dt1;
            comGT.DisplayMember = comTruong.Text;
            comGT.ValueMember = comTruong.Text;

        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
                try
                {
                    dt.Clear();
                    sql = "select MaTaiLieu , TenTaiLieu, MaTacGia , LoaiTaiLieu , SoLuong from TaiLieu where " + comTruong.Text + " = N'" + comGT.Text + "'";
                    da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);
                    grdDmtl.DataSource = dt;
                    NapCT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi cần xử lý: " , ex.ToString());
                }
            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            int i  = grdDmtl.CurrentCell.RowIndex;
            if (i < grdDmtl.RowCount -1)
            {
                grdDmtl.CurrentCell = grdDmtl.Rows[0].Cells[0];
                NapCT();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grdDmtl.CurrentCell.RowIndex;
            if (i > 0)
            {
                grdDmtl.CurrentCell = grdDmtl.Rows[i - 1].Cells[0];
                NapCT();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdDmtl.CurrentCell = grdDmtl[0, grdDmtl.RowCount - 1];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdDmtl.CurrentCell.RowIndex;
            if (i < grdDmtl.RowCount - 1)
            {
                grdDmtl.CurrentCell = grdDmtl.Rows[i + 1].Cells[0];
                NapCT();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grdDmtl.CurrentCell = grdDmtl[0, grdDmtl.RowCount - 1];
            NapCT();
            MessageBox.Show("Vui lòng nhập thông tin.");
            addnewflag = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng sửa thông tin.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                {
                    sql = "delete from TaiLieu where MaTaiLieu = N'" + txtMaTaiLieu.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    int i = grdDmtl.CurrentCell.RowIndex;
                    grdDmtl.Rows.RemoveAt(i);
                    NapLai();
                    MessageBox.Show("Đã xóa thành công");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                sql = "insert into TaiLieu (MaTaiLieu , TenTaiLieu, MaTacGia , LoaiTaiLieu , SoLuong) values (N'" + txtMaTaiLieu.Text + "', N'" + txtTenTaiLieu.Text + "', N'" + txtMaTacGia.Text + "', N'" + txtLoaiTaiLieu.Text + "', N'" + txtSoLuong.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                NapCT();
                addnewflag = false;
            }
            else
            {
                int n = grdDmtl.CurrentCell.RowIndex;
                for (int i = 0; i < n - 1; i++)
                {
                    string tmatl = grdDmtl.Rows[i].Cells["MaTaiLieu"].Value.ToString();
                    string ttenttl = grdDmtl.Rows[i].Cells["TenTaiLieu"].Value.ToString();
                    string tloaitl = grdDmtl.Rows[i].Cells["LoaiTaiLieu"].Value.ToString();
                    string tmatg = grdDmtl.Rows[i].Cells["MaTacGia"].Value.ToString();
                    string tsl = grdDmtl.Rows[i].Cells["SoLuong"].Value.ToString();
                    sql = "update TaiLieu set MaTaiLieu = N'" + tmatl + "', TenTaiLieu = N'" + ttenttl + "', LoaiTaiLieu = " + tloaitl + ", MaTacGia = N'" + tmatg + "', SoLuong = " + tsl + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var rpt = new rptReport();
            string filterSql = "SELECT * FROM TaiLieu WHERE " + comTruong.Text + " = @val";
            DataTable dt2 = new DataTable();
            using (var adapter = new SqlDataAdapter(filterSql, conn))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@val", comGT.Text);
                adapter.Fill(dt2);
            }
            var ds = new DataSet();
            ds.Tables.Add(dt2);
            rpt.DataSource = ds;
            rpt.DataMember = "TaiLieu";

            rpt.ShowPreview();
        }

        private void frmDmtl_Load(object sender, EventArgs e)
        {
            str = "Data Source=DESKTOP-MVG881B; Initial Catalog = QLTV; Integrated Security=True";
            conn.ConnectionString = str;
            conn.Open();
            sql = "select MaTaiLieu , TenTaiLieu, MaTacGia , LoaiTaiLieu , SoLuong from TaiLieu";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdDmtl.DataSource = dt;
            NapCT();
        }
    }
}
