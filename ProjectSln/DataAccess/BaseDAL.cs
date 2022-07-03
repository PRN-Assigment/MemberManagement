using BusinessObject;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //Mai Quang Khai
    public class BaseDAL
    {
        public MemberProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null;

        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new MemberProvider(connectionString);
        }

        public string GetConnectionString()
        {
            string connectionString = null;
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            connectionString = config["ConnectionStrings:DefaultConnection"];
            return connectionString;
        }

        public MemberObject GetDefaultAdmin()
        {
            MemberObject admin = new MemberObject();
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            admin.Email = config["DefaultUser:Email"];
            admin.Password = config["DefaultUser:Password"];
            admin.MemberName = config["DefaultUser:Name"];
            admin.City = config["DefaultUser:City"];
            admin.Country = config["DefaultUser:Country"];
            return admin;
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
