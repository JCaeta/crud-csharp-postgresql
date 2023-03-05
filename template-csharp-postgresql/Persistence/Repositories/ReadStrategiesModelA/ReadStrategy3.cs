using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelA
{
    public class ReadStrategy3<ModelA> : IReadStrategy<ModelA>
    where ModelA : template_csharp_postgresql.Models.ModelA, new()
    {
        // This strategy finds by ModelA and ModelB names
        private Helper<ModelA> helper;
        private string modAName;
        private string modBName;

        public ReadStrategy3()
        {
            this.helper = new Helper<ModelA>();
        }
        public List<ModelA> read(NpgsqlConnection connection)
        {
            string query = this.buildQuery();
            NpgsqlCommand executor = new NpgsqlCommand(query, connection);
            executor.Parameters.AddWithValue("@modAName", this.modAName);
            executor.Parameters.AddWithValue("@modBName", this.modBName);
            NpgsqlDataReader result = executor.ExecuteReader();

            return this.helper.convertNpgsqlDataReaderToListModelA(result);
        }

        public void setFilter(string modAName, string modBName)
        {
            this.modAName = modAName;
            this.modBName = modBName;
        }

        public string buildQuery()
        {
            return "select " +
                   "models_a.id as mod_a_id," +
                   "models_a.name as mod_a_name," +
                   "models_b.id as mod_b_id," +
                   "models_b.name as mod_b_name " +
                "from models_a " +
                "full join rel_mod_a_mod_b as relAB on models_a.id = relAB.id_model_a " +
                "full join models_b on models_b.id = relAB.id_model_b " +
                "where models_a.name = @modAName and models_b.name = @modBName;";

        }
    }
}
