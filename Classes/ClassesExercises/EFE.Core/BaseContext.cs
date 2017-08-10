using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFE.Core.Map;

namespace EFE.Core
{
    class BaseContext: AbstractContext
    {
        public BaseContext(string user, string password) :
            base("name=SqlContext", "dbo")
        {
            SetConnectionString(user, password);
            Database.SetInitializer(new CreateDatabaseIfNotExists<BaseContext>());
        }

        protected sealed override void SetConnectionString(string user, string password)
        {
            if (user == null || password == null)
            {
                Console.WriteLine("Error");
            }
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = ConfigurationManager.AppSettings.Get("Server"),
                InitialCatalog = ConfigurationManager.AppSettings.Get("Name"),
                PersistSecurityInfo = true,
                MultipleActiveResultSets = true,
                UserID = user,
                Password = password
            };
            Database.DefaultConnectionFactory = new SqlConnectionFactory(builder.ToString());

            Database.Connection.ConnectionString = builder.ToString();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AreaMap(Schema));
            modelBuilder.Configurations.Add(new PersonMap(Schema));
        }
    }
}
