using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Infrastructure.Context
{
    public class ApplicationDBContext:DbContext
    {

        private readonly IConfiguration _configuration;
        private readonly string _dbconnectionString;

        public ApplicationDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _dbconnectionString = _configuration.GetConnectionString("DBConnectionString");

        }

        public IDbConnection DBConnectionCreate()
            => new NpgsqlConnection(_dbconnectionString);


        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
           : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        

    }
}
