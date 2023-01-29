using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql;
using template_csharp_postgresql.Persistence.Repositories;
using template_csharp_postgresql.Entities;

namespace template_csharp_postgresql.Persistence
{
    public class PostgreSQLUnitOfWork : IUnitOfWork
    {
        private string connectionString = 
            "Server = " + Globals.SERVER + 
            "; User Id = " + Globals.USER_ID + 
            "; Password = " + Globals.PASSWORD + 
            "; Database = " + Globals.DATABASE_NAME;
        private NpgsqlConnection connection ;
         
        public void connect()
        {
            this.connection = new NpgsqlConnection(this.connectionString);
            this.connection.Open();
        }

        public void disconnect()
        {
            this.connection.Close();
        }

        public NpgsqlConnection getConnection()
        {
            return this.connection;
        }

        public EntityB insertEntityB(EntityB entityB)
        {
            EntityBRepository<EntityB> entityBRepository = new Repositories.EntityBRepository<EntityB>(this.connection);
            entityB = entityBRepository.create(entityB);
            return entityB;
        }

        public bool deleteEntityB(int id)
        {
            EntityB entityB = new EntityB(id);
            EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(this.connection);
            return entityBRepository.delete(entityB);
        }

        public bool updateEntityB(EntityB item)
        {
            EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(this.connection);
            return entityBRepository.update(item);
        }

        public List<EntityB> getAllEntitiesB()
        {
            EntityB entityB = new EntityB(-1, "");
            EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(this.connection);
            List<EntityB> entitiesB = entityBRepository.find(entityB);
            return entitiesB;

        }
    }
}
