namespace POC.Api.DTO.Request
{
    public class DepositeRequest 
    {
        public string FromAccount { get; set ; }

        public string ToAccountNo { get ; set ; }

        public decimal Amount { get ; set ; }
    }
}
