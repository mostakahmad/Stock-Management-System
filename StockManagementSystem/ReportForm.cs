using StockManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class ReportForm : Form
    {
        ReportManager _reportManager = new ReportManager();
        LoadSerialClass loadSerial = new LoadSerialClass();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int check;  

            string fromDate = fromDateTimePicker.Value.ToString("yyyy-MM-dd");
            string toDate = toDateTimePicker.Value.ToString("yyyy-MM-dd");

            if (soldRadioButton.Checked)
            {
                check = 1;
            }
            else if (lostRadioButton.Checked){
                check = 2;
            }
            else
            {
                check = 3;
            }

            DataTable dt = new DataTable();
            dt = _reportManager.LoadReport(fromDate, toDate, check);
            reportDataGridView.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                reportDataGridView.DataSource = dt;
                loadSerial.LoadSerial(reportDataGridView, reportDataGridView.Rows.Count);
            }
            else
            {
                MessageBox.Show("No Data Found!");
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            PdfButton.Width = 100;
            PdfButton.Height = 100;
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(4, 4, PdfButton.Width - 8, PdfButton.Height - 8);
            PdfButton.Region = new Region(p);
            PdfButton.Location = new Point(600, 25);
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
            PdfButton.Location = new Point(600, 25);
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
            PdfButton.Location = new Point(600, 25);
        }
    }
}
