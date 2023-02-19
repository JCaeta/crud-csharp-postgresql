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
        public void createEntityB(Form1 ui, string name)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            EntityB entityB = new EntityB(name);
            entityB = unitOfWork.createEntityB(entityB);
            ui.loadEntityBOnUi(entityB);
            unitOfWork.disconnect();
        }

        public void deleteEntityB(Form1 ui, EntityB entityB)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            bool result = unitOfWork.deleteEntityB(entityB.Id);
            unitOfWork.disconnect();
            if (result)
            {
                ui.deleteEntityBFromUi(entityB.Id);
            }else
            {
                ui.showWarning("Failed to delete item. Please check if the item is linked to any other entities before attempting to delete.");
            }
        }

        public void deleteEntityA(Form1 ui, int id)
        {
            EntityA entityA = new EntityA(id);
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            bool result = unitOfWork.deleteEntityA(entityA);
            unitOfWork.disconnect();

            if (result)
            {
                ui.deleteEntityAFromUi(id);
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

        public List<EntityB> getAllEntitiesB()
        {
            DataTable data = new DataTable();
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<EntityB> entitiesB = unitOfWork.getAllEntitiesB();
            unitOfWork.disconnect();

            return entitiesB;
        }

        public void createEntityA(Form1 ui, EntityA entityA)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            entityA = unitOfWork.createEntityA(entityA);
            unitOfWork.disconnect();

            ui.loadEntityAOnUi(entityA);
        }


        public List<EntityA> getAllEntitiesA()
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<EntityA> entitiesA = unitOfWork.getAllEntitiesA();
            unitOfWork.disconnect();

            return entitiesA;
        }

        public void updateEntityA(Form1 ui, EntityA entityA)
        {
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            bool result = unitOfWork.updateEntityA(entityA);
            unitOfWork.disconnect();

            if (result)
            {
                ui.updateEntityAOnUi(entityA);
            }
        }

        public List<EntityA> readEntityAOption1(string entityBName)
        {
            // Read by EntityB name
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<EntityA> entitiesA = unitOfWork.readEntityAOption1(entityBName);
            unitOfWork.disconnect();
            return entitiesA;

        }

        public List<EntityA> readEntityAOption2(string entityAName)
        {
            // Read by EntityA name
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<EntityA> entitiesA = unitOfWork.readEntityAOption2(entityAName);
            unitOfWork.disconnect();
            return entitiesA;

        }

        public List<EntityA> readEntityAOption3(string entityAName, string entityBName)
        {
            // Read by EntityA name and EntityB name
            PostgreSQLUnitOfWork unitOfWork = new PostgreSQLUnitOfWork();
            unitOfWork.connect();
            List<EntityA> entitiesA = unitOfWork.readEntityAOption3(entityAName, entityBName);
            unitOfWork.disconnect();
            return entitiesA;
        }
    }
}
