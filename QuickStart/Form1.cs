using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuickStart
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            //this.textbox_user.Text = "";
            //this.textbox_password.Text = "";
            this.Dispose();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string user = this.textbox_user.Text;
            string password = this.textbox_password.Text;

            SqlConnection conn = new SqlConnection("server=(DESKTOP-22MF9L6)/sqlexpress;database=ITSM_TEST;integrated security=true");
            conn.Open();

        }
    }
}
