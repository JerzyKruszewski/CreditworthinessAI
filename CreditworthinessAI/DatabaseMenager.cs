using System;
using System.Collections.Generic;
using System.Linq;
using CreditworthinessAI.Interfaces;
using CreditworthinessAI.Objects;
using CreditworthinessAI.Storage;

namespace CreditworthinessAI
{
    /// <summary>
    /// Class responsible for databese operations
    /// </summary>
    public class DatabaseMenager
    {
        private static readonly IStorage _storage;
        private static readonly IList<Account> _accounts;
        private static readonly IList<Client> _clients;
        private static readonly IList<CreditCard> _cards;
        private static readonly IList<Disposition> _dispositions;
        private static readonly IList<District> _districts;
        private static readonly IList<Loan> _loans;
        private static readonly IList<PermanentOrder> _orders;
        private static readonly IList<Transaction> _transactions;
        private static readonly IList<AIAccount> _aiAccounts;

        static DatabaseMenager()
        {
            _storage = new JsonStorage();
            _accounts = _storage.RestoreObject<List<Account>>("Resources/accounts");
            _clients = _storage.RestoreObject<List<Client>>("Resources/clients");
            _cards = _storage.RestoreObject<List<CreditCard>>("Resources/cards");
            _dispositions = _storage.RestoreObject<List<Disposition>>("Resources/dispositions");
            _districts = _storage.RestoreObject<List<District>>("Resources/districts");
            _loans = _storage.RestoreObject<List<Loan>>("Resources/loans");
            _orders = _storage.RestoreObject<List<PermanentOrder>>("Resources/orders");
            _transactions = _storage.RestoreObject<List<Transaction>>("Resources/trans");
            _aiAccounts = new List<AIAccount>();
        }

        /// <summary>
        /// Creates AIAccounts Database
        /// </summary>
        public static void CreateDatabase()
        {
            if (CheckDataBase())
            {
                int i = 0;

                foreach (Loan loan in _loans)
                {
                    Account account = GetAccounts(loan.account_id).FirstOrDefault();
                    CreditCard creditCard = GetCreditCards(loan.account_id).FirstOrDefault();
                    District district = GetDistricts(loan.account_id).FirstOrDefault();

                    List<PermanentOrder> orders = GetAccountPermanentOrders(loan.account_id);
                    List<Transaction> transactions = GetAccountTransactions(loan.account_id);

                    AIAccount aiAccount = new AIAccount()
                    {
                        Id = loan.loan_id,

                        FrequencyOfIssuanceOfStatements = GetFrequencyFromAccount(account.account_id),

                        HasCreditCard = IsCreditCardOwner(creditCard),

                        NumberOfInhabitantsInDistrict = district.no_of_inhabitants,
                        NumberOfCitiesInDistrict = district.no_of_cities,
                        AverageSalaryInDistrict = district.average_salary,

                        NumberOfPermanentOrders = orders.Count,
                        DebitedAmount = CalculateDebt(orders),

                        NumberOfCreditTransactions = GetCreditTransactions(transactions),
                        NumberOfWithdrawalTransactions = GetWithdrawalTransactions(transactions),
                        ActualAccountBalance = GetBalance(transactions),

                        LoanAmount = loan.amount,
                        LoanDuration = loan.duration,
                        LoanMonthlyPayments = loan.payments,
                        Creditworthiness = HasCreditworthiness(loan)
                    };

                    _aiAccounts.Add(aiAccount);
                    i++;
                    Console.WriteLine(i + "/682");

                    StoreDatabase();
                }
            }
        }
        
        private static void StoreDatabase()
        {
            CsvStorage.StoreObject(_aiAccounts, "Resources/AiDatabase");
        }

        private static bool CheckDataBase()
        {
            if (_accounts.Count == 4500 && _clients.Count == 5369 && _cards.Count == 892 && _dispositions.Count == 5369
                && _districts.Count == 77 && _loans.Count == 682 && _orders.Count == 6471 && _transactions.Count == 1056320)
            {
                return true;
            }

            return false;
        }

        private static string GetFrequencyFromAccount(int id)
        {
            string freqNotEng = _accounts.FirstOrDefault(x => x.account_id == id).frequency.ToUpper();

            switch (freqNotEng)
            {
                case "POPLATEK MESICNE":
                    return "monthly";
                case "POPLATEK TYDNE":
                    return "weekly";
                case "POPLATEK PO OBRATU":
                    return "after transaction";
                default:
                    return "";
            }
        }

        private static bool IsCreditCardOwner(CreditCard creditCard)
        {
            if (creditCard == null)
            {
                return false;
            }

            return true;
        }

        private static double CalculateDebt(List<PermanentOrder> orders)
        {
            double sum = 0.0;

            foreach (var item in orders)
            {
                sum += item.amount;
            }

            return sum;
        }

        private static int GetCreditTransactions(List<Transaction> transactions)
        {
            return transactions.Where(x => x.type.ToUpper() == "PRIJEM").ToList().Count;
        }

        private static int GetWithdrawalTransactions(List<Transaction> transactions)
        {
            return transactions.Where(x => x.type.ToUpper() == "VYDAJ").ToList().Count;
        }

        private static double GetBalance(List<Transaction> transactions)
        {
            return Double.Parse(transactions.LastOrDefault().balance);
        }

        private static bool HasCreditworthiness(Loan loan)
        {
            if (loan.status == "A" || loan.status == "C")
            {
                return true;
            }

            return false;
        }

        private static List<Account> GetAccounts(int accountId)
        {
            var result = from l in _loans
                         join a in _accounts
                         on accountId equals a.account_id
                         select a;

            return result.Distinct().ToList();
        }

        private static List<CreditCard> GetCreditCards(int holderAccountId)
        {
            var result = from a in _accounts
                         join d in _dispositions
                         on holderAccountId equals d.account_id
                         join c in _cards
                         on d.disp_id equals c.disp_id
                         select c;

            return result.Distinct().ToList();
        }

        private static List<District> GetDistricts(int accountId)
        {
            var result = from a in _accounts
                         where a.account_id == accountId
                         join d in _districts
                         on a.district_id equals d.district_id
                         select d;

            return result.Distinct().ToList();
        }

        private static List<PermanentOrder> GetAccountPermanentOrders(int accountId)
        {
            var result = from a in _accounts
                         join o in _orders
                         on accountId equals o.account_id
                         select o;

            return result.Distinct().ToList();
        }

        private static List<Transaction> GetAccountTransactions(int accountId)
        {
            var result = from a in _accounts
                         join t in _transactions
                         on accountId equals Int32.Parse(t.account_id)
                         select t;

            return result.Distinct().ToList();
        }
    }
}
