namespace POC.DatabaseHelper
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using POC.Common;

    public static class CustomerHelper
    {
        public static List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                FirstName = "Test1FN",
                MiddleName = "Test1MN",
                LastName = "Test1LN",
                AccountNumber = "AC001",
                AccountBal = new AccountBalance { AccountNumber = "AC001" , Balance = 0 },
                Transaction = new List<Transaction>
                {
                    new Transaction{ AccountNumber = "AC001", TransactionAmount = 200m },
                    new Transaction{ AccountNumber = "AC001", TransactionAmount = 100m },
                    new Transaction{ AccountNumber = "AC001", TransactionAmount = 500m }

                }
            },

            new Customer
            {
                FirstName = "Test2FN",
                MiddleName = "Test2MN",
                LastName = "Test2LN",
                AccountNumber = "AC002",
                AccountBal = new AccountBalance { AccountNumber = "AC002" , Balance = 2000.69m },
                Transaction = new List<Transaction>
                {

                    new Transaction{ AccountNumber = "AC002", TransactionAmount = 200m, TransactionDate = System.DateTime.Now.Date },
                    new Transaction{ AccountNumber = "AC002", TransactionAmount = 100m, TransactionDate = System.DateTime.Now.Date }

                }
            },

            new Customer
            {
                FirstName = "Test3FN",
                MiddleName = "Test3MN",
                LastName = "Test3LN",
                AccountNumber = "AC003",
                AccountBal = new AccountBalance { AccountNumber = "AC003" , Balance = 4800},
                Transaction = new List<Transaction>
                {

                    new Transaction{ AccountNumber = "AC003", TransactionAmount = 200m, TransactionDate = System.DateTime.Now.Date },
                    new Transaction{ AccountNumber = "AC003", TransactionAmount = 100m, TransactionDate = System.DateTime.Now.Date },
                    new Transaction{ AccountNumber = "AC003", TransactionAmount = 500m, TransactionDate = System.DateTime.Now.Date }

                }
            }

        };

        public static decimal GetBalance(string AccountNo)
        {

            var result = Customers.Where(r => r.AccountBal.Balance > 0 && r.AccountNumber == AccountNo)
                 .SingleOrDefault();

            return result == null ? 0 : result.AccountBal.Balance;
        }

        public static int GetTranPerDay(string AccountNo, DateTime dateofTran)
        {

            var count = Customers.Where(r => r.AccountNumber == AccountNo && r.Transaction.Count(d => d.TransactionDate == dateofTran) == POCConst.PER_DAY_TRANSACTION_LIMIT)
                        .SingleOrDefault();

            return count == null ? 0 : count.Transaction.Count;

        }

        public static decimal GetTargetBalance(string AccountNo, decimal depositAmt)
        {

            var result = Customers.Where(r => r.AccountBal.Balance > 0 && r.AccountNumber == AccountNo)
                 .SingleOrDefault();

            return result == null ? 0 : result.AccountBal.Balance;
        }

    }
}
