namespace CreditworthinessAI.Objects
{
    /// <summary>
    /// Class represents any necessary information about client to get his Creditworthiness
    /// </summary>
    public class AIAccount
    {
        public int Id { get; set; } //Maybe Account.Id

        public string FrequencyOfIssuanceOfStatements { get; set; } //from account

        public bool HasCreditCard { get; set; } //from creditcard

        public int NumberOfInhabitantsInDistrict { get; set; } //from district

        public int NumberOfCitiesInDistrict { get; set; } //from district

        public int AverageSalaryInDistrict { get; set; } //from district

        public int NumberOfPermanentOrders { get; set; } //from permanent orders

        public double DebitedAmount { get; set; } //from permanent orders

        public int NumberOfCreditTransactions { get; set; } //from transaction

        public int NumberOfWithdrawalTransactions { get; set; } //from transaction

        public double ActualAccountBalance { get; set; } //from transaction

        public int LoanAmount { get; set; } //from loan

        public int LoanDuration { get; set; } //from loan

        public int LoanMonthlyPayments { get; set; } //from loan

        public bool Creditworthiness { get; set; } //from loan A or C = true
    }
}
