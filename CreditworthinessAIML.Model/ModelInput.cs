// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace CreditworthinessAIML.Model
{
    public class ModelInput
    {
        [ColumnName("Id"), LoadColumn(0)]
        public float Id { get; set; }


        [ColumnName("FrequencyOfIssuanceOfStatements"), LoadColumn(1)]
        public string FrequencyOfIssuanceOfStatements { get; set; }


        [ColumnName("HasCreditCard"), LoadColumn(2)]
        public bool HasCreditCard { get; set; }


        [ColumnName("NumberOfInhabitantsInDistrict"), LoadColumn(3)]
        public float NumberOfInhabitantsInDistrict { get; set; }


        [ColumnName("NumberOfCitiesInDistrict"), LoadColumn(4)]
        public float NumberOfCitiesInDistrict { get; set; }


        [ColumnName("AverageSalaryInDistrict"), LoadColumn(5)]
        public float AverageSalaryInDistrict { get; set; }


        [ColumnName("NumberOfPermanentOrders"), LoadColumn(6)]
        public float NumberOfPermanentOrders { get; set; }


        [ColumnName("DebitedAmount"), LoadColumn(7)]
        public string DebitedAmount { get; set; }


        [ColumnName("NumberOfCreditTransactions"), LoadColumn(8)]
        public float NumberOfCreditTransactions { get; set; }


        [ColumnName("NumberOfWithdrawalTransactions"), LoadColumn(9)]
        public float NumberOfWithdrawalTransactions { get; set; }


        [ColumnName("ActualAccountBalance"), LoadColumn(10)]
        public string ActualAccountBalance { get; set; }


        [ColumnName("LoanAmount"), LoadColumn(11)]
        public float LoanAmount { get; set; }


        [ColumnName("LoanDuration"), LoadColumn(12)]
        public float LoanDuration { get; set; }


        [ColumnName("LoanMonthlyPayments"), LoadColumn(13)]
        public float LoanMonthlyPayments { get; set; }


        [ColumnName("Creditworthiness"), LoadColumn(14)]
        public bool Creditworthiness { get; set; }


    }
}