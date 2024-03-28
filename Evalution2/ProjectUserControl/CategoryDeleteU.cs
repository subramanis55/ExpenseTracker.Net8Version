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
    public partial class CategoryDeleteU : UserControl
    {
        public EventHandler<int> onClickRemove;
        public CategoryDeleteU()
        {
            InitializeComponent();
            DataTable dataTable = ExpenseManager.GetCategorySource();
            dataTable.Rows.RemoveAt(0);
            for(int i=0;i < dataTable.Rows.Count;i++){
            if (int.Parse(dataTable.Rows[i]["CategoryID"].ToString())==2){
                    dataTable.Rows.RemoveAt(i);
                    break;
            }
            }
            categoryCB.DataSource = dataTable;
            categoryCB.DisplayMember = "CategoryName";
            categoryCB.ValueMember = "CategoryID";
            removeBtn.Click+= RemoveBtnClick;
        }

        private void RemoveBtnClick(object sender, EventArgs e)
        {
            
            onClickRemove.Invoke(this, (int)categoryCB.SelectedValue);
        }
    }
}
