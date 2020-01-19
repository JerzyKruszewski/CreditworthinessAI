namespace CreditworthinessAI.Objects
{
    /// <summary>
    /// Class represent a loan
    /// Expected: 682 objects in Database
    /// </summary>
    public class Loan
    {
#pragma warning disable IDE1006 // Naming convention
        /// <summary>
        /// loan identifier
        /// </summary>
        public int loan_id { get; set; }

        /// <summary>
        /// identification of the account
        /// </summary>
        public int account_id { get; set; }

        /// <summary>
        /// date when the loan was granted
        /// </summary>
        /// <remarks>
        /// in the form YYMMDD
        /// </remarks>
        public string date { get; set; }

        /// <summary>
        /// amount of money
        /// </summary>
        public int amount { get; set; }

        /// <summary>
        /// duration of the loan
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// monthly payments
        /// </summary>
        public int payments { get; set; }

        /// <summary>
        /// status of paying off the loan
        /// </summary>
        /// <remarks>
        /// 'A' stands for contract finished, no problems,
        /// 'B' stands for contract finished, loan not payed,
        /// 'C' stands for running contract, OK so far,
        /// 'D' stands for running contract, client in debt
        /// </remarks>
        public string status { get; set; }
#pragma warning restore IDE1006 // Naming convention
    }
}
