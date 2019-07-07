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
    public partial class StockOutForm : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        ItemManager _itemManager = new ItemManager();
        StockManager _stockManager = new StockManager();
        StocksIn stocksIn = new StocksIn();
        StockOut stockOut = new StockOut();
        int availableItemCount = 0;
        int stockOutSl = 0;
        int row = 0, col = 0;
        //List<List<int>> stockOutLists = new List<List<int>>();
        int[,] stockOutLists = new int[20, 5];

        public StockOutForm()
        {
            InitializeComponent();
        }

        private void StockOutForm_Load(object sender, EventArgs e)
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
            stockOutDataGridView.Rows.Add();
            stockOutDataGridView.Rows[stockOutSl].Cells["sl"].Value = (stockOutSl+1).ToString();
            stockOutDataGridView.Rows[stockOutSl].Cells["item"].Value = itemComboBox.Text;
            stockOutDataGridView.Rows[stockOutSl].Cells["company"].Value = companyComboBox.Text;
            stockOutDataGridView.Rows[stockOutSl].Cells["quantity"].Value = stockOutTextBox.Text;

            stockOutLists[row, col++] = Convert.ToInt32(itemComboBox.SelectedValue);
            stockOutLists[row, col++] = Convert.ToInt32(categoryComboBox.SelectedValue);
            stockOutLists[row, col++] = Convert.ToInt32(companyComboBox.SelectedValue);
            stockOutLists[row, col++] = Convert.ToInt32(stockOutTextBox.Text);
            stockOutLists[row, col++] = availableItemCount - Convert.ToInt32(stockOutTextBox.Text);

            stockOutDataGridView.Rows[stockOutSl].Cells["itemID"].Value = itemComboBox.SelectedValue;
            stockOutDataGridView.Rows[stockOutSl].Cells["categoryID"].Value = categoryComboBox.SelectedValue;
            stockOutDataGridView.Rows[stockOutSl].Cells["companyID"].Value = companyComboBox.SelectedValue;
            stockOutDataGridView.Rows[stockOutSl].Cells["stockOutAmount"].Value = stockOutTextBox.Text;

            stockOutTextBox.Text = "";

            stockOutSl++;
            row++;
            col = 0;
        }

        private void LostButton_Click(object sender, EventArgs e)
        {
            _stockManager.InserStockOut(stockOutLists, row, 2);
            MessageBox.Show("Successfully Addedd!");
            ClearGrid();
        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            _stockManager.InserStockOut(stockOutLists, row, 3);
            MessageBox.Show("Successfully Addedd!");
            ClearGrid();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            _stockManager.InserStockOut(stockOutLists, row, 1);
            MessageBox.Show("Successfully Addedd!");
            ClearGrid();
        }

        private void ClearGrid()
        {
            stockOutDataGridView.Rows.Clear();
            stockOutDataGridView.Refresh();
            availableItemCount = 0;
            stockOutSl = 0;
            row = 0;
            col = 0;
        }
    }
}
