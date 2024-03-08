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
    public partial class CategoryUpdateU : UserControl
    {
        public EventHandler<List<object>> OnClickSave;
       
        public CategoryUpdateU()
        {
            InitializeComponent();

            DataTable dataTable = ExpenseManager.GetCategorySource();        
            categoryCB.DataSource = dataTable;
            categoryCB.DisplayMember = "CategoryName";
            categoryCB.ValueMember = "CategoryID";       
            categoryCB.SelectedIndexChanged += CategoryCBValueMemberChanged;
            CategoryCBValueMemberChanged(this, EventArgs.Empty);
           // categoryCB.SelectedValue = 1;
            SaveBtn.Click += SaveBtnClick;
        }

        private void SaveBtnClick(object sender, EventArgs e)
        {       
                //validate
                OnClickSave?.Invoke(this, new List<object>(){categoryCB.SelectedValue, categaryNameTB.Text, limitTB.Text });
                       
        }

        private void CategoryCBValueMemberChanged(object sender, EventArgs e)
        {     
                if (categoryCB.DataSource != null)
                {
                if (categoryCB.SelectedIndex == 0 || (int)categoryCB.SelectedValue==100)
                    {
                        categaryNameTB.ReadOnly = true;
                    }
                    else
                    {
                        categaryNameTB.ReadOnly = false;
                    }
                   DataTable table = ExpenseManager.GetCategoryById(int.Parse(categoryCB.SelectedValue.ToString()));
                    categaryNameTB.Text = table.Rows[0]["CategoryName"].ToString();
                    limitTB.Text = "" + table.Rows[0]["BudgetLimit"].ToString();
                }  
       
        }
    }
}
