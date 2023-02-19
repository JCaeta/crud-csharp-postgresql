using Microsoft.VisualStudio.TestTools.UnitTesting;
using template_csharp_postgresql.Persistence.Repositories.ReadStrategiesEntityB;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Entities;
using Npgsql;
using template_csharp_postgresql.Persistence.Repositories;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesEntityB.Tests
{
    [TestClass()]
    public class ReadByIdTests
    {
        [TestMethod()]
        public void readTest()
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
                ReadById<EntityB> readById = new ReadById<EntityB>();
                readById.setIds(ids);
                entitiesB = readById.read(connection);
            }

            //IReadStrategy<EntityB> readById = new ReadById<EntityB>();

            connection.Close();
            if (entitiesB.Count == 0)
            {
                Assert.Fail();
            }
        }
    }
}