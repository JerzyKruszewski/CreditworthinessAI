namespace CreditworthinessAI.Objects
{
    /// <summary>
    /// Class represents a client of a bank
    /// Expected: 5369 objects in Database
    /// </summary>
    public class Client
    {
#pragma warning disable IDE1006 // Naming convention
        /// <summary>
        /// client identifier
        /// </summary>
        public int client_id { get; set; }

        /// <summary>
        /// birthday and sex
        /// </summary>
        /// <remarks>
        /// the number is in the form YYMMDD for men,
        /// the number is in the form YYMM+50DD for women,
        /// where YYMMDD is the date of birth
        /// </remarks>
        public string birth_number { get; set; }

        /// <summary>
        /// address of the client
        /// </summary>
        public int district_id { get; set; }
#pragma warning restore IDE1006 // Naming convention
    }
}
