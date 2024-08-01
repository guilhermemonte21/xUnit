using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailTest
{
    public class Email
    {
        public static bool Validar(string Email)
        {
           if( (Email.Contains("@")) && (Email.Contains(".")) )
            {
                return true;
            }
            return false;
        }
    }
}
