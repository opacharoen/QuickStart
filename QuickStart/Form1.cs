using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

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
            //SqlConnection conn = new SqlConnection("Server=200.2.2.6;UID=sa;PASSWORD=*adm@krs;Database=DBSJI;Max Pool Size=400;Connect Timeout=600;");
            //conn.Open();

            using (SSLsEntities db = new SSLsEntities())
            {
                string txtuser = this.textbox_user.Text;
                string txtpassword = this.textbox_password.Text;
                var items = db.Users.SingleOrDefault(users => users.Id == txtuser && users.Password == txtpassword);
                if (items != null)
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Login not found!");
                } //-- END IF
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            foreach (Control X in this.Controls)
            {
                if (X is TextBox)
                {
                    X.Text = "";
                }
            }
            this.CenterToScreen();
        }
    }
}
