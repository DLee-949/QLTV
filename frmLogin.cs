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
    public partial class frmLogin: Form
    {
        // Raised when the login button is pressed; sends the typed account string.
        public event Action<string> LoginSubmitted;

        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            this.btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var account = txtAccount?.Text?.Trim() ?? string.Empty;
            LoginSubmitted?.Invoke(account);
            this.Close();
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked)             
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
