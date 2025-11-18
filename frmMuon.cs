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
    public partial class frmMuon : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string str, sql;
        public frmMuon()
        {
            InitializeComponent();
        }
        public void NapCT()
        {
            try
            {
                int i = grdPhieuMuon.CurrentRow.Index;
                txtMaPM.Text = grdPhieuMuon.Rows[i].Cells["MaPhieuMuon"].Value.ToString();
                txtMaDGPM.Text = grdPhieuMuon.Rows[i].Cells["MaDocGia"].Value.ToString();
                txtTenDGPM.Text = grdPhieuMuon.Rows[i].Cells["TenDocGia"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void frmMuon_Load(object sender, EventArgs e)
        {
            str = "Data Source = PING; Initial Catalog = QLTV1; Integrated Security = True;";
            conn.ConnectionString = str;
            conn.Open();
            sql = "select MaPhieuMuon, MaDocGia, TenDocGia from PhieuMuon";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdPhieuMuon.DataSource = dt;
            NapCT();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDG_Click(object sender, EventArgs e)
        {

        }

        private void txtGTPM_TextChanged(object sender, EventArgs e)
        {
            if (comTruongPM.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                string column = comTruongPM.SelectedItem.ToString();
                string keyword = txtGTPM.Text.Replace("'", "''");
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"{column} LIKE '%{keyword}%'";
            }
            NapCT();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCTPM_Click(object sender, EventArgs e)
        {
            frmCTPM f = new frmCTPM();
            f.
            f.ShowDialog();
        }

        private void grdPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
    }
}
