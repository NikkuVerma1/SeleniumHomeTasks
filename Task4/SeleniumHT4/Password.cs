using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHT4
{
    public class Password
    {
        public object s
        {
            get { return s; }
            set { Console.ReadLine(); }
        }

        public bool PasswordValidation(object s)
        {
            if (s is string && ((string)s).Length >= 8 && ((string)s).Length <= 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
