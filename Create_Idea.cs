using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Investment_ideas_platform
{
     class Create_Idea
    {
        public static bool create_new_idea (string idea_name, string abstract_des, string date_expires, string idea_content, string risk_rating)
        {
            if (idea_name != "" && abstract_des != "" && date_expires != "" && idea_content != "" && idea_content != "" && risk_rating != "")
            {
                DBConnection.getInstanceOfDBConnection().add_idea_to_DB(Constants.ADD_NEW_IDEA, idea_name, abstract_des, date_expires, idea_content, risk_rating);
                return true;
            }
            else 
            {
                MessageBox.Show("Failed to insert data into the Database");
                return false;
            }
            return false;
        }
    }
}
