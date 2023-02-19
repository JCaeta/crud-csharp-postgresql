using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using template_csharp_postgresql.Entities;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesEntityA
{
    public class ReadAllEntitiesA<EntityA> : IReadStrategy<EntityA>
    where EntityA : template_csharp_postgresql.Entities.EntityA, new()
    {
        private Helper<EntityA> helper;
        public ReadAllEntitiesA()
        {
            this.helper = new Helper<EntityA>();
        }

        public List<EntityA> read(NpgsqlConnection connection)
        {
            List<EntityA> entitiesA = new List<EntityA>();
            string query = this.buildQuery();
            NpgsqlDataReader result;
            using (NpgsqlCommand executor = new NpgsqlCommand(query, connection))
            {
                result = executor.ExecuteReader();
            }

            return this.helper.convertNpgsqlDataReaderToListEntityA(result);
        }

        private string buildQuery()
        {
            return
            "select " +
                "entities_a.id as ent_a_id, " +
                "entities_a.name as ent_a_name, " +
                "entities_b.id as ent_b_id, " +
                "entities_b.name as ent_b_name " +
                "from entities_a " +
                "full join rel_entities_a_entities_b on entities_a.id = rel_entities_a_entities_b.id_entity_a " +
                "full join entities_b on entities_b.id = rel_entities_a_entities_b.id_entity_b";

            // SQL query in /Persistence/queries.sql
            // Label to search: Strategy ReadAllEntitiesA
        }
    }
}
