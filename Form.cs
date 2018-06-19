using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            //connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=C:\Users\HBandita\Desktop\Database_stocks";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (textBox2.Text == "1234"))
            {
                groupBox1.Visible = false;
            }

            else
                MessageBox.Show("incorrect login details");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_stocksDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.database_stocksDataSet.Stock);
            // TODO: This line of code loads data into the 'database_stocksDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.database_stocksDataSet.Products);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            productsBindingSource1.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productsBindingSource1.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            productsBindingSource1.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productsBindingSource1.MovePrevious();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection Connect;
                //connection.Open();
                OleDbCommand command;


                Connect =new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; User Id=Admin; Data source=C:\Users\HBandita\Desktop\Database_stocks.accdb");
                Connect.Open();
                command = Connect.CreateCommand();
                command.CommandText= "INSERT INTO Products ([Product _Code], Product_Name, Status) VALUES('" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.SelectedItem.ToString() + "')";
                command.ExecuteNonQuery();

                string query = "SELECT [Product _Code], Product_Name, Status FROM Products";
                    command.CommandText = query;
                //command.ExecuteNonQuery();



                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;



                Connect.Close();
               

                MessageBox.Show("Data Saved");
                
            }

            catch (Exception)
            {
                MessageBox.Show("Try Again!");
            }
        }



        private void tabPage3_Click(object sender, EventArgs e)
        {
            //con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=C:\Users\HBandita\Desktop\Database_stocks.accdb";    

        }



        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            stockBindingSource.RemoveCurrent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection Connect;
                //connection.Open();
                OleDbCommand command;


                Connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; User Id=Admin; Data source=C:\Users\HBandita\Desktop\Database_stocks.accdb");
                Connect.Open();
                command = Connect.CreateCommand();
                //textBox7.Text = DateTime.Now.ToLongDateString();
                command.CommandText = "INSERT INTO Stock ( [Product Code], [Product Name], [Transaction year], Quantity) VALUES('" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "' )";

 
                command.ExecuteNonQuery();



                string query = "select * from Stock";
                command.CommandText = query;
                //command.ExecuteNonQuery();


                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;



                Connect.Close();


                MessageBox.Show("Data Saved");


            }

            catch (Exception)
            {
                MessageBox.Show("Try Again!");
            }
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            decimal x;
            x = Convert.ToDecimal(textBox12.Text);
            x = x / 100;

            int y;
            y= Convert.ToInt32(textBox10.Text);

            int z;
            z= Convert.ToInt32(textBox11.Text);

           decimal p = x * y * z;
            textBox13.Text = p.ToString();



        }

        private void button13_Click(object sender, EventArgs e)
        {
            stockBindingSource.MovePrevious();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            stockBindingSource.MoveNext();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

