using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walters_Dialer
{
    class Phone
    {
        
        string _CompName;
        string _PhoneNumber;
        string _PhoneType;
        public Phone(string CompName, string PhoneNumber, string PhoneType)
        {
            _CompName = CompName;
            _PhoneNumber = PhoneNumber;
            _PhoneType = PhoneType;
        }
        
        virtual public string Dial(string B)
        {
            
             Console.WriteLine(_CompName + " is being dialed using " + B + string.Format("{0:(###) ###-####}", decimal.Parse(_PhoneNumber)) + "...");
            return B;
        }


    }
}
