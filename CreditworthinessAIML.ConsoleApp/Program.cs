// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.IO;
using System.Linq;
using Microsoft.ML;
using CreditworthinessAIML.Model;

namespace CreditworthinessAIML.ConsoleApp
{
    internal class Program
    {
        //Dataset to use for predictions 
        private const string DATA_FILEPATH = @"../../../../CreditworthinessAI/bin/Debug/netcoreapp3.0/Resources/TrainData.csv";

        private static void Main()
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = CreateSingleDataSample(DATA_FILEPATH);

            // Make a single prediction on the sample data and print results
            ModelOutput predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Creditworthiness with predicted Creditworthiness from sample data...\n\n");
            Console.WriteLine($"Id: {sampleData.Id}");
            Console.WriteLine($"FrequencyOfIssuanceOfStatements: {sampleData.FrequencyOfIssuanceOfStatements}");
            Console.WriteLine($"HasCreditCard: {sampleData.HasCreditCard}");
            Console.WriteLine($"NumberOfInhabitantsInDistrict: {sampleData.NumberOfInhabitantsInDistrict}");
            Console.WriteLine($"NumberOfCitiesInDistrict: {sampleData.NumberOfCitiesInDistrict}");
            Console.WriteLine($"AverageSalaryInDistrict: {sampleData.AverageSalaryInDistrict}");
            Console.WriteLine($"NumberOfPermanentOrders: {sampleData.NumberOfPermanentOrders}");
            Console.WriteLine($"DebitedAmount: {sampleData.DebitedAmount}");
            Console.WriteLine($"NumberOfCreditTransactions: {sampleData.NumberOfCreditTransactions}");
            Console.WriteLine($"NumberOfWithdrawalTransactions: {sampleData.NumberOfWithdrawalTransactions}");
            Console.WriteLine($"ActualAccountBalance: {sampleData.ActualAccountBalance}");
            Console.WriteLine($"LoanAmount: {sampleData.LoanAmount}");
            Console.WriteLine($"LoanDuration: {sampleData.LoanDuration}");
            Console.WriteLine($"LoanMonthlyPayments: {sampleData.LoanMonthlyPayments}");
            Console.WriteLine($"\n\nActual Creditworthiness: {sampleData.Creditworthiness} \nPredicted Creditworthiness: {predictionResult.Prediction}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }

        // Change this code to create your own sample data
        #region CreateSingleDataSample
        // Method to load single row of dataset to try a single prediction
        private static ModelInput CreateSingleDataSample(string dataFilePath)
        {
            // Create MLContext
            MLContext mlContext = new MLContext();

            // Load dataset
            IDataView dataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                                            path: dataFilePath,
                                            hasHeader: true,
                                            separatorChar: ';',
                                            allowQuoting: true,
                                            allowSparse: false);

            // Use first line of dataset as model input
            // You can replace this with new test data (hardcoded or from end-user application)
            ModelInput sampleForPrediction = mlContext.Data.CreateEnumerable<ModelInput>(dataView, false).Skip(new Random().Next(0, 477)).First();
            return sampleForPrediction;
        }
        #endregion
    }
}
