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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                (productDGV.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("Nume like '%" + txtSearch.Text + "%' or Categoria like '%" + txtSearch.Text + "%'");
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
            bPriceTb.Text = "";
            prDataTb.Text = "";
        }

        private void GetCategory()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from CategoryTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Codul", typeof(int));
            dt.Load(Rdr);
            prCategoryCb.ValueMember = "Nume";
            prCategoryCb.DataSource = dt;
            Con.Close();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\stock.mdf;Integrated Security=True;Connect Timeout=30");
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(prNameTb.Text == "" || bPriceTb.Text == "" || prCategoryCb.SelectedIndex == -1)
            {
                MessageBox.Show("Mising Data", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProductTbl values(@PN,@PCat,@Bpr,@PrDate)", Con);
                    cmd.Parameters.AddWithValue("@PN", prNameTb.Text);
                    cmd.Parameters.AddWithValue("@PCat", prCategoryCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Bpr", bPriceTb.Text);
                    cmd.Parameters.AddWithValue("@PrDate", prDataTb.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Produsula fost salvat!");
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
                bPriceTb.Text = productDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                prDataTb.Text = productDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
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
            if (prNameTb.Text == "" || bPriceTb.Text == "" ||  prCategoryCb.SelectedIndex == -1)
            {
                MessageBox.Show("Lipsesc datele", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ProductTbl set Nume=@PN, Categoria=@PCat,Pretul=@Bpr,ProdData=@PrDate where Codul=@PrKey", Con);
                    cmd.Parameters.AddWithValue("@PN", prNameTb.Text);
                    cmd.Parameters.AddWithValue("@PCat", prCategoryCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Bpr", bPriceTb.Text);
                    cmd.Parameters.AddWithValue("@PrDate", prDataTb.Value.Date);
                    cmd.Parameters.AddWithValue("@PrKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Produsul a fost editat!");
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
                MessageBox.Show("Selecteaza produsul", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProductTbl where Codul=@PrKey", Con);
                    cmd.Parameters.AddWithValue("@PrKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Produsul a fost sters!");
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


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ShowProduct();
            txtSearch.Text = "";
            DeleteText();
        }

        private void prCategoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
