using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Exceptions
{
    public class InvalidEmailException:Exception
    {
        public override string Message
        {
            get
            {
                return "Invalid email id. Sign in failed.";
            }
        }
    }
}
