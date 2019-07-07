using StockManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    public class ReportManager
    {
        ReportRepository _reportRepository = new ReportRepository();
        public DataTable SummaryLoad(int companyID, int categoryID)
        {
            return _reportRepository.SummaryLoad(companyID, categoryID);
        }

        public DataTable LoadReport(string fromDate, string toDate, int check)
        {
            return _reportRepository.LoadReport(fromDate, toDate, check);
        }
    }
}
