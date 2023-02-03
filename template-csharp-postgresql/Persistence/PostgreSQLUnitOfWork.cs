using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql;
using template_csharp_postgresql.Persistence.Repositories;
using template_csharp_postgresql.Entities;
using template_csharp_postgresql.Persistence.Repositories.FindStrategiesEntityB;

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
            using(NpgsqlTransaction transaction = this.connection.BeginTransaction())
            {
                EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(this.connection, transaction);
                entityB = entityBRepository.create(entityB);
            }
            return entityB;
        }

        public bool deleteEntityB(int id)
        {

            EntityB entityB = new EntityB(id);
            bool result = false;
            using (NpgsqlTransaction transaction = this.connection.BeginTransaction())
            {
                EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(this.connection, transaction);
                result = entityBRepository.delete(entityB);

            }
            return result;
        }

        public bool updateEntityB(EntityB item)
        {
            bool result = false;
            using (NpgsqlTransaction transaction = this.connection.BeginTransaction())
            {
                EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(this.connection, transaction);
                result = entityBRepository.update(item);
            }
            return result;
        }

        public List<EntityB> getAllEntitiesB()
        {
            List<EntityB> entitiesB;
            using (NpgsqlTransaction transaction = this.connection.BeginTransaction())
            {
                EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(this.connection, transaction);
                FindAll<EntityB> findStrategy = new FindAll<EntityB>();
                entityBRepository.setFindStrategy(findStrategy);
                entitiesB = entityBRepository.find(new EntityB());
            }

            return entitiesB;
        }

        public List<EntityA> getAllEntitiesA() {
            EntityA filter = new EntityA(-1, "");
            List<EntityA> entitiesA;
            using (NpgsqlTransaction transaction = this.connection.BeginTransaction())
            {
                EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection, transaction);
                entitiesA = entityARepository.find(filter);
            }

            return entitiesA;

        }

        public EntityA insertEntityA(EntityA item)
        {
            using(NpgsqlTransaction transaction = this.connection.BeginTransaction())
            {
                EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection, transaction);
                entityARepository.create(item);
            }

            return item;
        }

        //public List<EntityA> 
    }
}
