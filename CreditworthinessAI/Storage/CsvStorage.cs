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
        /// Restore information from CSV database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static IEnumerable<T> RestoreObject<T>(string filepath)
        {
            using (var reader = new StreamReader($"{filepath}.csv"))
            using (var csv = new CsvReader(reader))
            {
                var records = csv.GetRecords<T>();

                return records;
            }
        }

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
