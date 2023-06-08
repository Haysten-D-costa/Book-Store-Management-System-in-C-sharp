using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreMSystem
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Main_Page main_page = new Main_Page();
            main_page.Show();
        }

        private void login_page_label(object sender, EventArgs e)
        {

        }

        private void login_page_image_box(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            External_Page expernal_Page = new External_Page();
            expernal_Page.Show();

        }

        private void user_name(object sender, EventArgs e)
        {

        }

        private void user_email(object sender, EventArgs e)
        {

        }

        private void user_password(object sender, EventArgs e)
        {

        }

        private void agree_login_check_mark(object sender, EventArgs e)
        {

        }

        private void admin_page_button_Click(object sender, EventArgs e)
        {
            Admin_Page admin_page = new Admin_Page();
            admin_page.Show();
        }
    }
}
