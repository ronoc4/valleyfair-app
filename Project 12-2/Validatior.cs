using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_2
{
    // tried to do a static class but cannot
   public static class Validatior
   // public class Validation 
    {
        #region Validation

       private static String title = "Entry Error";
       public static int number = 0;

       public static DateTimePicker dtp;
       public static DateTime dt1;
       public static DataFormats d2; 



       public static string Title
       {
           get
           {
               return title;
           }
           set
           {
               title = value;
           }
       }
  
       
        public static bool IsInt(TextBox textbox)
        {
            //int number = 0;
            if (int.TryParse(textbox.Text, out number) == true)
            {
                return true; 
            }
            else
            {
                MessageBox.Show(textbox.Name.ToString() + " must be a number.", Title);
                textbox.Focus();
                return false;
            }
        }

        // checks textboxes to see if they have text present 
        public static bool IsPresent(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(textbox.Name.ToString() + " is a required field.", Title);
                textbox.Focus();
                return false;
            }
            return true;
        }

        // checks to see if a valid time is picked. 
        public static bool IsTime(DateTimePicker dtpickr)
        {
            DateTime dtvalue = DateTime.Now;
            if (DateTime.TryParse(dtpickr.Value.ToShortDateString(), out dtvalue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // todo test this and double check logic 
        public static bool TimeIsOK(DateTime time1 , DateTime time2) 
        {
            if (time2 < time1)
            {
                MessageBox.Show("End time cannot be before the start time", "Time Entry Error");
                return false;
            }
            else if (time1 < DateTime.Now)
            {
                MessageBox.Show("Start time cannot be in the past");
                return false;
            }
            return true;
        }
        #endregion
    }
}
