namespace CreditworthinessAI.Objects
{
    /// <summary>
    /// Class represent permanent credit card
    /// Expected: 892 objects in Database
    /// </summary>
    public class CreditCard
    {
#pragma warning disable IDE1006 // Naming convention
        /// <summary>
        /// card identifier
        /// </summary>
        public int card_id { get; set; }

        /// <summary>
        /// disposition to an account
        /// </summary>
        public int disp_id { get; set; }

        /// <summary>
        /// type of card
        /// </summary>
        /// <remarks>
        /// possible values are "junior", "classic", "gold"
        /// </remarks>
        public string type { get; set; }

        /// <summary>
        /// issue date
        /// </summary>
        /// <remarks>
        /// in the form YYMMDD
        /// </remarks>
        public string issued { get; set; }
#pragma warning restore IDE1006 // Naming convention
    }
}
