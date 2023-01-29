using Microsoft.VisualStudio.TestTools.UnitTesting;
using template_csharp_postgresql.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace template_csharp_postgresql.Persistence.Tests
{
    [TestClass()]
    public class PostgreSQLUnitOfWorkTests
    {
        [TestMethod()]
        public void connectTest()
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();

            try
            {
                unitOfWork.connect();
                if(unitOfWork.getConnection() != null)
                {
                    unitOfWork.disconnect();
                    Console.WriteLine("Connection sucessful");
                   
                } else
                {
                    Assert.Fail();
                }
                
            } catch(Exception ex)
            {
                Console.WriteLine("Connection failed");
                Assert.Fail();
            }
        }
    }
}