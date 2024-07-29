using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using identifiableModel;
using IdentifiableBusiness;
using identifiableDl;
using System.Security.Principal;


namespace identifiableDatasAPI
{
    [ApiController]
    [Route("api/identifiable")]
    public class identityController : Controller
    {
        identifiableGetServices identifiablegetServices;
        identifiableTransactionsServices identifiableTransactionServices;

        public identityController()
        {
            identifiablegetServices = new identifiableGetServices();
            identifiableTransactionServices = new identifiableTransactionsServices();
        }


        [HttpGet]
        public IEnumerable<identifiableDatas> Getidentity()
        {
            var activeidentity = identifiablegetServices.Getidentifiableuser();

            List<identifiableDatas> identity = new List<identifiableDatas>(1);

            foreach (var item in activeidentity)
            {
                identity.Add(new identifiableDatas { firstname = item.firstname, middlename = item.middlename, email = item.email, contactnumber = item.contactnumber, address = item.address, password = item.password });
            }

            return identity;
        }

        [HttpPost]
        public JsonResult Addidentifiable(identifiableDatas identity)
        {
            var result = identifiableGetServices.CreateUser(identity.firstname, identity.middlename, identity.lastname, identity.email, identity.contactnumber, identity.address, identity.password);
            return new JsonResult(result);
        }

        [HttpPatch]
        public JsonResult UpdateUser(identifiableDatas identity)
        {
            var result = identifiableTransactionServices.Updateidentifiable(identity.firstname);
            return new JsonResult(result);
        }

        [HttpDelete]
        public JsonResult DeleteUser(identifiableDatas identity)
        {
            var deletepassword = new identifiableModel.identifiableDatas
            {
                password = identity.password
            };

            var result = identifiableTransactionServices.DeleteInfo(deletepassword);
            return new JsonResult(result);
        }
    }
}

