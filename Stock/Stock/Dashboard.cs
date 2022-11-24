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

namespace Stock
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountCategory();
            CountSuppliers();
            CountCustomers();
        }
        private void CountCategory()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CategoryTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            firstLbl.Text = dt.Rows[0][0].ToString()+" Categories";
            Con.Close();
        }
        private void CountSuppliers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from SupplierTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            secondLbl.Text = dt.Rows[0][0].ToString() + " Suppliers";
            Con.Close();
        }
        private void CountCustomers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CustomerTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            thirdLbl.Text = dt.Rows[0][0].ToString() + " Customers";
            Con.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\StockDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Stocks obj = new Stocks();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Category obj = new Category();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Suppliers obj = new Suppliers();
            obj.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            obj.Show();
            this.Hide();
        }
    }
}
