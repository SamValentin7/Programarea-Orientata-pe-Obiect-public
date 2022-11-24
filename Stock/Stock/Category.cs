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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            ShowCategory();
            CountCat();
        }

        private void ShowCategory()
        {
            Con.Open();
            string Query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CategoryDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DeleteText()
        {
            CatNameTb.Text = "";
        }

        private void CountCat()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CategoryTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CatNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\StockDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (CatNameTb.Text == "")
            {
                MessageBox.Show("Mising Data", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CategoryTbl values(@CatN)", Con);
                    cmd.Parameters.AddWithValue("@CatN", CatNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Category Saved!");
                    Con.Close();
                    ShowCategory();
                    CountCat();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (CatNameTb.Text == "")
            {
                MessageBox.Show("Mising Data", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CategoryTbl set CatName=@CN where CatId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", CatNameTb.Text);
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Category Edited!");
                    Con.Close();
                    ShowCategory();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CategoryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CatNameTb.Text = CategoryDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (CatNameTb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(CategoryDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch { }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Category", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CategoryTbl where CatId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Category Deleted!");
                    Con.Close();
                    ShowCategory();
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(CategoryDGV.Width, CategoryDGV.Height);
            CategoryDGV.DrawToBitmap(imagebmp, new Rectangle(0, 0, CategoryDGV.Width, CategoryDGV.Height));
            e.Graphics.DrawImage(imagebmp, 0, 120);
            e.Graphics.DrawString(label2.Text, new Font("Microsoft YaHei", 18, FontStyle.Bold), Brushes.Black, new Point(120));
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
