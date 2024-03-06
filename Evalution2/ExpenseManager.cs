using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evalution2
{
    static class ExpenseManager
    {
        public static MySqlConnection mySqlConnection;
        private static int category_Id = 1;
        private static int Expense_Id = 1;
        public static List<Category> CategoryList = new List<Category>();
        public static List<Expense> ExpenseList = new List<Expense>();
        private static MySqlCommand cmd=new MySqlCommand();
        public static void  DataBaseConnecting(){
            string connectionstring = "server=localhost;port=3306;uid=root;pwd=Suppu424*;database=subramani";
            mySqlConnection = new MySqlConnection(connectionstring);
          
            try
            {
                mySqlConnection.Open();
                cmd.Connection = mySqlConnection;
            }
            catch
            {
              
            }

        }
        public static string FindCategoryName(int categoryID)
        {
      
                string categoryNameFindQuery = $"select CategoryName from category where CategoryID={categoryID}";
                using(MySqlCommand command=new MySqlCommand(categoryNameFindQuery,mySqlConnection)){
                using(MySqlDataReader reader=command.ExecuteReader()){
                if(reader.Read()){
                       return reader["CategoryName"].ToString();
                }           
                }
                }
      

         
            return "Other";
        }
        public static string FindCategoryId(string name)
        {

           
            return "";
        }
        public static int FindCategoryLimit(int id)
        {

           
            return 0;
        }


        // Add Category

        public static bool AddCategory(string name, int limit)
        {
            string addCategoryQuery = $"insert into category(CategoryName,BudgetLimit,CurrentMonthUsedAmount) values ('{name}',{limit},{0});";
            cmd.CommandText = addCategoryQuery;
            cmd.ExecuteNonQuery();
            return true;
        }
        public static bool AddCategory(string name, int limit, int index)
        {
            string addCategoryQuery = $"insert into category(CategoryName,BudgetLimit,CurrentMonthUsedAmount) values ('{name}',{limit},{(int)0});";
            cmd.CommandText = addCategoryQuery;
            cmd.ExecuteNonQuery();
            return true;
        }

        // Update Category

        public static void UpdateCategory(int categoryID, string categoryName, int budgetLimit)
        {
            string foreignKeyCheckOFF = $"SET FOREIGN_KEY_CHECKS ={0};";
            cmd.CommandText = foreignKeyCheckOFF;
            cmd.ExecuteNonQuery();
            string updateCategoryQuery = $"update category set CategoryName='{categoryName}',BudgetLimit='{budgetLimit}' where CategoryID={categoryID}";
           cmd.CommandText = updateCategoryQuery;
            cmd.ExecuteNonQuery();
            string foreignKeyCheckOn = $"SET FOREIGN_KEY_CHECKS ={1};";
            cmd.CommandText = foreignKeyCheckOn;
            cmd.ExecuteNonQuery();
        }

        // Delete Category

        public static bool DeleteCategory(int categoryID)
        {
            string foreignKeyCheckOFF = $"SET FOREIGN_KEY_CHECKS ={0};";
            ExcuteQuery(foreignKeyCheckOFF);
            string deleteCategoryQuery = $"delete from category where CategoryID={categoryID};";
            ExcuteQuery(deleteCategoryQuery); 
            string convertExpenseToOthersCategory = $"update expense  set CategoryID={100} where CategoryID={categoryID};";
            ExcuteQuery(convertExpenseToOthersCategory);
            string sumOfOtherCategoryAmountAfterDeleteQuery = $" Select Sum(Amount) from expense where CategoryID={100} and Month(DateAndTime)={DateTime.Now.Month} and Year(DateAndTime)={DateTime.Now.Year};";
            cmd.CommandText = sumOfOtherCategoryAmountAfterDeleteQuery;
            int sumOfOtherCategoryAmountAfterDelete = Convert.ToInt32(cmd.ExecuteScalar());
            string UpdateOtherCategoryAmountQuery = $"Update category set CurrentMonthUsedAmount={sumOfOtherCategoryAmountAfterDelete} where  CategoryID={100}";
            ExcuteQuery(UpdateOtherCategoryAmountQuery);
            string foreignKeyCheckOn = $"SET FOREIGN_KEY_CHECKS ={1};";
            cmd.CommandText = foreignKeyCheckOn;
            cmd.ExecuteNonQuery();

            return true;
        }
        public static void ExcuteQuery(string query){
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        public static bool ChangeLimit(int id, int limit)
        {
          
            return false;
        }
        public static bool AddCurrentMonthSpentAmountToCategory(int categoryid, int amount)
        {
          
            return false;
        }
        
        public static int GetCurrentMonthLimitExceedAmount(int categoryID){

            string getCurrentMonthUsedAmountQuery = $"select (CurrentMonthUsedAmount-BudgetLimit)  from category where CategoryID={categoryID};";
            cmd.CommandText = getCurrentMonthUsedAmountQuery;
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
       
        public static Expense GetExpenseById(int expenseId)
        {
            string getExpenseQuery = $"select expense.ExpenseID ,expense.CategoryID ,expense.Amount ,expense.DateAndTime,expense.Detail From expense left Join category on expense.CategoryID = category.CategoryID where expense.ExpenseID={expenseId};";
            DataTable table = new DataTable();
            cmd.CommandText = getExpenseQuery;
            using(MySqlDataReader reader=cmd.ExecuteReader()){
                table.Load(reader);
            }
            
            return new Expense(int.Parse(table.Rows[0]["ExpenseID"].ToString()), int.Parse(table.Rows[0]["CategoryID"].ToString()), int.Parse(table.Rows[0]["Amount"].ToString()), (DateTime)table.Rows[0]["DateAndTime"], table.Rows[0]["Detail"].ToString());

        }
        public static DataTable GetCategoryById(int categoryId)
        {

            DataTable table = new DataTable();
            string getCategoryQuery = $"select CategoryName,BudgetLimit from category where CategoryID={categoryId}";
            cmd.CommandText = getCategoryQuery;
           using(MySqlDataReader reader=cmd.ExecuteReader()){
                table.Load(reader);
           }
            return table;

        }
        public static bool EditCurrentMonthUsedAmountToCategory(int amount,int categoryID){
            string addAmountToCategoryQuery = $"update category set CurrentMonthUsedAmount=CurrentMonthUsedAmount+{amount} where CategoryID={categoryID};";
            ExcuteQuery(addAmountToCategoryQuery);
            string addAmountToAllCategoryQuery = $"update category set CurrentMonthUsedAmount=CurrentMonthUsedAmount+{amount} where CategoryID={1};";
            ExcuteQuery(addAmountToAllCategoryQuery);
            return true;
        }
        // Add Expense

        public static bool AddExpense(List<object> expense)
        {
            string addQuery = $"INSERT INTO expense (CategoryID, Amount, DateAndTime, Detail) VALUES ({int.Parse(expense[0].ToString())}, {int.Parse(expense[1].ToString())}, '{((DateTime)expense[2]).ToString("yyyy-MM-dd HH:mm:ss")}', '{expense[3].ToString()}');";
            ExcuteQuery(addQuery);
            if (((DateTime)expense[2]).Month == DateTime.Now.Month && ((DateTime)expense[2]).Year == DateTime.Now.Year)
            {
                EditCurrentMonthUsedAmountToCategory(int.Parse(expense[1].ToString()), int.Parse(expense[0].ToString()));
            }

            return true;
        }
        public static bool AddExpense(string Details, int amount, DateTime dateTime, int categoryId)
        {

            string addQuery = $"INSERT INTO expense (CategoryID, Amount, DateAndTime, Detail) VALUES ({categoryId}, {amount}, '{dateTime.ToString("yyyy-MM-dd HH:mm:ss")}', '{Details}');";
            cmd.CommandText = addQuery;
            cmd.ExecuteNonQuery();
            if (dateTime.Month == DateTime.Now.Month && (dateTime.Year == DateTime.Now.Year))
            {
                EditCurrentMonthUsedAmountToCategory(amount, categoryId);
            }
            return true;
        }
      

        //Update Expense

        public static bool UpdateExpense(int id, int categoryID, int amount, DateTime dateTime, string Detail)
        {
           
            string expenseUpdateQuery = $"update expense set CategoryID={categoryID}, Amount={amount},DateAndTime='{(dateTime).ToString("yyyy-MM-dd HH:mm:ss")}',Detail='{Detail}' where ExpenseID={id};";
            cmd.CommandText = expenseUpdateQuery;
            cmd.ExecuteNonQuery();
            if (dateTime.Month == DateTime.Now.Month && dateTime.Year == DateTime.Now.Year)
            {
                EditCurrentMonthUsedAmountToCategory( amount, categoryID);
            }
            return true;
        }
        public static bool UpdateExpense(int id, List<object> expense)
        {
            string expenseUpdateQuery = $"update expense set CategoryID={int.Parse(expense[0].ToString())}, Amount={int.Parse(expense[1].ToString())},DateAndTime='{((DateTime)expense[2]).ToString("yyyy-MM-dd HH:mm:ss")}',Detail='{expense[3].ToString()}' where ExpenseID={id};";
            cmd.CommandText = expenseUpdateQuery;
            cmd.ExecuteNonQuery();
            if (((DateTime)expense[2]).Month == DateTime.Now.Month && ((DateTime)expense[2]).Year == DateTime.Now.Year)
            {
              
                EditCurrentMonthUsedAmountToCategory(int.Parse(expense[1].ToString()), int.Parse(expense[0].ToString()));
            }
            return true;
        }

        //Delete Expense

        public static bool DeleteExpense(int expenseId)
        {
            Expense expense = GetExpenseById(expenseId);


            string deleteQuery = $"delete From expense Where ExpenseId={expenseId}";
            cmd.CommandText = deleteQuery;
            cmd.ExecuteNonQuery();
            if (expense.DateAndTime.Month == DateTime.Now.Month && expense.DateAndTime.Year == DateTime.Now.Year)
            {
               
                EditCurrentMonthUsedAmountToCategory(-expense.Amount, expense.CategoryID);
            }
            return true;
        }
        

        // Get Source
      
        public static DataTable GetCategorySource(){
            DataTable table = new DataTable();

            string categoryGetQuery = "select category.CategoryID as CategoryID,category.CategoryName as CategoryName,category.BudgetLimit as BudgetLimit,category.CurrentMonthUsedAmount as CurrentMonthUsedAmount from category LEFT JOIN expense ON expense.CategoryID = category.CategoryID;" ;
            try
            {
                using (MySqlCommand command = new MySqlCommand(categoryGetQuery, mySqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }
                return table;
            }
            catch{
                return null;
            }         
        }
        public static DataTable GetExpenseSource()
        {
            DataTable table = new DataTable();

            string expenseGetQuery= "select expense.ExpenseID as ExpenseID,category.CategoryID as CategoryID,category.CategoryName as CategoryName,expense.DateAndTime as DateAndTime,expense.Amount as Amount,expense.Detail as Details from expense Left JOIN category  ON  Expense.CategoryID= Category.CategoryID;";
            try
            {
                using (MySqlCommand command = new MySqlCommand(expenseGetQuery, mySqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }
                return table;
            }
            catch
            {
                return null;
            }
        }
    }
}
