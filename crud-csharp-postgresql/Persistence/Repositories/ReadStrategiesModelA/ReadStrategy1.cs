using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using crud_csharp_postgresql.Models;

namespace crud_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelA
{
    public class ReadStrategy1<ModelA> : IReadStrategy<ModelA>
    where ModelA : crud_csharp_postgresql.Models.ModelA, new()
    {
        // This strategy finds by ModelB name
        private string filter;
        private Helper<ModelA> helper;

        public ReadStrategy1()
        {
            this.helper = new Helper<ModelA>();
        }
        public List<ModelA> read(NpgsqlConnection connection)
        {
            string query = this.buildQuery();
            NpgsqlCommand executor = new NpgsqlCommand(query, connection);
            executor.Parameters.AddWithValue("@name", this.filter);
            NpgsqlDataReader result = executor.ExecuteReader();

            return helper.convertNpgsqlDataReaderToListModelA(result);
        }

        public void setFilter(string modelBName)
        {
            this.filter = modelBName;
        }

        private string buildQuery()
        {
            return "select " +
                   "models_a.id as mod_a_id, " +
                    "models_a.name as mod_a_name, " +
                    "models_b.id as mod_b_id, " +
                    "models_b.name as mod_b_name " +
                "from models_a " +
                "full join rel_mod_a_mod_b as relAB on models_a.id = relAB.id_model_a " +
                "full join models_b on models_b.id = relAB.id_model_b " +
                "where models_a.id in ( " +
                    "select models_a.id " +
                    "from models_a " +
                    "full join rel_mod_a_mod_b as relAB on models_a.id = relAB.id_model_a " +
                    "full join models_b on models_b.id = relAB.id_model_b " +
                    "where models_b.name = @name);";

            // SQL query in /Persistence/queries.sql
            // search label: Strategy ReadModelAOption1
        }
    }
}
