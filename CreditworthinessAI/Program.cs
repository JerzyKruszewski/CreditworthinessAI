using System;
using System.Collections.Generic;
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
    }
}
