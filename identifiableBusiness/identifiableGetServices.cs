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
            identifiableInfo studentOperator = new identifiableInfo();
            return studentOperator.Getidentifiable();
        }
        public identifiableDatas Getidentifiableuser(string password)
        {
            identifiableDatas hpr = new identifiableDatas();

            foreach (var stud in Getidentifiableuser())
            {
                if (stud.password == password)
                {
                    hpr = stud;
                }
            }
            return hpr;
        }

        public identifiableDatas GetName(string firstname)
        {
            identifiableDatas hpr = new identifiableDatas();

            foreach (var stud in Getidentifiableuser())
            {
                if (stud.firstname == firstname)
                {
                    hpr = stud;
                }
            }
            return hpr;
        }
    }
}