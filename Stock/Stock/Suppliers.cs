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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
            ShowSuppliers();
        }

        private void ShowSuppliers()
        {
            Con.Open();
            string Query = "select * from SupplierTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SupplierDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DeleteText()
        {
            SuppNameTb.Text = "";
            SuppPhoneTb.Text = "";
            SuppAddressTb.Text = "";
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\StockDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (SuppNameTb.Text == "" || SuppPhoneTb.Text == "" || SuppAddressTb.Text == "")
            {
                MessageBox.Show("Mising Data", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SupplierTbl(SuppName, SuppPhone, SuppAddr) values(@SN,@SP,@SA)", Con);
                    cmd.Parameters.AddWithValue("@SN", SuppNameTb.Text);
                    cmd.Parameters.AddWithValue("@SP", SuppPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SA", SuppAddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Supplier Saved!");
                    Con.Close();
                    ShowSuppliers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;
        private void SupplierDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SuppNameTb.Text = SupplierDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                SuppPhoneTb.Text = SupplierDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                SuppAddressTb.Text = SupplierDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (SuppNameTb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(SupplierDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch { }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (SuppNameTb.Text == "" || SuppPhoneTb.Text == "" || SuppAddressTb.Text == "")
            {
                MessageBox.Show("Mising Data", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update SupplierTbl set SuppName=@SN, SuppPhone=@SP, SuppAddr=@SA where SuppCode=@SKey", Con);
                    cmd.Parameters.AddWithValue("@SN", SuppNameTb.Text);
                    cmd.Parameters.AddWithValue("@SP", SuppPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SA", SuppAddressTb.Text);cmd.Parameters.AddWithValue("@SKey", key);
                    cmd.Parameters.AddWithValue("@SKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Supplier Edited!");
                    Con.Close();
                    ShowSuppliers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Supplier", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from SupplierTbl where SuppCode=@SKey", Con);
                    cmd.Parameters.AddWithValue("@SKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Supplier Deleted!");
                    Con.Close();
                    ShowSuppliers();
                    DeleteText();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Stocks obj = new Stocks();
            obj.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            obj.Show();
            this.Hide();
        }
    }
}
