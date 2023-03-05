using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql;
using template_csharp_postgresql.Persistence.Repositories;
using template_csharp_postgresql.Models;
using template_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelB;
using template_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelA;

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

        public ModelB createModelB(ModelB modelB)
        {
            ModelBRepository<ModelB> modelBRepository = new ModelBRepository<ModelB>(this.connection);
            modelB = modelBRepository.create(modelB);
            return modelB;
        }

        public bool deleteModelB(int id)
        {

            ModelB modelB = new ModelB(id);
            bool result = false;

            ModelBRepository<ModelB> modelBRepository = new ModelBRepository<ModelB>(this.connection);
            result = modelBRepository.delete(modelB);

            return result;
        }

        public bool updateModelB(ModelB item)
        {
            bool result = false;
            ModelBRepository<ModelB> modelBRepository = new ModelBRepository<ModelB>(this.connection);
            result = modelBRepository.update(item);
            return result;
        }

        public List<ModelB> getAllModelsB()
        {
            List<ModelB> entitiesB;
            ModelBRepository<ModelB> modelBRepository = new ModelBRepository<ModelB>(this.connection);
            ReadAllModelsB<ModelB> readStrategy = new ReadAllModelsB<ModelB>();
            modelBRepository.setReadStrategy(readStrategy);
            entitiesB = modelBRepository.read(new ModelB());

            return entitiesB;
        }

        public List<ModelA> getAllModelsA() {

            List<ModelA> entitiesA;
            ModelARepository<ModelA> modelARepository = new ModelARepository<ModelA>(this.connection);
            ReadAllModelsA<ModelA> readStrategy = new ReadAllModelsA<ModelA>();
            modelARepository.setReadStrategy(readStrategy);
            entitiesA = modelARepository.read(new ModelA());

            return entitiesA;
        }

        public ModelA createModelA(ModelA item)
        {
            ModelARepository<ModelA> modelARepository = new ModelARepository<ModelA>(this.connection);
            modelARepository.create(item);

            return item;
        }

        public bool deleteModelA(ModelA item)
        {
            ModelARepository<ModelA> modelARepository = new ModelARepository<ModelA>(this.connection);
            return modelARepository.delete(item);
        }

        public bool updateModelA(ModelA item)
        {
            ModelARepository<ModelA> modelARepository = new ModelARepository<ModelA>(this.connection);
            return modelARepository.update(item);
        }

        public List<ModelA> readModelAOption1(string modelBName)
        {
            // This option reads by ModelB name
            ModelARepository<ModelA> modelARepository = new ModelARepository<ModelA>(this.connection);
            ReadStrategy1<ModelA> readStrategy = new ReadStrategy1<ModelA>();
            readStrategy.setFilter(modelBName);
            modelARepository.setReadStrategy(readStrategy);

            return modelARepository.read(new ModelA());
        }

        public List<ModelA> readModelAOption2(string modelAName)
        {
            // This option reads by ModelA name
            ModelARepository<ModelA> modelARepository = new ModelARepository<ModelA>(this.connection);
            ReadStrategy2<ModelA> readStrategy = new ReadStrategy2<ModelA>();
            readStrategy.setFilter(modelAName);
            modelARepository.setReadStrategy(readStrategy);

            return modelARepository.read(new ModelA());
        }

        public List<ModelA> readModelAOption3(string modelAName, string modelBName)
        {
            // This option reads by ModelA name and ModelB name
            ModelARepository<ModelA> modelARepository = new ModelARepository<ModelA>(this.connection);
            ReadStrategy3<ModelA> readStrategy = new ReadStrategy3<ModelA>();
            readStrategy.setFilter(modelAName, modelBName);
            modelARepository.setReadStrategy(readStrategy);

            return modelARepository.read(new ModelA());
        }

        public List<ModelB> readModelBByName(string name)
        {
            ModelBRepository<ModelB> modelBRepository = new ModelBRepository<ModelB>(this.connection);
            ReadByName<ModelB> readStrategy = new ReadByName<ModelB>();
            readStrategy.setName(name);
            modelBRepository.setReadStrategy(readStrategy);
            return modelBRepository.read(new ModelB());
        }
    }
}
