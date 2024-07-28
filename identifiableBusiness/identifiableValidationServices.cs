using System.Text;
using System.Threading.Tasks;
using identifiableDl;
using identifiableModel;

namespace IdentifiableBusiness
{
    internal class identifiableValidationServices
    {
        identifiableGetServices aina = new identifiableGetServices();

        public bool IsLoggedIn(string password)
        {
            bool result = aina.Getidentifiableuser(password) != null;
            return result;
        }
        public bool IsloggedIn(string firstname)
        {
            bool result = aina.GetName(firstname) != null;
            return result;
        }
    }
}