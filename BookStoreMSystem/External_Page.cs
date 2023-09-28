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
    public partial class External_Page : Form
    {
        public External_Page()
        {
            InitializeComponent();
        }

        private void Expernal_Page_Load(object sender, EventArgs e)
        {

        }

        private void next_button_Click(object sender, EventArgs e)
        {
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }

        private void personal_info_page_button_Click(object sender, EventArgs e)
        {
            Personal_Info_Page personal_Info = new Personal_Info_Page();
            personal_Info.Show();
        }

        private void proceed_label(object sender, EventArgs e)
        {
    
        }

        private void external_page_label(object sender, EventArgs e)
        {

        }

        private void description_label(object sender, EventArgs e)
        {

        }

        private void external_page_image(object sender, EventArgs e)
        {

        }
    }
}
