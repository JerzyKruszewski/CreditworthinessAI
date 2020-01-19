namespace CreditworthinessAI.Objects
{
    /// <summary>
    /// Class represent permanent order of transfer
    /// Expected: 6471 objects in Database
    /// </summary>
    public class PermanentOrder
    {
#pragma warning disable IDE1006 // Naming convention
        /// <summary>
        /// order identifier
        /// </summary>
        public int order_id { get; set; }

        /// <summary>
        /// account, the order is issued for
        /// </summary>
        public int account_id { get; set; }

        /// <summary>
        /// bank of the recipient
        /// </summary>
        /// <remarks>
        /// each bank has unique two-letter code
        /// </remarks>
        public string bank_to { get; set; }

        /// <summary>
        /// account of the recipient
        /// </summary>
        /// <remarks>
        /// MOST OF THEM NOT EXIST IN ACCOUNT DATABASE!!!
        /// </remarks>
        public int account_to { get; set; }

        /// <summary>
        /// debited amount
        /// </summary>
        public double amount { get; set; }

        /// <summary>
        /// characterization of the payment
        /// </summary>
        /// <remarks>
        /// "POJISTNE" stands for insurrance payment
        /// "SIPO" stands for household payment
        /// "LEASING" stands for leasing
        /// "UVER" stands for loan payment
        /// </remarks>
        public string k_symbol { get; set; }
#pragma warning restore IDE1006 // Naming convention
    }
}
