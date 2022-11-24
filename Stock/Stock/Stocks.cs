using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Stock
{
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
            ShowProduct();
            GetCategory();
            GetSuppliers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                (productDGV.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("Name like '%" + txtSearch.Text + "%' or Supp like '%" + txtSearch.Text + "%' or Category like '%" + txtSearch.Text + "%'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowProduct()
        {
            Con.Open();
            string Query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            productDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        private void DeleteText()
        {
            prNameTb.Text = "";
            prCategoryCb.Text = "";
            prQuantityTb.Text = "";
            bPriceTb.Text = "";
            sPriceTb.Text = "";
            prDataTb.Text = "";
            expDataTb.Text = "";
            prSupplierCb.Text = "";
        }

        private void GetCategory()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from CategoryTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatId", typeof(int));
            dt.Load(Rdr);
            prCategoryCb.ValueMember = "CatName";
            prCategoryCb.DataSource = dt;
            Con.Close();
        }

        private void GetSuppliers()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from SupplierTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SuppCode", typeof(int));
            dt.Load(Rdr);
            prSupplierCb.ValueMember = "SuppName";
            prSupplierCb.DataSource = dt;
            Con.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\StockDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(prNameTb.Text == "" || prQuantityTb.Text == "" || sPriceTb.Text == "" || bPriceTb.Text == "" || prSupplierCb.SelectedIndex == -1 || prCategoryCb.SelectedIndex == -1)
            {
                MessageBox.Show("Mising Data", "Info");
            }
            else
            {
                int Gain = Convert.ToInt32(sPriceTb.Text) - Convert.ToInt32(bPriceTb.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProductTbl values(@PN,@PCat,@Pqty,@Bpr,@Spr,@PrDate,@ExpDate,@Sup,@G)", Con);
                    cmd.Parameters.AddWithValue("@PN", prNameTb.Text);
                    cmd.Parameters.AddWithValue("@PCat", prCategoryCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Pqty", prQuantityTb.Text);
                    cmd.Parameters.AddWithValue("@Bpr", bPriceTb.Text);
                    cmd.Parameters.AddWithValue("@Spr", sPriceTb.Text);
                    cmd.Parameters.AddWithValue("@PrDate", prDataTb.Value.Date);
                    cmd.Parameters.AddWithValue("@ExpDate", expDataTb.Value.Date);
                    cmd.Parameters.AddWithValue("@Sup", prSupplierCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@G", Gain);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Product Saved!");
                    Con.Close();
                    ShowProduct();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void productDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                productDGV.ReadOnly = true;
                prNameTb.Text = productDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                prCategoryCb.Text = productDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                prQuantityTb.Text = productDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                bPriceTb.Text = productDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                sPriceTb.Text = productDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                prDataTb.Text = productDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
                expDataTb.Text = productDGV.Rows[e.RowIndex].Cells[7].Value.ToString();
                prSupplierCb.Text = productDGV.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (prNameTb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(productDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch
            {

            }
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (prNameTb.Text == "" || prQuantityTb.Text == "" || sPriceTb.Text == "" || bPriceTb.Text == "" || prSupplierCb.SelectedIndex == -1 || prCategoryCb.SelectedIndex == -1)
            {
                MessageBox.Show("Mising Data", "Info");
            }
            else
            {
                int Gain = Convert.ToInt32(sPriceTb.Text) - Convert.ToInt32(bPriceTb.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ProductTbl set Name=@PN, Category=@PCat, Qulity=@Pqty,BPrice=@Bpr,SPrice=@Spr,PrData=@PrDate,ExpData=@ExpDate,Supp=@Sup,Gain=@G where Code=@PrKey", Con);
                    cmd.Parameters.AddWithValue("@PN", prNameTb.Text);
                    cmd.Parameters.AddWithValue("@PCat", prCategoryCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Pqty", prQuantityTb.Text);
                    cmd.Parameters.AddWithValue("@Bpr", bPriceTb.Text);
                    cmd.Parameters.AddWithValue("@Spr", sPriceTb.Text);
                    cmd.Parameters.AddWithValue("@PrDate", prDataTb.Value.Date);
                    cmd.Parameters.AddWithValue("@ExpDate", expDataTb.Value.Date);
                    cmd.Parameters.AddWithValue("@Sup", prSupplierCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@G", Gain);
                    cmd.Parameters.AddWithValue("@PrKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Product Edited!");
                    Con.Close();
                    ShowProduct();
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
                MessageBox.Show("Select The Product", "Info");
            }
            else
            {
                int Gain = Convert.ToInt32(sPriceTb.Text) - Convert.ToInt32(bPriceTb.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProductTbl where Code=@PrKey", Con);
                    cmd.Parameters.AddWithValue("@PrKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Product Deleted!");
                    Con.Close();
                    ShowProduct();
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
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowProduct();
            txtSearch.Text = "";
            DeleteText();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            obj.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Con.Open();
            string sql = "select * from ProductTbl where PrData Between @date1 and @date2 and Category=@data"; 
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.SelectCommand.Parameters.AddWithValue("@date1", dtdate1.Value);
            da.SelectCommand.Parameters.AddWithValue("@date2", dtdate2.Value);
            da.SelectCommand.Parameters.AddWithValue("@data", txtCategory.Text);
            da.Fill(dt);
            Con.Close();
            productDGV.DataSource = dt;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Con.Open();
            string sql = "select * from ProductTbl where ExpData Between @date1 and @date2";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker2.Value);
            da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker1.Value);
            da.Fill(dt);
            Con.Close();
            productDGV.DataSource = dt;
        }
    }
}
