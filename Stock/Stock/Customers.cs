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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            ShowCustomers();
            ShowCustomers2();
        }

        private void ShowCustomers()
        {
            Con.Open();
            string Query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ShowCustomers2()
        {
            Con.Open();
            string Query = "select * from CustAddress";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomersDGV2.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DeleteText()
        {
            CstNameTb.Text = "";
            CstGenderCb.Text = "";
            CstPhoneTb.Text = "";
            CstAddressTb.Text = "";
            tbCity.Text = "";
            tbStreet.Text = "";
            tbAppartment.Text = "";

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\StockDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (CstNameTb.Text == "" || CstPhoneTb.Text == "" || CstAddressTb.Text == "" || CstGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Mising Data", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl values(@CN,@CP,@CA,@CG)", Con);
                    cmd.Parameters.AddWithValue("@CN", CstNameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CstPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CstAddressTb.Text);
                    cmd.Parameters.AddWithValue("@CG", CstGenderCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show(@"Customer Saved!");
                    Con.Close();
                    //ShowCustomers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            if (tbCity.Text == "" || tbStreet.Text == "" || tbAppartment.Text == "")
            {
                MessageBox.Show("Feel also City, Street and Appartment", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustAddress values(@Ct,@St,@Ap,@Adr)", Con);
                    cmd.Parameters.AddWithValue("@Ct", tbCity.Text);
                    cmd.Parameters.AddWithValue("@St", tbStreet.Text);
                    cmd.Parameters.AddWithValue("@Ap", tbAppartment.Text);
                    cmd.Parameters.AddWithValue("@Adr", CstAddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Customer Saved!");
                    Con.Close();
                    ShowCustomers();
                    ShowCustomers2();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        int key = 0;
        private void CustomersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CstNameTb.Text = CustomersDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                CstPhoneTb.Text = CustomersDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                CstAddressTb.Text = CustomersDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                CstGenderCb.Text = CustomersDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (CstNameTb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(CustomersDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch { }
        }
        int key2;
        private void CustomersDGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbCity.Text = CustomersDGV2.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbStreet.Text = CustomersDGV2.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbAppartment.Text = CustomersDGV2.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (tbCity.Text == "")
                {
                    key2 = 0;
                }
                else
                {
                    key2 = Convert.ToInt32(CustomersDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch { }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (CstNameTb.Text == "" || CstPhoneTb.Text == "" || CstAddressTb.Text == "" || CstGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Mising Data", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CustomerTbl set CustName=@CN, CustPhone=@CP, CustAddr=@CA, CustGen=@CG where CustId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", CstNameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CstPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CstAddressTb.Text);
                    cmd.Parameters.AddWithValue("@CG", CstGenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Customer Edited!");
                    Con.Close();
                    ShowCustomers();
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
                MessageBox.Show("Select The Customer", "Info");
            }
            else
            {
                try
                {
                    Con.Open();
                    MessageBox.Show("You are not allowed to delete the Customer!", "Info", MessageBoxButtons.OKCancel);
                    /*SqlCommand cmd = new SqlCommand("delete from CustomerTbl where CustId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();*/
                    //MessageBox.Show(@"Product Deleted!");
                    Con.Close();
                    //ShowCustomers();
                    DeleteText();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            /*if (key2 == 0)
            {
                MessageBox.Show("Select The Both Sides", "Info");
            }
            else
            {
                try
                {
                    MessageBox.Show("Are you sure you want to delete the Customer??!", "Info", MessageBoxButtons.OKCancel);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustAddress where Id=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AKey", key2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Customer Deleted!");
                    Con.Close();
                    ShowCustomers();
                    ShowCustomers2();
                    DeleteText();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }*/

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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(CustomersDGV.Width, CustomersDGV.Height);
            CustomersDGV.DrawToBitmap(imagebmp, new Rectangle(0, 0, CustomersDGV.Width, CustomersDGV.Height));
            e.Graphics.DrawImage(imagebmp, 0, 120);
            e.Graphics.DrawString(label2.Text, new Font("Microsoft YaHei", 18, FontStyle.Bold), Brushes.Black, new Point(120));
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowCustomers();
            ShowCustomers2();
            DeleteText();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (key2 == 0)
            {
                MessageBox.Show("Select The Both Sides", "Info");
            }
            else
            {
                try
                {
                    MessageBox.Show("Are you sure you want to delete the Customer??!", "Info", MessageBoxButtons.OKCancel);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustAddress where Id=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AKey", key2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Address Deleted!");
                    Con.Close();
                    //ShowCustomers();
                    ShowCustomers2();
                    DeleteText();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
