using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class ChartViewU : UserControl
    {
        List<string> categoryNameList;
        List<int> categoryValuesList;
        public ChartViewU()
        {
            InitializeComponent();
        }

        private void ChartViewU_Load(object sender, EventArgs e)
        {

        }
    }
}
