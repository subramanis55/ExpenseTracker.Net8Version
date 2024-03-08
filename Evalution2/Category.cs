using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public class Category
    {
        public string Id {
            set;
            get;
        }
        public string Name {
            set;
            get;
        }
        public int Limit {
            set;
            get;
        }
     public int CurrentUsedAmount{
            set;
            get;

    }
       public  Category(string id,string name,int limit){
            Id = id;
            Name = name;
            Limit = limit;
        }
    }
}
