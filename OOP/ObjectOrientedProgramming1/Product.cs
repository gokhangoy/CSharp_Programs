using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming1
{
    class Product //Entity Class --> This class only should contain the properties. Not any operation.
    {
        public int productId { get; set; }
        public int productCategoryId { get; set; }
        public string productName { get; set; }
        public string productDescription{ get; set; }
        public double productUnitPrice{ get; set; }
        public int productStock{ get; set; }

        //if you won't do any mathematical operation with a property then you should declare that property as string. This way actually you could avoid th conflicts.. 
    }
}
