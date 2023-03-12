using System;
using System.Collections.Generic;
using System.Text;
using crud_csharp_postgresql.Persistence;
using crud_csharp_postgresql.Models;
using System.Data;
using crud_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelB;
using System.IO;
using System.Windows.Forms;

namespace crud_csharp_postgresql
{
    public class Controller
    {
        private Dictionary<string, string> databaseInformation;
        private bool databaseInformationConfigured = false;

        public Controller()
        {
            this.databaseInformation = new Dictionary<string, string>();
            this.databaseInformation.Add("SERVER", "");
            this.databaseInformation.Add("USER_ID", "");
            this.databaseInformation.Add("PASSWORD", "");
            this.databaseInformation.Add("DATABASE_NAME", "");
        }

        public void setDatabaseInformation(Dictionary<string, string> databaseInformation)
        {
            string rootPath = Application.StartupPath;
            string filePath = Path.Combine(rootPath, "..\\..\\..\\database-information.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach(string key in databaseInformation.Keys)
                {
                    writer.WriteLine(key + ":" + databaseInformation[key]);
                }
            }
        }

        public bool loadDatabaseInformation()
        {
            string rootPath = Application.StartupPath;
            string filePath = Path.Combine(rootPath, "..\\..\\..\\database-information.txt");

            // 1) Check if file exists
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Do something with the line
                    string[] parts = line.Split(':');
                    this.databaseInformation[parts[0]] = parts[1];
                }
                reader.Close();

                PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
                this.databaseInformationConfigured = unitOfWork.checkStringConnection();
                return databaseInformationConfigured;

            } else
            {
                return false;
            }
        }

        public bool isDatabaseInformationConfigured()
        {
            return this.databaseInformationConfigured;
        }

        public ModelB createModelB(string name)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            ModelB modelB = new ModelB(name);
            modelB = unitOfWork.createModelB(modelB);
            unitOfWork.disconnect();
            return modelB;
        }

        public List<ModelB> readAllModelsB()
        {
            DataTable data = new DataTable();
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            List<ModelB> modelsB = unitOfWork.readAllModelsB();
            unitOfWork.disconnect();

            return modelsB;
        }

        public List<ModelB> readModelBByName(string name)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            return unitOfWork.readModelBByName(name);
        }

        public bool updateModelB(ModelB modelB)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            bool result = unitOfWork.updateModelB(modelB);
            unitOfWork.disconnect();
            return result;
        }

        public bool deleteModelB(ModelB modelB)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            bool result = unitOfWork.deleteModelB(modelB.Id);
            unitOfWork.disconnect();
            return result;
        }

        public ModelA createModelA(ModelA modelA)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            modelA = unitOfWork.createModelA(modelA);
            unitOfWork.disconnect();

            return modelA;
        }

        public List<ModelA> readAllModelsA()
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            List<ModelA> modelsA = unitOfWork.readAllModelsA();
            unitOfWork.disconnect();

            return modelsA;
        }

        public List<ModelA> readModelAOption1(string modelBName)
        {
            // Read by ModelB name
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            List<ModelA> modelsA = unitOfWork.readModelAOption1(modelBName);
            unitOfWork.disconnect();
            return modelsA;
        }

        public List<ModelA> readModelAOption2(string modelAName)
        {
            // Read by ModelA name
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            List<ModelA> modelsA = unitOfWork.readModelAOption2(modelAName);
            unitOfWork.disconnect();
            return modelsA;
        }

        public List<ModelA> readModelAOption3(string modelAName, string modelBName)
        {
            // Read by ModelA name and ModelB name
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            List<ModelA> modelsA = unitOfWork.readModelAOption3(modelAName, modelBName);
            unitOfWork.disconnect();
            return modelsA;
        }

        public bool deleteModelA(int id)
        {
            ModelA modelA = new ModelA(id);
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            bool result = unitOfWork.deleteModelA(modelA);
            unitOfWork.disconnect();
            return result;
        }

        public bool updateModelA(ModelA modelA)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork(this.databaseInformation);
            unitOfWork.connect();
            bool result = unitOfWork.updateModelA(modelA);
            unitOfWork.disconnect();
            return result;
        }
    }
}
