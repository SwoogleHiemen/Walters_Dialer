using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_Dialer
{
    class CellPhone : Phone
    {
       
        public CellPhone(string CompName, string PhoneNumber, string PhoneType) : base(CompName, PhoneNumber, PhoneType)
        {
        }
        public override string Dial(string B) 
        {
            B = "1+";
            base.Dial(B);
            return B;
        }
    }
}
