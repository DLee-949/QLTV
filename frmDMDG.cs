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
    public partial class frmDMDG : Form
    {
        public frmDMDG()
        {
            InitializeComponent();
        }

        private void frmDMDG_Load(object sender, EventArgs e)
        {
            str = "Data Source = DESKTOP-MVG881B; Initial Catalog = QLTV; Integrated Security = True;";
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
}
