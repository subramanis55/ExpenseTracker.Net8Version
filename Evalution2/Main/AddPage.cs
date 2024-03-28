using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class AddPage : Form
    {
        
        public EventHandler<List<object>> OnSubmit;
        public bool IsEditMode;
        private int editExpenseId;
        private DateTime date;
        public AddPage()
        {
            InitializeComponent();
            DataTable dataTable = ExpenseManager.GetCategorySource();
            dataTable.Rows.RemoveAt(0);
            categoryCB.DataSource = dataTable;        
            categoryCB.DisplayMember = "CategoryName";
            categoryCB.ValueMember = "CategoryID";
            Load += AddPageLoad;

        }

        public AddPage(int expenseId){

            InitializeComponent();
            editExpenseId=expenseId;
            IsEditMode = true;
            DataTable dataTable = ExpenseManager.GetCategorySource();
            dataTable.Rows.RemoveAt(0);
            categoryCB.DataSource = dataTable;
            categoryCB.DisplayMember = "CategoryName";
            categoryCB.ValueMember = "CategoryID";

            Load += AddPageLoad;
            ValueSetToEdit();
        }

        private void ValueSetToEdit()
        {
           if(editExpenseId!=0){
                Expense expense = ExpenseManager.GetExpenseById(editExpenseId);
               
                amountTB.Text =""+ expense.Amount;
                dateTimePicker.Value = expense.DateAndTime;
                categoryCB.SelectedValue = expense.CategoryID;
                reasonTB.Text = expense.Detail;
           } 
        }

        public AddPage(List<string> categorySource)
        {
            InitializeComponent();
           
        }

        private void AddPageLoad(object sender, EventArgs e)
        {
            submitBtn.Click += SubmitBtnClick;
            dateTimePicker.ValueChanged += DateTimePickerValueChanged;
           // categoryCB.SelectedIndex = 0;
            date = dateTimePicker.Value;
        }
       
        private void DateTimePickerValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker.Value;
        }

        private void SubmitBtnClick(object sender, EventArgs e)
        {
             OnSubmit?.Invoke(this, new List<object>() { categoryCB.SelectedValue.ToString(), amountTB.Text, date, reasonTB.Text });                      
                          
        }
    }
}
