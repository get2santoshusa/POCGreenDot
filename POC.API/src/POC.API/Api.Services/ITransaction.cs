
namespace POC.Api.Services
{
    using POC.Api.DTO.Request;

    public interface ITransaction
    {

        void TransferAmount(DepositeRequest deposit, out string response);

    }
}
