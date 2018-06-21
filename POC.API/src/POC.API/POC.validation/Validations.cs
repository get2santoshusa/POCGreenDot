namespace POC.validation
{
    using System;
    using POC.Common;
    using POC.DatabaseHelper;

    public static class Validations
    {
        public static bool CheckBalanceSource(string sourceAccountNo)
        {

            if (CheckBalance(sourceAccountNo) <= 0)
            {
                return false;
            }

            return true;
        }

        public static bool CheckTransaction(decimal tranferAmount)
        {

            if (tranferAmount > POCConst.PER_DAY_TRANSACTION_AMOUNT_LIMIT)
            {
                return false;
            }

            return true;
        }

        public static bool CheckTargetAccBal(string targetAccountNo, decimal depositAmt )
        {
            
            if (CheckBalance(targetAccountNo) + depositAmt > POCConst.TARGET_ACCOUNT_BALANCE_LIMIT)
            {
                return false;
            }

            return true;
        }

        public static bool CheckTranPerDay(string AccountNo, DateTime dateofTran)
        {

            if (CheckSameDayTransaction(AccountNo, dateofTran) >= 3)
            {
                return false;
            }

            return true;

        }

        private static int CheckSameDayTransaction(string accountNo, DateTime dateofTran)
        {
            return CustomerHelper.GetTranPerDay(accountNo, dateofTran);
        }

        private static decimal CheckBalance(string sourceAccountNo)
        {
            return CustomerHelper.GetBalance(sourceAccountNo);
        }


    }
}
