using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
     class Expense
    {
    public int ExpenseID{
            set;
            get;
    }
    public string Detail{
            set;
            get;
        }
    public int Amount{
            set;
            get;
    }
    public int CategoryID{
            set;
            get;
        }
     public DateTime DateAndTime{
            set;
            get;
        }
    public Expense( int expenseId, int categoryID,  int amount,DateTime dateTime, string detail)
        {
            ExpenseID = expenseId;
            CategoryID = categoryID;
            Detail = detail;
            Amount = amount;          
            DateAndTime = dateTime;
        }
    }
}
