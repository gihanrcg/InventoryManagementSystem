using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public static class Validations
    {
        public static Boolean isValidEmail(String email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        }

        public static Boolean isLengthValid(String text, int lenth)
        {
            return text.Length >= lenth;

        }

        public static Boolean isValidMobile(String mobileNo)
        {
            if (mobileNo.Length == 10)
            {
                return true;
            }
            else if (mobileNo.Length == 9 && (!mobileNo.StartsWith("0")))
            {
                return true;
            }
            else if (mobileNo.Length == 12 && mobileNo.StartsWith("+")) 
            {
                return true;
            }
            else{
                return false;
            }
        }



    }
}
