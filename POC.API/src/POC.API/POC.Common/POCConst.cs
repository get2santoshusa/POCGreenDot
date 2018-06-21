namespace POC.Common
{
    public static class POCConst
    {

        public const string MESSAGE_NEGATIVE_BALANCE = "Source balance cannot go negative";

        public const string MESSAGE_PER_TRANSACTION = "Source cannot send more than $1000 per transaction.";

        public const string MESSAGE_TARGET_BALANCE_RESTRICTION = "Target account balance cannot exceed $5000";

        public const string MESSAGE_PER_DAY_TRANSACTION = "No more than 3 transfers per day can happen from a specific Source account to a specific Target account";

        public const string MESSAGE_SUCCESS = "Deposite Completed Successfully";

        public const int PER_DAY_TRANSACTION_LIMIT = 3;

        public const int PER_DAY_TRANSACTION_AMOUNT_LIMIT = 1000;

        public const int TARGET_ACCOUNT_BALANCE_LIMIT = 5000;


    }
}
