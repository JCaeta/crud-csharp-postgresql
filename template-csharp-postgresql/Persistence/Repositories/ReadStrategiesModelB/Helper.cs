using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Models;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelB
{
    public class Helper<ModelB>
    where ModelB : template_csharp_postgresql.Models.ModelB, new()
    {
        public List<ModelB> convertNpgsqlDataReaderToListModelB(NpgsqlDataReader result)
        {
            List<ModelB> modelsB = new List<ModelB>();
            while (result.Read())
            {
                if (!result.IsDBNull(0))
                {
                    int id = int.Parse(result.GetInt32(0).ToString());
                    string name = result.GetString(1);
                    ModelB modelB = new ModelB();
                    modelB.Id = id;
                    modelB.Name = name;
                    modelsB.Add(modelB);
                }
            }

            return modelsB;
        }
    }
}
