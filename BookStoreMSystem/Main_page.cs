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
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help_Page help_Page = new Help_Page();
            help_Page.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void books_button_Click(object sender, EventArgs e)
        {
            Books_Page books_Page = new Books_Page();
            books_Page.Show();
        }

        private void category_button_Click(object sender, EventArgs e)
        {
            Category_Page category_Page = new Category_Page();
            category_Page.Show();
        }

        private void cart_button_Click(object sender, EventArgs e)
        {
            Cart_Page cart_Page = new Cart_Page();
            cart_Page.Show();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Exit_Page exit_Page = new Exit_Page();
            exit_Page.Show();
        }

        private void main_page_side_bar(object sender, EventArgs e)
        {

        }

        private void main_page_label(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
