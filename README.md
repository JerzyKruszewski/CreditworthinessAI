# CreditworthinessAI
A binary classification AI in ML.NET using Model Builder

## Project Purpose
The project aims to create an AI that would predicts creditworthiness based on PKDD'99 Discovery Challenge Financial Data Set.

## Project Stages
1. Converting PKDD'99 Discovery Challenge Financial Data Set from .sas7bdat files to .csv
1. Converting from .csv files to .json
1. Creating necessery objects inside a Visual Studio
1. Fetching objects from .json files using [Newtonsoft.Json](https://www.newtonsoft.com/json)
1. Manipulating data using mostly [System.LINQ](https://docs.microsoft.com/pl-pl/dotnet/api/system.linq?view=netcore-3.0)
1. Creating AIAccount object (object with every information needed for making prediction)
1. Preparing training and test dataset
   * Creating .csv file with entire training and test data (682 rows) using [CsvHelper](https://joshclose.github.io/CsvHelper/)
   * Spliting it into two datasets: training (478 rows ~70%) and test (204 rows ~30%)
   * Saving them in .csv files
1. Running ML.NET Model Builder on training dataset.
1. Makeing a simple testing algotithm on test dataset.

## Model Builder Report
```
|     Trainer                              Accuracy      AUC    AUPRC  F1-score  Duration #Iteration             |
|1    AveragedPerceptronBinary               0,8462   0,6042   0,9482    0,9167       0,5          1             |
|2    SdcaLogisticRegressionBinary           0,8654   0,5469   0,9442    0,9278       1,4          2             |
|3    LightGbmBinary                         0,8548   0,7766   0,9675    0,9217       1,2          3             |
|4    SymbolicSgdLogisticRegressionBinary    0,8571   0,9259   0,9869    0,9231       0,6          4             |
|5    LinearSvmBinary                        0,7419   0,5948   0,9291    0,8431       0,4          5             |
|6    FastTreeBinary                         0,8537   0,8194   0,9313    0,9118       1,6          6             |
|7    LbfgsLogisticRegressionBinary          0,8571   0,7963   0,9596    0,9231       0,5          7             |
|8    FastForestBinary                       0,8571   0,7685   0,9565    0,9231       1,2          8             |
|9    SgdCalibratedBinary                    0,8571   0,8704   0,9771    0,9231       0,4          9             |
|10   SdcaLogisticRegressionBinary           0,8571   0,8426   0,9714    0,9231       0,5         10             |
|11   LbfgsLogisticRegressionBinary          0,2195   0,5000   0,7007       NaN       0,5         11             |
|12   SgdCalibratedBinary                    0,8571   0,8843   0,9792    0,9231       0,5         12             |

===============================================Experiment Results=================================================
------------------------------------------------------------------------------------------------------------------
|                                                     Summary                                                    |
------------------------------------------------------------------------------------------------------------------
|ML Task: binary-classification                                                                                  |
|Dataset: [CENSORED]\CreditworthinessAI\bin\Debug\netcoreapp3.0\Resources\TrainData.csv|
|Label : Creditworthiness                                                                                        |
|Total experiment time : 9,3 Secs                                                                                |
|Total number of models explored: 12                                                                             |
------------------------------------------------------------------------------------------------------------------

|                                              Top 5 models explored                                             |
------------------------------------------------------------------------------------------------------------------
|     Trainer                              Accuracy      AUC    AUPRC  F1-score  Duration #Iteration             |
|1    SdcaLogisticRegressionBinary           0,8654   0,5469   0,9442    0,9278       1,4          1             |
|2    SymbolicSgdLogisticRegressionBinary    0,8571   0,9259   0,9869    0,9231       0,6          2             |
|3    LbfgsLogisticRegressionBinary          0,8571   0,7963   0,9596    0,9231       0,5          3             |
|4    FastForestBinary                       0,8571   0,7685   0,9565    0,9231       1,2          4             |
|5    SgdCalibratedBinary                    0,8571   0,8704   0,9771    0,9231       0,4          5             |
------------------------------------------------------------------------------------------------------------------

Code Generated

```

## Testset Results
```
Predicted: 204 accounts.
Accurate Predictions: 190
Accuracy: 0,9313725490196079
False Positive: 11
False Negative: 3
```
