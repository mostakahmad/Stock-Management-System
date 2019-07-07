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
    public partial class HomeForm : Form
    {
        CategoryForm f1 = new CategoryForm();
        CompanyForm f2 = new CompanyForm();
        ItemForm f3 = new ItemForm();
        StockInForm f4 = new StockInForm();
        StockOutForm f5 = new StockOutForm();
        SummaryForm f6 = new SummaryForm();
        ReportForm f7 = new ReportForm();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            groupMemberGroupBox.Visible = false;
            FormShow(f1, f2, f3, f4, f5, f6, f7);
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            groupMemberGroupBox.Visible = false;
            FormShow(f2, f1, f3, f4, f5, f6, f7);
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            groupMemberGroupBox.Visible = false;
            FormShow(f3, f1, f2, f4, f5, f6, f7);
        }

        private void StockInButton_Click(object sender, EventArgs e)
        {
            groupMemberGroupBox.Visible = false;
            FormShow(f4, f1, f2, f3, f5, f6, f7);
        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            groupMemberGroupBox.Visible = false;
            FormShow(f5, f1, f2, f3, f4, f6, f7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupMemberGroupBox.Visible = false;
            FormShow(f6, f1, f2, f3, f4, f5, f7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupMemberGroupBox.Visible = false;
            FormShow(f7, f1, f2, f3, f4, f5, f6);
        }

        private void HomButton_Click(object sender, EventArgs e)
        {
            groupMemberGroupBox.Visible = true;
            erdRictureBox.Hide();
            FormShow(f1, f2, f3, f4, f5, f6, f7);
            f1.Hide();
        }

        public void FormShow(Form f1, Form f2, Form f3, Form f4, Form f5, Form f6, Form f7)
        {
            f1.Show();
            f2.Hide();
            f3.Hide();
            f4.Hide();
            f5.Hide();
            f6.Hide();
            f7.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            erdRictureBox.Hide();
            introLable.Text = "\'Stock Management System is\' is a Desktop Application developed using ASP.Net By \'Mostak Ahmad\'.\n" +
                "  This App will be very helpuf for any company to maintain their products. Stock In and Stock Out\n       details can be easily " +
                "handled. View Summary and Create Report are the special feature\n                                       of this \'Stock Management System\' App.";
        }

        private void ERDiagramButton_Click(object sender, EventArgs e)
        {
            erdRictureBox.Show();
        }
    }
}
