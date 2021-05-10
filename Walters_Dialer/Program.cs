using System;
//Mason Walters
//IT1112
//Notes:
//Behaviors Not Implemented and Why:
namespace Walters_Dialer
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            HomePhone HP1 = new HomePhone("CompuTest", "3039855060", "1");
            HomePhone HP2 = new HomePhone("DataFunctions", "8008762524", "1");
            HomePhone HP3 = new HomePhone("Donnay Repair", "7083973330", "1");
            HomePhone HP4 = new HomePhone("ErgoNomic Inc", "3604343894", "1");
            HomePhone HP5 = new HomePhone("ErgoSource", "8009694374", "1");
            CellPhone CP1 = new CellPhone("Curtis Manufactoring", "6035324123", "2");
            CellPhone CP2 = new CellPhone("Fox Bay Industries", "8008748527", "2");
            CellPhone CP3 = new CellPhone("Glare-Guard", "8005456254", "2");
            CellPhone CP4 = new CellPhone("Harzard Comm Specialists", "4077836641", "2");
            CellPhone CP5 = new CellPhone("Komfort Supports", "7144724409", "2");

            Phone[] PhoneArray = new Phone[10];
            PhoneArray[0] = HP1;
            PhoneArray[1] = HP2;
            PhoneArray[2] = HP3;
            PhoneArray[3] = HP4;
            PhoneArray[4] = HP5;
            PhoneArray[5] = CP1;
            PhoneArray[6] = CP2;
            PhoneArray[7] = CP3;
            PhoneArray[8] = CP4;
            PhoneArray[9] = CP5;
            string B = "";
            for (int i = 0; i < 10; i++)
            {
                
                PhoneArray[i].Dial(B);
            }
        }
        
    }
}
