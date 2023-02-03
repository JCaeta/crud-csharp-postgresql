using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using template_csharp_postgresql.Entities;
using template_csharp_postgresql.Persistence.Repositories.FindStrategiesEntityB;

namespace template_csharp_postgresql.Persistence.Repositories.FindStrategiesEntityA
{
    public class FindAll<EntityA> : IFindStrategy<EntityA>
    where EntityA : template_csharp_postgresql.Entities.EntityA, new()
    {
        public List<EntityA> find(NpgsqlConnection connection, NpgsqlTransaction transaction)
        {
            // In this case the filter is not necessary because we need all the entitiesA
            // We need to search both entities A and entities B objects because they are associated
            // Get entities A
            List<EntityA> entitiesA = new List<EntityA>();

            // Search the relationship between entities A and B
            DataTable relEntAEntB = this.getRelEntitiesAEntitiesB(connection, transaction);

            // Build queries to search entities A and B
            string queryEntitiesA = this.buildStringToSearchEntityA(relEntAEntB);

            // Get entitites B
            List<EntityB> entitiesB = this.getEntitiesB(connection, transaction, relEntAEntB);


            //// Search entitiesB
            //NpgsqlCommand executor = new NpgsqlCommand(queryEntitiesB, connection);
            //NpgsqlDataReader resultEntitiesB = executor.ExecuteReader();

            //executor = new NpgsqlCommand(queryEntitiesA, connection);
            //NpgsqlDataReader resultEntitiesA = executor.ExecuteReader();

            return entitiesA;
        }

        private DataTable getRelEntitiesAEntitiesB(NpgsqlConnection connection, NpgsqlTransaction transaction)
        {
            // Returns a DataTable object with the fields
            // - id
            // - id_entity_a
            // - id_entity_b

            // 1) Execute command
            //string query = "select * from rel_entities_a_entities_b";
            //NpgsqlCommand executor = new NpgsqlCommand(query, connection);
            //NpgsqlDataReader resultRelEntitiesAEntitiesB = executor.ExecuteReader();

            string query = "select * from rel_entities_a_entities_b";
            NpgsqlDataReader resultRelEntitiesAEntitiesB;
            using (NpgsqlCommand executor = new NpgsqlCommand(query, connection, transaction))
            {
                resultRelEntitiesAEntitiesB = executor.ExecuteReader();
            }

            // 2) Extract data
            DataTable table = new DataTable();
            table.Columns.Add("id");
            table.Columns.Add("id_entity_a");
            table.Columns.Add("id_entity_b");
            int count = 0;
            while (resultRelEntitiesAEntitiesB.Read())
            {
                table.Rows.Add();
                table.Rows[count]["id"] = resultRelEntitiesAEntitiesB.GetInt32(0);
                table.Rows[count]["id_entity_a"] = resultRelEntitiesAEntitiesB.GetInt32(1);
                table.Rows[count]["id_entity_b"] = resultRelEntitiesAEntitiesB.GetInt32(2);
                count += 1;
            }

            return table;
        }
        private string buildStringToSearchEntityA(DataTable resultRelEntitiesAEntitiesB)
        {
            string ids = this.buildStringToSearchEntAB(resultRelEntitiesAEntitiesB, "id_entity_a");
            return "select distinct * from entities_a where id in " + ids + ";";
        }

        private string buildStringToSearchEntityB(DataTable resultRelEntitiesAEntitiesB)
        {
            string ids = this.buildStringToSearchEntAB(resultRelEntitiesAEntitiesB, "id_entity_b");
            return "select * from entities_b where id in " + ids + ";";
        }

        private string buildStringToSearchEntAB(DataTable result_rel_entities_a_entities_b, string idFieldName)
        {
            string ids = "(" + result_rel_entities_a_entities_b.Rows[0][idFieldName];

            for(int i = 1; i < result_rel_entities_a_entities_b.Rows.Count; i++)
            {
                ids += ", " + result_rel_entities_a_entities_b.Rows[i][idFieldName];
            }

            ids += ")";
            return ids;
        }

        private List<EntityB> getEntitiesB(NpgsqlConnection connection, NpgsqlTransaction transaction, DataTable relEntAEntB)
        {
            // 1) Get entities B ids
            List<int> ids = new List<int>();
            for (int i = 0; i <= relEntAEntB.Rows.Count - 1; i++)
            {
                ids.Add(int.Parse(relEntAEntB.Rows[i]["id_entity_b"].ToString()));
            }

            // 2) Instanciate EntityB Repository
            EntityBRepository<EntityB> entityBRepository = new EntityBRepository<EntityB>(connection, transaction);
            FindById<EntityB> findStrategy = new FindById<EntityB>();
            findStrategy.setIds(ids);
            entityBRepository.setFindStrategy(findStrategy);

            // 3) Create a default filter
            // It'will be not used in this strategy but is requested in the find() method parameters
            EntityB filter = new EntityB();

            // 3) Get entities B
            List<EntityB> entitiesB = entityBRepository.find(filter);


            //string queryEntitiesB = this.buildStringToSearchEntityB(relEntAEntB);
            return entitiesB;
        }
    }
}
