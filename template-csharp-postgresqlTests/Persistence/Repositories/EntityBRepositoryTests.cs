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

            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            NpgsqlConnection conn = unitOfWork.getConnection();


            EntityBRepository<EntityB> repository = new EntityBRepository<EntityB>(conn);
            repository.create(entityB);

            unitOfWork.disconnect();

        }
    }
}