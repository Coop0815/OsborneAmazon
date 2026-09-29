using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsborneAmazon
{
    public partial class Form1 : Form
    {

        public static List<Product> productList = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            listView.View= View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;

            listView.Columns.Add("Product ID", 100);
            listView.Columns.Add("Product Name",150);
            listView.Columns.Add("Description", 250);
            listView.Columns.Add("Color");
            listView.Columns.Add("material");

            if(string.IsNullOrWhiteSpace(txtPID.Text))
            {
                MessageBox.Show("Enter product ID.");
                txtPID.Focus();
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Product product = new Product()
            {
                ProductID = txtPID.Text,
                ProductName = textBoxName.Text,
                ProductDescription = textBoxDescription.Text,
                ProductMaterial = txtMaterial.Text,
                ProductColor = txtColor.Text,

            };

            if (string.IsNullOrEmpty(txtPID.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxDescription.Text) ||string.IsNullOrEmpty(txtMaterial.Text) || string.IsNullOrEmpty(txtColor.Text))
                return;

            productList.Add(product);


            ListViewItem item = new ListViewItem(txtPID.Text);
            item.SubItems.Add(textBoxName.Text);
            item.SubItems.Add(textBoxDescription.Text);
            item.SubItems.Add(txtColor.Text);
            item.SubItems.Add(txtMaterial.Text);
            listView.Items.Add(item);
            txtPID.Clear();
            textBoxName.Clear();
            textBoxDescription.Clear();
            txtColor.Clear();
            txtMaterial.Clear();
            txtPID.Focus();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0 )

            // listView.Items.Remove(listView.SelectedItems[0]);
            
            { int index = listView.SelectedItems[0].Index;
                listView.Items.RemoveAt(index);
                productList.RemoveAt(index);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            lblCount.Text = productList.Count.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPID.Clear();
            textBoxName.Clear();
            textBoxDescription.Clear();
            txtColor.Clear();
            txtMaterial.Clear();
            txtPID.Focus();

        }
    }

}
