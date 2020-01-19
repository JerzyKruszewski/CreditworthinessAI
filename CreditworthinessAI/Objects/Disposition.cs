namespace CreditworthinessAI.Objects
{
    /// <summary>
    /// Class represents the type of permission that client on account
    /// Expected: 5369 objects in Database
    /// </summary>
    public class Disposition
    {
#pragma warning disable IDE1006 // Naming convention
        /// <summary>
        /// Disposition identifier
        /// </summary>
        public int disp_id { get; set; }

        /// <summary>
        /// identification number of a client
        /// </summary>
        public int client_id { get; set; }

        /// <summary>
        /// identification number of an account
        /// </summary>
        public int account_id { get; set; }

        /// <summary>
        /// type of disposition (owner/user)
        /// </summary>
        /// <remarks>
        /// only owner can issue permanent orders and ask for a loan
        /// </remarks>
        public string type { get; set; }
#pragma warning restore IDE1006 // Naming convention
    }
}
