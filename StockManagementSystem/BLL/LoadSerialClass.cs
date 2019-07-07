using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.BLL
{
    public class LoadSerialClass
    {
        public void LoadSerial(DataGridView dataGridView, int size)
        {
            for(int i = 0; i < size; i++)
            {
                dataGridView.Rows[i].Cells["sl"].Value = (i + 1).ToString();
            }
        }
    }
}
