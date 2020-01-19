using System.IO;
using Newtonsoft.Json;
using CreditworthinessAI.Interfaces;

namespace CreditworthinessAI.Storage
{
    /// <summary>
    /// JSON storage handler
    /// </summary>
    public class JsonStorage : IStorage
    {
        /// <summary>
        /// Restore information from JSON database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public T RestoreObject<T>(string filepath)
        {
            var json = File.ReadAllText($"{filepath}.json");
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Store object in JSON database
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filepath"></param>
        public void StoreObject(object obj, string filepath)
        {
            var file = $"{filepath}.json";

            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);

            File.WriteAllText(file, json);
        }
    }
}
