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
    public partial class Books_Page : Form
    {
        public Books_Page()
        {
            InitializeComponent();
        }

        private void Books_Page_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showBooks_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=HAYDC24\\SQLEXPRESS;Initial Catalog=BooksDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "SELECT * FROM Book_Specification";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            booksDataGridView.DataSource = table;
            
            con.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=HAYDC24\\SQLEXPRESS;Initial Catalog=BooksDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            string Query = "SELECT * FROM Book_Specification WHERE bookID LIKE @bookID + '%' OR bookName LIKE @bookName + '%' OR bookPublishDate LIKE @bookPublishDate + '%' OR bookAuthor LIKE @bookAuthor + '%' OR bookGenere LIKE @bookGenere + '%' OR bookPrice LIKE @bookPrice + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.SelectCommand.Parameters.AddWithValue("@bookID", searchTextBox.Text.Trim());
            sda.SelectCommand.Parameters.AddWithValue("@bookName", searchTextBox.Text.Trim());
            sda.SelectCommand.Parameters.AddWithValue("@bookPublishDate", searchTextBox.Text.Trim());
            sda.SelectCommand.Parameters.AddWithValue("@bookAuthor", searchTextBox.Text.Trim());
            sda.SelectCommand.Parameters.AddWithValue("@bookGenere", searchTextBox.Text.Trim());
            sda.SelectCommand.Parameters.AddWithValue("@bookPrice", searchTextBox.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);

            booksDataGridView.DataSource = data;
            searchTextBox.Text = "";
            con.Close();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
