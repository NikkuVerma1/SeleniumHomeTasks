using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class InvalidAgeException:Exception
    {
        public override string Message
        {
            get
            {
                return "Age is less than 18 --> Invalid age!!";
            }
        }
    
    }
}
