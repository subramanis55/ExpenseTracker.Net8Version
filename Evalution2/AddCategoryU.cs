using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evalution2
{
    public partial class AddCategoryU : UserControl
    {
       
        public EventHandler<List<object>> OnclickSubmit;
   
        private string editCategoryId="";
        public AddCategoryU()
        {
            InitializeComponent();
            submitBtn.Click += SubmitBtnClick;
        }
        public AddCategoryU(Category category)
        {
            InitializeComponent();
            editCategoryId = category.Id;
            categaryNameTB.Text = category.Name;
            submitBtn.Click += SubmitBtnClick;
        }

        private void SubmitBtnClick(object sender, EventArgs e)
        {
        //if(Validate())
     
                if (editCategoryId != "")
                {
                    OnclickSubmit.Invoke(this, new List<object> { editCategoryId, categaryNameTB.Text, limitTB.Text });
                }
                else
                {
                    OnclickSubmit.Invoke(this, new List<object> { categaryNameTB.Text, limitTB.Text });

                }
            
     
            
        }
    }
}
