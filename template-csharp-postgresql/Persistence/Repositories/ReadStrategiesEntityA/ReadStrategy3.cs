using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesEntityA
{
    public class ReadStrategy3<EntityA> : IReadStrategy<EntityA>
    where EntityA : template_csharp_postgresql.Entities.EntityA, new()
    {
        // This strategy finds by EntityA and EntityB names
        private Helper<EntityA> helper;
        private string entAName;
        private string entBName;

        public ReadStrategy3()
        {
            this.helper = new Helper<EntityA>();
        }
        public List<EntityA> read(NpgsqlConnection connection)
        {
            string query = this.buildQuery();
            NpgsqlCommand executor = new NpgsqlCommand(query, connection);
            executor.Parameters.AddWithValue("@entAName", this.entAName);
            executor.Parameters.AddWithValue("@entBName", this.entBName);
            NpgsqlDataReader result = executor.ExecuteReader();

            return this.helper.convertNpgsqlDataReaderToListEntityA(result);
        }

        public void setFilter(string entAName, string entBName)
        {
            this.entAName = entAName;
            this.entBName = entBName;
        }

        public string buildQuery()
        {
            return "select " +
                   "entities_a.id as ent_a_id," +
                   "entities_a.name as ent_a_name," +
                   "entities_b.id as ent_b_id," +
                   "entities_b.name as ent_b_name " +
                "from entities_a " +
                "join rel_entities_a_entities_b as relAB on entities_a.id = relAB.id_entity_a " +
                "join entities_b on entities_b.id = relAB.id_entity_b " +
                "where entities_a.name = '@entAName' and entities_b.name = '@entBName';";

        }
    }
}
