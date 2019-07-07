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
using System.Threading;
using System.Drawing.Drawing2D;

namespace StockManagementSystem
{
    public partial class SummaryForm : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        CategoryManager _categoryManager = new CategoryManager();
        ReportManager _reportManager = new ReportManager();
        LoadSerialClass loadSerial = new LoadSerialClass();

        //Thread firstThread, secondThread;

        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            PdfButton.Width = 100;
            PdfButton.Height = 100;
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(4, 4, PdfButton.Width - 8, PdfButton.Height - 8);
            PdfButton.Region = new Region(p);
            PdfButton.Location = new Point(618, 200);
            //Thread firstThread = new Thread(new ThreadStart(SummaryLoad));
            //Thread secondThread = new Thread(new ThreadStart(ColorChange));
            SummaryLoad();
            //firstThread.Start();
            //secondThread.Start();
        }

        private void SummaryLoad()
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
            //firstThread = new Thread(new ThreadStart(SaveLoad));
            //secondThread = new Thread(new ThreadStart(ColorChange));
            //firstThread.Start();
            //secondThread.Start();
            SaveLoad();
        }

        private void SaveLoad()
        {
            if (companyComboBox.Text == "--SELECT--")
            {
                MessageBox.Show("Please Select a Company");
                return;
            }
            if (categoryComboBox.Text == "--SELECT--")
            {
                MessageBox.Show("Please Select a Category");
                return;
            }
            
            int companyID = Convert.ToInt32(companyComboBox.SelectedValue);
            int categoryID = Convert.ToInt32(categoryComboBox.SelectedValue);

            DataTable dt = _reportManager.SummaryLoad(companyID, categoryID);

            if (dt.Rows.Count > 0)
            {
                summaryDataGridView.DataSource = dt;
                loadSerial.LoadSerial(summaryDataGridView, summaryDataGridView.Rows.Count);
            }
            else
            {
                MessageBox.Show("No Data Found!");
                summaryDataGridView.DataSource = "";
            }
            //secondThread.Start();
        }

        private void ColorChange()
        {
            while (true)
            {
                for (int i = 0; i < 100000; i++) ;
                PdfButton.BackColor = Color.DarkRed;
                for (int i = 0; i < 100000; i++) ;
                PdfButton.BackColor = Color.DarkGreen;
            }
        }

        private void PdfButton_MouseEnter(object sender, EventArgs e)
        {
            PdfButton.BackColor = Color.DarkRed;
            PdfButton.Size = new Size(150, 150);
            PdfButton.Width = 150;
            PdfButton.Height = 150;
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(4, 4, PdfButton.Width - 8, PdfButton.Height - 8);
            PdfButton.Region = new Region(p);
            PdfButton.Location = new Point(618, 175);
        }

        private void PdfButton_MouseLeave(object sender, EventArgs e)
        {
            PdfButton.BackColor = Color.DarkGreen;
            PdfButton.Size = new Size(100, 100);
            PdfButton.Width = 100;
            PdfButton.Height = 100;
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(4, 4, PdfButton.Width - 8, PdfButton.Height - 8);
            PdfButton.Region = new Region(p); 
            PdfButton.Location = new Point(618, 200);
        }
    }
}

