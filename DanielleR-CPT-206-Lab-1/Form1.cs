using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielleR_CPT_206_Lab_1
{
    public partial class Form1 : Form
    {
        //Global Variables that store user input from textboxes on Form1
        int userUnits = 0;
        decimal userPriceMin = 0.0m;
        decimal userPriceMax = 0.0m;
        string userProductNum = "";
        string userDescription = "";

        ResultsForm formResults = new ResultsForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

        }

        private void btnProdNum_Click(object sender, EventArgs e)
        {
            try
            {
                //Catchs missing user input
                if (txtProductNumber.Text == "")
                {
                    MessageBox.Show("Please Enter a Product Number");
                }
                else
                {
                    userProductNum = txtProductNumber.Text;

                    ProductDataDataContext db = new ProductDataDataContext();

                    var results = from Product in db.Products
                                  where Product.Product_Number == userProductNum
                                  select Product.Description;
                    formResults.lBoxResults.Items.Clear();

                    foreach (string description in results)
                    {
                        formResults.lBoxResults.Items.Add(description);
                    }

                    formResults.Show();
                }
            }catch { MessageBox.Show("Error!"); }
        }

        private void btnDescripText_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescriptionText.Text == "")
                {
                    MessageBox.Show("Please Enter a Product Name");
                }
                else
                {
                    userDescription = txtDescriptionText.Text;

                    ProductDataDataContext db = new ProductDataDataContext();

                    var results = from Product in db.Products
                                  where Product.Description == userDescription
                                  select Product.Description;
                    formResults.lBoxResults.Items.Clear();

                    foreach (string description in results)
                    {
                        formResults.lBoxResults.Items.Add(description);
                    }

                    formResults.Show();
                }
            }catch { MessageBox.Show("Error!"); }
        }

        private void btnSortByUnitsASC_Click(object sender, EventArgs e)
        {
            ProductDataDataContext db = new ProductDataDataContext();

            var results = from product in db.Products
                          orderby product.Units_On_Hand
                          select product.Description;

            formResults.lBoxResults.Items.Clear();

            foreach (string description in results)
            {
                formResults.lBoxResults.Items.Add(description);
            }

            formResults.Show();
        }

        private void btnMoreThanUnits_Click(object sender, EventArgs e)
        {
            try
            {
                userUnits = int.Parse(txtUnitAmount.Text);

                if (txtUnitAmount.Text == "")
                {
                    MessageBox.Show("Please Enter Correct Units");
                }
                else
                {
                    ProductDataDataContext db = new ProductDataDataContext();

                    var results = from product in db.Products
                                  where product.Units_On_Hand > userUnits
                                  select product.Description;

                    formResults.lBoxResults.Items.Clear();

                    foreach (string description in results)
                    {
                        formResults.lBoxResults.Items.Add(description);
                    }

                    formResults.Show();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnLessThanUnits_Click(object sender, EventArgs e)
        {
            try
            {
                userUnits = int.Parse(txtUnitAmount.Text);

                if (txtUnitAmount.Text == "")
                {
                    MessageBox.Show("Please Enter Correct Units");
                }
                else
                {
                    ProductDataDataContext db = new ProductDataDataContext();

                    var results = from product in db.Products
                                  where product.Units_On_Hand < userUnits
                                  select product.Description;

                    formResults.lBoxResults.Items.Clear();

                    foreach (string description in results)
                    {
                        formResults.lBoxResults.Items.Add(description);
                    }

                    formResults.Show();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSortByPriceASC_Click(object sender, EventArgs e)
        {
            ProductDataDataContext db = new ProductDataDataContext();

            var results = from product in db.Products
                          orderby product.Price
                          select product.Description;

            formResults.lBoxResults.Items.Clear();

            foreach (string description in results)
            {
                formResults.lBoxResults.Items.Add(description);
            }

            formResults.Show();
        }

        private void btnFindInRange_Click(object sender, EventArgs e)
        {
            try
            {
                userPriceMin = decimal.Parse(txtPriceMin.Text);
                userPriceMax = decimal.Parse(txtPriceMax.Text);

                ProductDataDataContext db = new ProductDataDataContext();

                var results = from product in db.Products
                              where product.Price > userPriceMin
                              where product.Price < userPriceMax
                              select product.Description;

                formResults.lBoxResults.Items.Clear();

                foreach (string description in results)
                {
                    formResults.lBoxResults.Items.Add(description);
                }

                formResults.Show();

            }catch { MessageBox.Show("Error"); }
        }
    }
}
