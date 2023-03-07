using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using template_csharp_postgresql.Models;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelA
{
    public class ReadAllModelsA<ModelA> : IReadStrategy<ModelA>
    where ModelA : template_csharp_postgresql.Models.ModelA, new()
    {
        private Helper<ModelA> helper;
        public ReadAllModelsA()
        {
            this.helper = new Helper<ModelA>();
        }

        public List<ModelA> read(NpgsqlConnection connection)
        {
            List<ModelA> modelsA = new List<ModelA>();
            string query = this.buildQuery();
            NpgsqlDataReader result;
            using (NpgsqlCommand executor = new NpgsqlCommand(query, connection))
            {
                result = executor.ExecuteReader();
            }

            return this.helper.convertNpgsqlDataReaderToListModelA(result);
        }

        private string buildQuery()
        {
            return
            "select " +
                "models_a.id as mod_a_id, " +
                "models_a.name as mod_a_name, " +
                "models_b.id as mod_b_id, " +
                "models_b.name as mod_b_name " +
                "from models_a " +
                "full join rel_mod_a_mod_b on models_a.id = rel_mod_a_mod_b.id_model_a " +
                "full join models_b on models_b.id = rel_mod_a_mod_b.id_model_b";

            // SQL query in /Persistence/queries.sql
            // Label to search: Strategy ReadAllModelsA
        }
    }
}
