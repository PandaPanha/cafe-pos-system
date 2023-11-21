using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_pos_system.services
{
    public static class PhoneService
    {
        public static string ConvertPhoneToPhoneNoWhiteSpace(string phoneNo)
        {
            phoneNo = phoneNo.Replace(" ", string.Empty);
            //first ensure there is no whitespace between each character
            string phoneNo_whiteSpace = string.Empty;

            int countChar = 0;
            //insert whitespace into the string after 3 character ex: 012 345 678
            foreach (char c in phoneNo)
            {
                if (countChar == 3)
                {
                    phoneNo_whiteSpace += ' ';
                    phoneNo_whiteSpace += c;
                    countChar = 0;
                }
                else
                {
                    phoneNo_whiteSpace += c;
                }
                countChar++;
            }

            return phoneNo_whiteSpace;
        }
    }
}
