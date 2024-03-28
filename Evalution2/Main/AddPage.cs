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
           // dataTable.Rows.Add(new DataRow(dataTable.Rows[0]));
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
        bool isUp;
        Point prevPoint;
        private void MessageBoxTopPMouseMove(object sender, MouseEventArgs e)
        {
            if (isUp)
            {
                this.Location = new Point(Location.X + (Cursor.Position.X - prevPoint.X), Location.Y + (Cursor.Position.Y - prevPoint.Y));
                prevPoint = Cursor.Position;
            }

        }
        private void MessageBoxTopPMouseDown(object sender, MouseEventArgs e)
        {
            isUp = true;
            prevPoint = Cursor.Position;
        }

        private void MessageBoxTopPMouseUp(object sender, MouseEventArgs e)
        {
            isUp = false;
        }
        public AddPage(List<string> categorySource)
        {
            InitializeComponent();
           
        }

        private void AddPageLoad(object sender, EventArgs e)
        {
            AddBtn.Click += SubmitBtnClick;
            dateTimePicker.ValueChanged += DateTimePickerValueChanged;
            cancelBtn.Click += CancelBtn_Click;
            // categoryCB.SelectedIndex = 0;
            date = dateTimePicker.Value;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DateTimePickerValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker.Value;
        }

        private void SubmitBtnClick(object sender, EventArgs e)
        {
             OnSubmit?.Invoke(this, new List<object>() { categoryCB.SelectedValue.ToString(), amountTB.Text, date, reasonTB.Text });                      
                          
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
