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
            ui.loadNewEntityB(int.Parse(entityB.Id.ToString()), entityB.Name);
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
    }
}
