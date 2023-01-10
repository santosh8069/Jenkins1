using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.DTO;
using Domains.Entities;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Context;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repository
{
    public class UserRepository: IUser
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(ApplicationDBContext context,ILogger<UserRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<User> GetUsers()
        {
            try
            {

                    var sql = "select * from users";
                    var connection = _context.DBConnectionCreate();                
                    connection.Open();
                    var user=await connection.QueryAsync<User>(sql);
                    connection.Close();
                    return user.FirstOrDefault();

                

               
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
        }

      

    }
}
