using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_Dialer
{
    class HomePhone : Phone
    {
      
        public HomePhone(string CompName, string PhoneNumber, string PhoneType) : base(CompName, PhoneNumber, PhoneType)
        {
            
        }
        public override string Dial(string B)
        {
            B = "";
            base.Dial(B);
            return B;
        }
    }
}
