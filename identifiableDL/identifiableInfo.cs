using System.Data;
using identifiableModel;

namespace identifiableDl
{
    public class identifiableInfo
    {
        List<identifiableDatas> identity;
        SqlDBData sqlData;

        public identifiableInfo()
        {
            identity = new List<identifiableDatas>();
            sqlData = new SqlDBData();
        }

        public List<identifiableDatas> Getidentifiable()
        {
            identity = sqlData.Getidentifiable();
            return identity;
        }

        public int Addidentifiable(identifiableDatas identity)
        {
            return sqlData.Addidentifiable(identity.firstname, identity.middlename, identity.lastname, identity.email, identity.contactnumber, identity.address, identity.password);
        }
        public int Updateidentifiable(identifiableDatas identity)
        {
            return sqlData.Updateidentifiable(identity.firstname, identity.middlename, identity.lastname, identity.email, identity.contactnumber, identity.address, identity.password);
        }
        public int Deleteidentifiable(identifiableDatas identity)
        {
            return sqlData.Deleteidentifiable(identity.password);
        }

    }
}