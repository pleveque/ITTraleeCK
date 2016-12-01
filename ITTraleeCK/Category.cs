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
                return CategoryName;
            }
            set
            {
                categoryName = value;
            }
        }

        public string ToString()
        {
            return this.CategoryID + " " + this.CategoryName;
        }

    }
}
