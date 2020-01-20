using System;
using System.Collections.Generic;
using System.Text;
using CreditworthinessAIML.Model;
using CreditworthinessAI.Objects;

namespace CreditworthinessAI
{
    public class ModelTester
    {
        public static void TestModel(List<AIAccount> accounts)
        {
            int i = 0;
            int truth = 0;
            int falsePositive = 0;
            int falseNegative = 0;

            foreach (AIAccount account in accounts)
            {
                // Add input data
                var input = new ModelInput()
                {
                    Id = account.Id,
                    FrequencyOfIssuanceOfStatements = account.FrequencyOfIssuanceOfStatements,

                    HasCreditCard = account.HasCreditCard,

                    NumberOfInhabitantsInDistrict = account.NumberOfInhabitantsInDistrict,
                    NumberOfCitiesInDistrict = account.NumberOfCitiesInDistrict,
                    AverageSalaryInDistrict = account.AverageSalaryInDistrict,

                    NumberOfPermanentOrders = account.NumberOfPermanentOrders,
                    DebitedAmount = account.DebitedAmount.ToString(),

                    NumberOfCreditTransactions = account.NumberOfCreditTransactions,
                    NumberOfWithdrawalTransactions = account.NumberOfWithdrawalTransactions,
                    ActualAccountBalance = account.ActualAccountBalance.ToString(),

                    LoanAmount = account.LoanAmount,
                    LoanDuration = account.LoanDuration,
                    LoanMonthlyPayments = account.LoanMonthlyPayments
                };

                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine($"{result.Prediction} ({result.Score})");

                if (result.Prediction == account.Creditworthiness)
                {
                    truth++;
                }
                else if (result.Prediction && !account.Creditworthiness)
                {
                    falsePositive++;
                }
                else if (!result.Prediction && account.Creditworthiness)
                {
                    falseNegative++;
                }

                i++;
            }

            Console.WriteLine($"\n\nPredicted: {i} accounts.\nTrue Predictions: {truth}\nAccuracy: {(double)truth / i}\nFalse Positive: {falsePositive}\nFalse Negative: {falseNegative}");
        }
    }
}
