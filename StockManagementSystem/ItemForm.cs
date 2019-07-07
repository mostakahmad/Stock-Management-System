using StockManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;

namespace StockManagementSystem
{
    public partial class ItemForm : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        CategoryManager _categoryManager = new CategoryManager();
        ItemManager _ItemManager = new ItemManager();
        Item item = new Item();
        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {         
            companyComboBox.DataSource = _companyManager.LoadCompanies();
            categoryComboBox.DataSource = _categoryManager.LoadCategories();
            companyComboBox.SelectedItem = null;
            companyComboBox.SelectedText = "--SELECT--";
            categoryComboBox.SelectedItem = null;
            categoryComboBox.SelectedText = "--SELECT--";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int isExists = 0;

            if (categoryComboBox.Text == "--SELECT--")
            {
                MessageBox.Show("Please Select a Category");
                return;
            }
            if (companyComboBox.Text == "--SELECT--") 
            {
                MessageBox.Show("Please Select a Company");
                return;
            }

            item.CategoryID = Convert.ToInt32(categoryComboBox.SelectedValue);
            item.CompanyID = Convert.ToInt32(companyComboBox.SelectedValue);

            if (itemNameTextBox.Text == "")
            {
                errorMsg.Text = "Please Write an Item Name";
                return;
            }
            if (rolTextBox.Text == "")
            {
                errorMsg2.Text = "Please Give the Reorder Level";
                return;
            }

            int i = 0;
            bool isNumeric = int.TryParse(rolTextBox.Text, out i);

            if(isNumeric == false)
            {
                errorMsg2.Text = "Please Enter Numeric Value";
                return;
            }

            item.ItemName = itemNameTextBox.Text;
            item.ReorderLevel = Convert.ToInt32(rolTextBox.Text);

            isExists = _ItemManager.CheckItem(item);
            if (isExists > 0)
            {
                errorMsg.Text = "This Item already included!";
                itemNameTextBox.Text = "";
                rolTextBox.Text = "";
                return;
            }

            int isExecuted = _ItemManager.InsertItem(item);

            if(isExecuted > 0)
            {
                MessageBox.Show("Item Successfully Saved!");
            }
            else
            {
                MessageBox.Show("Something Went Wrong!");
            }
            itemNameTextBox.Text = "";
            rolTextBox.Text = "";
        }

        private void itemNameTextBox_Click(object sender, EventArgs e)
        {
            errorMsg.Text = "";
        }

        private void rolTextBox_Click(object sender, EventArgs e)
        {
            errorMsg2.Text = "";
        }
    }
}
