using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelB
{
    public class ReadAllModelsB<ModelB> : IReadStrategy<ModelB>
    where ModelB : template_csharp_postgresql.Models.ModelB, new()
    {
        public List<ModelB> read(NpgsqlConnection connection)
        {
            List<ModelB> modelsB = new List<ModelB>();

            // 1) Execute query
            string query = "select * from models_b;";
            NpgsqlDataReader result;
            using (NpgsqlCommand executor = new NpgsqlCommand(query, connection))
            {
                result = executor.ExecuteReader();
            }

            // 2) Extract data
            while (result.Read())
            {
                System.Int32 id = result.GetInt32(0);
                string name = result.GetString(1);
                ModelB modelB = new ModelB();
                modelB.Id = id;
                modelB.Name = name;
                modelsB.Add(modelB);
            }

            return modelsB;
        }
    }
}
