using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Dialogs
{
    public partial class ProductForm : Form
    {
        private Product product;
        public ProductForm(Product product)
        {
            InitializeComponent();

            this.product = product;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTb.Text))
            {
                MessageBox.Show("Enter a product name!");
                return;
            }
            product.Name = nameTb.Text;
            product.Price = priceNumeric.Value;
            product.ProductDate = prodDatePicker.Value;
            product.Description = descriptionTb.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
