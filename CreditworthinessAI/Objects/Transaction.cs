namespace CreditworthinessAI.Objects
{
    /// <summary>
    /// Class represent a single transfer
    /// Expected: 1056320 objects in Database
    /// </summary>
    public class Transaction
    {
#pragma warning disable IDE1006 // Naming convention
        /// <summary>
        /// Transaction identifier
        /// </summary>
        public string trans_id { get; set; }

        /// <summary>
        /// account, the transation deals with
        /// </summary>
        public string account_id { get; set; }

        /// <summary>
        /// date of transaction
        /// </summary>
        /// <remarks>
        /// in the form YYMMDD
        /// </remarks>
        public string date { get; set; }

        /// <summary>
        /// credit or withdrawal
        /// </summary>
        /// <remarks>
        /// "PRIJEM" stands for credit
        /// "VYDAJ" stands for withdrawal
        /// </remarks>
        public string type { get; set; }

        /// <summary>
        /// mode of transaction
        /// </summary>
        /// <remarks>
        /// "VYBER KARTOU" credit card withdrawal
        /// "VKLAD" credit in cash
        /// "PREVOD Z UCTU" collection from another bank
        /// "VYBER" withdrawal in cash
        /// "PREVOD NA UCET" remittance to another bank
        /// </remarks>
        public string operation { get; set; }

        /// <summary>
        /// amount of money
        /// </summary>
        public string amount { get; set; }

        /// <summary>
        /// balance after transaction
        /// </summary>
        public string balance { get; set; }

        /// <summary>
        /// characterization of the transaction
        /// </summary>
        /// <remarks>
        /// "POJISTNE" stands for insurrance payment
        /// "SLUZBY" stands for payment for statement
        /// "UROK" stands for interest credited
        /// "SANKC. UROK" sanction interest if negative balance
        /// "SIPO" stands for household
        /// "DUCHOD" stands for old-age pension
        /// "UVER" stands for loan payment
        /// </remarks>
        public string k_symbol { get; set; }

        /// <summary>
        /// bank of the partner
        /// </summary>
        /// <remarks>
        /// each bank has unique two-letter code
        /// </remarks>
        public string bank { get; set; }

        /// <summary>
        /// account of the partner
        /// </summary>
        /// <remarks>
        /// MOST OF THEM NOT EXIST IN ACCOUNT DATABASE!!!
        /// </remarks>
        public string account { get; set; }
#pragma warning restore IDE1006 // Naming convention
    }
}
