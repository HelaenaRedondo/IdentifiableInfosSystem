using identifiableDl;
using identifiableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IdentifiableBusiness
{
    public class identifiableTransactionsServices
    {
        identifiableValidationServices sc = new identifiableValidationServices();
        identifiableInfo hp = new identifiableInfo();

        public bool Createidentifiable(string firstname, string middlename, string lastname, string email, string contactnumber, string address, string password)
        {
            bool result = false;

            if (sc.IsloggedIn(identity.password))
            {
                result = hp.Addidentifiable(identity) > 0;
            }
            return result;
        }
        public bool Createidentifiable(string firstname, string middlename, string lastname, string email, string contactnumber, string address, string password)
        {
            identifiableDatas hp = new identifiableDatas { firstname = firstname, middlename = middlename, lastname = lastname, email = email, contactnumber = contactnumber, address = address, password = password };

            return Createidentifiable(hp);
        }



        public bool Updateidentifiable(string firstname, identifiableDatas identity)
        {

            bool result = false;

            if (sc.IsloggedIn(identity.password))
            {
                result = hp.Updateidentifiable(identity) > 0;
            }
            return result;
        }
        public bool Updateidentifiable(string firstname, string middlename, string lastname, string email, string contactnumber, string address, string password)
        {
            identifiableDatas hp = new identifiableDatas { firstname = firstname, middlename = middlename, lastname = lastname, email = email, contactnumber = contactnumber, address = address, password = password };

            return Updateidentifiable(hp);
        }



        public bool DeleteInfo(identifiableDatas identity)
        {
            bool st = false;

            if (sc.IsloggedIn(identity.password))
            {
                st = hp.Deleteidentifiable(identity) > 0;
            }
            return st;
        }
    }
}
