using Microsoft.VisualStudio.TestTools.UnitTesting;
using template_csharp_postgresql.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Entities;
using Npgsql;

namespace template_csharp_postgresql.Persistence.Repositories.Tests
{
    [TestClass()]
    public class EntityBRepositoryTests
    {
        [TestMethod()]
        //[Ignore()]
        public void createTest()
        {
            EntityB entityB = new EntityB();
            entityB.Name = "Test name 1";

            string connectionString =
            "Server = " + Globals.SERVER +
            "; User Id = " + Globals.USER_ID +
            "; Password = " + Globals.PASSWORD +
            "; Database = " + Globals.DATABASE_NAME;


            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            using (NpgsqlTransaction transaction = connection.BeginTransaction())
            {
                EntityBRepository<EntityB> repository = new EntityBRepository<EntityB>(connection, transaction);
                repository.create(entityB);
            }


            unitOfWork.disconnect();

        }
    }
}