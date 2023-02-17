using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql;
using template_csharp_postgresql.Persistence.Repositories;
using template_csharp_postgresql.Entities;
using template_csharp_postgresql.Persistence.Repositories.FindStrategiesEntityB;
using template_csharp_postgresql.Persistence.Repositories.FindStrategiesEntityA;

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
            FindAllEntitiesB<EntityB> findStrategy = new FindAllEntitiesB<EntityB>();
            entityBRepository.setFindStrategy(findStrategy);
            entitiesB = entityBRepository.find(new EntityB());

            return entitiesB;
        }

        public List<EntityA> getAllEntitiesA() {

            List<EntityA> entitiesA;
            EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection);
            FindAllEntitiesA<EntityA> findStrategy = new FindAllEntitiesA<EntityA>();
            entityARepository.setFindStrategy(findStrategy);
            entitiesA = entityARepository.find(new EntityA());

            return entitiesA;
        }

        public EntityA insertEntityA(EntityA item)
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

        public List<EntityA> filterEntityAOption1(string entityBName)
        {
            // This option finds by EntityB name
            EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection);
            FindStrategy1<EntityA> findStrategy = new FindStrategy1<EntityA>();
            findStrategy.setFilter(entityBName);
            entityARepository.setFindStrategy(findStrategy);

            return entityARepository.find(new EntityA());
        }

        public List<EntityA> filterEntityAOption2(string entityAName)
        {
            // This option finds by EntityA name
            EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection);
            FindStrategy2<EntityA> findStrategy = new FindStrategy2<EntityA>();
            findStrategy.setFilter(entityAName);
            entityARepository.setFindStrategy(findStrategy);

            return entityARepository.find(new EntityA());
        }

        public List<EntityA> filterEntityAOption3(string entityAName, string entityBName)
        {
            // This option finds by EntityA name and EntityB name
            EntityARepository<EntityA> entityARepository = new EntityARepository<EntityA>(this.connection);
            FindStrategy3<EntityA> findStrategy = new FindStrategy3<EntityA>();
            findStrategy.setFilter(entityAName, entityBName);
            entityARepository.setFindStrategy(findStrategy);

            return entityARepository.find(new EntityA());
        }
    }
}
