namespace CreditworthinessAI.Interfaces
{
    /// <summary>
    /// Interface to handle file storage
    /// </summary>
    public interface IStorage
    {
        /// <summary>
        /// Fetch the object from file
        /// </summary>
        /// <typeparam name="T">type of restoring object</typeparam>
        /// <param name="filepath">path to database</param>
        /// <returns></returns>
        public T RestoreObject<T>(string filepath);

        /// <summary>
        /// Store object in database
        /// </summary>
        /// <param name="obj">object to store</param>
        /// <param name="filepath">path to database</param>
        public void StoreObject(object obj, string filepath);
    }
}
