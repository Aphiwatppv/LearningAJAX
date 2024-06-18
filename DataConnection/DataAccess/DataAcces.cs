using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.DataAccess
{
    public class DataAcces : IDataAcces
    {
        private string _connectionString;
        public DataAcces(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<T>> GetDataAsync<T, U>(string storedProcedure, U parameters)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                var result = await conn.QueryAsync<T>(storedProcedure, parameters);
                return result;
            }
        }

        public async Task<T> GetSingleDataAsync<T, U>(string storedProcedure, U parameters)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                var result = await conn.QueryFirstAsync<T>(storedProcedure, parameters);
                return result;
            }
        }

        public async Task UpdatedataAsync<U>(string storedProcedure, U parameters)
        {
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                await conn.ExecuteAsync(storedProcedure, parameters);
            }
        }
    }
}
