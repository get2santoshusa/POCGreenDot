namespace POC.Api.Services.Impl
{
    using POC.Api.DTO.Request;
    using POC.Common;
    using POC.validation;

    public class Transaction : ITransaction
    {
        public void TransferAmount(DepositeRequest deposit, out string response)
        {

            response = POCConst.MESSAGE_SUCCESS;

            if (!Validations.CheckBalanceSource(deposit.FromAccount))
            {
                response = POCConst.MESSAGE_NEGATIVE_BALANCE;
                return;
            }

            if (!Validations.CheckTransaction(deposit.Amount))
            {
                response = POCConst.MESSAGE_PER_TRANSACTION;
                return;
            }


            if (!Validations.CheckTranPerDay(deposit.ToAccountNo, System.DateTime.Now.Date))
            {
                response = POCConst.MESSAGE_PER_DAY_TRANSACTION;
                return;
            };


           
        }
    }
}
