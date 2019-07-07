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
    public partial class CompanyForm : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        Company company = new Company();
        LoadSerialClass loadSerial = new LoadSerialClass();
        public CompanyForm()
        {
            InitializeComponent();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            companyDataGridView.DataSource = _companyManager.LoadCompanies();
            loadSerial.LoadSerial(companyDataGridView, companyDataGridView.Rows.Count);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int isExists = 0;

            company.CompanyName = companyNameTextBox.Text;

            if(companyNameTextBox.Text == "")
            {
                errorMsg.Text = "Please Write Your Company Name";
                return;
            }

            isExists = _companyManager.CheckCompany(company);
            if (isExists > 0)
            {
                errorMsg.Text ="'"+ companyNameTextBox.Text + "' Company already exists!";
                companyNameTextBox.Text = "";
                return;
            }

            int isExecuted = _companyManager.InsertCompany(company);
            if (isExecuted > 0)
            {
                MessageBox.Show("Company Added");
            }
            else
            {
                MessageBox.Show("Try Again!!");
            }
            companyDataGridView.DataSource = _companyManager.LoadCompanies();
            loadSerial.LoadSerial(companyDataGridView, companyDataGridView.Rows.Count);
            companyNameTextBox.Text = "";
        }

        private void companyNameTextBox_Click(object sender, EventArgs e)
        {
            errorMsg.Text = "";
        }
    }
}
