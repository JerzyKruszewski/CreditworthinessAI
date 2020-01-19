namespace CreditworthinessAI.Objects
{
    /// <summary>
    /// Class represent disctrict
    /// Expected: 77 objects in Database
    /// </summary>
    public class District
    {
#pragma warning disable IDE1006 // Naming convention
        /// <summary>
        /// district identifier
        /// </summary>
        public int district_id { get; set; }

        /// <summary>
        /// district name
        /// </summary>
        public string district_name { get; set; }

        /// <summary>
        /// region
        /// </summary>
        public string region { get; set; }

        /// <summary>
        /// no. of inhabitants
        /// </summary>
        public int no_of_inhabitants { get; set; }

        /// <summary>
        /// no. of municipalities with inhabitants less than 499
        /// </summary>
        public int no_of_municipalities_with_inhabitants_less_499 { get; set; }

        /// <summary>
        /// no. of municipalities with inhabitants 500-1999
        /// </summary>
        public int no_of_municipalities_with_inhabitants_500_to_1999 { get; set; }

        /// <summary>
        /// no. of municipalities with inhabitants 2000-9999
        /// </summary>
        public int no_of_municipalities_with_inhabitants_2000_to_9999 { get; set; }

        /// <summary>
        /// no. of municipalities with inhabitants >10000
        /// </summary>
        public int no_of_municipalities_with_inhabitants_more_10000 { get; set; }

        /// <summary>
        /// no. of cities
        /// </summary>
        public int no_of_cities { get; set; }

        /// <summary>
        /// ratio of urban inhabitants
        /// </summary>
        public double ratio_of_urban_inhabitants { get; set; }

        /// <summary>
        /// average salary
        /// </summary>
        public int average_salary { get; set; }

        /// <summary>
        /// unemploymant rate '95
        /// </summary>
        public double unemploymant_rate_95 { get; set; }

        /// <summary>
        /// unemploymant rate '96
        /// </summary>
        public double unemploymant_rate_96 { get; set; }

        /// <summary>
        /// no. of enterpreneurs per 1000 inhabitants
        /// </summary>
        public int no_of_enterpreneurs_per_1000_inhabitants { get; set; }

        /// <summary>
        /// no. of commited crimes '95
        /// </summary>
        public int no_of_commited_crimes_95 { get; set; }

        /// <summary>
        /// no. of commited crimes '96
        /// </summary>
        public int no_of_commited_crimes_96 { get; set; }
#pragma warning restore IDE1006 // Naming convention
    }
}
