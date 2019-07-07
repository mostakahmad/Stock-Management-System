using StockManagementSystem.BLL;
using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class CategoryForm : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        Category category = new Category();
        LoadSerialClass loadSerial = new LoadSerialClass();

        public CategoryForm()
        {
            InitializeComponent();
            categoryDataGridView.AllowUserToAddRows = false;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            categoryDataGridView.DataSource = _categoryManager.LoadCategories();
            loadSerial.LoadSerial(categoryDataGridView, categoryDataGridView.Rows.Count);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int isExists = 0;

            category.CategoryName = categoryNameTextBox.Text;

            if (categoryNameTextBox.Text == "")
            {
                errorMsg.Text = "Please Write a Category Name";
                return;
            }

            isExists = _categoryManager.CheckCategory(category);
            if(isExists > 0)
            {
                errorMsg.Text = "'" + categoryNameTextBox.Text + "' Category already exists!";
                categoryNameTextBox.Text = "";
                return;
            }

            int isExecuted = _categoryManager.InsertCategory(category);
            if (isExecuted > 0)
            {
                MessageBox.Show("Category Added");
            }
            else
            {
                MessageBox.Show("Try Again!!");
            }
            categoryDataGridView.DataSource = _categoryManager.LoadCategories();
            loadSerial.LoadSerial(categoryDataGridView, categoryDataGridView.Rows.Count);
            categoryNameTextBox.Text = "";
        }

        private void categoryNameTextBox_Click(object sender, EventArgs e)
        {
            errorMsg.Text = "";
        }
    }
}
