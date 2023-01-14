using System;
using System.Collections.Generic;
using System.Text;

namespace Investment_ideas_platform
{
    class createNewProduct
    {
        public static bool create_new_product(string product_name, string product_type, string company_name, string product_description)
        {
            DBConnection.getInstanceOfDBConnection().add_product_to_DB(Constants.ADD_NEW_PRODUCT, product_name, product_type, company_name, product_description);
            return true;
        }
    }
}