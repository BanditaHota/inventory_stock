using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "bandita") && (textBox2.Text == "bandy"))
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_stocksDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.database_stocksDataSet.Products);

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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productsBindingSource1.EndEdit();
                this.productsTableAdapter.Update(this.database_stocksDataSet.Products);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
