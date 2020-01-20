using System.Collections;
using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace CreditworthinessAI.Storage
{
    /// <summary>
    /// CSV storage handler
    /// </summary>
    public class CsvStorage
    {
        /// <summary>
        /// Store object in CSV database
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filepath"></param>
        public static void StoreObject(object obj, string filepath)
        {
            using (var writer = new StreamWriter($"{filepath}.csv"))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords((IEnumerable) obj);
            }
        }
    }
}
