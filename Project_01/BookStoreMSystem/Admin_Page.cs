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
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=HAYDC24\\SQLEXPRESS;Initial Catalog=BooksDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string SearchData = searchTextBox.Text;

            string Query = "SELECT * FROM Book_Specification WHERE bookID LIKE '%"+SearchData+"%'";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();

            booksDataGridView.Rows.Clear(); // ERROR ! This Clear() function is not working...

            while(reader.Read())
            {
                booksDataGridView.Rows.Add(reader["bookID"]);
            }

            con.Close();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            Modify_Page modify_Page = new Modify_Page();
            modify_Page.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
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

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
