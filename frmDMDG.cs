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
            // TODO: This line of code loads data into the 'qLTVDataSet3.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.qLTVDataSet3.DocGia);

        }
    }
}
