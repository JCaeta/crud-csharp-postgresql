using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Entities;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesEntityA
{
    public class ReadStrategy1<EntityA> : IReadStrategy<EntityA>
    where EntityA : template_csharp_postgresql.Entities.EntityA, new()
    {
        // This strategy finds by EntityB name
        private string filter;
        private Helper<EntityA> helper;

        public ReadStrategy1()
        {
            this.helper = new Helper<EntityA>();
        }
        public List<EntityA> read(NpgsqlConnection connection)
        {
            string query = this.buildQuery();
            NpgsqlCommand executor = new NpgsqlCommand(query, connection);
            executor.Parameters.AddWithValue("@name", this.filter);
            NpgsqlDataReader result = executor.ExecuteReader();

            return helper.convertNpgsqlDataReaderToListEntityA(result);
        }

        public void setFilter(string entityBName)
        {
            this.filter = entityBName;
        }

        private string buildQuery()
        {
            return "select " +
                   "entities_a.id as ent_a_id," +
                   "entities_a.name as ent_a_name," +
                   "entities_b.id as ent_b_id," +
                   "entities_b.name as ent_b_name " +
                "from entities_a " +
                "full join rel_entities_a_entities_b as relAB on entities_a.id = relAB.id_entity_a " +
                "full join entities_b on entities_b.id = relAB.id_entity_b " +
                "where entities_b.name = @name;";
        }

    }
}
