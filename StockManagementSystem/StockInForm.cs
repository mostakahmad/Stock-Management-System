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
    public partial class StockInForm : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        ItemManager _itemManager = new ItemManager();
        StockManager _stockManager = new StockManager();
        StocksIn stocksIn = new StocksIn();
        LoadSerialClass loadSerial = new LoadSerialClass();
        int availableItemCount = 0;

        public StockInForm()
        {
            InitializeComponent();
        }

        private void StockInForm_Load(object sender, EventArgs e)
        {
            companyComboBox.DataSource = _companyManager.LoadCompanies();
            companyComboBox.SelectedItem = null;
            companyComboBox.SelectedText = "--SELECT--";
        }

        private void CompanyValueChanged(object sender, EventArgs e)
        {
            int companyID = Convert.ToInt32(companyComboBox.SelectedValue);
            categoryComboBox.DataSource = _itemManager.LoadCategories(companyID);
        }

        private void CategoryValueChanged(object sender, EventArgs e)
        {
            int companyID = Convert.ToInt32(companyComboBox.SelectedValue);
            int categoryID = Convert.ToInt32(categoryComboBox.SelectedValue);
            itemComboBox.DataSource = _itemManager.Loaditems(companyID, categoryID);
        }

        private void ItemValueChanged(object sender, EventArgs e)
        {
            int itemID = Convert.ToInt32(itemComboBox.SelectedValue);
            DataTable dt = _itemManager.Fetchitems(itemID);

            rolTextBox.Text = dt.Rows[0]["ReorderLevel"].ToString();
            availableTextBox.Text = dt.Rows[0]["AvailableItem"].ToString();
            availableItemCount = Convert.ToInt32(dt.Rows[0]["AvailableItem"]);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            stocksIn.CompanyID = Convert.ToInt32( companyComboBox.SelectedValue);
            stocksIn.CategoryID = Convert.ToInt32( categoryComboBox.SelectedValue);
            stocksIn.ItemID = Convert.ToInt32(itemComboBox.SelectedValue);
            int stockIn = Convert.ToInt32( stockInTextBox.Text);
            stocksIn.StockIn = stockIn;
            availableItemCount += stockIn;

            int isExecuted = _stockManager.InserStock(stocksIn);
            int isExecuted2 = _itemManager.UpdateItem(stocksIn, availableItemCount);

            if(isExecuted > 0 && isExecuted2 > 0)
            {
                MessageBox.Show("Stock In Successfully!");
                stockInDataGridView.DataSource = _stockManager.LoadStockHistory(stocksIn);
                loadSerial.LoadSerial(stockInDataGridView, stockInDataGridView.Rows.Count);
                LoadAction(stockInDataGridView, stockInDataGridView.Rows.Count);
            }
            else
            {
                MessageBox.Show("Try Again!");
            }
            stockInTextBox.Text = "";
        }

        private void LoadAction(DataGridView dataGridView, int size)
        {
            for (int i = 0; i < size; i++)
            {
                dataGridView.Rows[i].Cells["action"].Value = "   Edit";
            }
        }
    }
}
