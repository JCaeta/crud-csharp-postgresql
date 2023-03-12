using Microsoft.VisualStudio.TestTools.UnitTesting;
using template_csharp_postgresql.Persistence.Repositories.ReadStrategiesEntityA;
using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using template_csharp_postgresql.Entities;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesEntityA.Tests
{
    [TestClass()]
    public class ReadAllTests
    {
        private string connectionString =
            "Server = " + Globals.SERVER +
            "; User Id = " + Globals.USER_ID +
            "; Password = " + Globals.PASSWORD +
            "; Database = " + Globals.DATABASE_NAME;

        [TestMethod()]
        public void readTest()
        {

            NpgsqlConnection connection = new NpgsqlConnection(this.connectionString);
            connection.Open();
            ReadAllEntitiesA<EntityA> readAll = new ReadAllEntitiesA<EntityA>();
            List<EntityA> entitiesA = readAll.read(connection);
            connection.Close();
            if (entitiesA.Count == 0)
            {
                Assert.Fail();
            }

        }
    }
}