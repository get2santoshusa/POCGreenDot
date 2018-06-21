namespace POC.DatabaseHelper
{
    using System;
    using System.Collections.Generic;

    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string AccountNumber { get; set; }

        public DateTime DOB { get; set; }

        public string Address { get; set; }

        public AccountBalance AccountBal { get; set; }

        public List<Transaction> Transaction { get; set; }
    }
}
