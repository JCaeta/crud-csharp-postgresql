using Microsoft.VisualStudio.TestTools.UnitTesting;
using template_csharp_postgresql.Persistence.Repositories.FindStrategiesEntityB;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Entities;
using Npgsql;
using template_csharp_postgresql.Persistence.Repositories;

namespace template_csharp_postgresql.Persistence.Repositories.FindStrategiesEntityB.Tests
{
    [TestClass()]
    public class FindByIdTests
    {
        [TestMethod()]
        public void findTest()
        {
            string connectionString =
            "Server = " + Globals.SERVER +
            "; User Id = " + Globals.USER_ID +
            "; Password = " + Globals.PASSWORD +
            "; Database = " + Globals.DATABASE_NAME;

            List<int> ids = new List<int> { 42, 44 };
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            List<EntityB> entitiesB;
            using (NpgsqlTransaction transaction = connection.BeginTransaction())
            {
                FindById<EntityB> findById = new FindById<EntityB>();
                findById.setIds(ids);
                entitiesB = findById.find(connection);
            }

            //IFindStrategy<EntityB> findById = new FindById<EntityB>();

            connection.Close();
            if (entitiesB.Count == 0)
            {
                Assert.Fail();
            }
        }
    }
}