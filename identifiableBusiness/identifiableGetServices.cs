using identifiableDl;
using identifiableModel;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace IdentifiableBusiness
{
    public class identifiableGetServices
    {
        public static object CreateUser(string firstname, string middlename, string lastname, string email, string contactnumber, string address, string password)
        {
            throw new NotImplementedException();
        }

        public List<identifiableDatas> Getidentifiableuser()
        {
            identifiableInfo userOperator = new identifiableInfo();
            return userOperator.Getidentifiable();
        }
        public identifiableDatas Getidentifiableuser(string password)
        {
            identifiableDatas hpr = new identifiableDatas();

            foreach (var user in Getidentifiableuser())
            {
                if (user.password == password)
                {
                    hpr = user;
                }
            }
            return hpr;
        }

        public identifiableDatas GetName(string firstname)
        {
            identifiableDatas hpr = new identifiableDatas();

            foreach (var user in Getidentifiableuser())
            {
                if (user.firstname == firstname)
                {
                    hpr = user;
                }
            }
            return hpr;
        }

    }
}
