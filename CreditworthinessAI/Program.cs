using System;
using System.Collections.Generic;
using System.Linq;
using CreditworthinessAI.Interfaces;
using CreditworthinessAI.Objects;
using CreditworthinessAI.Storage;

namespace CreditworthinessAI
{
    internal class Program
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

        static Program()
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
        }

        private static void Main()
        {
            Console.WriteLine(CheckDataBase());
            //Console.WriteLine(GetDistrict(1972).district_id);
            //Console.WriteLine(GetCreditCard(73).card_id);

            //foreach (var item in GetAccountPermanentOrders(3))
            //{
            //    Console.WriteLine(item.order_id);
            //}

            Console.WriteLine(GetLoan(1801).status);


            Console.ReadKey();
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

        //Unnecessery
        private static int GetCreditCards()
        {
            var result = from a in _accounts
                         join d in _dispositions
                         on a.account_id equals d.account_id
                         join c in _cards
                         on d.disp_id equals c.disp_id
                         select c;

            return result.Count();
        }

        private static CreditCard GetCreditCard(int holderAccountId)
        {
            var result = from a in _accounts
                         join d in _dispositions
                         on holderAccountId equals d.account_id
                         join c in _cards
                         on d.disp_id equals c.disp_id
                         select c;

            return result.FirstOrDefault();
        }

        private static District GetDistrict(int accountId)
        {
            var result = from a in _accounts
                         where a.account_id == accountId
                         join d in _districts
                         on a.district_id equals d.district_id
                         select d;

            return result.FirstOrDefault();
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

        private static Loan GetLoan(int accountId)
        {
            var result = from a in _accounts
                         join l in _loans
                         on accountId equals l.account_id
                         select l;

            return result.FirstOrDefault();
        }
    }
}
