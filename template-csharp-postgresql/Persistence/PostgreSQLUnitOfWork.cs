using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql;
using template_csharp_postgresql.Persistence.Repositories;
using template_csharp_postgresql.Entities;
using template_csharp_postgresql.Persistence.Repositories.ReadStrategiesEntityB;
using template_csharp_postgresql.Persistence.Repositories.ReadStrategiesEntityA;

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

        public EntityB createEntityB(EntityB entityB)
        {
            EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(this.connection);
            entityB = entityBRepository.create(entityB);
            return entityB;
        }

        public bool deleteEntityB(int id)
        {

            EntityB entityB = new EntityB(id);
            bool result = false;

            EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(this.connection);
            result = entityBRepository.delete(entityB);

            return result;
        }

        public bool updateEntityB(EntityB item)
        {
            bool result = false;
            EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(this.connection);
            result = entityBRepository.update(item);
            return result;
        }

        public List<EntityB> getAllEntitiesB()
        {
            List<EntityB> entitiesB;
            EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(this.connection);
            ReadAllEntitiesB<EntityB> readStrategy = new ReadAllEntitiesB<EntityB>();
            entityBRepository.setReadStrategy(readStrategy);
            entitiesB = entityBRepository.read(new EntityB());

            return entitiesB;
        }

        public List<EntityA> getAllEntitiesA() {

            List<EntityA> entitiesA;
            EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection);
            ReadAllEntitiesA<EntityA> readStrategy = new ReadAllEntitiesA<EntityA>();
            entityARepository.setReadStrategy(readStrategy);
            entitiesA = entityARepository.read(new EntityA());

            return entitiesA;
        }

        public EntityA createEntityA(EntityA item)
        {
            EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection);
            entityARepository.create(item);

            return item;
        }

        public bool deleteEntityA(EntityA item)
        {
            EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection);
            return entityARepository.delete(item);
        }

        public bool updateEntityA(EntityA item)
        {
            EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection);
            return entityARepository.update(item);
        }

        public List<EntityA> readEntityAOption1(string entityBName)
        {
            // This option reads by EntityB name
            EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection);
            ReadStrategy1<EntityA> readStrategy = new ReadStrategy1<EntityA>();
            readStrategy.setFilter(entityBName);
            entityARepository.setReadStrategy(readStrategy);

            return entityARepository.read(new EntityA());
        }

        public List<EntityA> readEntityAOption2(string entityAName)
        {
            // This option reads by EntityA name
            EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection);
            ReadStrategy2<EntityA> readStrategy = new ReadStrategy2<EntityA>();
            readStrategy.setFilter(entityAName);
            entityARepository.setReadStrategy(readStrategy);

            return entityARepository.read(new EntityA());
        }

        public List<EntityA> readEntityAOption3(string entityAName, string entityBName)
        {
            // This option reads by EntityA name and EntityB name
            EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection);
            ReadStrategy3<EntityA> readStrategy = new ReadStrategy3<EntityA>();
            readStrategy.setFilter(entityAName, entityBName);
            entityARepository.setReadStrategy(readStrategy);

            return entityARepository.read(new EntityA());
        }
    }
}
