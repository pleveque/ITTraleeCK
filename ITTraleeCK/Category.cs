using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    class Category
    {
        private int categoryID;
        private string categoryName;

        public int CategoryID
        {
            get
            {
                return categoryID;
            }
            set
            {
                categoryID = value;
            }
        }
        public string CategoryName
        {
            get
            {
                return categoryName;
            }
            set
            {
                categoryName = value;
            }
        }

        public string ToString()
        {
            return "Category ID : " + this.CategoryID + " Category Name : " + this.CategoryName;
        }

    }
}
