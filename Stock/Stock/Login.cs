using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (UsernameTb.Text == "Admin" && PasswordTb.Text == "Admin")
            {
                Stocks obj = new Stocks();
                obj.Show();
                this.Hide();
            }
        }
    }
}
