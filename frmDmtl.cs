using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = "select distinct " + comTruong.Text + " from TaiLieu";
            da = new SqlDataAdapter(sql, conn);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            comGT.DataSource = dt1;
            comGT.DisplayMember = comTruong.Text;
            comGT.ValueMember = comTruong.Text;
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
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comGT_SelectedIndexChanged(object sender, EventArgs e)
        {

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
