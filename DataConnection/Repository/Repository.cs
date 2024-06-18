using DataConnection.DataAccess;
using DataConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataConnection.Repository
{
    public class Repository : IRepository
    {
        private readonly IDataAcces _dataAcces;
        public Repository(IDataAcces dataAcces)
        {
            _dataAcces = dataAcces;
        }

        public async Task<IEnumerable<User>> getAllUsersAsync()
        {
            IEnumerable<User> result = await _dataAcces.GetDataAsync<User, dynamic>(storedProcedure:
                "dbo.ShowAllUsers",
                new
                {

                });
            return result;
        }


        public async Task<User> getSingleUserAsync(int Id)
        {
            User result = await _dataAcces.GetSingleDataAsync<User, dynamic>(storedProcedure:
                "dbo.ShowUserById",
                new
                {
                    Id = Id
                }
                );

            return result;
        }

        private async Task<User> getuserdetailbyname(string name)
        {
            User result = await _dataAcces.GetSingleDataAsync<User, dynamic>(storedProcedure: "", new 
            {
                Name = name
            });
            return result;
        }

        public async Task<string> AddUserToDbAsync(User user)
        {
            await _dataAcces.UpdatedataAsync(storedProcedure: "dbo.AddUser", new
            {
                Name = user.Name,
                LastName = user.LastName
            });

            var result = await getuserdetailbyname(user.Name);

            return result != null ? "Added user already" : "Fail to add user";
        }


    }
}
