using StockManagementSystem.Models;
using StockManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    public class CompanyManager
    {
        CompanyRepository _companyRepository = new CompanyRepository();
        public DataTable LoadCompanies()
        {
            return _companyRepository.LoadCompanies();
        }

        public int InsertCompany(Company company)
        {
            return _companyRepository.InsertCompany(company);
        }

        public int CheckCompany(Company company)
        {
            return _companyRepository.CheckCompany(company);
        }
    }
}
