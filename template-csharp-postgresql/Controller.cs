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
        private PostgreSQLUnitOfWork unitOfWork;

        public Controller()
        {
            this.unitOfWork = new PostgreSQLUnitOfWork();
        }

        public void insertEntityB(Form1 ui, string name)
        {
            this.unitOfWork.connect();
            EntityB entityB = new EntityB(name);
            entityB = this.unitOfWork.insertEntityB(entityB);
            ui.loadNewEntityBInGridSearch(int.Parse(entityB.Id.ToString()), entityB.Name);
            this.unitOfWork.disconnect();
        }

        public void deleteEntityB(Form1 ui, int id, int index)
        {
            this.unitOfWork.connect();
            bool result = this.unitOfWork.deleteEntityB(id);
            this.unitOfWork.disconnect();
            if (result)
            {
                ui.deleteEntityBFromGrid(index);
            }
        }

        public void updateEntityB(Form1 ui, int id, string name, int index)
        {
            EntityB entityB = new EntityB(id, name);
            this.unitOfWork.connect();
            if (unitOfWork.updateEntityB(entityB))
            {
                ui.replaceEntityBInGrid(index, id, name);
            }
            this.unitOfWork.disconnect();
        }

        public DataTable getAllEntitiesB()
        {
            DataTable data = new DataTable();
            this.unitOfWork.connect();
            List<EntityB> entitiesB = this.unitOfWork.getAllEntitiesB();
            this.unitOfWork.disconnect();

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

            this.unitOfWork.connect();
            entityA = this.unitOfWork.insertEntityA(entityA);
            this.unitOfWork.disconnect();
        }

        public List<EntityA> getAllEntitiesA()
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<EntityA> entitiesA = this.unitOfWork.getAllEntitiesA();
            unitOfWork.disconnect();

            Dictionary<int, DataTable> dataEntitiesB = new Dictionary<int, DataTable>();// Dictionary for entitiesB
            DataTable dataEntitiesA = new DataTable();
            dataEntitiesA.Columns.Add("id");
            dataEntitiesA.Columns.Add("name");

            Dictionary<string, DataTable> dataEntities = new Dictionary<string, DataTable>(); // Dictionary for both entities a and b datatables

            int countA = 0;
            foreach (EntityA entityA in entitiesA)
            {
                // Load entitiesB
                if (!dataEntitiesB.ContainsKey(entityA.Id))
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("id");
                    dt.Columns.Add("name");
                    dataEntitiesB.Add(entityA.Id, dt);
                }
                int countB = 0;
                foreach (EntityB entityB in entityA.EntitiesB)
                {
                    dataEntitiesB[entityA.Id].Rows.Add();
                    dataEntitiesB[entityA.Id].Rows[countB]["id"] = entityB.Id;
                    dataEntitiesB[entityA.Id].Rows[countB]["name"] = entityB.Name;
                    countB++;
                }

                // Load entitiesA
                dataEntitiesA.Rows.Add();
                dataEntitiesA.Rows[countB]["id"] = entityA.Id;
                dataEntitiesA.Rows[countB]["name"] = entityA.Name;
                countA++;
            }
            dataEntities.Add("A", dataEntitiesA);
            dataEntities.Add("B", dataEntitiesB);

            return entitiesA;
        }


    }
}
