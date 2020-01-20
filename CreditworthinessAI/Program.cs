using System;

namespace CreditworthinessAI
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                DatabaseMenager.CreateDatabase();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
                throw;
            }
        }
    }
}
