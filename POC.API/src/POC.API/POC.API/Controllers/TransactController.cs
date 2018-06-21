namespace POC.API.Controllers
{

    using POC.Api.Services;
    using POC.Api.Services.Impl;
    using POC.Api.DTO.Request;
    using POC.Factory;
    using System.Configuration;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class TransactController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Deposite([FromBody]DepositeRequest data)
        {

            ITransaction ITran = FactoryApi<Transaction>.Create(ConfigurationManager.AppSettings["TranObj"]);
            ITran.TransferAmount(data, out string response);

            var message = Request.CreateResponse(HttpStatusCode.OK, new { response = response });
            return message;

        }
    }
}
