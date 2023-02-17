using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Persistence;
using template_csharp_postgresql.Entities;
using System.Data;

namespace template_csharp_postgresql
{
    public class Controller
    {
        public void insertEntityB(Form1 ui, string name)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            EntityB entityB = new EntityB(name);
            entityB = unitOfWork.insertEntityB(entityB);
            ui.loadNewEntityBInGridSearch(int.Parse(entityB.Id.ToString()), entityB.Name);
            unitOfWork.disconnect();
        }

        public void deleteEntityB(Form1 ui, int id, int index)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            bool result = unitOfWork.deleteEntityB(id);
            unitOfWork.disconnect();
            if (result)
            {
                ui.deleteEntityBFromGrid(index);
            }else
            {
                ui.showWarning("Failed to delete item. Please check if the item is linked to any other entities before attempting to delete.");
            }
        }


        public void deleteEntityA(Form1 ui, int id, int index)
        {
            EntityA entityA = new EntityA(id);
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            bool result = unitOfWork.deleteEntityA(entityA);
            unitOfWork.disconnect();

            if (result)
            {
                ui.deleteEntityAFromGrid(index, id);
            }
        }

        public void updateEntityB(Form1 ui, int id, string name, int index)
        {
            EntityB entityB = new EntityB(id, name);
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            if (unitOfWork.updateEntityB(entityB))
            {
                ui.replaceEntityBInGrid(index, id, name);
            }

            unitOfWork.disconnect();
        }

        public DataTable getAllEntitiesB()
        {
            DataTable data = new DataTable();
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<EntityB> entitiesB = unitOfWork.getAllEntitiesB();
            unitOfWork.disconnect();

            // Load datatable
            data.Columns.Add("id");
            data.Columns.Add("name");
            int count = 0;
            foreach (EntityB entityB in entitiesB)
            {
                data.Rows.Add();
                data.Rows[count]["id"] = entityB.Id;
                data.Rows[count]["name"] = entityB.Name;
                count += 1;
            }
            return data;
        }

        public void insertEntityA(Form1 ui, DataTable dtEntititesB, string name)
        {
            EntityA entityA = new EntityA(name);
            List<EntityB> entitiesB = new List<EntityB>();
            foreach(DataRow row in dtEntititesB.Rows)
            {
                EntityB entityB = new EntityB(int.Parse(row["id"].ToString()), row["name"].ToString());
                entitiesB.Add(entityB);
            }
            entityA.EntitiesB = entitiesB;

            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            entityA = unitOfWork.insertEntityA(entityA);
            unitOfWork.disconnect();
        }

        public Dictionary<string, Dictionary<int, DataTable>> getAllEntitiesA()
        {
            // Returns a dictionary
            //{"A": {entAid, [{idEntA, name}]},
            // "B": {entAid: [{idEntB1, name1}, {idEntB2, name2}, ...]}}

            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<EntityA> entitiesA = unitOfWork.getAllEntitiesA();
            unitOfWork.disconnect();

            // Convert entities object to DataTables and Dictionary
            // those are the data types the gui will handle
            Dictionary<int, DataTable> dataEntitiesB = new Dictionary<int, DataTable>();// Dictionary for entitiesB
            Dictionary<int, DataTable> dataEntitiesA = new Dictionary<int, DataTable>(); // Dictionary for entitiesA
            Dictionary<string, Dictionary<int, DataTable>> dataEntities = new Dictionary<string, Dictionary<int, DataTable>>(); // Dictionary for both entities A and B

            foreach (EntityA entityA in entitiesA)
            {
                // Convert entitiesB
                if (!dataEntitiesB.ContainsKey(entityA.Id))
                {
                    // Create entitiesB datatable
                    DataTable dtEntitiesB = new DataTable();
                    dtEntitiesB.Columns.Add("id");
                    dtEntitiesB.Columns.Add("name");
                    dataEntitiesB.Add(entityA.Id, dtEntitiesB);

                    // Create entitiesA datatable
                    DataTable dtEntitiesA = new DataTable();
                    dtEntitiesA.Columns.Add("id");
                    dtEntitiesA.Columns.Add("name");

                    // Convert entities A
                    dtEntitiesA.Rows.Add();
                    dtEntitiesA.Rows[0]["id"] = entityA.Id;
                    dtEntitiesA.Rows[0]["name"] = entityA.Name;
                    dataEntitiesA.Add(entityA.Id, dtEntitiesA);
                }
                int countB = 0;
                foreach (EntityB entityB in entityA.EntitiesB)
                {
                    dataEntitiesB[entityA.Id].Rows.Add();
                    dataEntitiesB[entityA.Id].Rows[countB]["id"] = entityB.Id;
                    dataEntitiesB[entityA.Id].Rows[countB]["name"] = entityB.Name;
                    countB++;
                }
            }
            dataEntities.Add("A", dataEntitiesA);
            dataEntities.Add("B", dataEntitiesB);
            return dataEntities;
        }

        public void updateEntityA(Form1 ui, Dictionary<string, DataTable> dataEntityA)
        {
            // 1) Convert data to EntityA object
            EntityA entityA = new EntityA();
            entityA.Id = int.Parse(dataEntityA["A"].Rows[0]["id"].ToString());
            entityA.Name = dataEntityA["A"].Rows[0]["name"].ToString();

            foreach(DataRow row in dataEntityA["B"].Rows)
            {
                EntityB entityB = new EntityB();
                entityB.Id = int.Parse(row["id"].ToString());
                entityB.Name = row["name"].ToString();

                entityA.EntitiesB.Add(entityB);
            }

            // 2) Update in database
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            bool result = unitOfWork.updateEntityA(entityA);
            unitOfWork.disconnect();

            if (result)
            {
                ui.loadEntitiesA();
            }
        }

        public void filterEntityAOption1(string entityBName)
        {
            // Find by EntityB name
            PostgreSQLUnitOfWork unitOfwork = new PostgreSQLUnitOfWork();
            unitOfwork.connect();

            unitOfwork.disconnect();

        }

        public void filterEntityAOption2(string entityAName)
        {
            // Find by EntityA name
            PostgreSQLUnitOfWork unitOfwork = new PostgreSQLUnitOfWork();
            unitOfwork.connect();

            unitOfwork.disconnect();

        }

        public void filterEntityAOption3(string entityAName, string entityBName)
        {
            // Find by EntityA name and EntityB name
            PostgreSQLUnitOfWork unitOfwork = new PostgreSQLUnitOfWork();
            unitOfwork.connect();

            unitOfwork.disconnect();

        }
    }
}
