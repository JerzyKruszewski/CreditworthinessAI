using System;

namespace CreditworthinessAI
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                //Commented cause database already created
                //DatabaseMenager.CreateDatabase();
                //DatabaseMenager.SplitDatabase();

                ModelTester.TestModel(DatabaseMenager.GetTestAIAccounts());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
                throw;
            }
        }
    }
}
