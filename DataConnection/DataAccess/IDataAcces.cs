using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataConnection.DataAccess
{
    public interface IDataAcces
    {
        Task<IEnumerable<T>> GetDataAsync<T, U>(string storedProcedure, U parameters);
        Task<T> GetSingleDataAsync<T, U>(string storedProcedure, U parameters);
        Task UpdatedataAsync<U>(string storedProcedure, U parameters);
    }
}