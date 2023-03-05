using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Persistence;
using template_csharp_postgresql.Models;
using System.Data;
using template_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelB;

namespace template_csharp_postgresql
{
    public class Controller
    {
        public ModelB createModelB(string name)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            ModelB modelB = new ModelB(name);
            modelB = unitOfWork.createModelB(modelB);
            unitOfWork.disconnect();
            return modelB;
        }

        public bool deleteModelB(ModelB modelB)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            bool result = unitOfWork.deleteModelB(modelB.Id);
            unitOfWork.disconnect();
            return result;
        }

        public bool deleteModelA(int id)
        {
            ModelA modelA = new ModelA(id);
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            bool result = unitOfWork.deleteModelA(modelA);
            unitOfWork.disconnect();
            return result;

        }

        public bool updateModelB(ModelB modelB)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            bool result = unitOfWork.updateModelB(modelB);
            unitOfWork.disconnect();
            return result;

        }

        public List<ModelB> getAllModelsB()
        {
            DataTable data = new DataTable();
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<ModelB> modelsB = unitOfWork.getAllModelsB();
            unitOfWork.disconnect();

            return modelsB;
        }

        public ModelA createModelA(ModelA modelA)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            modelA = unitOfWork.createModelA(modelA);
            unitOfWork.disconnect();

            return modelA;
        }


        public List<ModelA> getAllModelsA()
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<ModelA> modelsA = unitOfWork.getAllModelsA();
            unitOfWork.disconnect();

            return modelsA;
        }

        public bool updateModelA(ModelA modelA)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            bool result = unitOfWork.updateModelA(modelA);
            unitOfWork.disconnect();
            return result;
        }

        public List<ModelA> readModelAOption1(string modelBName)
        {
            // Read by ModelB name
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<ModelA> modelsA = unitOfWork.readModelAOption1(modelBName);
            unitOfWork.disconnect();
            return modelsA;
        }

        public List<ModelA> readModelAOption2(string modelAName)
        {
            // Read by ModelA name
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<ModelA> modelsA = unitOfWork.readModelAOption2(modelAName);
            unitOfWork.disconnect();
            return modelsA;
        }

        public List<ModelA> readModelAOption3(string modelAName, string modelBName)
        {
            // Read by ModelA name and ModelB name
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<ModelA> modelsA = unitOfWork.readModelAOption3(modelAName, modelBName);
            unitOfWork.disconnect();
            return modelsA;
        }

        public List<ModelB> readModelBByName(string name)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            return unitOfWork.readModelBByName(name);
        }
    }
}
