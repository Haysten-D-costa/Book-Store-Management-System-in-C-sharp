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

namespace BookStoreMSystem
{
    public partial class Modify_Page : Form
    {
        public Modify_Page()
        {
            InitializeComponent();
        }

        private void Modify_window_Load(object sender, EventArgs e)
        {
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=HAYDC24\\SQLEXPRESS;Initial Catalog=BooksDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string ID = bookIdTextBox.Text;
            string Name = bookNameTextBox.Text;
            string PDate = bookPDateTextBox.Text;
            string Author = bookAuthorTextBox.Text;
            string Genre = bookGenreTextBox.Text;
            string Price = bookPriceTextBox.Text;

            string Query = "UPDATE Book_Specification SET bookName = '" + Name + "', bookPublishDate = '" + PDate + "', bookAuthor = '" + Author + "', bookGenere = '" + Genre + "', bookPrice = '" + Price + "' WHERE bookID = " + ID;
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Entry updated Successfully !");
            bookIdTextBox.Text = "";
            bookNameTextBox.Text = "";
            bookAuthorTextBox.Text = "";
            bookGenreTextBox.Text = "";
            bookPDateTextBox.Text = "";
            bookPriceTextBox.Text = "";
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showRecordButton_Click(object sender, EventArgs e)
        {
           
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=HAYDC24\\SQLEXPRESS;Initial Catalog=BooksDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string ID = bookIdTextBox.Text;

            string Query = "DELETE FROM Book_Specification WHERE bookID = "+ ID;
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Entry deleted Successfully !");

            // Clearing the text boxes after operations...
            bookIdTextBox.Text = "";
            bookNameTextBox.Text = "";
            bookAuthorTextBox.Text = "";
            bookGenreTextBox.Text = "";
            bookPDateTextBox.Text = "";
            bookPriceTextBox.Text = "";

        }
    }
}
