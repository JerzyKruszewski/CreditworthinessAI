namespace CreditworthinessAI.Objects
{
    /// <summary>
    /// Class represents a bank account
    /// Expected: 4500 objects in Database
    /// </summary>
    public class Account
    {
#pragma warning disable IDE1006 // Naming convention
        /// <summary>
        /// identification number of the account
        /// </summary>
        public int account_id { get; set; }

        /// <summary>
        /// location of the branch
        /// </summary>
        public int district_id { get; set; }

        /// <summary>
        /// date of creating of the account
        /// </summary>
        /// <remarks>
        /// in the form YYMMDD
        /// </remarks>
        public string date { get; set; }

        /// <summary>
        /// frequency of issuance of statements
        /// </summary>
        /// <remarks>
        /// Possible values:
        ///     "POPLATEK MESICNE" stands for monthly issuance
        ///     "POPLATEK TYDNE" stands for weekly issuance
        ///     "POPLATEK PO OBRATU" stands for issuance after transaction
        /// </remarks>
        public string frequency { get; set; }
#pragma warning restore IDE1006 // Naming convention
    }
}
